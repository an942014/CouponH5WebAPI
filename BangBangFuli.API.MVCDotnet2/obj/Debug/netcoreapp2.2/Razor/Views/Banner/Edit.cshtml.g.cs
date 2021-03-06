#pragma checksum "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\Banner\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b94871892c645f1afe160150e96ec7fa9ec8d209"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Banner_Edit), @"mvc.1.0.view", @"/Views/Banner/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Banner/Edit.cshtml", typeof(AspNetCore.Views_Banner_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b94871892c645f1afe160150e96ec7fa9ec8d209", @"/Views/Banner/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"869bc3105167e9dd4b3ce0ee5ffc553ce1a63b36", @"/Views/_ViewImports.cshtml")]
    public class Views_Banner_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BannerViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\Banner\Edit.cshtml"
  
    ViewBag.Title = "编辑Banner信息";

#line default
#line hidden
            BeginContext(66, 577, true);
            WriteLiteral(@"<h4>Banner信息</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""editsave"" enctype=""multipart/form-data"" asp-controller=""Banner"" method=""post"" class=""mt-3"">
            <div asp-validation-summary=""All"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""BannerId"" />

            <div class=""form-group row"">
                <label asp-for=""BatchId"" class=""col-sm-2 col-form-label""></label>
                <div class=""col-sm-10"">
                    <input asp-for=""BatchId"" class=""form-control"" placeholder=""请输入批次号""");
            EndContext();
            BeginWriteAttribute("value", " value=", 643, "", 664, 1);
#line 16 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\Banner\Edit.cshtml"
WriteAttributeValue("", 650, Model.BatchId, 650, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(664, 382, true);
            WriteLiteral(@" />
                    <span asp-validation-for=""BatchId"" class=""text-danger""></span>
                </div>
            </div>

            <div class=""form-group row"">
                <label asp-for=""Name"" class=""col-sm-2 col-form-label""></label>
                <div class=""col-sm-10"">
                    <input asp-for=""Name"" class=""form-control"" placeholder=""请输入批次名称""");
            EndContext();
            BeginWriteAttribute("value", " value=", 1046, "", 1064, 1);
#line 24 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\Banner\Edit.cshtml"
WriteAttributeValue("", 1053, Model.Name, 1053, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1064, 840, true);
            WriteLiteral(@" />
                    <span asp-validation-for=""Name"" class=""text-danger""></span>
                </div>
            </div>

            <div class=""form-group row"">
                <label asp-for=""Photos"" class=""col-sm-2 col-form-label""></label>
                <div class=""col-sm-10"">
                    <div class=""custom-file"">
                        <input asp-for=""Photos"" multiple class=""form-control custom-file-input"">
                        <label class=""custom-file-label"">请选择照片....</label>
                    </div>
                </div>
            </div>

            <div class=""form-group"">
                <input type=""submit"" value=""更新"" class=""btn btn-primary"" />
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
                BeginContext(1921, 558, true);
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
            BeginContext(2482, 2, true);
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
