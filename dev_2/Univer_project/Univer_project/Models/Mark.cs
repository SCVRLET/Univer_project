using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Univer_project.Models
{
    public class Mark
    {
        public int Id { get; set; }
        public int Semester { get; set; }
        public string Subject { get; set; }
        public int Points_for_semester { get; set; }
        public string Type_of_test { get; set; }
        public DateTime Date_of_test { get; set; }
        public int Points_for_test { get; set; }
        public int Sum_of_points { get => Points_for_semester + Points_for_test;}
    }
}
