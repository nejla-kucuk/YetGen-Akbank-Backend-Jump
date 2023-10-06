using Microsoft.AspNetCore.Mvc;
using W4._2_MVCCilent.Models;
using W4._2_PWGenerator;

namespace W4._2_MVCCilent.Controllers
{
    public class PasswordsController : Controller
    {
        private readonly PasswordGenerator _passwordGenerator;

        public PasswordsController()
        {
            _passwordGenerator = new PasswordGenerator();
        }

        // Bu kısma "Action" denir.
        [HttpGet]
        public IActionResult Index()
        {
            var indexViewModel = new PasswordsIndexViewModel();

            indexViewModel.WellcomeMessage = "Wellcome! :) ";

           // indexViewModel.Password = _passwordGenerator.Generate(15, true, true,true,true);

            return View(indexViewModel);
        }

        [HttpPost]
        public IActionResult Index(PasswordsIndexViewModel viewModel)
        {
            var indexViewModel = new PasswordsIndexViewModel();

            indexViewModel.Password = _passwordGenerator.Generate(viewModel.PasswordLenght, 
                                                                  viewModel.IncludeNumbers, 
                                                                  viewModel.IncludeLowerCaseChars, 
                                                                  viewModel.IncludeUpperCaseChars, 
                                                                  viewModel.IncludeSpecialChars);

            return View(indexViewModel);
        }
    }
}
