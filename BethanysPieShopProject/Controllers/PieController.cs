namespace BethanysPieShopProject.Controllers
{
    using BethanysPieShopProject.Models.Repositories;
    using BethanysPieShopProject.ViewModels;
    using Microsoft.AspNetCore.Mvc;

    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            PieListViewModel pieListViewModel = new PieListViewModel();
            pieListViewModel.Pies = _pieRepository.AllPies;
            return View(pieListViewModel);
        }
    }
}
