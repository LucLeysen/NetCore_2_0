using System.Collections.Generic;
using BethaniesPieShop.Models;

namespace BethaniesPieShop.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Pie> Pies { get; set; }
    }
}