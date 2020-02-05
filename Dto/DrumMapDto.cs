using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chord.IO.Service.Models.Hierarchy.DrumMaps;
using Chord.IO.Service.Models.Hierarchy.Fingerings;

namespace Chord.IO.Service.Dto
{
    public class DrumMapDto : DrumMap
    {
        public DrumMap ToModelObject()
        {
            return new DrumMap
            {
                Name = this.Name,
                Map = this.Map
            };
        }

        public static DrumMapDto FromModelObject(DrumMap model)
        {
            return new DrumMapDto
            {
                Name = model.Name,
                Map = model.Map
            };
        }
    }
}
