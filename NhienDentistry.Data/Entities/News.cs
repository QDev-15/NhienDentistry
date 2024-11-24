using NhienDentistry.Data.Entities;

namespace NhienDentistry.Data.Entities
{
    public class News
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public string Alias { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int SortOrder { get; set; } = 0;
        public long FileSize { get; set; }
        public List<Image> Images { get; set; } = new List<Image>();
        public Language Language { get; set; }
        public string Url { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
