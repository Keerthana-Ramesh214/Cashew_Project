#pragma checksum "C:\Users\Admin\source\repos\ShoppingApp\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b8bcbc35055275c74651d34a2b55d67e8a7cd4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b8bcbc35055275c74651d34a2b55d67e8a7cd4f", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9650a1976e0c12ce9f77745181f01694dd4d0bd3", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShoppingApp.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("second"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-family:Georgia, \'Times New Roman\', Times, serif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetProductDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\source\repos\ShoppingApp\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Latest compiled and minified CSS -->
<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">

<!-- jQuery library -->
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>

<!-- Latest compiled JavaScript -->
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>

<!--==========================================-->
<!-- Carousel                                 -->
<!--==========================================-->

<style>
    body{
        font-family:Georgia, 'Times New Roman', Times, serif;
        font-size:large;
    }

    /*CAROUSEL*/
    .main-text {
        position: absolute;
        top: 100px;
        width: 96.66666666666666%;
        color: #FFF;
    }

    .carousel-btns {
        margin-top: 2em;
    }

        .carousel-btns .btn {
            width: 150px;
        }

    .carousel-inner .imgOverlay {
        position: absolute;
        to");
            WriteLiteral(@"p: 0;
        width: 100%;
        height: 100%;
        background-color: rgba(6, 28, 38, 0.5);
    }

    .carousel-inner img {
        width: 100%;
    }

    /*CONTROL*/
    .carousel-control {
        width: auto;
    }

        .carousel-control .icon-prev,
        .carousel-control .icon-next,
        .carousel-control .fa-chevron-left,
        .carousel-control .fa-chevron-right {
            position: absolute;
            top: 47%;
            right: 0;
            z-index: 5;
            display: inline-block;
            background-color: #000;
            width: 38px;
            height: 38px;
            line-height: 40px;
            font-size: 14px;
        }

        .carousel-control .icon-prev,
        .carousel-control .fa-chevron-left {
            left: 0;
        }

    .carousel-indicators li {
        width: 12px;
        height: 12px;
        margin: 0 1px;
        border: 2px solid #fff;
        opacity: .8;
    }

    .carousel-indicators");
            WriteLiteral(@" .active {
        background-color: #28ace2;
        border-color: #28ace2;
    }

    .carousel-control .icon-prev, .carousel-control .fa-chevron-left,
    .carousel-control .icon-right, .carousel-control .fa-chevron-right {
        border-radius: 50px;
    }

    .carousel-control .icon-prev, .carousel-control .fa-chevron-left {
        left: 30px;
    }

    .carousel-control .icon-right, .carousel-control .fa-chevron-right {
        right: 30px;
    }





</style>


");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b8bcbc35055275c74651d34a2b55d67e8a7cd4f8072", async() => {
                WriteLiteral(@"
    <div class=""container"">
        <div id=""themeSlider"" class=""carousel slide"" data-ride=""carousel"">
            <ol class=""carousel-indicators"">
                <li data-target=""#themeSlider"" data-slide-to=""0"" class=""active""></li>
                <li data-target=""#themeSlider"" data-slide-to=""1""></li>
                <li data-target=""#themeSlider"" data-slide-to=""2""></li>
            </ol>

            <div class=""carousel-inner"">
                <div class=""item active"">
                    <div class=""imgOverlay""></div>
                    <img style=""height: 450px; width: 100%"" src=""https://m.media-amazon.com/images/I/41R6Wj681dL.jpg"" alt=""First slide"">
                    <div class=""carousel-caption"">
                        <h3 style=""font-family:Georgia, 'Times New Roman', Times, serif"">Cashew Kernels</h3>
                    </div>
                </div>
                <div class=""item"">
                    <div class=""imgOverlay""></div>
                    <img style=""height:450");
                WriteLiteral(@"px;width:100%"" src=""https://5.imimg.com/data5/JY/OU/MY-23644779/cashew-nut-500x500.jpg"" alt=""Second slide"">
                    <div class=""carousel-caption"">
                        <h3 style=""font-family:Georgia, 'Times New Roman', Times, serif"">Kaju</h3>
                    </div>
                </div>
                <div class=""item"">
                    <div class=""imgOverlay""></div>
                    <img style=""height: 450px; width: 100%"" src=""https://5.imimg.com/data5/XJ/BV/MY-11002274/cashew-nut-500x500.jpg"" alt=""Third slide"">
                    <div class=""carousel-caption"">
                        <h3 style=""font-family:Georgia, 'Times New Roman', Times, serif"">Quality Assured</h3>
                    </div>
                </div>
            </div>

            <a class=""left carousel-control"" href=""#themeSlider"" data-slide=""prev"">
                <span class=""fa fa-chevron-left""></span>
            </a>
            <a class=""right carousel-control"" href=""#themeSlider"" data-s");
                WriteLiteral("lide=\"next\">\r\n                <span class=\"fa fa-chevron-right\"></span>\r\n            </a>\r\n        </div>\r\n\r\n        <hr />\r\n\r\n\r\n");
#nullable restore
#line 157 "C:\Users\Admin\source\repos\ShoppingApp\Views\Products\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\" col-md-4\" style=\"padding-bottom:20px\">\r\n                <div class=\"card\" style=\"width: 32rem\">\r\n                    <img class=\"card-img-top\"");
                BeginWriteAttribute("src", " src=", 5042, "", 5078, 1);
#nullable restore
#line 161 "C:\Users\Admin\source\repos\ShoppingApp\Views\Products\Index.cshtml"
WriteAttributeValue("", 5047, Url.Content(item.ProductImage), 5047, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Card image cap\" style=\" height:200px;width:318px\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\" style=\"font-family:Georgia, \'Times New Roman\', Times, serif\"><b>");
#nullable restore
#line 163 "C:\Users\Admin\source\repos\ShoppingApp\Views\Products\Index.cshtml"
                                                                                                          Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></h5>\r\n                        <p class=\"card-text\" style=\"font-family:Georgia, \'Times New Roman\', Times, serif\">");
#nullable restore
#line 164 "C:\Users\Admin\source\repos\ShoppingApp\Views\Products\Index.cshtml"
                                                                                                     Write(Html.DisplayFor(modelItem => item.ProductPrice));

#line default
#line hidden
#nullable disable
                WriteLiteral("/KG INR </p>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b8bcbc35055275c74651d34a2b55d67e8a7cd4f12552", async() => {
                    WriteLiteral("Add to Cart");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "itemid", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 165 "C:\Users\Admin\source\repos\ShoppingApp\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 5650, item.ProductId, 5650, 15, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ItemId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 165 "C:\Users\Admin\source\repos\ShoppingApp\Views\Products\Index.cshtml"
                                                                                                                                                                                                              WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ItemId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ItemId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ItemId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 165 "C:\Users\Admin\source\repos\ShoppingApp\Views\Products\Index.cshtml"
                                                                                                                                                                                                                                                      WriteLiteral(item.ProductName);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ProductName"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ProductName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ProductName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 165 "C:\Users\Admin\source\repos\ShoppingApp\Views\Products\Index.cshtml"
                                                                                                                                                                                                                                                                                                 WriteLiteral(item.ProductPrice);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ProductPrice"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ProductPrice", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ProductPrice"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <br />\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b8bcbc35055275c74651d34a2b55d67e8a7cd4f17914", async() => {
                    WriteLiteral("More details");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 167 "C:\Users\Admin\source\repos\ShoppingApp\Views\Products\Index.cshtml"
                                                            WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 171 "C:\Users\Admin\source\repos\ShoppingApp\Views\Products\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShoppingApp.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591