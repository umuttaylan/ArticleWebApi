﻿using Movie.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Movie.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetList(Expression<Func<T, bool>> condition = null);
        T Get(Expression<Func<T, bool>> condition);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        bool SaveChanges();
    }
}
