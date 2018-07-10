using System;
using System.Collections.Generic;

namespace _06_Polymorphism_Exercise2
{
    public interface IStudentService
    {
        bool Create(Student student);
        Student GetById(int studentId);
        IEnumerable<Student> GetAll();
        bool Update(Student student);
        bool Delete(int studentId);
    }
}