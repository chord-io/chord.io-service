using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Chord.IO.Service.Enums;
using Newtonsoft.Json;

namespace Chord.IO.Service.Dto
{
    public class DegreeAndSemitonesIntervalDto : IntervalDto
    {
        [JsonIgnore]
        public new IntervalQuality Quality { get; set; }
    }
}
