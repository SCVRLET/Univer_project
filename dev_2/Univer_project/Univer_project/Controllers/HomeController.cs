using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Univer_project.Models;
using Univer_project.Service;
using System.Text;
using System.Data;
using Dapper;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Univer_project.Controllers
{
    public class HomeController : Controller
    {

        SqlCommand sql_command = new SqlCommand();


        string GetHashString(string s)
        { 
            byte[] bytes = Encoding.UTF8.GetBytes(s);

            MD5CryptoServiceProvider CSP =
                new MD5CryptoServiceProvider();

            byte[] byteHash = CSP.ComputeHash(bytes);

            string hash = string.Empty;

            foreach (byte b in byteHash)
                hash += string.Format("{0:x2}", b);

            return hash;
        }

        public IActionResult Index()
        {
            if(!HttpContext.User.Identity.IsAuthenticated)
                return View();

            User user;
            using (IDbConnection temp_connection = new SqlConnection(Config.ConnectionString))
            {
                user = temp_connection.Query<User>("SELECT * FROM Users WHERE Login = '"
                     + HttpContext.User.Identity.Name + "';").ToList().First();
            }
            return RedirectToAction("Index", "User", user);
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Timetable()
        {
            return View("Timetable", new TimetableService());
        }

        //Авторизация
        [HttpPost]
        public async Task<IActionResult> Login(string login, string password, bool rememberMe)
        {
            SqlConnection main_connection = new SqlConnection(Config.ConnectionString);
            main_connection.Open();

            var hash = GetHashString(password);
            string command_select = "SELECT * FROM Users;";
            SqlCommand sql_command = new SqlCommand(command_select, main_connection);

            User user;
            try
            {
                using (IDbConnection temp_connection = new SqlConnection(Config.ConnectionString))
                {
                    user = temp_connection.Query<User>(command_select).ToList().Where(x=>x.Login == login & x.Hash_code == hash).First();
                }

                var dr = sql_command.ExecuteReader();
                dr.Read();

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, login)
                };
                var identity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                var props = new AuthenticationProperties { IsPersistent = true, AllowRefresh=true };

                if (rememberMe)
                {
                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties()).Wait();
                }

                else
                {
                    HttpContext.SignInAsync(principal, props).Wait();
                }
                main_connection.Close();

                return RedirectToAction("Index", "User", user);
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public JsonResult GroupsSearch(string institute_name)
        {
            var timetableservice = new TimetableService();

            var groups = timetableservice.GetGroups(institute_name);

            return Json(groups);
        }

        [HttpPost]
        public IActionResult TimetableSearch(string group_name)
        {
            var timetableservice = new TimetableService();

            var timetables = timetableservice.GetTimetables(group_name);

            return Json(timetables);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
