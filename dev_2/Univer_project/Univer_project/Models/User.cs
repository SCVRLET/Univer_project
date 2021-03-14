using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Univer_project.Service;

namespace Univer_project.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Hash_code { get; set; }
        public string Email { get; set; }
        public int Institute { get; set; }
        public int Group_name { get; set; }
        public string Full_name { get; set; }
        public bool Is_teacher { get; set; }

        public string GetAvatarName()
        {
            using (IDbConnection temp_connection = new SqlConnection(Config.ConnectionString))
            {
                var t = temp_connection.Query<UserPhoto>("SELECT * FROM UsersPhotos").Where(x => x.User_id == Id);

                if (t.Count() > 0)
                    return t.First().Photo;
            }

            return "https://prikolist.club/wp-content/uploads/2019/12/0-14.jpg";
        }
    }
}
    