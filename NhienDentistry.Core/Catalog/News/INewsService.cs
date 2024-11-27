using NhienDentistry.ViewModels.Catalog.News;
using NhienDentistry.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhienDentistry.Core.Catalog.News
{
    public interface INewsService
    {
        Task<int> Create(NewsRequestCreated request);

        Task<int> Update(NewsRequestUpdated request);

        Task<int> Delete(int productId);

        Task<NewsVm> GetById(int productId, string languageId);
        Task<PagedResult<NewsVm>> GetAllPaging(GetManageNewsPagingRequest request);
    }
}
