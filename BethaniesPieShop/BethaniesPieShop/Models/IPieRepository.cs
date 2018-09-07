using System.Collections.Generic;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace BethaniesPieShop.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();
        Pie GetPieById(int pieId);
    }
}