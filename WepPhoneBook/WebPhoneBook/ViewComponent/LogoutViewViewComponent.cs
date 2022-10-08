using Microsoft.AspNetCore.Mvc;

namespace WebPhoneBook.Component
{
    public class LogoutViewViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
