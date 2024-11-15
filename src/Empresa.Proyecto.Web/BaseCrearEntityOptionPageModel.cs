using Empresa.Proyecto.Core.Entities;
using Empresa.Proyecto.Core.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

namespace Empresa.Proyecto.Web
{
    public class BaseCrearEntityOptionPageModel<T> : PageModel where T : BaseEntity
    {
        private readonly IAsyncRepository<EntityOption> Repo;
        private readonly ILogger<BaseCrearEntityOptionPageModel<T>> Logger;
        private readonly IAsyncRepository<SimpleEntity> _simpleEntityRepo;

        public IReadOnlyList<SimpleEntity> Entidades { get; set; } = null!;


        public BaseCrearEntityOptionPageModel(ILogger<BaseCrearEntityOptionPageModel<T>> logger, IAsyncRepository<EntityOption> repo, IAsyncRepository<SimpleEntity> simpleEntityRepo)
        {
            Repo = repo;
            Logger = logger;
            _simpleEntityRepo = simpleEntityRepo;
        }
        [BindProperty]
        public EntityOption Input { get; set; } = null!;

        public virtual async Task OnGetAsync()
        {
            Entidades = await _simpleEntityRepo.ListAllOrderAsync();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                // Si el modelo no es válido, devuelve un error con los mensajes de validación.
                var errorMessages = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();

                return new JsonResult(new { success = false, errorMessage = string.Join(", ", errorMessages) });
            }

            // Si el modelo es válido, guarda la nueva opción
            var entityOption = new EntityOption
            {
                Nombre = Input.Nombre,
                SimpleEntityId = Input.SimpleEntityId,
                Created = DateTime.Now,
                Modified = DateTime.Now,                              
            };

            await Repo.AddAsync(entityOption);

            // Devuelve una respuesta JSON con éxito y una redirección a la vista principal
            return new JsonResult(new { success = true, message = "La opción se creó correctamente", redirectUrl = "/Index" });
        }
    }
}
