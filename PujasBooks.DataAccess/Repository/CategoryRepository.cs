﻿using PujasBooks.DataAccess.Repository.IRepository;
using PujasBooks.Models;
using PujasBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PujasBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            // use .NET LINQ to retrieve the first or default category object,
            // then pass the id as a generic entity which matches the category ID
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);

            if (objFromDb != null)  // Save changes if not null
            {
                objFromDb.Name = category.Name;
                //_db.SaveChanges();
            }

            //throw new NotImplementedException();
        }
    }
}
