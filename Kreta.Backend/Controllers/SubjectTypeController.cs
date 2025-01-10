using Kreta.Backend.Controllers.Base;
using Kreta.Backend.Repos.Base;
using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kreta.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubjectTypeController : BaseController<SubjectType, SubjectTypeDto>
    {
        public SubjectTypeController(SubjectTypeAssambler? assambler, IBaseRepo<SubjectType>? repo) : base(assambler, repo)
        {
        }
    }
}
