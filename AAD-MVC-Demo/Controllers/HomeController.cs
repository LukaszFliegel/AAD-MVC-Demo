using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AAD_MVC_Demo.Models;
using Microsoft.AspNetCore.Authorization;

namespace AAD_MVC_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Standard()
        {
            var bannedCards = new List<BannedCardViewModel>
            {
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=467001&type=card"
                },
                new BannedCardViewModel
                {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=473159&type=card"
                },
                new BannedCardViewModel
                {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=473131&type=card"
                },
                new BannedCardViewModel
                {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=466952&type=card"
                }                
            };

            return View(bannedCards);
        }

        public IActionResult Pionieer()
        {
            var bannedCards = new List<BannedCardViewModel>
            {
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=405094&type=card"
                },
                new BannedCardViewModel
                {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=423686&type=card"
                },
                new BannedCardViewModel
                {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=467001&type=card"
                },
                new BannedCardViewModel
                {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=405098&type=card"
                },
                new BannedCardViewModel
                {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=466933&type=card"
                },
                new BannedCardViewModel
                {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=450253&type=card"
                },
                new BannedCardViewModel
                {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=407650&type=card"
                },
                new BannedCardViewModel
                {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=473159&type=card"
                },
                new BannedCardViewModel
                {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=473131&type=card"
                },
                new BannedCardViewModel
                {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=405104&type=card"
                },
                new BannedCardViewModel
                {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=417808&type=card"
                },
                new BannedCardViewModel
                {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=466952&type=card"
                },
                new BannedCardViewModel
                {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=405115&type=card"
                },
                new BannedCardViewModel
                {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=405116&type=card"
                }
            };

            return View(bannedCards);
        }

        public IActionResult Modern()
        {
            var bannedCards = new List<BannedCardViewModel>
            {
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=205275&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=218006&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=74441&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=456683&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=420596&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=49050&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=456837&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=456063&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=456646&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=409631&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=409569&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=470686&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=233056&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=75241&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=456763&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=451205&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=413711&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=464151&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=113533&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=51633&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=230066&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=420606&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=446209&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=473159&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=451051&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=405347&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=247550&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=121217&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=451233&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=49009&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=243487&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=413774&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=433154&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=397816&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=84694&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=456675&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=205312&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=416756&type=card"
                },
                new BannedCardViewModel {
                    ImageUri = "https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid=205313&type=card"
                }
            };

            return View(bannedCards);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
