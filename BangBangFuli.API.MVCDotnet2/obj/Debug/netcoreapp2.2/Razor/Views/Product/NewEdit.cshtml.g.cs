#pragma checksum "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\Product\NewEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56e5cd1196f4d0d6c7e67b4a1cb613b3538a2e56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_NewEdit), @"mvc.1.0.view", @"/Views/Product/NewEdit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/NewEdit.cshtml", typeof(AspNetCore.Views_Product_NewEdit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56e5cd1196f4d0d6c7e67b4a1cb613b3538a2e56", @"/Views/Product/NewEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"869bc3105167e9dd4b3ce0ee5ffc553ce1a63b36", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_NewEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 272, true);
            WriteLiteral(@"<div class=""editor-area"">
    <div>
        <h2>商品描述(富文本)</h2>
        <script id=""editor"" type=""text/plain"" style=""height:500px;"">
        </script>
    </div>
    <div id=""btns"">
        <div>

            <button onclick=""getContent()"">添加商品描述内容(富文本)</button>
");
            EndContext();
            BeginContext(844, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
            BeginContext(1563, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(1718, 1217, true);
            WriteLiteral(@"</div>
<div>
    <a asp-action=""Index"" class=""btn btn-default"">返回列表</a>
</div>
<script type=""text/javascript"">//实例化编辑器
    //建议使用工厂方法getEditor创建和引用编辑器实例，如果在某个闭包下引用该编辑器，直接调用UE.getEditor('editor')就能拿到相关的实例
    var ue = UE.getEditor('editor');


    function isFocus(e){
        alert(UE.getEditor('editor').isFocus());
        UE.dom.domUtils.preventDefault(e)
    }
    function setblur(e){
        UE.getEditor('editor').blur();
        UE.dom.domUtils.preventDefault(e)
    }
    function insertHtml() {
        var value = prompt('插入html代码', '');
        UE.getEditor('editor').execCommand('insertHtml', value)
    }
    function createEditor() {
        enableBtn();
        UE.getEditor('editor');
    }
    function getAllHtml() {
        alert(UE.getEditor('editor').getAllHtml())
    }
    function getContent() {
        //var arr = [];
        //arr.push(""使用editor.getContent()方法可以获得编辑器的内容"");
        //arr.push(""内容为："");
        //arr.push(UE.getEditor('editor').getContent());
    ");
            WriteLiteral("    //alert(arr.join(\"\\n\"));\r\n\r\n        var arr = [];\r\n        arr.push(UE.getEditor(\'editor\').getContent());\r\n        $.post(\"../Product/SaveProductDescription\", { description: arr ,productId:");
            EndContext();
            BeginContext(2936, 17, false);
#line 79 "E:\BangbangFuli\source2\BangBangFuli.API.MVCDotnet2\Views\Product\NewEdit.cshtml"
                                                                             Write(ViewBag.productId);

#line default
#line hidden
            EndContext();
            BeginContext(2953, 2656, true);
            WriteLiteral(@" }, function (result) {
        });
    }
    function getPlainTxt() {
        var arr = [];
        arr.push(""使用editor.getPlainTxt()方法可以获得编辑器的带格式的纯文本内容"");
        arr.push(""内容为："");
        arr.push(UE.getEditor('editor').getPlainTxt());
        alert(arr.join('\n'))
    }
    function setContent(isAppendTo) {
        var arr = [];
        arr.push(""使用editor.setContent('欢迎使用ueditor')方法可以设置编辑器的内容"");
        UE.getEditor('editor').setContent('欢迎使用ueditor', isAppendTo);
        alert(arr.join(""\n""));
    }
    function setDisabled() {
        UE.getEditor('editor').setDisabled('fullscreen');
        disableBtn(""enable"");
    }

    function setEnabled() {
        UE.getEditor('editor').setEnabled();
        enableBtn();
    }

    function getText() {
        //当你点击按钮时编辑区域已经失去了焦点，如果直接用getText将不会得到内容，所以要在选回来，然后取得内容
        var range = UE.getEditor('editor').selection.getRange();
        range.select();
        var txt = UE.getEditor('editor').selection.getText();
        alert(txt)");
            WriteLiteral(@"
    }

    function getContentTxt() {
        var arr = [];
        arr.push(""使用editor.getContentTxt()方法可以获得编辑器的纯文本内容"");
        arr.push(""编辑器的纯文本内容为："");
        arr.push(UE.getEditor('editor').getContentTxt());
        alert(arr.join(""\n""));
    }
    function hasContent() {
        var arr = [];
        arr.push(""使用editor.hasContents()方法判断编辑器里是否有内容"");
        arr.push(""判断结果为："");
        arr.push(UE.getEditor('editor').hasContents());
        alert(arr.join(""\n""));
    }
    function setFocus() {
        UE.getEditor('editor').focus();
    }
    function deleteEditor() {
        disableBtn();
        UE.getEditor('editor').destroy();
    }
    function disableBtn(str) {
        var div = document.getElementById('btns');
        var btns = UE.dom.domUtils.getElementsByTagName(div, ""button"");
        for (var i = 0, btn; btn = btns[i++];) {
            if (btn.id == str) {
                UE.dom.domUtils.removeAttributes(btn, [""disabled""]);
            } else {
                bt");
            WriteLiteral(@"n.setAttribute(""disabled"", ""true"");
            }
        }
    }
    function enableBtn() {
        var div = document.getElementById('btns');
        var btns = UE.dom.domUtils.getElementsByTagName(div, ""button"");
        for (var i = 0, btn; btn = btns[i++];) {
            UE.dom.domUtils.removeAttributes(btn, [""disabled""]);
        }
    }

    function getLocalData () {
        alert(UE.getEditor('editor').execCommand( ""getlocaldata"" ));
    }

    function clearLocalData () {
        UE.getEditor('editor').execCommand( ""clearlocaldata"" );
        alert(""已清空草稿箱"")
    }</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
