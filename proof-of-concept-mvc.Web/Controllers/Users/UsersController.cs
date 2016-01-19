namespace proof_of_concept_mvc.Controllers.Users
{
    using System;
    using System.Web.Mvc;
    using Microsoft.AspNet.Identity;
    using proof_of_concept_mvc.Domain.Users;
    using proof_of_concept_mvc.Domain.Users.Dto;

    [Authorize]
    public class UsersController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // GET: Users
        public ActionResult Index()
        {
            string currentUserId = User.Identity.GetUserId();
            var userDetails = _userRepository.GetUserDetails(currentUserId);
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
                _userRepository.UpdateUserDetails(personViewModel);
                TempData["success-message"] = "User details updated."; // used in _ErrorContentPartial - active for one redirect then destroyed
            } 
            catch (Exception)
            {
                return View("Index", personViewModel);
            }

            return RedirectToAction("Index");
        }
    }
}
