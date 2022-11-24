using PujasBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PujasBooks.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType coverType);
    }
}