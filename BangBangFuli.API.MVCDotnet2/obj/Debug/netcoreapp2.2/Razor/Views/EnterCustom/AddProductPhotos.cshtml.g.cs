#pragma checksum "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\AddProductPhotos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30251d26dadf5d29dc68b59f2d37964c82aa473a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EnterCustom_AddProductPhotos), @"mvc.1.0.view", @"/Views/EnterCustom/AddProductPhotos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EnterCustom/AddProductPhotos.cshtml", typeof(AspNetCore.Views_EnterCustom_AddProductPhotos))]
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
#line 1 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\AddProductPhotos.cshtml"
using BangBangFuli.H5.API.Core.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30251d26dadf5d29dc68b59f2d37964c82aa473a", @"/Views/EnterCustom/AddProductPhotos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"869bc3105167e9dd4b3ce0ee5ffc553ce1a63b36", @"/Views/_ViewImports.cshtml")]
    public class Views_EnterCustom_AddProductPhotos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductInformation>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/layui/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/layui/jquery.form.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\AddProductPhotos.cshtml"
  
    ViewData["Title"] = "添加商品图片";
    Layout = "~/BasePages/_Layout.cshtml";

#line default
#line hidden
            BeginContext(155, 878, true);
            WriteLiteral(@"<blockquote class=""layui-elem-quote"">
    添加商品图片信息
</blockquote>
<div class=""manage-form-container"">
    <div class=""layui-upload"">
        <button type=""button"" class=""layui-btn layui-btn-normal"" id=""testList"">选择多文件</button>
        <div class=""layui-upload-list"">
            <table class=""layui-table"">
                <thead>
                    <tr>
                        <th>文件名</th>
                        <th>大小</th>
                        <th>状态</th>
                        <th>操作</th>
                    </tr>
                </thead>
                <tbody id=""demoList""></tbody>
            </table>
        </div>
        <button type=""button"" class=""layui-btn"" id=""testListAction"">开始上传</button>
    </div>
</div>

<form class=""layui-form"" method=""post"" id=""addform"" action=""/EnterCustom/SavePhotos"">
    <input type=""hidden"" name=""ID""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1033, "\"", 1068, 1);
#line 31 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\AddProductPhotos.cshtml"
WriteAttributeValue("", 1041, Model!=null ? Model.Id:0, 1041, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1069, 226, true);
            WriteLiteral(" id=\"ID\" />\r\n    <div class=\"layui-form-item\">\r\n        <div class=\"layui-input-block\">\r\n            <button type=\"submit\" class=\"layui-btn\" lay-submit=\"\" lay-filter=\"demo1\">保存</button>\r\n        </div>\r\n    </div>\r\n</form>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1312, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1318, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30251d26dadf5d29dc68b59f2d37964c82aa473a6254", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1368, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1374, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30251d26dadf5d29dc68b59f2d37964c82aa473a7509", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1420, 1103, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
         layui.use(['form', 'element', 'layer'], function () {
            var layer = layui.layer
            var form = layui.form
         })

        $('#addform').validate({
            ignore:"""",
            submitHandler: function (form) {
                layer.load(0, { shade: false })
                $(form).ajaxSubmit(function (res) {
                    if (res.code == 1) {
                        layer.msg('保存成功', { icon: 6 });
                        window.location = '/EnterCustom/AddProductDescription?ProductId=' + res.id
                    } else {
                        layer.msg('保存失败', { icon: 5 });
                    }
                })
            }
        })


        layui.use('upload', function () {
            var $ = layui.jquery
                , upload = layui.upload;
            //多文件列表示例
            var demoListView = $('#demoList')
                , uploadListIns = upload.render({
                    elem: '#");
                WriteLiteral("testList\'\r\n                    , url: \'/EnterCustom/Uploadattachment?ProductId=");
                EndContext();
                BeginContext(2524, 8, false);
#line 71 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\EnterCustom\AddProductPhotos.cshtml"
                                                               Write(Model.Id);

#line default
#line hidden
                EndContext();
                BeginContext(2532, 2742, true);
                WriteLiteral(@"'
                    , accept: 'file'
                    , multiple: true
                    , auto: false
                    , bindAction: '#testListAction'
                    , choose: function (obj) {
                        var files = this.files = obj.pushFile(); //将每次选择的文件追加到文件队列
                        //读取本地文件
                        obj.preview(function (index, file, result) {
                            var tr = $(['<tr id=""upload-' + index + '"">'
                                , '<td>' + file.name + '</td>'
                                , '<td>' + (file.size / 1014).toFixed(1) + 'kb</td>'
                                , '<td>等待上传</td>'
                                , '<td>'
                                , '<button class=""layui-btn layui-btn-xs demo-reload layui-hide"">重传</button>'
                                , '<button class=""layui-btn layui-btn-xs layui-btn-danger demo-delete"">删除</button>'
                                , '</td>'
                                ,");
                WriteLiteral(@" '</tr>'].join(''));

                            //单个重传
                            tr.find('.demo-reload').on('click', function () {
                                obj.upload(index, file);
                            });

                            //删除
                            tr.find('.demo-delete').on('click', function () {
                                delete files[index]; //删除对应的文件
                                tr.remove();
                                uploadListIns.config.elem.next()[0].value = ''; //清空 input file 值，以免删除后出现同名文件不可选
                            });

                            demoListView.append(tr);
                        });
                    }
                    , done: function (res, index, upload) {
                        if (res.code == 0) { //上传成功
                            var tr = demoListView.find('tr#upload-' + index)
                                , tds = tr.children();
                            tds.eq(2).html('<span style=""color: #5");
                WriteLiteral(@"FB878;"">上传成功</span>');
                            tds.eq(3).html(''); //清空操作
                            return delete this.files[index]; //删除文件队列已经上传成功的文件
                        }
                        this.error(index, upload);
                    }
                    , error: function (index, upload) {
                        var tr = demoListView.find('tr#upload-' + index)
                            , tds = tr.children();
                        tds.eq(2).html('<span style=""color: #FF5722;"">上传失败</span>');
                        tds.eq(3).find('.demo-reload').removeClass('layui-hide'); //显示重传
                    }
                });
        })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductInformation> Html { get; private set; }
    }
}
#pragma warning restore 1591
