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
        public string Type { get; set; }
        public long FileSize { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public AppUser User { get; set; }

        public List<Article> Articles { get; set; } = new List<Article>();
        public List<Slide> Slides { get; set; } = new List<Slide>();
    }
}
