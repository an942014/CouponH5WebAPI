#pragma checksum "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryBannerList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fded406a010b1497acbb195d032cb8b3f592788f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EnterCustom_QueryBannerList), @"mvc.1.0.view", @"/Views/EnterCustom/QueryBannerList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EnterCustom/QueryBannerList.cshtml", typeof(AspNetCore.Views_EnterCustom_QueryBannerList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fded406a010b1497acbb195d032cb8b3f592788f", @"/Views/EnterCustom/QueryBannerList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"869bc3105167e9dd4b3ce0ee5ffc553ce1a63b36", @"/Views/_ViewImports.cshtml")]
    public class Views_EnterCustom_QueryBannerList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BangBangFuli.API.MVCDotnet2.Models.BannerViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryBannerList.cshtml"
  
    ViewData["Title"] = "Banner管理";
    Layout = "~/BasePages/_Layout.cshtml";

#line default
#line hidden
            BeginContext(160, 925, true);
            WriteLiteral(@"<blockquote class=""layui-elem-quote"">
    <a class=""layui-btn layui-btn-normal"" href=""/EnterCustom/AddNewBanner"">添加Banner</a>
</blockquote>
<fieldset class=""layui-elem-field layui-field-title"" style=""margin-top: 20px;"">
    <legend>Banner信息综合查询</legend>
</fieldset>
<div class=""layui-fluid"">
    <div class=""layui-row"" id=""content_table"">
        <table class=""layui-table"" lay-filter=""test"">
            <thead>
                <tr>
                    <th>
                        ID(序号)
                    </th>
                    <th>
                        批次号
                    </th>
                    <th>
                        批次名称
                    </th>
                    <th>
                        创建时间
                    </th>
                    <th>
                        操作
                    </th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 35 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryBannerList.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1150, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1235, 43, false);
#line 39 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryBannerList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.BannerId));

#line default
#line hidden
            EndContext();
            BeginContext(1278, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1370, 42, false);
#line 42 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryBannerList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.BatchId));

#line default
#line hidden
            EndContext();
            BeginContext(1412, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1504, 39, false);
#line 45 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryBannerList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1543, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1635, 45, false);
#line 48 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryBannerList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.CreateTime));

#line default
#line hidden
            EndContext();
            BeginContext(1680, 93, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1773, "\"", 1825, 2);
            WriteAttributeValue("", 1780, "/EnterCustom/AddNewBanner?id=", 1780, 29, true);
#line 51 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryBannerList.cshtml"
WriteAttributeValue("", 1809, item.BannerId, 1809, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1826, 144, true);
            WriteLiteral(" class=\"layui-btn layui-btn-small\">编辑</a>\r\n                            <a href=\"javascript:;\" class=\"layui-btn layui-btn-danger layui-btn-small\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1970, "\"", 2003, 3);
            WriteAttributeValue("", 1980, "del(\'", 1980, 5, true);
#line 52 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryBannerList.cshtml"
WriteAttributeValue("", 1985, item.BannerId, 1985, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 2001, "\')", 2001, 2, true);
            EndWriteAttribute();
            BeginContext(2004, 67, true);
            WriteLiteral(">删除</a>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 55 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\QueryBannerList.cshtml"
                }

#line default
#line hidden
            BeginContext(2090, 93, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n        <div id=\"page\"></div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2200, 856, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        var layer, form
        layui.use(['form', 'element', 'layer', 'laypage', 'upload', 'table'], function () {
            form = layui.form
            layer = layui.layer
            del = function (id) {
                layer.confirm('是否删除？', { icon: 3, title: '删除提示' }, function (index) {
                    $.get('/EnterCustom/DelBanner?id=' + id, function (res) {
                        if (res.code == 1) {
                            layer.msg('成功', { icon: 6 });
                            window.location = '/EnterCustom/QueryBannerList'
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BangBangFuli.API.MVCDotnet2.Models.BannerViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
