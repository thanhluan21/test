#pragma checksum "D:\wepchamcongversion1\wepchamcongversion1\Views\MauNghiPheps\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8c2dcb1284b2676e44e8e456080d39a63a6232b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MauNghiPheps_Index), @"mvc.1.0.view", @"/Views/MauNghiPheps/Index.cshtml")]
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
#nullable restore
#line 1 "D:\wepchamcongversion1\wepchamcongversion1\Views\_ViewImports.cshtml"
using wepchamcongversion1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\wepchamcongversion1\wepchamcongversion1\Views\_ViewImports.cshtml"
using wepchamcongversion1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8c2dcb1284b2676e44e8e456080d39a63a6232b", @"/Views/MauNghiPheps/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c20b6a89ae87d6d30593ee670a340dec54aed91", @"/Views/_ViewImports.cshtml")]
    public class Views_MauNghiPheps_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<wepchamcongversion1.Models.MauNghiPhep>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\wepchamcongversion1\wepchamcongversion1\Views\MauNghiPheps\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n<p>\r\n    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 139, "\"", 251, 6);
            WriteAttributeValue("", 149, "showInPopup(\'", 149, 13, true);
#nullable restore
#line 11 "D:\wepchamcongversion1\wepchamcongversion1\Views\MauNghiPheps\Index.cshtml"
WriteAttributeValue("", 162, Url.Action("AddOrEdit","MauNghiPheps",null,Context.Request.Scheme), 162, 67, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 229, "\',\'T???o", 229, 6, true);
            WriteAttributeValue(" ", 235, "M???u", 236, 4, true);
            WriteAttributeValue(" ", 239, "Ngh???", 240, 5, true);
            WriteAttributeValue(" ", 244, "Ph??p\')", 245, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Create New</a>\r\n</p>\r\n\r\n<div id=\"view-all\">\r\n    ");
#nullable restore
#line 15 "D:\wepchamcongversion1\wepchamcongversion1\Views\MauNghiPheps\Index.cshtml"
Write(await Html.PartialAsync("_ViewAll", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<wepchamcongversion1.Models.MauNghiPhep>> Html { get; private set; }
    }
}
#pragma warning restore 1591
