using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chord.IO.Service.Models.Hierarchy.Fingerings;

namespace Chord.IO.Service.Dto
{
    public class FingeringDto : FingeringData
    {
        public Fingering ToModelObject()
        {
            return new Fingering
            {
                AuthorId = this.AuthorId,
                EditedFrom = this.EditedFrom,
                Name = this.Name,
                Type = this.Type,
                Tags = this.Tags,
                Evaluations = this.Evaluations,
                Entries = this.Entries
            };
        }

        public static FingeringDto FromModelObject(Fingering model)
        {
            return new FingeringDto
            {
                AuthorId = model.AuthorId,
                EditedFrom = model.EditedFrom,
                Name = model.Name,
                Type = model.Type,
                Tags = model.Tags,
                Evaluations = model.Evaluations,
                Entries = model.Entries
            };
        }
    }
}
