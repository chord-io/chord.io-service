using Chord.IO.Service.Enums;
using Chord.IO.Service.Models;
using Chord.IO.Service.Models.Arithmetic;

namespace Chord.IO.Service.Dto
{
    public class IntervalDto
    {
        public uint Degree { get; set; }
        public uint Semitones { get; set; }
        public IntervalQuality Quality { get; set; }

        public Interval ToModelObject()
        {
            return new Interval(this.Degree, this.Semitones, this.Quality);
        }

        public static IntervalDto FromModelObject(Interval model)
        {
            return new IntervalDto
            {
                Degree = model.Degree,
                Semitones = model.Semitones,
                Quality = model.Quality
            };
        }
    }
}
