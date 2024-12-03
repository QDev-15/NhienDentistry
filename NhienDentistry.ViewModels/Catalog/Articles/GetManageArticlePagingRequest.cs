using NhienDentistry.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NhienDentistry.ViewModels.Catalog.Articles

{
    public class GetManageArticlePagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

        public int? LanguageId { get; set; }

        public int? CategoryId { get; set; }
    }
}