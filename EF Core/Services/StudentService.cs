using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using EF_Core.DAL;
using EF_Core.models;

namespace EF_Core.Services
{
    internal class StudentService
    {
        private static AppDataBase _context = new AppDataBase();

        public static List<Student> GetAll()
        {
            return _context.Students.ToList();
            
        }

        public static Student GetById(int id)
        {
            return _context.Students.FirstOrDefault(s => s.Id == id);
        }

        public static void Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public static void Delete(int id)
        {
            var student = _context.Students.FirstOrDefault(s => s.Id == id);
            if(student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
        }


    }
}
