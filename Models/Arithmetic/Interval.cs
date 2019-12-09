using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Chord.IO.Service.Enums;
using Chord.IO.Service.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;

namespace Chord.IO.Service.Models.Arithmetic
{
    public class Interval
    {
        public uint Degree { get; }
        public uint Semitones { get; }
        public IntervalQuality Quality { get; }

        private static readonly Regex Regex = new Regex(@"^(\D+)(\d*)$");

        public static readonly IReadOnlyDictionary<uint, IReadOnlyDictionary<uint, IntervalQuality>> LookUpTable = new Dictionary<uint, IReadOnlyDictionary<uint, IntervalQuality>>
        {
            {
                1, new Dictionary<uint, IntervalQuality>
                {
                    { 11, IntervalQuality.Diminished },
                    { 0, IntervalQuality.Perfect },
                    { 1, IntervalQuality.Augmented }
                }.AsReadOnly()
            },
            {
                2, new Dictionary<uint, IntervalQuality>
                {
                    { 0, IntervalQuality.Diminished },
                    { 1, IntervalQuality.Minor },
                    { 2, IntervalQuality.Major },
                    { 3, IntervalQuality.Augmented }
                }.AsReadOnly()
            },
            {
                3, new Dictionary<uint, IntervalQuality>
                {
                    { 2, IntervalQuality.Diminished },
                    { 3, IntervalQuality.Minor },
                    { 4, IntervalQuality.Major },
                    { 5, IntervalQuality.Augmented }
                }.AsReadOnly()
            },
            {
                4, new Dictionary<uint, IntervalQuality>
                {
                    { 4, IntervalQuality.Diminished },
                    { 5, IntervalQuality.Perfect },
                    { 6, IntervalQuality.Augmented }
                }.AsReadOnly()
            },
            {
                5, new Dictionary<uint, IntervalQuality>
                {
                    { 6, IntervalQuality.Diminished },
                    { 7, IntervalQuality.Perfect },
                    { 8, IntervalQuality.Augmented }
                }.AsReadOnly()
            },
            {
                6, new Dictionary<uint, IntervalQuality>
                {
                    { 7, IntervalQuality.Diminished },
                    { 8, IntervalQuality.Minor },
                    { 9, IntervalQuality.Major },
                    { 10, IntervalQuality.Augmented }
                }.AsReadOnly()
            },
            {
                7, new Dictionary<uint, IntervalQuality>
                {
                    { 9, IntervalQuality.Diminished },
                    { 10, IntervalQuality.Minor },
                    { 11, IntervalQuality.Major },
                    { 12, IntervalQuality.Augmented }
                }.AsReadOnly()
            }
        }.AsReadOnly();
        
        public static readonly IReadOnlyDictionary<IntervalFormat, IReadOnlyDictionary<IntervalQuality, string>> Translator = new Dictionary<IntervalFormat, IReadOnlyDictionary<IntervalQuality, string>>
        {
            {
                IntervalFormat.Short, new Dictionary<IntervalQuality, string>
                {
                    { IntervalQuality.Perfect, "P" },
                    { IntervalQuality.Diminished, "d" },
                    { IntervalQuality.Augmented, "A" },
                    { IntervalQuality.Minor, "m" },
                    { IntervalQuality.Major, "M" },
                }.AsReadOnly()
            },
            {
                IntervalFormat.Medium, new Dictionary<IntervalQuality, string>
                {
                    { IntervalQuality.Perfect, "perf" },
                    { IntervalQuality.Diminished, "dim" },
                    { IntervalQuality.Augmented, "aug" },
                    { IntervalQuality.Minor, "min" },
                    { IntervalQuality.Major, "maj" },
                }.AsReadOnly()
            }
        }.AsReadOnly();

        public static readonly IReadOnlyList<KeyValuePair<string, IntervalQuality>> InvertedTranslator = Translator
            .SelectMany(x => x.Value.ToDictionary(y => y.Value, y => y.Key).AsReadOnly())
            .ToList()
            .AsReadOnly();

