using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Univer_project.Models
{
    public class TimetableCell
    {
        public int Id { get; set; }
        public string Time_interval { get; set; }
        public string Subject { get; set; }
        public string Building { get; set; }
        public string Teacher { get; set; }
        public int Audience { get; set; }

    }

    public class IdAndDayOfWeek
    {
        public int Timetable_cell { get; set; }
        public string Day_of_week { get; set; }
    }
    public class Timetable
    {
        public int Id { get; set; }
        public string Day_of_week { get; set; }
        //public int Group_name { get; set; }
        public TimetableCell Timetable_cell{ get; set; }

        public Timetable( string day_of_week, TimetableCell timetableCell)
        {
            Day_of_week = day_of_week;
            Timetable_cell = timetableCell;
        }
    }

}
