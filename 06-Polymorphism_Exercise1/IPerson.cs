using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;

namespace _06_Polymorphism_Exercise1
{
    public interface IPerson<T>
    {
        bool Create(T model);
        T GetById(int id);
        IEnumerable<T> GetAll();
        bool Update(T model);
        bool Delete(int id);
    }
}