        private static readonly IReadOnlyList<uint> Steps = new List<uint>
        {
            3,
            7,
            10,
            13,
            17,
            21,
            24
        }.AsReadOnly();

        public Interval(uint degree, uint semitones, IntervalQuality quality)
        {
            this.Degree = degree;
            this.Semitones = semitones;
            this.Quality = quality;
        }

        #region Comparisons
        public int CompareTo(Interval other)
        {
            if (this.Degree != other.Degree && this.Degree < other.Degree)
            {
                return -1;
            }
            if (this.Degree != other.Degree && this.Degree > other.Degree)
            {
                return 1;
            }

            if (this.Semitones != other.Semitones && this.Semitones < other.Semitones)
            {
                return -1;
            }
            if (this.Semitones != other.Semitones && this.Semitones > other.Semitones)
            {
                return 1;
            }

            if (this.Quality != other.Quality && this.Quality < other.Quality)
            {
                return -1;
            }
            if (this.Quality != other.Quality && this.Quality > other.Quality)
            {
                return 1;
            }

            return 0;
        }

        public static bool operator <(Interval a, Interval b) { return a.CompareTo(b) < 0; }
        public static bool operator >(Interval a, Interval b) { return a.CompareTo(b) > 0; }
        public static bool operator <=(Interval a, Interval b) { return a.CompareTo(b) <= 0; }
        public static bool operator >=(Interval a, Interval b) { return a.CompareTo(b) >= 0; }
        public static bool operator ==(Interval a, Interval b) { return a?.CompareTo(b) == 0; }
        public static bool operator !=(Interval a, Interval b) { return a?.CompareTo(b) != 0; }

        protected bool Equals(Interval other)
        {
            return this.Degree == other.Degree && this.Semitones == other.Semitones && this.Quality == other.Quality;
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
                var hashCode = this.Degree;
                hashCode = (hashCode * 397) ^ this.Semitones;
                hashCode = ((hashCode * 397) ^ (uint)this.Quality);
                return Convert.ToInt32(hashCode);
            }
        }
        #endregion

        #region Utils
        private static uint NormalizeDegree(uint degree)
        {
            return degree % 7;
        }

        private static uint NormalizeSemitones(uint semitones)
        {
            return semitones % 12;
        }

        private static uint ToHiddenVariable(uint degree)
        {
            return degree - 3 - Convert.ToUInt32(Math.Floor((degree - 5) / 7.0D));
        }
        #endregion

        #region Creations
        public static Interval FromDegreeAndQuality(uint degree, IntervalQuality quality)
        {
            var semitones = LookUpTable
                .Single(x => x.Key == NormalizeDegree(degree))
                .Value
                .Single(x => x.Value == quality)
                .Key;
            semitones = Convert.ToUInt32(Math.Floor(degree / 7.0D)) * 12 + semitones;
            return new Interval(degree, semitones, quality);
        }

        public static Interval FromSemitonesAndQuality(uint semitones, IntervalQuality quality)
        {
            var degree = LookUpTable
                .Single(x => x.Value.ContainsKey(NormalizeSemitones(semitones)) && x.Value.Values.Contains(quality))
                .Key;
            degree = Convert.ToUInt32(Math.Floor(semitones / 12.0)) * 7 + degree;
            return new Interval(degree, semitones, quality);
        }

        public static Interval FromDegreeAndSemitones(uint degree, uint semitones)
        {
            var quality = LookUpTable
                .Single(x => x.Key == NormalizeDegree(degree))
                .Value
                .Single(x => x.Key == NormalizeSemitones(semitones))
                .Value;
            return new Interval(degree, semitones, quality);
        }

