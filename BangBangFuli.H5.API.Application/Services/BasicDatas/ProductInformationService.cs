﻿using System;
using System.Collections.Generic;
using System.Text;
using BangBangFuli.H5.API.Core.Entities;
using BangBangFuli.H5.API.Core.IRepositories.BasicDatas;

namespace BangBangFuli.H5.API.Application.Services.BasicDatas
{
    public class ProductInformationService : IProductInformationService
    {
        private readonly IProductRepository _productRepository;

        public ProductInformationService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public List<ProductInformation> GetAll()
        {
           return   _productRepository.GetAll();
        }
    }
}
