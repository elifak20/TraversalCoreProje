using Microsoft.AspNetCore.Mvc;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Controllers
{
    public interface ILoginController
    {
        IActionResult SignIn();
        IActionResult SignUp();
        Task<IActionResult> SignUp(UserRegisterViewModel p);
    }
}