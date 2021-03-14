using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Univer_project.Models;
using Univer_project.Service;

namespace Univer_project.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        IWebHostEnvironment _appEnvironment;

        public UserController(IWebHostEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;
        }

        User GetThisUser()
        {
            User user;
            using (IDbConnection temp_connection = new SqlConnection(Config.ConnectionString))
            {
                user = temp_connection.Query<User>("SELECT * FROM Users WHERE Login = '"
                     + HttpContext.User.Identity.Name + "';").ToList().First();
            }
            return user;
        }

        public IActionResult Index(User user)
        {
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Progress()
        {
            var id = GetThisUser().Id;
            List<Mark> marks;
            using (IDbConnection temp_connection = new SqlConnection(Config.ConnectionString))
            {
                marks = temp_connection.Query<Mark>($"SELECT Marks.Id, Semester, Subjects.Name as Subject, Points_for_semester, Type_of_test," +
                    $"Date_of_test, Points_for_test " +
                    $" FROM Marks " +
                    $"JOIN Subjects ON Subjects.Id = Marks.Subject_Id " +
                    $"WHERE User_Id = {id};").ToList();
            }

            return View(marks);
        }

        public IActionResult Timetable()
        {
            return View("Timetable", new TimetableService());
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

        public IActionResult Profile()
        {
            return View(GetThisUser());
        }

        [HttpPost]
        public IActionResult ChangeEmail(string email)
        {
            SqlConnection temp_connection = new SqlConnection(Config.ConnectionString);
            temp_connection.Open();
            var command = $"UPDATE Users SET Email = @email WHERE Id = {GetThisUser().Id}";
            SqlCommand sqlcommand = new SqlCommand(command, temp_connection);
            sqlcommand.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            sqlcommand.ExecuteScalar();
            temp_connection.Close();

           return RedirectToAction("Profile");
        }

        [HttpPost]
        public async Task<IActionResult> ChangeProfilePhoto(IFormFile photo)
        {
            try
            {
                if (photo.Length > 0)
                {
                    using (FileStream fileStream = System.IO.File.Create($"{_appEnvironment.WebRootPath}/UsersProfilesPhotos/" + GetThisUser().Login + ".jpg"))
                    {
                        await photo.CopyToAsync(fileStream);
                        fileStream.Flush();

                    }

                    using (IDbConnection temp_connection = new SqlConnection(Config.ConnectionString))
                    {
                        if (temp_connection.Query<UserPhoto>($"SELECT * FROM UsersPhotos WHERE User_id = {GetThisUser().Id}").Count() == 0)
                            temp_connection.Execute($"INSERT INTO UsersPhotos (User_id,Photo) VALUES ({GetThisUser().Id}," +
                            $"'{_appEnvironment.WebRootPath}/UsersProfilesPhotos/" + GetThisUser().Login + ".jpg" + $"')");

                        else
                            temp_connection.Execute($"UPDATE UsersPhotos SET" +
                            $" Photo = '{_appEnvironment.WebRootPath}/UsersProfilesPhotos/" + GetThisUser().Login + ".jpg" + $"'" +
                            $"WHERE User_id = {GetThisUser().Id}");
                    }
                }
            }

            catch
            {
                return RedirectToAction("Profile");
            }

            return RedirectToAction("Profile");
        }

        public IActionResult AboutUs()
        {
            return View();
        }
    }

    public class FileUPloadAPI
    {
        public IFormFile files { get; set; }
    }
}
