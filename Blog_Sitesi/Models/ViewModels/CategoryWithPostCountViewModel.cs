using Microsoft.AspNetCore.Mvc;

namespace Blog_Sitesi.Models.ViewModels
{
    public class CategoryWithPostCountViewModel
    {
        public string CategoryName { get; set; }
        public int PostCount{ get; set; }
    }
}
