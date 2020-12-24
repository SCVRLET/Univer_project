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
    public interface ITimetableService
    {
         IEnumerable<Institute>  GetInstitutes(); //Для института
         IEnumerable<Group> GetGroups(string institute_name); // Для группы
    }
    public class TimetableService : ITimetableService
    {
        public  IEnumerable<Institute> GetInstitutes() //Вытаскиваем институты
        {
            string command_select = "SELECT * FROM Institutes";
            List<Institute> ret;

            using (IDbConnection temp_connection = new SqlConnection(Config.ConnectionString))
                ret = temp_connection.Query<Institute>(command_select).ToList();
            
            return ret;
        }

        public  IEnumerable<Group> GetGroups(string institute_name) //Вытаскиваем группы институтов, "ключ" - название института
        {
            List<Group> ret;
            using (IDbConnection temp_connection = new SqlConnection(Config.ConnectionString))
                ret = temp_connection.Query<Group>("SELECT * FROM Groups").Where(x=>x.Institute_name==institute_name).ToList();
            
            return ret;
        }

        public IEnumerable<Timetable> GetTimetables(string group_name)
        {
            List<Timetable> ret = new List<Timetable>();

            string select_group = "SELECT Id FROM Groups WHERE Name = '" + group_name + "';";

            using (IDbConnection temp_connection = new SqlConnection(Config.ConnectionString))
            {
                int group = temp_connection.Query<int>(select_group).ToList().First();

                string command_1 = "SELECT Timetable_cell, Day_of_week FROM Timetable " +
                $"WHERE Group_name = {group} " +
                "ORDER BY " +
                "CASE " +
                "WHEN Day_of_week = 'Понедельник' THEN 1 " +
                "WHEN Day_of_week = 'Вторник' THEN 2" +
                "WHEN Day_of_week = 'Среда' THEN 3 " +
                "WHEN Day_of_week = 'Четверг' THEN 4 " +
                "WHEN Day_of_week = 'Пятница' THEN 5 " +
                "WHEN Day_of_week = 'Суббота' THEN 6 " +
                "END ASC;";

                var temp1 = temp_connection.Query<IdAndDayOfWeek>(command_1).ToList();

                foreach(var i in temp1)
                {
                    string temp_command = "SELECT TimetableCells.Id, Time_interval," +
                        " Subjects.Name AS Subject, " +
                        "Building, Teacher, Audience FROM TimetableCells JOIN Subjects " +
                        "ON TimetableCells.Subject = Subjects.Id " +
                        "WHERE TimetableCells.Id = " + i.Timetable_cell.ToString() + ";";
                    var t = temp_connection.Query<TimetableCell>(temp_command).ToList().First();
                    ret.Add(new Timetable(i.Day_of_week, t));
                }
            }

            return ret;
        }
    }
}
