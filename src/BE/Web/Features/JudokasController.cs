namespace JTSystem.Web.Features
{
    using JTSystem.Application.Common;
    using JTSystem.Application.Tournaments.Comands.Categories.Delete;
    using JTSystem.Application.Tournaments.Comands.Judokas.Create;
    using JTSystem.Application.Tournaments.Comands.Judokas.Edit;
    using JTSystem.Application.Tournaments.Queries.Common;
    using JTSystem.Application.Tournaments.Queries.Judokas;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class JudokasController : ApiController
    {
        [HttpPost(nameof(Create))]
        [Authorize]
        public async Task<ActionResult<CreateJudokaOutputModel>> Create(
            CreateJudokaCommand command)
            => await this.Send(command);

        [HttpPost(nameof(Edit))]
        [Authorize]
        public async Task<ActionResult<EditJudokaOutputModel>> Edit(
            EditJudokaCommand command)
            => await this.Send(command);

        [HttpPost(nameof(Delete))]
        [Authorize]
        public async Task<ActionResult<Result>> Delete(
            DeleteJudokaCommand command)
            => await this.Send(command);

        [HttpGet(nameof(GetJudokaDetails))]
        public async Task<ActionResult<JudokaOutputModel>> GetJudokaDetails(
            [FromQuery] GetJudokaDetailsQuery query)
            => await this.Send(query);

        [HttpGet(nameof(GetJudokas))]
        public async Task<ActionResult<IEnumerable<JudokaOutputModel>>> GetJudokas(
            [FromQuery] GetJudokasQuery query)
            => await this.Send(query);

        [HttpGet(nameof(GetJudokasByTournament))]
        public async Task<ActionResult<IEnumerable<JudokaOutputModel>>> GetJudokasByTournament(
            [FromQuery] GetJudokasByTournamentQuery query)
            => await this.Send(query);
    }
}
