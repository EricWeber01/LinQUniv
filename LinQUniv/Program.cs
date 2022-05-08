using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace LinqUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Department> dp = new List<Department>();
            List<Group> gp = new List<Group>();
            List<Teacher> tc = new List<Teacher>();
            List<Faculty> fc = new List<Faculty>();
            Academy parse = new Academy();
            parse.ReadDepartmnet(dp);
            parse.ReadFaculty(fc);
            parse.ReadGroup(gp);
            parse.ReadTeacher(tc);
            fc.Reverse();
            var z1 = fc;
            fc.Reverse();
            var z2 = gp.Select(p => p.Name + " | " + p.Rating);
            var z3 = tc.Select(p => p.Surname + p.Salary / p.Premium + "x раз больше" + p.Salary + " | " + p.Premium);
            var z4 = fc.Select(p => "The dean of faculty " + p.Name + " is " + p.Dean);
            var z5 = tc.Where(p => p.Salary > 1050 && p.IsProfessor == true).Select(p => p.Surname);
            var z6 = dp.Where(p => p.Financing > 25000 || p.Financing < 11000).Select(p => p.Name);
            var z7 = fc.SkipWhile(p => p.Name == "Computer Science").Select(p => p.Name);
            var z8 = tc.Where(p => p.IsProfessor == false).Select(p => p.Surname + " | " + p.Position);
            var z9 = tc.Where(p => p.IsAssistant == true && (p.Premium > 160 && p.Premium < 550)).Select(p => p.Name + "|" + p.Position + "|" + p.Salary + "|" + p.Premium);
            var z10 = tc.Where(p => p.IsAssistant == true).Select(p => p.Surname + " | " + p.Salary);
            var z11 = tc.Where(p => p.EmploymentDate < new DateTime(2000, 01, 01)).Select(p => p.Position + " | " + p.Position);
            var z12 = fc.OrderBy(p => p.Name).TakeWhile(p => p.Name != "Software Development").Select(p => p.Name);
            var z13 = tc.Where(p => p.IsAssistant == true && (p.Salary + p.Premium) < 1200).Select(p => p.Name);
            var z14 = gp.Where(p => p.Year == 5 && (p.Rating > 1 && p.Rating < 5)).Select(p => p.Name);
            var z15 = tc.Where(p => p.IsAssistant == true && (p.Salary < 550 || p.Premium < 200));

        }
    }
}
