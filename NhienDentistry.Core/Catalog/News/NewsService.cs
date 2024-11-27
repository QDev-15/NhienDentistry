using NhienDentistry.ViewModels.Catalog.News;
using NhienDentistry.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhienDentistry.Core.Catalog.News
{
    internal class NewsService : INewsService
    {
        public Task<int> Create(NewsRequestCreated request)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<NewsVm>> GetAllPaging(GetManageNewsPagingRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<NewsVm> GetById(int productId, string languageId)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(NewsRequestUpdated request)
        {
            throw new NotImplementedException();
        }
    }
}
