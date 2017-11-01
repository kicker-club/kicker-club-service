using Microsoft.AspNetCore.Mvc;

namespace kicker_club_service.Controllers
{
    [Route("api/tournaments")]
    public class TournamentsController : Controller
    {
        [HttpGet]
        public JsonResult Get()
        {
            var listTournaments = new string[] { "Double Elimination", "Round Robin", "MonsterDyp", "Single Elimination", "Group Tournament" };

            return Json(listTournaments);
        }
    }
}