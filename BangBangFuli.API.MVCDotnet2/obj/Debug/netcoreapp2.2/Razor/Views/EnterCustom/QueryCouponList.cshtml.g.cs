#pragma checksum "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryCouponList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d62e777153319a225d7ba75954b222602482556a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EnterCustom_QueryCouponList), @"mvc.1.0.view", @"/Views/EnterCustom/QueryCouponList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EnterCustom/QueryCouponList.cshtml", typeof(AspNetCore.Views_EnterCustom_QueryCouponList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d62e777153319a225d7ba75954b222602482556a", @"/Views/EnterCustom/QueryCouponList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"869bc3105167e9dd4b3ce0ee5ffc553ce1a63b36", @"/Views/_ViewImports.cshtml")]
    public class Views_EnterCustom_QueryCouponList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CouponViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryCouponList.cshtml"
  
    ViewData["Title"] = "券管理";
    Layout = "~/BasePages/_Layout.cshtml";

#line default
#line hidden
            BeginContext(113, 941, true);
            WriteLiteral(@"<blockquote class=""layui-elem-quote"">
    <a class=""layui-btn layui-btn-normal"" href=""/EnterCustom/AddNewCoupon"">添加券</a>
</blockquote>
<fieldset class=""layui-elem-field layui-field-title"" style=""margin-top: 20px;"">
    <legend>券信息综合查询</legend>
</fieldset>
<div class=""layui-fluid"">
    <div class=""layui-row"" id=""content_table"">
        <table class=""layui-table"" lay-filter=""test"">
            <thead>
                <tr>
                    <th>
                        券码
                    </th>
                    <th>
                        密码
                    </th>
                    <th>
                        有效期
                    </th>
                    <th>
                        可用次数
                    </th>
                    <th>
                        总次数
                    </th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 36 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryCouponList.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1119, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1204, 39, false);
#line 40 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryCouponList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Code));

#line default
#line hidden
            EndContext();
            BeginContext(1243, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1335, 43, false);
#line 43 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryCouponList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
            EndContext();
            BeginContext(1378, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1470, 47, false);
#line 46 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryCouponList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ValidityDate));

#line default
#line hidden
            EndContext();
            BeginContext(1517, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1609, 49, false);
#line 49 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryCouponList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AvaliableCount));

#line default
#line hidden
            EndContext();
            BeginContext(1658, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1750, 45, false);
#line 52 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryCouponList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TotalCount));

#line default
#line hidden
            EndContext();
            BeginContext(1795, 93, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1888, "\"", 1934, 2);
            WriteAttributeValue("", 1895, "/EnterCustom/AddNewCoupon?id=", 1895, 29, true);
#line 55 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryCouponList.cshtml"
WriteAttributeValue("", 1924, item.Id, 1924, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1935, 144, true);
            WriteLiteral(" class=\"layui-btn layui-btn-small\">编辑</a>\r\n                            <a href=\"javascript:;\" class=\"layui-btn layui-btn-danger layui-btn-small\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2079, "\"", 2106, 3);
            WriteAttributeValue("", 2089, "del(\'", 2089, 5, true);
#line 56 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryCouponList.cshtml"
WriteAttributeValue("", 2094, item.Id, 2094, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 2104, "\')", 2104, 2, true);
            EndWriteAttribute();
            BeginContext(2107, 67, true);
            WriteLiteral(">删除</a>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 59 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryCouponList.cshtml"
                }

#line default
#line hidden
            BeginContext(2193, 93, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n        <div id=\"page\"></div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2303, 856, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        var layer, form
        layui.use(['form', 'element', 'layer', 'laypage', 'upload', 'table'], function () {
            form = layui.form
            layer = layui.layer
            del = function (id) {
                layer.confirm('是否删除？', { icon: 3, title: '删除提示' }, function (index) {
                    $.get('/EnterCustom/DelCoupon?id=' + id, function (res) {
                        if (res.code == 1) {
                            layer.msg('成功', { icon: 6 });
                            window.location = '/EnterCustom/QueryCouponList'
                        } else {
                            layer.msg('失败', { icon: 5 });
                        }
                    })
                    layer.close(index);
                });
            }

        });
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CouponViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
