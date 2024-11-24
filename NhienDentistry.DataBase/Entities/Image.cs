using NhienDentistry.Date.Enums;
using NhienDentistry.DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NhienDentistry.DataBase.Entities
{
    public class Image
    {
        public int Id { get; set; }

        public string Path { get; set; }


        public Status Status { get; set; }

        public long FileSize { get; set; }
        public int? NewsId { get; set; }
        public int? SlideId { get; set; }
        public News? News { get; set; }
        public Slide? Slide { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
