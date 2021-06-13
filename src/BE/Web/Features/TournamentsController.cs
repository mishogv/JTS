namespace JTSystem.Web.Features
{
    using JTSystem.Application.Tournaments.Comands.Create;
    using JTSystem.Application.Tournaments.Comands.Edit;
    using JTSystem.Application.Tournaments.Comands.Delete;
    using JTSystem.Application.Tournaments.Queries.Common;
    using JTSystem.Application.Tournaments.Queries.Tournaments;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using JTSystem.Application.Common;
    using JTSystem.Application.Tournaments.Queries.Details;

    public class TournamentsController : ApiController
    {
        [HttpPost(nameof(Create))]
        [Authorize]
        public async Task<ActionResult<CreateTournamentOutputModel>> Create(
            CreateTournamentCommand command)
            => await this.Send(command);

        [HttpPost(nameof(Edit))]
        [Authorize]
        public async Task<ActionResult<EditTournamentOutputModel>> Edit(
            EditTournamentCommand command)
            => await this.Send(command);

        [HttpPost(nameof(Delete))]
        [Authorize]
        public async Task<ActionResult<Result>> Delete(
            DeleteTournamentCommand command)
            => await this.Send(command);

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TournamentOutputModel>>> Tournaments(
            [FromQuery] GetTournamentsQuery command)
            => await this.Send(command);

        [HttpGet(nameof(GetTournamentDetails))]
        public async Task<ActionResult<TournamentDetailsOutputModel>> GetTournamentDetails(
            [FromQuery] GetTournamentDetailsQuery command)
            => await this.Send(command);

    }
}
