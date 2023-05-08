using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace ASP.NET_Razor.Pages
{
    public class FirstPage : PageModel
    {
       public string title { set; get; } = "Day la trang Razor cua Hung";


        public void OnGet()
        {
            Console.WriteLine("Truy van Get");
            ViewData["mydata"] = "Razor cua Hung";
        }

        public void OnGetXyz()
        {
            Console.WriteLine("Truy van OnGetXyz");
            ViewData["mydata"] = "Razor cua Hung Xyz";
        }
        public string Welcome(string name)
        {
            return $"Chao mung {name} den voi trang web";
        }
    }
}
