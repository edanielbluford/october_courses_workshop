﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace october_courses_workshop.Repositories
{
    public interface IRepository<T> where T : class
    {

        IEnumerable<T> GetAll();
        T GetById(int id);
        //void Create(T obj);
        //void Delete(T obj);
        //void Update(T obj);


    }
}
