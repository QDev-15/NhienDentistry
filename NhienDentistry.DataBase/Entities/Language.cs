using System;
using System.Collections.Generic;
using System.Text;

namespace NhienDentistry.DataBase.Entities
{
    public class Language
    {
        public int Id { get; set; }
        public string Code { get; set; }

        public string Name { get; set; }

        public bool IsDefault { get; set; }

        public List<News> Newss { get; set; }

        public List<CategoryTranslation> CategoryTranslations   { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