        public static Interval FromNotes(Note a, Note b)
        {
            var degree = 1U;
            var semitones = 0U;
            var quality = IntervalQuality.Perfect;

            if (a == b)
            {
                return new Interval(degree, semitones, quality);
            }

            var minimum = a < b ? a : b;
            var maximum = a > b ? a : b;

            semitones = maximum.ToIntegral() - minimum.ToIntegral();
            degree = (maximum.Index + 1 + Convert.ToUInt32(Math.Abs(maximum.Pitch)) * 7) - (minimum.Index + Convert.ToUInt32(Math.Abs(minimum.Pitch)) * 7);
            quality = LookUpTable
                .Single(x => x.Key == NormalizeDegree(degree))
                .Value
                .Single(x => x.Key == NormalizeSemitones(semitones))
                .Value;

            return new Interval(degree, semitones, quality);
        }
        #endregion

        #region Representations
        public static Interval FromString(string interval)
        {
            var match = Regex.Match(interval);

            if (!match.Success)
            {
                throw new ArgumentException($"is not a valid interval representation", nameof(interval));
            }

            var name = match.Groups[1].Value;
            var quality = InvertedTranslator
                .Single(x => x.Key == name)
                .Value;
            var degree = uint.Parse(match.Groups[2].Value);

            return Interval.FromDegreeAndQuality(degree, quality);
        }

        public string ToString(IntervalFormat format)
        {
            var name = "";
            var degree = this.Degree.ToString();

            name = format switch
            {
                IntervalFormat.Formula => this.ToStringFormula(),
                _ => Translator
                    .Single(x => x.Key == format)
                    .Value
                    .Single(x => x.Key == this.Quality)
                    .Value
            };

            return $"{name}{degree}";
        }

        private string ToStringFormula()
        {
            var name = "";

            if (this.Degree == 1 || this.Degree == 4 || this.Degree == 5)
            {
                name = this.Quality switch
                {
                    IntervalQuality.Diminished => "b",
                    IntervalQuality.Perfect => "",
                    IntervalQuality.Augmented => "#",
                    _ => name
                };
            }
            else
            {
                name = this.Quality switch
                {
                    IntervalQuality.Diminished => "bb",
                    IntervalQuality.Minor => "b",
                    IntervalQuality.Major => "",
                    IntervalQuality.Augmented => "#",
                    _ => name
                };
            }

            return name;
        }
        #endregion

        #region Conversions
        public static Interval FromIntegral(uint integral)
        {
            var scaledIntegral = (integral - 2) % 25;
            var step = Core.Math.Steps(Steps, scaledIntegral);
            var x = Convert.ToUInt32((Steps.IndexOf(step) + 2) % 7);

            if (x == 0)
            {
                x = 7;
            }

            var scaledIntegralRatio = Math.Round(((scaledIntegral + 2) % 24) / 24.0D, 2);
            var integralRatio = Math.Round(integral / 24.0D, 2);
            var multiplier = Convert.ToUInt32(integralRatio - scaledIntegralRatio);

            if (multiplier < 24)
            {
                multiplier = 0;
            }

            var degree =  x + (multiplier * 7U);
            var semitones = integral + ToHiddenVariable(degree) + degree;

            return Interval.FromDegreeAndSemitones(degree, semitones);
        }

        public uint ToIntegral()
        {
            var factor = ToHiddenVariable(this.Degree);
            return factor + this.Degree + this.Semitones;
        }
        #endregion

        #region Transformations
        public Interval Invert()
        {
            var quality = this.Quality switch
            {
                IntervalQuality.Augmented => IntervalQuality.Diminished,
                IntervalQuality.Diminished => IntervalQuality.Augmented,
                IntervalQuality.Major => IntervalQuality.Minor,
                IntervalQuality.Minor => IntervalQuality.Major,
                IntervalQuality.Perfect => IntervalQuality.Perfect,
                _ => this.Quality
            };
            var factor = Convert.ToUInt32(Math.Floor(this.Degree / 7.0D)) * 7;
            var degree = 9 - NormalizeDegree(this.Degree) + factor;
            return FromDegreeAndQuality(degree, quality);
        }

        public Note ToNote(Note root)
        {
            return Note.FromIntegral(root.ToIntegral() + Convert.ToUInt32(this.Semitones));
        }
        #endregion
    }
}
