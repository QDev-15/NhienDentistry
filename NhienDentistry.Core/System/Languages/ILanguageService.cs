using NhienDentistry.ViewModels.Common;
using NhienDentistry.ViewModels.System.Languages;
using NhienDentistry.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NhienDentistry.Core.System.Languages
{
    public interface ILanguageService
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}