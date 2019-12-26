﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using BangBangFuli.API.MVCDotnet2.Filter;
using BangBangFuli.API.MVCDotnet2.Models;
using BangBangFuli.Common;
using BangBangFuli.H5.API.Application.Services.BasicDatas;
using BangBangFuli.H5.API.Core;
using BangBangFuli.H5.API.Core.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BangBangFuli.API.MVCDotnet2.Controllers
{
    [UserLoginFilter]
    public class EnterCustomController : Controller
    {
        private UserInfo _userinfo;
        private IUserRoleJurisdictionService _userRoleJurisdictionService;
        private IModuleInfoService _moduleInfoService;
        private readonly IBatchInformationService _batchInformationService;
        private readonly IProductInformationService _productInformationService;
        private readonly IHostingEnvironment _hostingEnvironment;

        private readonly IBannerService _bannerService;
        private readonly IBannerDetailService _bannerDetailService;
        private readonly ICouponService _couponService;
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;

        public EnterCustomController(IUserRoleJurisdictionService userRoleJurisdictionService, IModuleInfoService moduleInfoService , 
            IProductInformationService productInformationService, IBatchInformationService batchInformationService, IHostingEnvironment hostingEnvironment,
            IBannerService bannerService , IBannerDetailService bannerDetailService,ICouponService couponService,
            IOrderService orderService,IOrderDetailService orderDetailService)
        {
            _hostingEnvironment = hostingEnvironment;
            _userRoleJurisdictionService = userRoleJurisdictionService;
            _moduleInfoService = moduleInfoService;
            _productInformationService = productInformationService;
            _batchInformationService = batchInformationService;
            _bannerService = bannerService;
            _bannerDetailService = bannerDetailService;
            _couponService = couponService;
            _orderService = orderService;
            _orderDetailService = orderDetailService;
        }

        /// <summary>
        /// 当前登录的用户
        /// </summary>
        public new UserInfo User
        {
            get
            {
                if (_userinfo == null)
                    _userinfo = JsonSerializerHelper.Deserialize<UserInfo>(HttpContext.Session.GetString("user"));
                return _userinfo;
            }
        }


        /// <summary>
        /// 首页，工作台
        /// </summary>
        /// <returns></returns>
        public IActionResult ConsoleIndex()
        {
            return View();
        }

        #region 商品

        /// <summary>
        /// 商品页面
        /// </summary>
        /// <returns></returns>
        public IActionResult QueryProductList()
        {
            var productViewModelList = new List<ProductInformationViewModel>();
            var products = _productInformationService.GetAll();
            foreach (var product in products)
            {
                BatchInformation batchInfo = _batchInformationService.GetBatchInfoById(product.BatchId);
                productViewModelList.Add(new ProductInformationViewModel
                {
                    ProductId = product.Id,
                    ProductCode = product.ProductCode,
                    ProductName = product.ProductName,
                    StockStatusType = product.StockType,
                    ProductStatusType = product.ProductStatus,
                    ClassType = product.Type,
                    BatchId = product.BatchId,
                    BatchName =batchInfo!=null?batchInfo.Name:string.Empty
                });
            }
            return View(productViewModelList);
        }

        /// <summary>
        /// 新建商品页面
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult AddNewProduct(int id)
        {
            ProductInformation productInfo = new ProductInformation();
            if (id>0)
            {
                productInfo = _productInformationService.GetProductById(id);
            }
            List<BatchInformation> batchInfos = _batchInformationService.GetAll();
            ViewBag.BatchInfos = batchInfos;
            return View(productInfo);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult DelProduct(int id)
        {
            try
            {
                _productInformationService.RemoveProductById(id);
                return Json(new { code = 1, msg = "OK" });
            }
            catch (Exception ex)
            {
               return  Json(new { code = 0, msg = "OK" });
            }
        }


        [HttpPost]
        public IActionResult SaveProduct()
        {
            int id = Request.Form["ID"].TryToInt(0);
            if (id > 0)
            {
                var info = _productInformationService.GetProductById(id);
                info.ProductCode = Request.Form["ProductCode"].TryToString();
                info.ProductName = Request.Form["ProductName"].TryToString();
                info.BatchId = Request.Form["BatchId"].TryToInt(0);
                info.Type = (ClassTypeEnum)Request.Form["ClassType"].TryToInt(0);
                info.ProductStatus = (ProductStatusTypeEnum)Request.Form["ProductStatusType"].TryToInt(0);
                info.StockType = (StockStatusTypeEnum)Request.Form["StockStatusType"].TryToInt(0);
                _productInformationService.UpdateProduct(info);
                return Json(new { code = 1, msg = "OK", id = info.Id });
            }
            else
            {
                ProductInformation productInfo = new ProductInformation();
                productInfo.ProductCode = Request.Form["ProductCode"].TryToString();
                productInfo.ProductName = Request.Form["ProductName"].TryToString();
                productInfo.BatchId = Request.Form["BatchId"].TryToInt(0);
                productInfo.Type = (ClassTypeEnum)Request.Form["ClassType"].TryToInt(0);
                productInfo.ProductStatus = (ProductStatusTypeEnum)Request.Form["ProductStatusType"].TryToInt(0);
                productInfo.StockType = (StockStatusTypeEnum)Request.Form["StockStatusType"].TryToInt(0);
                id = _productInformationService.AddProduct(productInfo);
                if (id > 0)
                {
                    return Json(new { code = 1, msg = "OK", id = id });
                }
                else
                {
                    return Json(new { code = 0, msg = "保存失败" });
                }
            }
        }

        /// <summary>
        /// 商品图片页面
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        public IActionResult AddProductPhotos(int ProductId)
        {
            var productInfo = _productInformationService.GetProductById(ProductId);
            return View(productInfo);
        }

        /// <summary>
        /// 图片关联
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>

        [HttpPost]
        public IActionResult Uploadattachment(int ProductId)
        {
            #region 文件上传
            var imgFile = Request.Form.Files[0];
            if (imgFile != null && !string.IsNullOrEmpty(imgFile.FileName))
            {
                string uniqueFileName = null;
                var filename = ContentDispositionHeaderValue
                     .Parse(imgFile.ContentDisposition)
                     .FileName
                     .Trim('"');
                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + filename;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (FileStream fs = System.IO.File.Create(filePath))
                {
                    imgFile.CopyTo(fs);
                    fs.Flush();
                }

                var productInfo = _productInformationService.GetProductById(ProductId);
                var details = new List<ProductDetail>();
                details.Add(new ProductDetail()
                {
                    ProductInformationId = ProductId,
                    PhotoPath = Path.Combine("img",uniqueFileName)
                });
                productInfo.Details = details;

                _productInformationService.UpdateProduct(productInfo);

                return Json(new { code = 0, msg = "上传成功", data = new { src = $"/images/{filePath}", title = "图片标题" } });
            }
            return Json(new { code = 1, msg = "上传失败", });
            #endregion
        }

        [HttpPost]
        public IActionResult SavePhotos()
        {
            int id = Request.Form["ID"].TryToInt(0);
            return Json(new { code = 1, msg = "OK", id = id });
        }

        /// <summary>
        /// 商品描述页面
        /// </summary>
        /// <returns></returns>
        public IActionResult AddProductDescription(int ProductId)
        {
            var productInfo = _productInformationService.GetProductById(ProductId);
            return View(productInfo);
        }


        /// <summary>
        ///  保存描述内容
        /// </summary>
        /// <returns></returns>

        [HttpPost]
        public  IActionResult SaveProductDescriptionLog(int ProductId)
        {
            var productInfo = _productInformationService.GetProductById(ProductId);
            productInfo.Description = Request.Form["Rem"].TryToString();
            _productInformationService.UpdateProduct(productInfo);
            return Json(new { code = 1, msg = "OK" });
        }



        #endregion


        #region banner

        /// <summary>
        /// banner 列表页面
        /// </summary>
        /// <returns></returns>
        public IActionResult QueryBannerList()
        {
            List<BannerViewModel> bannerViewModels = new List<BannerViewModel>();
            List<Banner> banners = _bannerService.GetAll();
            foreach (var banner in banners)
            {
                bannerViewModels.Add(new BannerViewModel
                {
                    BannerId = banner.Id,
                    BatchId = banner.BatchId,
                    Name = banner.Name,
                    CreateTime = banner.CreateTime
                });
            }
            return View(bannerViewModels);
        }

        /// <summary>
        /// 新建banner视图
        /// </summary>
        /// <returns></returns>
        public IActionResult AddNewBanner(int id)
        {
            Banner bannerInfo = new Banner();
            if (id > 0)
            {
                bannerInfo = _bannerService.GetBannerById(id);
            }
            List<BatchInformation> batchInfos = _batchInformationService.GetAll();
            ViewBag.BatchInfos = batchInfos;
            ViewBag.SelectedBatchInfo = _batchInformationService.GetBatchInfoById(bannerInfo.BatchId);
            return View(bannerInfo);
        }

        [HttpPost]
        public IActionResult SaveBanner()
        {
            int id = Request.Form["ID"].TryToInt(0);
            if (id > 0)
            {
                var info = _bannerService.GetBannerById(id);
                info.Name = Request.Form["Name"].TryToString();
                info.BatchId = Request.Form["BatchId"].TryToInt(0);
                _bannerService.UpdateBanner(info);
                return Json(new { code = 1, msg = "OK", id = info.Id });
            }
            else
            {
                Banner bannerInfo = new Banner();
                bannerInfo.Name = Request.Form["Name"].TryToString();
                bannerInfo.BatchId = Request.Form["BatchId"].TryToInt(0);
                bannerInfo.CreateTime = DateTime.Now;
                id = _bannerService.AddBanner(bannerInfo);
                if (id > 0)
                {
                    return Json(new { code = 1, msg = "OK", id = id });
                }
                else
                {
                    return Json(new { code = 0, msg = "保存失败" });
                }
            }
        }

        /// <summary>
        /// banner 图片上传页面
        /// </summary>
        /// <param name="bannerId"></param>
        /// <returns></returns>
        public IActionResult AddBannerPhotos(int BannerId)
        {
            var bannerInfo = _bannerService.GetBannerById(BannerId);
            return View(bannerInfo);
        }


        [HttpGet]
        public IActionResult DelBanner(int id)
        {
            try
            {
                _bannerService.RemoveBannerById(id);
                return Json(new { code = 1, msg = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { code = 0, msg = "OK" });
            }
        }

        /// <summary>
        /// 上传banner图片
        /// </summary>
        /// <param name="BannerId"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult UploadBannerAttachment(int BannerId)
        {
            #region 文件上传
            var imgFile = Request.Form.Files[0];
            if (imgFile != null && !string.IsNullOrEmpty(imgFile.FileName))
            {
                string uniqueFileName = null;
                var filename = ContentDispositionHeaderValue
                     .Parse(imgFile.ContentDisposition)
                     .FileName
                     .Trim('"');
                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "banners");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + filename;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (FileStream fs = System.IO.File.Create(filePath))
                {
                    imgFile.CopyTo(fs);
                    fs.Flush();
                }

                #region banner 信息

                var bannerInfo = _bannerService.GetBannerById(BannerId);
                var details = new List<BannerDetail>();
                details.Add(new BannerDetail()
                {
                    BannerId = bannerInfo.Id,
                    PhotoPath = Path.Combine("banners",uniqueFileName)
                });
                bannerInfo.BannerDetails = details;
                _bannerService.UpdateBanner(bannerInfo);

                #endregion


                return Json(new { code = 0, msg = "上传成功", data = new { src = $"/images/{filePath}", title = "图片标题" } });
            }
            return Json(new { code = 1, msg = "上传失败", });
            #endregion
        }



        #endregion


        #region 提货券管理

        /// <summary>
        /// 券列表页
        /// </summary>
        /// <returns></returns>
        public IActionResult QueryCouponList()
        {
            var couponViewModelList = new List<CouponViewModel>();
            var coupons = _couponService.GetAll();
            foreach (var item in coupons)
            {
                couponViewModelList.Add(new CouponViewModel
                {
                    Code = item.Code,
                    Password = item.Password,
                    ValidityDate = item.ValidityDate,
                    AvaliableCount = item.AvaliableCount,
                    TotalCount = item.TotalCount
                });
            }

            return View(couponViewModelList);
        }

        /// <summary>
        /// 券新增页
        /// </summary>
        /// <returns></returns>
        public IActionResult AddNewCoupon()
        {
            return View();
        }

        public IActionResult CheckResult()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCouponSave(CouponViewModel model)
        {
            if (ModelState.IsValid)
            {
                var checkRet = _couponService.CheckIfCouponAlreadyExist(model.Code);
                if (checkRet)
                {
                    return RedirectToAction(nameof(CheckResult));
                }
                Coupon coupon = new Coupon
                {
                    Code = model.Code,
                    Password = model.Password,
                    ValidityDate = model.ValidityDate,
                    AvaliableCount = model.AvaliableCount,
                    TotalCount = model.TotalCount
                };
                _couponService.AddNew(coupon);

                return RedirectToAction(nameof(QueryCouponList));
            }
            return View(model);
        }

        #endregion

        #region 订单

        /// <summary>
        /// 订单页面
        /// </summary>
        /// <returns></returns>
        public IActionResult QueryOrderList()
        {
            List<OrderViewModel> orderViewModels = new List<OrderViewModel>();
            var orders = _orderService.GetAll();
            foreach (var order in orders)
            {
                orderViewModels.Add(new OrderViewModel
                {
                    OrderId = order.Id,
                    OrderCode = order.OrderCode,
                    CouponCode = order.CouponCode,
                    Contactor = order.Contactor,
                    MobilePhone = order.MobilePhone,
                    Address = order.Address,
                    ZipCode = order.ZipCode,
                    Telephone = order.Telephone
                });
            }

            return View(orderViewModels);
        }




        #endregion

        #region 批次

        /// <summary>
        /// 批次列表页
        /// </summary>
        /// <returns></returns>
        public IActionResult QueryBatchList()
        {
            List<BatchViewModel> batchViewModels = new List<BatchViewModel>();
            List<BatchInformation> batchInfos = _batchInformationService.GetAll();
            foreach (var batch in batchInfos)
            {
                batchViewModels.Add(new BatchViewModel
                {
                    Id = batch.Id,
                    BatchId = batch.Id,
                    Name = batch.Name,
                    CreateTime = batch.CreateTime
                });
            }
            return View(batchViewModels);
        }

        /// <summary>
        /// 新增界面
        /// </summary>
        /// <returns></returns>
        public IActionResult AddNewBatch()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBatchSave(BatchViewModel model)
        {
            if (ModelState.IsValid)
            {
                BatchInformation batchInfo = new BatchInformation
                {
                    Id = model.BatchId,
                    Name = model.Name,
                    CreateTime = DateTime.Now,
                };
                _batchInformationService.CreateNew(batchInfo);

                return RedirectToAction(nameof(QueryBatchList));
            }
            return View();
        }



        #endregion


        #region 供应商

        /// <summary>
        /// 供应商列表页
        /// </summary>
        /// <returns></returns>
        public IActionResult QuerySupplierList()
        {
            return View();
        }


        #endregion



        #region 基类

        public override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            return base.OnActionExecutionAsync(context, next);
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.HttpContext.Session.Keys.Contains("user"))
            {
                context.Result = new RedirectResult("/Account/Index");
                return;
            }
            base.OnActionExecuting(context);
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            ViewData["user"] = User;
            List<UserRoleJurisdiction> userrolejurlist = _userRoleJurisdictionService.GetListAsync(User.RoleID);
            ViewData["userrolejurlist"] = userrolejurlist;
            List<ModuleInfo> modulelist = _moduleInfoService.GetList();
            ViewData["modulelist"] = modulelist;
            base.OnActionExecuted(context);
        }

        #endregion


        #region 分类枚举
        private void PopulateClassDropDownList(object selectedClass = null)
        {
            var productTypes = new List<object>();
            productTypes.Add(new { id = 0, name = "悦享生活" });
            productTypes.Add(new { id = 1, name = "居家好物" });
            productTypes.Add(new { id = 2, name = "品质生活" });
            productTypes.Add(new { id = 3, name = "厨房甄选" });
            ViewBag.Catelogs = new SelectList(productTypes, "id", "name", selectedClass);
        }


        private void PopulateProductStatusDropDownList(object selectedProductStatus = null)
        {
            var productStatusTypes = new List<object>();
            productStatusTypes.Add(new { id = 0, name = "下架" });
            productStatusTypes.Add(new { id = 1, name = "上架" });
            ViewBag.ProductStatusTypes = new SelectList(productStatusTypes, "id", "name", selectedProductStatus);
        }

        private void PopulateStockStatusDropDownList(object selectedStockStatus = null)
        {
            var stockStatusTypes = new List<object>();
            stockStatusTypes.Add(new { id = 0, name = "无货" });
            stockStatusTypes.Add(new { id = 1, name = "有货" });
            ViewBag.StockStatusTypes = new SelectList(stockStatusTypes, "id", "name", selectedStockStatus);
        }

        private void PopulateBatchDropDownList(object selectedBatch = null)
        {
            var batchs = new List<object>();
            List<BatchInformation> batchInfos = _batchInformationService.GetAll();
            ViewBag.BatchInfos = batchInfos;
        }


        public string GetClassTypeDisplayName(int index)
        {
            var ret = string.Empty;
            switch (index)
            {
                case 0:
                    ret = "悦享生活";
                    break;
                case 1:
                    ret = "居家好物";
                    break;
                case 2:
                    ret = "品质生活";
                    break;
                case 3:
                    ret = "厨房甄选";
                    break;
            }
            return ret;
        }

        public string GetProductStatusDisplayName(int index)
        {
            var ret = string.Empty;
            switch (index)
            {
                case 0:
                    ret = "下架";
                    break;
                case 1:
                    ret = "上架";
                    break;
            }
            return ret;
        }

        public string GetStockStatusDisplayName(int index)
        {
            var ret = string.Empty;
            switch (index)
            {
                case 0:
                    ret = "无货";
                    break;
                case 1:
                    ret = "有货";
                    break;
            }
            return ret;
        }

        #endregion
    }
}