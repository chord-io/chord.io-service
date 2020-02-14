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
                Name = this.Name,
                AuthorId = this.AuthorId,
                Tempo = this.Tempo,
                Visibility = this.Visibility,
                Tracks = this.Tracks,
                Themes = this.Themes
            };
        }

        public static ProjectDto FromModelObject(Project model)
        {
            return new ProjectDto
            {
                Name = model.Name,
                AuthorId = model.AuthorId,
                Tempo = model.Tempo,
                Visibility = model.Visibility,
                Tracks = model.Tracks,
                Themes = model.Themes
            };
        }
    }
}
