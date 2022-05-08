using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQUniv
{
    internal class Academy
    {
        class Teacher

        {

            public int Id { get; set; }

            public DateTime EmploymentDate { get; set; }

            public bool IsAssistant { get; set; }

            public bool IsProfessor { get; set; }

            public string Name { get; set; }

            public string Position { get; set; }

            public int Premium { get; set; }

            public int Salary { get; set; }

            public string Surname { get; set; }

            public override string ToString()
            {
                return $"{Id} | {EmploymentDate.ToShortDateString()} | {IsAssistant} | {IsProfessor} | {Name} | {Surname} | {Position} | {Premium} | {Salary}";
            }

        }

        class Group

        {

            public string Name { get; set; }

            public int Id { get; set; }

            public int Rating { get; set; }

            public int Year { get; set; }

            public int TeacherId { get; set; }

            public int DepartmentId { get; set; }
            public override string ToString()
            {
                return $"{Name} | {Id} | {Rating} | {Year} | {TeacherId} | {DepartmentId}";
            }

        }

        class Faculty

        {

            public int Id { get; set; }

            public string Name { get; set; }

            public string Dean { get; set; }

            public int DepartmentId { get; set; }
            public override string ToString()
            {
                return $"{Id} | {Name} | {Dean} | {DepartmentId}";
            }

        }

        class Department

        {

            public int Id { get; set; }

            public string Name { get; set; }

            public int Financing { get; set; }

            public override string ToString()

            {

                return $"Depatment {Id}:\nName: {Name}\nFinancing: {Financing}\n";

            }

        }

        class Academy

        {


            public void AddDepartmnet(List<Department> departments)

            {

                Console.WriteLine("Введите имя: ");

                string name = Console.ReadLine();

                Console.WriteLine("Введите id: ");

                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите финансирование");

                int financing = int.Parse(Console.ReadLine());

                departments.Add(new Department { Id = id, Name = name, Financing = financing });

            }
            public void ReadDepartmnet(List<Department> departments)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Departmnet.xml");
                XmlElement root = doc.DocumentElement;
                string name;
                int id;
                int financing;
                foreach (XmlNode item in doc.GetElementsByTagName("Departmnet"))
                {
                    XmlNode _name = item.Attributes.GetNamedItem("name");
                    XmlNode _id = item.Attributes.GetNamedItem("id");
                    XmlNode _financing = item.Attributes.GetNamedItem("financing");

                    name = _name.Value;
                    id = Int32.Parse(_id.Value);
                    financing = Int32.Parse(_financing.Value);
                    departments.Add(new Department { Id = id, Name = name, Financing = financing });
                }
            }
            public void AddFaculty(List<Faculty> faculties)

            {

                Console.WriteLine("Введите имя: ");

                string name = Console.ReadLine();

                Console.WriteLine("Введите id: ");

                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите имя декана: ");

                string dean = Console.ReadLine();

                Console.WriteLine("Введите id кафедры: ");

                int idd = int.Parse(Console.ReadLine());

                faculties.Add(new Faculty { Id = id, Dean = dean, Name = name, DepartmentId = idd });

            }
            public void ReadFaculty(List<Faculty> faculties)

            {



                string name;
                int id;
                string dean;
                int idd;

                XmlDocument doc = new XmlDocument();
                doc.Load("Faculty.xml");
                XmlElement root = doc.DocumentElement;

                foreach (XmlNode item in doc.GetElementsByTagName("Faculty"))
                {
                    XmlNode _name = item.Attributes.GetNamedItem("name");
                    XmlNode _id = item.Attributes.GetNamedItem("id");
                    XmlNode _idd = item.Attributes.GetNamedItem("idd");
                    XmlNode _dean = item.Attributes.GetNamedItem("dean");

                    name = _name.Value;
                    dean = _dean.Value;
                    id = Int32.Parse(_id.Value);
                    idd = Int32.Parse(_idd.Value);

                    faculties.Add(new Faculty { Id = id, Dean = dean, Name = name, DepartmentId = idd });
                }



            }
            public void AddGroup(List<Group> group)

            {

                Console.WriteLine("Введите имя: ");

                string name = Console.ReadLine();

                Console.WriteLine("Введите id: ");

                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите рейтинг(0-5): ");

                int rating = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите курс(0-5): ");

                int year = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите id перподавателя: ");

                int idt = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите id кафедры: ");

                int idd = int.Parse(Console.ReadLine());

                group.Add(new Group { Name = name, Id = id, Rating = rating, Year = year, TeacherId = idt, DepartmentId = idd });

            }

            public void ReadGroup(List<Group> group)
            {

                XmlDocument doc = new XmlDocument();
                doc.Load("Group.xml");
                XmlElement root = doc.DocumentElement;
                foreach (XmlNode item in doc.GetElementsByTagName("Group"))
                {
                    XmlNode _name = item.Attributes.GetNamedItem("name");
                    XmlNode _id = item.Attributes.GetNamedItem("id");
                    XmlNode _rating = item.Attributes.GetNamedItem("rating");
                    XmlNode _year = item.Attributes.GetNamedItem("year");
                    XmlNode _idt = item.Attributes.GetNamedItem("idt");
                    XmlNode _idd = item.Attributes.GetNamedItem("idd");
                    group.Add(new Group { Name = _name.Value, Id = Int32.Parse(_id.Value), Rating = Int32.Parse(_rating.Value), Year = Int32.Parse(_year.Value), TeacherId = Int32.Parse(_idt.Value), DepartmentId = Int32.Parse(_idd.Value) });
                }

            }
            public void AddTeacher(List<Teacher> teachers)

            {

                Console.WriteLine("Введите имя: ");

                string name = Console.ReadLine();

                Console.WriteLine("Введите фамилию: ");

                string surname = Console.ReadLine();

                Console.WriteLine("Введите id: ");

                int id = int.Parse(Console.ReadLine());

                DateTime date = DateTime.Now;

                Console.WriteLine("Ассистент-true,false: ");

                bool assistant = bool.Parse(Console.ReadLine());

                Console.WriteLine("Профессор-true,false: ");

                bool professor = bool.Parse(Console.ReadLine());

                Console.WriteLine("Введите должность: ");

                string postion = Console.ReadLine();

                Console.WriteLine("Введите зарплату: ");

                int salary = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите премию: ");

                int premium = int.Parse(Console.ReadLine());

                teachers.Add(new Teacher { Name = name, Surname = surname, Id = id, EmploymentDate = date, IsAssistant = assistant, IsProfessor = professor, Position = postion, Salary = salary, Premium = premium });

            }

            public void ReadTeacher(List<Teacher> teachers)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Teacher.xml");
                XmlElement root = doc.DocumentElement;
                foreach (XmlNode item in doc.GetElementsByTagName("Teacher"))
                {
                    XmlNode _name = item.Attributes.GetNamedItem("name");
                    XmlNode _surname = item.Attributes.GetNamedItem("surname");
                    XmlNode _id = item.Attributes.GetNamedItem("id");
                    XmlNode _assistant = item.Attributes.GetNamedItem("assistant");
                    XmlNode _professor = item.Attributes.GetNamedItem("professor");
                    XmlNode _position = item.Attributes.GetNamedItem("position");
                    XmlNode _salary = item.Attributes.GetNamedItem("salary");
                    XmlNode _premium = item.Attributes.GetNamedItem("premium");
                    XmlNode _date = item.Attributes.GetNamedItem("date");
                    teachers.Add(new Teacher
                    {
                        Name = _name.Value,
                        Surname = _surname.Value,
                        Id = Int32.Parse(_id.Value),
                        EmploymentDate = DateTime.Parse(_date.Value),
                        IsAssistant = bool.Parse(_assistant.Value),
                        IsProfessor = bool.Parse(_professor.Value),
                        Position = _position.Value,
                        Salary = Int32.Parse(_salary.Value),
                        Premium = Int32.Parse(_premium.Value)
                    });

                }
            }
}
