namespace JTSystem.Web.Features
{
    using System.Threading.Tasks;
    using Application.Identity.Commands.ChangePassword;
    using Application.Identity.Commands.LoginUser;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class IdentityController : ApiController
    {
        [HttpPost(nameof(Login))]
        public async Task<ActionResult<LoginOutputModel>> Login(
            LoginUserCommand command)
            => await this.Send(command);

        [Authorize]
        [HttpPut(nameof(ChangePassword))]
        public async Task<ActionResult> ChangePassword(
            ChangePasswordCommand command)
            => await this.Send(command);
    }
}
