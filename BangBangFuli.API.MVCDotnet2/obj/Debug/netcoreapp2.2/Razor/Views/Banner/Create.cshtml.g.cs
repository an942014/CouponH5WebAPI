#pragma checksum "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\Banner\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a84607582087d9661e9403eb4f380b53a375ee60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Banner_Create), @"mvc.1.0.view", @"/Views/Banner/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Banner/Create.cshtml", typeof(AspNetCore.Views_Banner_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a84607582087d9661e9403eb4f380b53a375ee60", @"/Views/Banner/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"869bc3105167e9dd4b3ce0ee5ffc553ce1a63b36", @"/Views/_ViewImports.cshtml")]
    public class Views_Banner_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BannerViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\Banner\Create.cshtml"
  
    ViewBag.Title = "创建Banner信息";

#line default
#line hidden
            BeginContext(66, 1372, true);
            WriteLiteral(@"<h4>Banner信息</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""CreateSave"" enctype=""multipart/form-data"" asp-controller=""Banner"" method=""post"" class=""mt-3"">
            <div asp-validation-summary=""All"" class=""text-danger""></div>

            <div class=""form-group"">
                <label asp-for=""BatchId"" class=""control-label""></label>
                <select asp-for=""BatchId"" class=""form-control"" asp-items=""ViewBag.BatchIds"">
                    <option value="""">-- 选择批次号 --</option>
                </select>
                <span asp-validation-for=""BatchId"" class=""text-danger""></span>
            </div>

            <div class=""form-group row"">
                <label asp-for=""Photos"" class=""col-sm-2 col-form-label""></label>
                <div class=""col-sm-10"">
                    <div class=""custom-file"">
                        <input asp-for=""Photos"" multiple class=""form-control custom-file-input"">
                        <label class=""custom-file-");
            WriteLiteral(@"label"">请选择照片....</label>
                    </div>
                </div>
            </div>

            <div class=""form-group"">
                <input type=""submit"" value=""添加"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>
<div>
    <a asp-action=""Index"" class=""btn btn-default"">返回列表</a>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1455, 558, true);
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(document).ready(function () {

            $('.custom-file-input').on(""change"", function () {

                console.log($(this));
                var fileLabel = $(this).next("".custom-file-label"");

                var files = $(this)[0].files;

                if (files.length > 1) {

                    fileLabel.html(""您已经选择了"" + files.length + ""个文件"");
                } else {
                    fileLabel.html(files[0].name);
                }
            });
        });</script>
");
                EndContext();
            }
            );
            BeginContext(2016, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BannerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
