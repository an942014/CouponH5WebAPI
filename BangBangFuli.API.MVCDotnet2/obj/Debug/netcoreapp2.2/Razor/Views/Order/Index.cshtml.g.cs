#pragma checksum "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6a8e390f3c7a1666598a8aed59cb4cfba43cac1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Index.cshtml", typeof(AspNetCore.Views_Order_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\_ViewImports.cshtml"
using BangBangFuli.API.MVCDotnet2;

#line default
#line hidden
#line 2 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\_ViewImports.cshtml"
using BangBangFuli.API.MVCDotnet2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6a8e390f3c7a1666598a8aed59cb4cfba43cac1", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"869bc3105167e9dd4b3ce0ee5ffc553ce1a63b36", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\Order\Index.cshtml"
  
    ViewData["Title"] = "订单信息";

#line default
#line hidden
            BeginContext(69, 533, true);
            WriteLiteral(@"<h2>订单信息</h2>
<table class=""table"">
    <thead>
        <tr>
            <th>
                订单号
            </th>
            <th>
                券码
            </th>
            <th>
                联系人
            </th>
            <th>
                手机号码
            </th>
            <th>
                地址
            </th>
            <th>
                邮编
            </th>
            <th>
                座机
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 34 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\Order\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(651, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(700, 44, false);
#line 38 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\Order\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderCode));

#line default
#line hidden
            EndContext();
            BeginContext(744, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(800, 45, false);
#line 41 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\Order\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CouponCode));

#line default
#line hidden
            EndContext();
            BeginContext(845, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(901, 44, false);
#line 44 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\Order\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Contactor));

#line default
#line hidden
            EndContext();
            BeginContext(945, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1001, 46, false);
#line 47 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\Order\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MobilePhone));

#line default
#line hidden
            EndContext();
            BeginContext(1047, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1103, 42, false);
#line 50 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\Order\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1145, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1201, 42, false);
#line 53 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\Order\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ZipCode));

#line default
#line hidden
            EndContext();
            BeginContext(1243, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1299, 44, false);
#line 56 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\Order\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Telephone));

#line default
#line hidden
            EndContext();
            BeginContext(1343, 78, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Details\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1421, "\"", 1449, 1);
#line 59 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\Order\Index.cshtml"
WriteAttributeValue("", 1436, item.OrderId, 1436, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1450, 77, true);
            WriteLiteral(" class=\"btn btn-primary m-1\">详情</a> |\r\n                <a asp-action=\"Delete\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1527, "\"", 1555, 1);
#line 60 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\Order\Index.cshtml"
WriteAttributeValue("", 1542, item.OrderId, 1542, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1556, 71, true);
            WriteLiteral(" class=\"btn btn-primary m-1\">删除</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 63 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\Order\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1638, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
