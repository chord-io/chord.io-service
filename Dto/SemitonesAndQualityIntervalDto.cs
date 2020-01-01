using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Chord.IO.Service.Enums;
using Newtonsoft.Json;

namespace Chord.IO.Service.Dto
{
    public class SemitonesAndQualityIntervalDto : IntervalDto
    {
        [JsonIgnore]
        public new uint Degree { get; set; }
    }
}
