#pragma checksum "C:\Users\Admin\source\repos\ShoppingApp\Views\Admin\CustomerDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c02fed0ce62ce679f0d9917ac723d6819c59328c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CustomerDetails), @"mvc.1.0.view", @"/Views/Admin/CustomerDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c02fed0ce62ce679f0d9917ac723d6819c59328c", @"/Views/Admin/CustomerDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9650a1976e0c12ce9f77745181f01694dd4d0bd3", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CustomerDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShoppingApp.Models.UserRegistration>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\source\repos\ShoppingApp\Views\Admin\CustomerDetails.cshtml"
  
    ViewData["Title"] = "CustomerDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    th{
        background-color:cadetblue;
    }

</style>
<h1>CustomerDetails</h1>

<table class=""table"">
    <thead class=""border"">
        <tr>
            <th class=""border"">
                Customer Mobile No
            </th>
            <th class=""border"">
                ");
#nullable restore
#line 21 "C:\Users\Admin\source\repos\ShoppingApp\Views\Admin\CustomerDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"border\">\r\n                ");
#nullable restore
#line 24 "C:\Users\Admin\source\repos\ShoppingApp\Views\Admin\CustomerDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"border\">\r\n                ");
#nullable restore
#line 27 "C:\Users\Admin\source\repos\ShoppingApp\Views\Admin\CustomerDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Dob));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"border\">\r\n                ");
#nullable restore
#line 30 "C:\Users\Admin\source\repos\ShoppingApp\Views\Admin\CustomerDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.DeliveryAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 35 "C:\Users\Admin\source\repos\ShoppingApp\Views\Admin\CustomerDetails.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class=\"border\">\r\n                ");
#nullable restore
#line 38 "C:\Users\Admin\source\repos\ShoppingApp\Views\Admin\CustomerDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"border\">\r\n                ");
#nullable restore
#line 41 "C:\Users\Admin\source\repos\ShoppingApp\Views\Admin\CustomerDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"border\">\r\n                ");
#nullable restore
#line 44 "C:\Users\Admin\source\repos\ShoppingApp\Views\Admin\CustomerDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"border\">\r\n                ");
#nullable restore
#line 47 "C:\Users\Admin\source\repos\ShoppingApp\Views\Admin\CustomerDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dob));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"border\">\r\n                ");
#nullable restore
#line 50 "C:\Users\Admin\source\repos\ShoppingApp\Views\Admin\CustomerDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.DeliveryAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 53 "C:\Users\Admin\source\repos\ShoppingApp\Views\Admin\CustomerDetails.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShoppingApp.Models.UserRegistration>> Html { get; private set; }
    }
}
#pragma warning restore 1591
