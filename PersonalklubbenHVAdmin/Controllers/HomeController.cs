using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Loinprojekt_admin.Controllers
{
     [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Models.AdminModel sessionObjekt = (Models.AdminModel)Session["admin"];

            ViewBag.Username = "Inloggad som: " + sessionObjekt.username;
            return View();
        }
        //funkar
        public ActionResult ShowProfile(int id)
        {
<<<<<<< HEAD
            
            UserService.UserProfileServiceClient client = new UserService.UserProfileServiceClient();
=======
            Models.AdminModel sessionObjekt = (Models.AdminModel)Session["admin"];

            ViewBag.Username = "Inloggad som: " + sessionObjekt.username;
            try
            {
                // Anrop till webservicen
                UserService.UserProfileServiceClient client = new UserService.UserProfileServiceClient();
>>>>>>> Sessions klara, man måste starta från vyn "LoginPage" och logga in med kontot Admin/Admin

            return View(client.GetUserByUserId(id));
        }
        //funkar
        public ActionResult ActiveUsers()
        {
<<<<<<< HEAD
            LoginService.LoginServiceClient client = new LoginService.LoginServiceClient();
            
            return View(client.GetActiveUsers());
=======
            Models.AdminModel sessionObjekt = (Models.AdminModel)Session["admin"];

            ViewBag.Username = "Inloggad som: " + sessionObjekt.username;
            try
            {
                // Anrop till webservicen
                LoginService.LoginServiceClient client = new LoginService.LoginServiceClient();
                if (client.GetActiveUsers() != null)
                {
                    // Anrop till servicens metod för att visa alla aktiva användare
                    return View(client.GetActiveUsers());

                }
                else
                {
                    ModelState.AddModelError("Felmeddelande", "It seems like there are no active users yet");
                    return View();
                }
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Home", "ActiveUsers"));
            }
>>>>>>> Sessions klara, man måste starta från vyn "LoginPage" och logga in med kontot Admin/Admin
        }
        //funkar
        public ActionResult Moderators()
        {
<<<<<<< HEAD
            LoginService.LoginServiceClient client = new LoginService.LoginServiceClient();
=======
            Models.AdminModel sessionObjekt = (Models.AdminModel)Session["admin"];

            ViewBag.Username = "Inloggad som: " + sessionObjekt.username;
            try
            {
                // Anrop till webservicen
                LoginService.LoginServiceClient client = new LoginService.LoginServiceClient();
                if (client.GetModerators() != null)
                {
>>>>>>> Sessions klara, man måste starta från vyn "LoginPage" och logga in med kontot Admin/Admin

            return View(client.GetModerators());
        }
        //funkar
        public ActionResult FlaggedErrands()
        {
<<<<<<< HEAD
            LoginService.LoginServiceClient client = new LoginService.LoginServiceClient();
=======
            Models.AdminModel sessionObjekt = (Models.AdminModel)Session["admin"];

            ViewBag.Username = "Inloggad som: " + sessionObjekt.username;
            try
            {
                // Anrop till webservicen
                LoginService.LoginServiceClient client = new LoginService.LoginServiceClient();
                if (client.GetFlaggedUsers() != null)
                {
                    // Anrop till webservicens metod för att visa alla flaggade ärenden
                    return View(client.GetFlaggedUsers());
>>>>>>> Sessions klara, man måste starta från vyn "LoginPage" och logga in med kontot Admin/Admin

            return View(client.GetFlaggedUsers());
        } 
        //funkar
        public ActionResult BlockedUsers()
        {
<<<<<<< HEAD
            LoginService.LoginServiceClient client = new LoginService.LoginServiceClient();

            return View(client.GetBlockedUsers());
=======
            Models.AdminModel sessionObjekt = (Models.AdminModel)Session["admin"];

            ViewBag.Username = "Inloggad som: " + sessionObjekt.username;
            try
            {
                // Anrop till webservicen
                LoginService.LoginServiceClient client = new LoginService.LoginServiceClient();
                if (client.GetBlockedUsers() != null)
                {
                    // Anrop till webservicens metod för att visa alla blockade användare
                    return View(client.GetBlockedUsers());
                }
                else
                {
                    ModelState.AddModelError("Felmeddelande", "No blocked users, good for us!");
                    return View();
                }
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Home", "ActiveUsers"));
            }
           
>>>>>>> Sessions klara, man måste starta från vyn "LoginPage" och logga in med kontot Admin/Admin
        }
     
        //funkar
        public ActionResult Delete(int id)
        {
<<<<<<< HEAD
            UserService.UserProfileServiceClient client = new UserService.UserProfileServiceClient();
            return View(client.GetUserByUserId(id));
=======
            Models.AdminModel sessionObjekt = (Models.AdminModel)Session["admin"];

            ViewBag.Username = "Inloggad som: " + sessionObjekt.username;
            try
            {
                // Anrop till webservicen
                UserService.UserProfileServiceClient client = new UserService.UserProfileServiceClient();
                if (client.GetUserByUserId(id) != null)
                {
                    // Anrop till webservicens metod för att hitta en specifik användare och visa upp en vy utifrån detta
                    return View(client.GetUserByUserId(id));
                }
                else
                {
                    ModelState.AddModelError("Felmeddelande", "Cant find this user");
                    return View();
                }
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Home", "ActiveUsers"));
            }

>>>>>>> Sessions klara, man måste starta från vyn "LoginPage" och logga in med kontot Admin/Admin
        }
        //funkar
        [HttpPost, ActionName("Delete")] [ValidateAntiForgeryToken]
        public ActionResult ConfirmDelete(int id)
        {
<<<<<<< HEAD
            LoginService.LoginServiceClient client = new LoginService.LoginServiceClient();
            client.DeleteUser(id);
=======
            Models.AdminModel sessionObjekt = (Models.AdminModel)Session["admin"];

            ViewBag.Username = "Inloggad som: " + sessionObjekt.username;
            try
            {
                // Anrop till webservicen
                LoginService.LoginServiceClient client = new LoginService.LoginServiceClient();
                // Anrop till webservicens metod för att radera en användare, där vi skickar me med den specifika användarens Id
                client.DeleteUser(id);
                // När raderingen slutförs, återvänd till sidan som visar alla aktiva användare
                ModelState.AddModelError("Felmeddelande", "Konto raderat!");
                return RedirectToAction("ActiveUsers");
>>>>>>> Sessions klara, man måste starta från vyn "LoginPage" och logga in med kontot Admin/Admin

            return RedirectToAction("ActiveUsers");
        }
        //funkar
        public ActionResult AddPermission(int id)
        {
<<<<<<< HEAD
           LoginService.LoginServiceClient client = new LoginService.LoginServiceClient();
            client.AssignModeratorRole(id);
=======
            Models.AdminModel sessionObjekt = (Models.AdminModel)Session["admin"];

            ViewBag.Username = "Inloggad som: " + sessionObjekt.username;
>>>>>>> Sessions klara, man måste starta från vyn "LoginPage" och logga in med kontot Admin/Admin

            return RedirectToAction("ActiveUsers");
        }
        //funkar
        public ActionResult DeletePermission(int id)
        {
<<<<<<< HEAD
            LoginService.LoginServiceClient client = new LoginService.LoginServiceClient();
            client.AssignUserRole(id);

            return RedirectToAction("Moderators");
=======
            Models.AdminModel sessionObjekt = (Models.AdminModel)Session["admin"];

            ViewBag.Username = "Inloggad som: " + sessionObjekt.username;
            try
            {
                // Anrop till webservicen
                LoginService.LoginServiceClient client = new LoginService.LoginServiceClient();
                if (client.AssignUserRole(id) == true)
                {
                    // Här ropas på webserivcens metod för att lägga till behörigheter, är det rätt?
                    client.AssignUserRole(id);
                    // När behörigheten är raderad, återvänd till sidan som visar alla moderatorer
                    return RedirectToAction("Moderators");
                }
                else
                {
                    ModelState.AddModelError("Felmeddelande", "The user is already a normal user");
                    return View();
                }
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Home", "ActiveUsers"));
            }
>>>>>>> Sessions klara, man måste starta från vyn "LoginPage" och logga in med kontot Admin/Admin
        }
        //funkar
        public ActionResult Unflag(int id)
        {
<<<<<<< HEAD
            LoginService.LoginServiceClient client = new LoginService.LoginServiceClient();
=======
            Models.AdminModel sessionObjekt = (Models.AdminModel)Session["admin"];

            ViewBag.Username = "Inloggad som: " + sessionObjekt.username;
            try
            {
                // Anrop till webservicen
                LoginService.LoginServiceClient client = new LoginService.LoginServiceClient();
                if (client.AssignUserRole(id) == true)
                {
                    // Anrop till webservicens metod för att ta bort flaggan från en användare, här skickar vi med Id:t för den specifika användaren
                    client.UnflagUser(id);
                    // När operationen är klar, återvänd till sidan som visar alla aktiva användare
                    return RedirectToAction("ActiveUsers");
                }
                else
                {
                    ModelState.AddModelError("Felmeddelande", "The user cant be unflagged");
                    return View();
                }
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Home", "ActiveUsers"));
            }
>>>>>>> Sessions klara, man måste starta från vyn "LoginPage" och logga in med kontot Admin/Admin

            client.UnflagUser(id);
            return RedirectToAction("ActiveUsers");
        }


        //KVAR ATT GÖRA:

        /* public ActionResult Block(int id)
         {
             LoginService.LoginServiceClient client = new LoginService.LoginServiceClient();
             client.BlockUser(id);
             return RedirectToAction("ActiveUsers");
         }*/


        public ActionResult Contact()
        {
<<<<<<< HEAD
            LoginService.LoginServiceClient client = new LoginService.LoginServiceClient();
            client.GetAdmins();
            return View();
=======
              Models.AdminModel sessionObjekt = (Models.AdminModel)Session["admin"];

            ViewBag.Username = "Inloggad som: " + sessionObjekt.username;
            try
            {
                // Anrop till webservicen
                LoginService.LoginServiceClient client = new LoginService.LoginServiceClient();
                if (client.GetAdmins() != null)
                {

                    // Anrop till webserivcens metod för att hämta alla admins
                    return View(client.GetAdmins());
                }
                else
                {
                    ModelState.AddModelError("Felmeddelande", "It seems like there are no admins yet");
                    return View();
                }
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Home", "ActiveUsers"));
            }
>>>>>>> Sessions klara, man måste starta från vyn "LoginPage" och logga in med kontot Admin/Admin
        }
        public ActionResult LogOut()
        {
            return View();
        }
    }
}