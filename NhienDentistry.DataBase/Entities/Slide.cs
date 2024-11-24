﻿using NhienDentistry.Date.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NhienDentistry.DataBase.Entities
{
    public class Slide
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Url { set; get; }
        public Image Image { get; set; }
        public int SortOrder { get; set; }
        public Status Status { set; get; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate
        {
            get; set;
        }
    }
}