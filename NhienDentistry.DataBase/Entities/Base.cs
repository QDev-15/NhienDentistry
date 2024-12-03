﻿using NhienDentistry.Date.Enums;

namespace NhienDentistry.DataBase.Entities
{
    public class Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Map { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
