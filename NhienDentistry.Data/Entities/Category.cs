using NhienDentistry.Date.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NhienDentistry.Data.Entities
{
    public class Category
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Alias { set; get; }
        public int? ParentId { set; get; }
        public Status Status { set; get; }
        public Category Parent { set; get; }
        public List<Category> Categories { set; get; }
        public List<News> News { set; get; }
        public List<CategoryTranslation> CategoryTranslations { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
