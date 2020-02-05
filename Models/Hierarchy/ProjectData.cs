﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Chord.IO.Service.Models.Hierarchy.Tracks;
using Chord.IO.Service.Services;
using Chord.IO.Service.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace Chord.IO.Service.Models.Hierarchy
{
    public class ProjectData : IValidatableObject
    {
        public static readonly string TrackIndexOutOfBoundKeyword = "track-index";

        [MinLength(5, ErrorMessage = "Value {0} require a minimum length of {1} character")]
        [MaxLength(30, ErrorMessage = "Value {0} require a maximum length of {1} character")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonIgnore]
        public string AuthorId { get; set; }

        [Range(30, 360, ErrorMessage = "Value for {0} must be between {1} and {2}")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("tempo", Required = Required.Always)]
        public uint Tempo { get; set; }

        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("is_private", Required = Required.Always)]
        public bool IsPrivate { get; set; }

        [MaxLength(16, ErrorMessage = "Value {0} require a maximum length of {1} tracks")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("tracks", Required = Required.Always)]
        public List<Track> Tracks { get; set; }

        [MaxLength(50, ErrorMessage = "Value {0} require a maximum length of {1} themes")]
        [Required(ErrorMessage = "Value {0} is required")]
        [JsonProperty("themes", Required = Required.Always)]
        public List<Theme> Themes { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();
            var service = validationContext.GetService<ProjectService>();
            var httpContext = validationContext.GetService<IHttpContextAccessor>().HttpContext;
            var userId = HttpContextUtils.GetUserId(httpContext).Result;

            var isExist = service.IsExist(x => x.Name == this.Name && this.AuthorId == userId).Result;

            if (isExist == true && httpContext.Request.Method == HttpMethods.Post)
            {
                results.Add(new ValidationResult(
                    "project name must be unique",
                    new[] { nameof(this.Name) }
                ));
            }

            var trackIndexes = this.Tracks.Select(x => this.Tracks.IndexOf(x));
            var trackIndexOutOfBound = this.Themes
                .Where(x => !trackIndexes.Contains(x.TrackIndex))
                .ToList();

            if (trackIndexOutOfBound.Count > 0)
            {
                results.Add(new ValidationResult(
                    "track index related to a theme must be valid",
                    new[] { TrackIndexOutOfBoundKeyword }
                ));
            }

            return results;
        }
    }
}
