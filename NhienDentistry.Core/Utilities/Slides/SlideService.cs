using NhienDentistry.Core.System.Roles;
using NhienDentistry.DataBase.EF;
using NhienDentistry.DataBase.Entities;
using NhienDentistry.ViewModels.System.Roles;
using NhienDentistry.ViewModels.Utilities.Slides;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhienDentistry.Core.Utilities.Slides
{
    public class SlideService : ISlideService
    {
        private readonly NhienDbContext _context;

        public SlideService(NhienDbContext context)
        {
            _context = context;
        }

        public async Task<List<SlideVm>> GetAll()
        {
            var slides = await _context.Slides.OrderBy(x => x.SortOrder)
                .Select(x => new SlideVm()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Url = x.Url,
                    ImageId = x.Image.Id
                }).ToListAsync();

            return slides;
        }
    }
}