using NhienDentistry.Data.Enums;
using NhienDentistry.Date.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NhienDentistry.Data.Entities
{
    public class Contact
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string PhoneNumber { set; get; }
        public string Message { set; get; }
        public TypeMessage Type { set; get; } = TypeMessage.None;
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
