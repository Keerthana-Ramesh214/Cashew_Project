#pragma checksum "C:\Users\Admin\source\repos\ShoppingApp\Views\Home\MsgPassing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c469b9e1404818d7d4341ae4e2cb84deeed545d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MsgPassing), @"mvc.1.0.view", @"/Views/Home/MsgPassing.cshtml")]
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
#line 1 "C:\Users\Admin\source\repos\ShoppingApp\Views\_ViewImports.cshtml"
using ShoppingApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\ShoppingApp\Views\_ViewImports.cshtml"
using ShoppingApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c469b9e1404818d7d4341ae4e2cb84deeed545d1", @"/Views/Home/MsgPassing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9650a1976e0c12ce9f77745181f01694dd4d0bd3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MsgPassing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShoppingApp.Models.ContactUs>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\source\repos\ShoppingApp\Views\Home\MsgPassing.cshtml"
  
    ViewData["Title"] = "MsgPassing";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<style>\r\n    th {\r\n        background-color: cadetblue;\r\n    }\r\n</style>\r\n\r\n\r\n<h1>Hey!!!You have some Messages.....</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th class=\"border\">\r\n                ");
#nullable restore
#line 21 "C:\Users\Admin\source\repos\ShoppingApp\Views\Home\MsgPassing.cshtml"
           Write(Html.DisplayNameFor(model => model.MailId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"border\">\r\n                ");
#nullable restore
#line 24 "C:\Users\Admin\source\repos\ShoppingApp\Views\Home\MsgPassing.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"border\">\r\n                ");
#nullable restore
#line 27 "C:\Users\Admin\source\repos\ShoppingApp\Views\Home\MsgPassing.cshtml"
           Write(Html.DisplayNameFor(model => model.Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"border\">\r\n                ");
#nullable restore
#line 30 "C:\Users\Admin\source\repos\ShoppingApp\Views\Home\MsgPassing.cshtml"
           Write(Html.DisplayNameFor(model => model.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 35 "C:\Users\Admin\source\repos\ShoppingApp\Views\Home\MsgPassing.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class=\"border\">\r\n                ");
#nullable restore
#line 38 "C:\Users\Admin\source\repos\ShoppingApp\Views\Home\MsgPassing.cshtml"
           Write(Html.DisplayFor(modelItem => item.MailId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"border\">\r\n                ");
#nullable restore
#line 41 "C:\Users\Admin\source\repos\ShoppingApp\Views\Home\MsgPassing.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"border\">\r\n                ");
#nullable restore
#line 44 "C:\Users\Admin\source\repos\ShoppingApp\Views\Home\MsgPassing.cshtml"
           Write(Html.DisplayFor(modelItem => item.Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"border\">\r\n                ");
#nullable restore
#line 47 "C:\Users\Admin\source\repos\ShoppingApp\Views\Home\MsgPassing.cshtml"
           Write(Html.DisplayFor(modelItem => item.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 50 "C:\Users\Admin\source\repos\ShoppingApp\Views\Home\MsgPassing.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShoppingApp.Models.ContactUs>> Html { get; private set; }
    }
}
#pragma warning restore 1591
