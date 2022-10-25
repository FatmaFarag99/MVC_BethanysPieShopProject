namespace BethanysPieShopProject.ViewModels
{
    using BethanysPieShopProject.Models;

    public class PieListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
