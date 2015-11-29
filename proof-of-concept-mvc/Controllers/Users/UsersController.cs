namespace proof_of_concept_mvc.Controllers.Users
{
    using System;
    using System.Web.Mvc;
    using Microsoft.AspNet.Identity;
    using proof_of_concept.Application.Users;
    using proof_of_concept.Domain.Users.Dto;

    [Authorize]
    public class UsersController : Controller
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: Users
        public ActionResult Index()
        {
            string currentUserId = User.Identity.GetUserId();
            var userDetails = _userService.GetUserDetails(currentUserId);
            return View(userDetails);
        }

        // POST: Edit Users
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UserDetailDto personViewModel)
        {
            if (ModelState.IsValid == false)
            {
                return View("Index", personViewModel);
            }

            try
            {
                personViewModel.Id = User.Identity.GetUserId();
                _userService.UpdateUserDetails(personViewModel);
            } 
            catch (Exception)
            {
                ViewBag.ErrorMessage = "Failed to update your details. Please try again.";
                return View("Index", personViewModel);
            }

            return RedirectToAction("Index");
        }
    }
}
