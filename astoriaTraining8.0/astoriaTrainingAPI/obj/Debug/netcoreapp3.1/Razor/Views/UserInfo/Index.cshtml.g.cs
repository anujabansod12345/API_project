#pragma checksum "E:\API\astoriaTraining8.0\astoriaTrainingAPI\Views\UserInfo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "977ed2e5923393c3253a29cceab0fa7443a1c3ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserInfo_Index), @"mvc.1.0.view", @"/Views/UserInfo/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"977ed2e5923393c3253a29cceab0fa7443a1c3ea", @"/Views/UserInfo/Index.cshtml")]
    public class Views_UserInfo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<astoriaTrainingAPI.Models.UserInfo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\API\astoriaTraining8.0\astoriaTrainingAPI\Views\UserInfo\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "E:\API\astoriaTraining8.0\astoriaTrainingAPI\Views\UserInfo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "E:\API\astoriaTraining8.0\astoriaTrainingAPI\Views\UserInfo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "E:\API\astoriaTraining8.0\astoriaTrainingAPI\Views\UserInfo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "E:\API\astoriaTraining8.0\astoriaTrainingAPI\Views\UserInfo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "E:\API\astoriaTraining8.0\astoriaTrainingAPI\Views\UserInfo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Passwords));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "E:\API\astoriaTraining8.0\astoriaTrainingAPI\Views\UserInfo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "E:\API\astoriaTraining8.0\astoriaTrainingAPI\Views\UserInfo\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "E:\API\astoriaTraining8.0\astoriaTrainingAPI\Views\UserInfo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "E:\API\astoriaTraining8.0\astoriaTrainingAPI\Views\UserInfo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "E:\API\astoriaTraining8.0\astoriaTrainingAPI\Views\UserInfo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "E:\API\astoriaTraining8.0\astoriaTrainingAPI\Views\UserInfo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "E:\API\astoriaTraining8.0\astoriaTrainingAPI\Views\UserInfo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Passwords));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "E:\API\astoriaTraining8.0\astoriaTrainingAPI\Views\UserInfo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1588, "\"", 1611, 1);
#nullable restore
#line 58 "E:\API\astoriaTraining8.0\astoriaTrainingAPI\Views\UserInfo\Index.cshtml"
WriteAttributeValue("", 1603, item.ID, 1603, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1664, "\"", 1687, 1);
#nullable restore
#line 59 "E:\API\astoriaTraining8.0\astoriaTrainingAPI\Views\UserInfo\Index.cshtml"
WriteAttributeValue("", 1679, item.ID, 1679, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1742, "\"", 1765, 1);
#nullable restore
#line 60 "E:\API\astoriaTraining8.0\astoriaTrainingAPI\Views\UserInfo\Index.cshtml"
WriteAttributeValue("", 1757, item.ID, 1757, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 63 "E:\API\astoriaTraining8.0\astoriaTrainingAPI\Views\UserInfo\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<astoriaTrainingAPI.Models.UserInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
