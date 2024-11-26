using NhienDentistry.Date.Enums;
using NhienDentistry.DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using NhienDentistry.DataBase.Enums;

namespace NhienDentistry.DataBase.Entities
{
    public class Image
    {
        public int Id { get; set; }

        public string Path { get; set; }
        public ImageType Type { get; set; }
        public Status Status { get; set; }
        public long FileSize { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public AppUser User { get; set; }
        public List<AppUser> AppUsers { get; set; } = new List<AppUser>();
        public List<News> News { get; set; } = new List<News>();
        public List<Slide> Slides { get; set; } = new List<Slide>();

    }
}
