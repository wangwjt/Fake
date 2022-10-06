using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace Fake.API.Dto
{
    public class TouristRouteDTO
    {
        public TouristRouteDTO()
        {
        }

        public TouristRouteDTO(string id, string title, string desc, string createTime)
        {
            Id = id;
            Title = title;
            Desc = desc;
            CreateTime = createTime;
        }

        public string Id { get; set; }

        public string Title { get; set; }

        public string Desc { get; set; }

        public string CreateTime { get; set; }
    }
}
