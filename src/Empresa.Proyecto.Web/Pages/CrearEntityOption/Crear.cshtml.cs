using Empresa.Proyecto.Core.Entities;
using Empresa.Proyecto.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Empresa.Proyecto.Web.Pages.CrearEntityOption
{
    public class CrearModel : BaseCrearEntityOptionPageModel<EntityOption>
    {
        public CrearModel(ILogger<BaseCrearEntityOptionPageModel<EntityOption>> logger, IAsyncRepository<EntityOption> repo, IAsyncRepository<SimpleEntity> simpleEntityRepo) : base(logger, repo, simpleEntityRepo)
        {
        }

    }
}
