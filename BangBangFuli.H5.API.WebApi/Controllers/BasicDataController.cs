﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using BangBangFuli.H5.API.Application.Models.BasicDatas;
using BangBangFuli.H5.API.Application.Services.BasicDatas;
using BangBangFuli.H5.API.Application.Services.Redis;
using BangBangFuli.H5.API.WebAPI;
using BangBangFuli.H5.API.WebAPI.Controllers.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;

namespace BangBangFuli.H5.API.WebAPI.Controllers
{
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class BasicDataController : ControllerBase
    {
        private readonly ICouponService _couponService;
        private readonly IBannerService _bannerService;
        private readonly IProductInformationService _productService;
        public string VERFIY_CODE_TOKEN_COOKIE_NAME = "VerifyCode";

        public BasicDataController(ICouponService couponService,IBannerService bannerService,IProductInformationService productService)
        {
            _couponService = couponService;
            _bannerService = bannerService;
            _productService = productService;
        }



        /// <summary>
        /// 1,获取批次号获取banner图片数组
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/v{version:apiVersion}/BasicData/Banner/{batchCode}")]
        public ResponseOutput GetBannerByBatchCode(string batchCode)
        {
            var photoUniqueNames = _bannerService.GetUniquePhotoNamesByBatchCode(batchCode);
            return new ResponseOutput(photoUniqueNames, HttpContext.TraceIdentifier);
        }


        /// <summary>
        ///2, 验证码接口,验证code写入cookie的VerifyCode键值对中
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/v{version:apiVersion}/BasicData/NumberVerifyCode")]
        public FileContentResult GetNumberVerifyCode()
        {
            string code = VerifyCodeHelper.GetSingleObj().CreateVerifyCode(VerifyCodeHelper.VerifyCodeType.NumberVerifyCode);

            Response.Cookies.Append(VERFIY_CODE_TOKEN_COOKIE_NAME, code);

            byte[] codeImage = VerifyCodeHelper.GetSingleObj().CreateByteByImgVerifyCode(code, 100, 40);
            return File(codeImage, @"image/jpeg");
        }

        /// <summary>
        /// 3,兑换,成功就返回券号信息
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("/api/v{version:apiVersion}/BasicData/ExchangeCoupon/{code}/{password}")]
        public ResponseOutput ExchangeCoupon(int code,string password )
        {
            CouponDto dto = new CouponDto();
            var ret = _couponService.VerifyCoupon(code, password);
            if (ret)
            {
                var coupon = _couponService.GetCouponByCode(code);
                dto = new CouponDto
                {
                    Code = coupon.Code,
                    ValidityDate = coupon.ValidityDate,
                    AvaliableCount = coupon.AvaliableCount,
                    TotalCount = coupon.TotalCount
                };
                return new ResponseOutput(dto, HttpContext.TraceIdentifier);
            }
            else
            {
                return new ResponseOutput(dto,"劵信息获取失败", HttpContext.TraceIdentifier);
            }
        }

        /// <summary>
        /// 4and5 返回大类下的商品信息，包含图片，是否有货，详情等信息
        /// </summary>
        /// <param name="class1"></param>
        /// <param name="class2"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/v{version:apiVersion}/BasicData/Products/{class1}/{class2}")]
        public ResponseOutput GetProductsByCatelog(int class1,int class2)
        {
            var products = _productService.GetProductsByClass(class1, class2);

            var productDtos = new List<ProductDto>();

            foreach (var product in products)
            {
                productDtos.Add(new ProductDto
                {
                    Code = product.ProductCode,
                    Name = product.Name,
                    Description = product.Description,
                    IsInStock = product.IsInStock,
                    Photos = product.Details.Select(item => item.PhotoPath).ToList()
                });
            }

            return new ResponseOutput(productDtos, HttpContext.TraceIdentifier);
        }

        [HttpPost]
        [Route("/api/v{version:apiVersion}/BasicData/NewOrder")]
        public ResponseOutput CreateNewOrder(OrderInputDto inputDto)
        {
            if (inputDto==null)
            {
                return new ResponseOutput(null, "传入参数为空", HttpContext.TraceIdentifier);
            }








            return new ResponseOutput(null, HttpContext.TraceIdentifier);
        }























        }
}
