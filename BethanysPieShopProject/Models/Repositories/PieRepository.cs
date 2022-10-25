namespace BethanysPieShopProject.Models.Repositories
{
    using BethanysPieShopProject.Models.Context;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;

    public class PieRepository : IPieRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public PieRepository( ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public IEnumerable<Pie> AllPies
        {
            get { return _applicationDbContext.Pies.Include(e => e.Category); }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _applicationDbContext.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek);
            }
        }

        public Pie GetPieById(int id)
        {
            return _applicationDbContext.Pies.FirstOrDefault(p => p.PieId == id);
        }
    }
}
