﻿using Resturant_pro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_pro.AccessData.Repository.IRepository
{
    public interface ICategoryRepository :IRepository<Category> 
    {
        void Update(Category obj);
    
        
    }
}