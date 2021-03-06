#pragma checksum "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryProductList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08e4e670f887b9a2021677fd2439b3f805ae0cd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EnterCustom_QueryProductList), @"mvc.1.0.view", @"/Views/EnterCustom/QueryProductList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EnterCustom/QueryProductList.cshtml", typeof(AspNetCore.Views_EnterCustom_QueryProductList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08e4e670f887b9a2021677fd2439b3f805ae0cd2", @"/Views/EnterCustom/QueryProductList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"869bc3105167e9dd4b3ce0ee5ffc553ce1a63b36", @"/Views/_ViewImports.cshtml")]
    public class Views_EnterCustom_QueryProductList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BangBangFuli.API.MVCDotnet2.Models.ProductInformationViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryProductList.cshtml"
  
    ViewData["Title"] = "商品管理";
    Layout = "~/BasePages/_Layout.cshtml";

#line default
#line hidden
            BeginContext(168, 1249, true);
            WriteLiteral(@"<blockquote class=""layui-elem-quote"">
    <a class=""layui-btn layui-btn-normal"" href=""/EnterCustom/AddNewProduct"">添加商品</a>
</blockquote>
<fieldset class=""layui-elem-field layui-field-title"" style=""margin-top: 20px;"">
    <legend>商品信息综合查询</legend>
</fieldset>
<div class=""layui-fluid"">
    <div class=""layui-row"" id=""content_table"">
        <table class=""layui-table"" lay-filter=""test"">
            <thead>
                <tr>
                    <th>
                        商品ID(序号)
                    </th>
                    <th>
                        商品编码
                    </th>
                    <th>
                        商品名称
                    </th>
                    <th>
                        是否有库存
                    </th>
                    <th>
                        状态
                    </th>
                    <th>
                        分类
                    </th>
                    <th>
                        批次号
                    </th>
     ");
            WriteLiteral("               <th>\r\n                        批次名称\r\n                    </th>\r\n                    <th>\r\n                        操作\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 47 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryProductList.cshtml"
                 if (Model != null && Model.Count() > 0)
                {
                    foreach (var product in Model)
                    {

#line default
#line hidden
            BeginContext(1569, 127, true);
            WriteLiteral("                        <tr class=\"laytable-cell-1-picurl\">\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1697, 47, false);
#line 53 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryProductList.cshtml"
                           Write(Html.DisplayFor(modelItem => product.ProductId));

#line default
#line hidden
            EndContext();
            BeginContext(1744, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1848, 49, false);
#line 56 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryProductList.cshtml"
                           Write(Html.DisplayFor(modelItem => product.ProductCode));

#line default
#line hidden
            EndContext();
            BeginContext(1897, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2001, 49, false);
#line 59 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryProductList.cshtml"
                           Write(Html.DisplayFor(modelItem => product.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(2050, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2154, 53, false);
#line 62 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryProductList.cshtml"
                           Write(Html.DisplayFor(modelItem => product.StockStatusName));

#line default
#line hidden
            EndContext();
            BeginContext(2207, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2311, 55, false);
#line 65 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryProductList.cshtml"
                           Write(Html.DisplayFor(modelItem => product.ProductStatusName));

#line default
#line hidden
            EndContext();
            BeginContext(2366, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2470, 51, false);
#line 68 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryProductList.cshtml"
                           Write(Html.DisplayFor(modelItem => product.ClassTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(2521, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2625, 45, false);
#line 71 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryProductList.cshtml"
                           Write(Html.DisplayFor(modelItem => product.BatchId));

#line default
#line hidden
            EndContext();
            BeginContext(2670, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2774, 47, false);
#line 74 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryProductList.cshtml"
                           Write(Html.DisplayFor(modelItem => product.BatchName));

#line default
#line hidden
            EndContext();
            BeginContext(2821, 105, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2926, "\"", 2983, 2);
            WriteAttributeValue("", 2933, "/EnterCustom/AddNewProduct?id=", 2933, 30, true);
#line 77 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryProductList.cshtml"
WriteAttributeValue("", 2963, product.ProductId, 2963, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2984, 148, true);
            WriteLiteral(" class=\"layui-btn layui-btn-small\">编辑</a>\r\n                                <a href=\"javascript:;\" class=\"layui-btn layui-btn-danger layui-btn-small\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3132, "\"", 3169, 3);
            WriteAttributeValue("", 3142, "del(\'", 3142, 5, true);
#line 78 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryProductList.cshtml"
WriteAttributeValue("", 3147, product.ProductId, 3147, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 3167, "\')", 3167, 2, true);
            EndWriteAttribute();
            BeginContext(3170, 75, true);
            WriteLiteral(">删除</a>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 81 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryProductList.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(3287, 93, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n        <div id=\"page\"></div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3397, 858, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        var layer, form
        layui.use(['form', 'element', 'layer', 'laypage', 'upload', 'table'], function () {
            form = layui.form
            layer = layui.layer
            del = function (id) {
                layer.confirm('是否删除？', { icon: 3, title: '删除提示' }, function (index) {
                    $.get('/EnterCustom/DelProduct?id=' + id, function (res) {
                        if (res.code == 1) {
                            layer.msg('成功', { icon: 6 });
                            window.location = '/EnterCustom/QueryProductList'
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
            BeginContext(4258, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BangBangFuli.API.MVCDotnet2.Models.ProductInformationViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
