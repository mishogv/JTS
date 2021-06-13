namespace JTSystem.Web.Features
{
    using JTSystem.Application.Common;
    using JTSystem.Application.Tournaments.Comands.Categories.Create;
    using JTSystem.Application.Tournaments.Comands.Categories.Delete;
    using JTSystem.Application.Tournaments.Comands.Categories.Edit;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    public class CategoriesController : ApiController
    {
        [HttpPost(nameof(Create))]
        [Authorize]
        public async Task<ActionResult<CreateCategoryOutputModel>> Create(
            CreateCategoryCommand command)
            => await this.Send(command);

        [HttpPost(nameof(Edit))]
        [Authorize]
        public async Task<ActionResult<EditCategoryOutputModel>> Edit(
            EditCategoryCommand command)
            => await this.Send(command);

        [HttpPost(nameof(Delete))]
        [Authorize]
        public async Task<ActionResult<Result>> Delete(
            DeleteCategoryCommand command)
            => await this.Send(command);
    }
}
