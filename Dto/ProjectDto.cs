using Chord.IO.Service.Models;
using Chord.IO.Service.Models.Hierarchy;
using MongoDB.Bson;

namespace Chord.IO.Service.Dto
{
    public class ProjectDto : ProjectData
    {
        public Project ToModelObject()
        {
            return new Project
            {
                Id = ObjectId.Empty.ToString(),
                Name = this.Name,
                AuthorId = this.AuthorId,
                Tempo = this.Tempo,
                IsPrivate = this.IsPrivate,
                Tracks = this.Tracks
            };
        }

        public static ProjectDto FromModelObject(Project model)
        {
            return new ProjectDto
            {
                Name = model.Name,
                AuthorId = model.AuthorId,
                Tempo = model.Tempo,
                IsPrivate = model.IsPrivate,
                Tracks = model.Tracks
            };
        }
    }
}
