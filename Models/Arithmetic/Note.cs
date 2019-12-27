using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Chord.IO.Service.Models.Arithmetic
{
    public class Note : IComparable<Note>
    {
        private static readonly Regex Regex = new Regex(@"^(A|B|C|D|E|F|G)(#*|b*)(\d)$");

        public static readonly IReadOnlyList<char> LookUpTable = new List<char>
        {
            'C',
            'D',
            'E',
            'F',
            'G',
            'A',
            'B',
        }.AsReadOnly();

        public char Key { get; }
        public uint Index { get; }
        public int Pitch { get; }
        public int Alteration { get; }

        public Note(char key, int pitch = 0, int alteration = 0)
        {
            if(!LookUpTable.Contains(key))
            {
                throw new ArgumentException($"is not a valid note name", nameof(key));
            }
            if (!(-2 <= pitch && pitch <= 8))
            {
                throw new ArgumentException($"must be between -2 and 8", nameof(pitch));
            }
            this.Key = key;
            this.Index = LookUpTable[key];
            this.Pitch = pitch;
            this.Alteration = alteration;
        }

        #region Comparisons
        public int CompareTo(Note other)
        {
            if (this.Pitch != other.Pitch && this.Pitch < other.Pitch)
            {
                return -1;
            }
            if (this.Pitch != other.Pitch && this.Pitch > other.Pitch)
            {
                return 1;
            }

            if (this.Index != other.Index && this.Index < other.Index)
            {
                return -1;
            }
            if (this.Index != other.Index && this.Index > other.Index)
            {
                return 1;
            }

            if (this.Alteration != other.Alteration && this.Alteration < other.Alteration)
            {
                return -1;
            }
            if (this.Alteration != other.Alteration && this.Alteration > other.Alteration)
            {
                return 1;
            }

            return 0;
        }

        public static bool operator <(Note a, Note b) { return a.CompareTo(b) < 0; }
        public static bool operator >(Note a, Note b) { return a.CompareTo(b) > 0; }
        public static bool operator <=(Note a, Note b) { return a.CompareTo(b) <= 0; }
        public static bool operator >=(Note a, Note b) { return a.CompareTo(b) >= 0; }
        public static bool operator ==(Note a, Note b) { return a?.CompareTo(b) == 0; }
        public static bool operator !=(Note a, Note b) { return a?.CompareTo(b) != 0; }

        protected bool Equals(Note other)
        {
            return this.Index == other.Index && this.Pitch == other.Pitch && this.Alteration == other.Alteration;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            return obj.GetType() == this.GetType() && Equals((Note)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (ulong)this.Index;
                hashCode = (hashCode * 397) ^ (ulong)this.Pitch;
                hashCode = ((hashCode * 397) ^ (ulong)this.Alteration);
                return Convert.ToInt32(hashCode);
            }
        }
        #endregion

        #region Representations
        public static Note FromString(string note)
        {
            var match = Regex.Match(note);

            if (!match.Success)
            {
                throw new ArgumentException($"is not a valid note representation", nameof(note));
            }

            var key = char.Parse(match.Groups[1].Value);
            var pitch = int.Parse(match.Groups[3].Value);
            var alterationValue = match.Groups[2].Value;
            var alteration = 0;

            if (!string.IsNullOrEmpty(alterationValue))
            {
                var direction = alterationValue.First().Equals('#') ? 1 : -1;
                alteration = direction * alterationValue.Length;
            }

            return new Note(key, pitch, alteration);
        }

        public override string ToString()
        {
            var symbol = "";

            if (0 < this.Alteration)
            {
                symbol = "#";
            }
            else if (this.Alteration < 0)
            {
                symbol = "b";
            }

            return $"{this.Key}{Enumerable.Repeat(symbol, Math.Abs(this.Alteration))}{this.Pitch}";
        }
        #endregion

        #region Conversions
        public static Note FromMidi(uint index)
        {
            if (!(0 <= index && index <= 127))
            {
                throw new ArgumentException("must be between 0 and 127", nameof(index));
            }

            return Note.FromIntegral(index);
        }

        public uint ToMidi()
        {
            var note = this.Simplify();
            return note.ToIntegral();
        }

        public static Note FromIntegral(uint integral)
        {
            if (!(integral <= 127))
            {
                throw new ArgumentException("must be between 0 and 127", nameof(integral));
            }

            var index = integral % 12;
            var pitch = Convert.ToInt32(Math.Floor(integral / 12.0D - 2.0D));
            var alteration = 0;

            if (index <= 4 && index % 2 == 1)
            {
                index -= 1;
                alteration = 1;
            }
            else if (index >= 5 && index % 2 == 1)
            {
                index += 1;
                index /= 2;
            }
            else if (index >= 5 && index % 2 == 0)
            {
                index /= 2;
                alteration = 1;
            }

            return new Note(LookUpTable[Convert.ToInt32(index)], pitch, alteration);
        }

        public uint ToIntegral()
        {
            var index = this.Index * 2;

            if (6 <= index)
            {
                index -= 1;
            }

            return Convert.ToUInt32(this.Pitch - -2) * 12 + Convert.ToUInt32(index + this.Alteration);
        }
        #endregion

        #region Transformations
        public Note Simplify()
        {
            if (-1 <= this.Alteration && this.Alteration <= 1)
            {
                throw new ArithmeticException("Simplification cannot be performed because the alteration is already set to the minimum value, which is -1, 0 or 1");
            }

            var integral = this.ToIntegral();
            return Note.FromIntegral(integral);
        }

        public Note GetInterval(uint degree)
        {
            if (degree <= 1)
            {
                throw new ArgumentException("must be strictly positive", nameof(degree));
            }

            return this.ShiftToRight(degree - 1);
        }

        public Note ShiftToRight(uint distance)
        {
            if (distance <= 0)
            {
                throw new ArgumentException("must be strictly positive", nameof(distance));
            }
            var delta = this.Index + distance;
            return this.ShiftTo(delta);
        }

        public Note ShiftToLeft(uint distance)
        {
            if (distance <= 0)
            {
                throw new ArgumentException("must be strictly positive", nameof(distance));
            }
            var delta = this.Index - distance;
            return this.ShiftTo(delta);
        }

        private Note ShiftTo(uint distance)
        {
            var index = distance % 7;
            var pitch = this.Pitch + Convert.ToInt32(Math.Floor(distance / 7.0D));
            var key = LookUpTable[(int)index];
            return new Note(key, pitch, this.Alteration);
        }

        public Note AlterUpward(int semitones)
        {
            if (semitones <= 0)
            {
                throw new ArgumentException("must be strictly positive", nameof(semitones));
            }
            return this.AlterTo(this.Alteration + semitones);
        }

        public Note AlterDownward(int semitones)
        {
            if (semitones <= 0)
            {
                throw new ArgumentException("must be strictly positive", nameof(semitones));
            }
            return this.AlterTo(this.Alteration - semitones);
        }

        private Note AlterTo(int distance)
        {
            return new Note(this.Key, this.Pitch, distance);
        }
        #endregion
    }
}
