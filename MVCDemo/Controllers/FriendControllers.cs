using Microsoft.AspNetCore.Mvc;
using MVCDemo.FriendServices;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class FriendController : Controller
    {
        public IActionResult Index()
        {
            List<FriendModel> friends = FriendService.GetAll();
            return View(friends);
        }

        public IActionResult Details(int id)
        {
            FriendModel f = FriendService.Get(id);
            return View(f);
        }
        public IActionResult List()
        {
            List<FriendModel> friends = FriendService.GetAll();
            return View(friends);
        }


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(FriendModel f)
        {
            FriendService.Add(f);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int Id)
        {
            FriendModel f = FriendService.Get(Id);
            if (f != null)
                return View(f);
            else
                return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult Delete(FriendModel f)
        {
            FriendService.Delete(f.FriendID);
            return RedirectToAction("List");
        }
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id, string Fname, string Fplace)
        {
            FriendModel f = new FriendModel { FriendID = id, FName = Fname, FPlace = Fplace };
            FriendService.Update(f);
            return RedirectToAction("List");
        }
    }
}

