using EF_Core.DAL;
using EF_Core.models;
using EF_Core.Services;

namespace EF_Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new AppDataBase();

            //var student1 = new Student { Name = "Murad", Surname = "Ganbarov", AvgPoint = "75" };
            //var student2 = new Student { Name = "Tofiq", Surname = "Nasibli", AvgPoint = "90" };
            //var student3 = new Student { Name = "Sabuhi", Surname = "Jamalzade", AvgPoint = "98" };

            //StudentService.Create(student1);
            //StudentService.Create(student2);
            //StudentService.Create(student3);



            //var Allstudents = StudentService.GetAll();
            //foreach (var student in Allstudents)
            //{
            //    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Surname: {student.Surname}, AvgPoint: {student.AvgPoint}");
            //}


            StudentService.Delete(1);
            var Allstudents = StudentService.GetAll();
            foreach (var student in Allstudents)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Surname: {student.Surname}, AvgPoint: {student.AvgPoint}");
            }


        }
    }
}