using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Empresa.Proyecto.Core.Entities;
using Empresa.Proyecto.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Empresa.Proyecto.Web.Pages
{
    public class BaseCatalogPageModel<T>: PageModel where T : BaseEntity
    {
        private readonly IAsyncRepository<T> Repo;
        private readonly ILogger<BaseCatalogPageModel<T>> Logger;

        public IReadOnlyList<T> Entidades { get; set; } = null!;

        public BaseCatalogPageModel(ILogger<BaseCatalogPageModel<T>> logger, IAsyncRepository<T> repo)
        {
            Repo = repo;
            Logger = logger;
        }

        public async Task<JsonResult> OnPostCatalog(int pageNumber = 1, int pageSize = 10)
        {
            var (items, totalCount) = await Repo.GetPagedAsync(pageNumber, pageSize);
            return new JsonResult(new { data = items, recordsTotal = totalCount, recordsFiltered = totalCount });
        }
    }
}
