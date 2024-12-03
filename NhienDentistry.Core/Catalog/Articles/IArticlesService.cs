﻿using NhienDentistry.ViewModels.Catalog.Articles;
using NhienDentistry.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhienDentistry.Core.Catalog.Articles
{
    public interface IArticlesService
    {
        Task<ArticleVm> Create(ArticleRequestCreated request);

        Task<ArticleVm> Update(ArticleRequestUpdated request);

        Task<bool> Delete(int id);

        Task<ArticleVm> GetById(int id);
        Task<PagedResult<ArticleVm>> GetAllPaging(GetManageArticlePagingRequest request);
    }
}
