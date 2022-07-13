#pragma checksum "C:\Users\Admin\source\repos\ShoppingApp\Views\ShoppingCart\OrderHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d576a7b2751a3f08e641a5b7d7b788cb045a234d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_OrderHistory), @"mvc.1.0.view", @"/Views/ShoppingCart/OrderHistory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d576a7b2751a3f08e641a5b7d7b788cb045a234d", @"/Views/ShoppingCart/OrderHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9650a1976e0c12ce9f77745181f01694dd4d0bd3", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_OrderHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShoppingApp.Models.OrderDetail>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\source\repos\ShoppingApp\Views\ShoppingCart\OrderHistory.cshtml"
  
    ViewData["Title"] = "OrderHistory";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    th {\r\n        background-color: cadetblue;\r\n    }\r\n</style>\r\n<h1>OrderHistory</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th class=\"border\">\r\n                ");
#nullable restore
#line 18 "C:\Users\Admin\source\repos\ShoppingApp\Views\ShoppingCart\OrderHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"border\">\r\n                ");
#nullable restore
#line 21 "C:\Users\Admin\source\repos\ShoppingApp\Views\ShoppingCart\OrderHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"border\">\r\n                ");
#nullable restore
#line 24 "C:\Users\Admin\source\repos\ShoppingApp\Views\ShoppingCart\OrderHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderDeliveryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"border\">\r\n                ");
#nullable restore
#line 27 "C:\Users\Admin\source\repos\ShoppingApp\Views\ShoppingCart\OrderHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerMobNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"border\">\r\n                ");
#nullable restore
#line 30 "C:\Users\Admin\source\repos\ShoppingApp\Views\ShoppingCart\OrderHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.QuantityOrdered));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"border\">\r\n                ");
#nullable restore
#line 33 "C:\Users\Admin\source\repos\ShoppingApp\Views\ShoppingCart\OrderHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderTotalAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 38 "C:\Users\Admin\source\repos\ShoppingApp\Views\ShoppingCart\OrderHistory.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class=\"border\">\r\n                ");
#nullable restore
#line 42 "C:\Users\Admin\source\repos\ShoppingApp\Views\ShoppingCart\OrderHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"border\">\r\n                ");
#nullable restore
#line 45 "C:\Users\Admin\source\repos\ShoppingApp\Views\ShoppingCart\OrderHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"border\">\r\n                ");
#nullable restore
#line 48 "C:\Users\Admin\source\repos\ShoppingApp\Views\ShoppingCart\OrderHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderDeliveryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"border\">\r\n                ");
#nullable restore
#line 51 "C:\Users\Admin\source\repos\ShoppingApp\Views\ShoppingCart\OrderHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerMobNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"border\">\r\n                ");
#nullable restore
#line 54 "C:\Users\Admin\source\repos\ShoppingApp\Views\ShoppingCart\OrderHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.QuantityOrdered));

#line default
#line hidden
#nullable disable
            WriteLiteral(" KG\r\n            </td>\r\n            <td class=\"border\">\r\n                ");
#nullable restore
#line 57 "C:\Users\Admin\source\repos\ShoppingApp\Views\ShoppingCart\OrderHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderTotalAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral(" INR\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 60 "C:\Users\Admin\source\repos\ShoppingApp\Views\ShoppingCart\OrderHistory.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d576a7b2751a3f08e641a5b7d7b788cb045a234d8788", async() => {
                WriteLiteral("Back to Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShoppingApp.Models.OrderDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591