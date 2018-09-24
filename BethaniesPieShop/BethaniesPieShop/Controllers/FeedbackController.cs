using BethaniesPieShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethaniesPieShop.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly IFeedbackRepository _feedbackRepository;

        public FeedbackController(IFeedbackRepository feedbackFeedbackRepository)
        {
            _feedbackRepository = feedbackFeedbackRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}