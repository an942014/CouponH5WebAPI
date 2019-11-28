﻿using BangBangFuli.H5.API.Core.Entities;
using BangBangFuli.H5.API.Core.IRepositories.BasicDatas;
using BangBangFuli.Utils.ORM.Imp;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangBangFuli.H5.API.EntityFrameworkCore.Repositories
{
    public class ProductRepository : BaseRepository<CouponSystemDBContext, ProductInformation>, IProductRepository
    {
        public ProductRepository(IDbContextManager<CouponSystemDBContext> dbContextManager)
: base(dbContextManager)
        {
        }

        public  List<ProductInformation> GetAll()
        {
            return Master.ProductInformations.ToList();
        }
    }
}
