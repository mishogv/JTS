namespace JTSystem.Web.Features
{
    using JTSystem.Application.Statistics.Queries.GetJudokaViewsQuery;
    using JTSystem.Application.Statistics.Queries.GetTournamentViewsQuery;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [Authorize]
    public class StatisticsController : ApiController
    {
        [HttpGet]
        [Route(nameof(GetJudokaViews) + PathSeparator + Id)]
        public async Task<ActionResult<IEnumerable<JudokaViewOutputModel>>> GetJudokaViews(
            [FromRoute] GetJudokaViewsQuery query)
            => await this.Send(query);

        [HttpGet]
        [Route(nameof(GetTouramentViews) + PathSeparator + Id)]
        public async Task<ActionResult<IEnumerable<TournamentViewOutputModel>>> GetTouramentViews(
            [FromRoute] GetTournamentViewsQuery query)
            => await this.Send(query);

    }
}
