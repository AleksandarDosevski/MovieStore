#pragma checksum "D:\Developer\ASP.NET Core\MovieStore - Jorgos\MovieStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7eb270610cb851daeaa3d179169c9bb2474e6c69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Developer\ASP.NET Core\MovieStore - Jorgos\MovieStore\Views\_ViewImports.cshtml"
using MovieStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Developer\ASP.NET Core\MovieStore - Jorgos\MovieStore\Views\_ViewImports.cshtml"
using MovieStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7eb270610cb851daeaa3d179169c9bb2474e6c69", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a8c2dc702b202c6daeaeb5df09bdab9162bf52c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieStore.Models.MovieViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-height: 350px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Developer\ASP.NET Core\MovieStore - Jorgos\MovieStore\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"container-fluid text-center\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7eb270610cb851daeaa3d179169c9bb2474e6c694731", async() => {
                WriteLiteral(@"
        <div class=""search-main p-3"">
            <button type=""submit"" class=""btn search-btn-icon""><i class=""fa fa-search""></i></button>
            <input type=""text"" class=""form-control search-box-style"" id=""searchmovie"" />
            <button type=""submit"" class=""btn btn-success search-btn"">Search</button>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            WriteLiteral(@"<div class=""container-fluid text-left moviecover-background"">
    <h1 class=""display-4 banner-text-style1"" style=""color: yellow""><b>Welcome to our Online MovieStore</b></h1>
    <h4 class=""display-4 banner-text-style2"">all your favorite movies in one place</h4>
</div>

");
            WriteLiteral("<div class=\"custom-container pt-5\">\r\n    <h2>Popular Movies!</h2>\r\n    <h6><em>Some of our most sold movies!</em></h6>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 30 "D:\Developer\ASP.NET Core\MovieStore - Jorgos\MovieStore\Views\Home\Index.cshtml"
         foreach (var item in Model.TopPopularMovies)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-12 col-md-3 mt-5\">\r\n                <div class=\"card h-100\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7eb270610cb851daeaa3d179169c9bb2474e6c697407", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1284, "~/images/", 1284, 9, true);
#nullable restore
#line 34 "D:\Developer\ASP.NET Core\MovieStore - Jorgos\MovieStore\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1293, item.PhotoURL, 1293, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\"> ");
#nullable restore
#line 36 "D:\Developer\ASP.NET Core\MovieStore - Jorgos\MovieStore\Views\Home\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n                        <h6");
            BeginWriteAttribute("class", " class=\"", 1527, "\"", 1535, 0);
            EndWriteAttribute();
            WriteLiteral("><em>by</em> ");
#nullable restore
#line 37 "D:\Developer\ASP.NET Core\MovieStore - Jorgos\MovieStore\Views\Home\Index.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.DirectorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <hr />\r\n                        <p class=\"card-text\">Category: ");
#nullable restore
#line 39 "D:\Developer\ASP.NET Core\MovieStore - Jorgos\MovieStore\Views\Home\Index.cshtml"
                                                  Write(Html.DisplayFor(modelItem => item.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <button class=\"btn btn-secondary btn-block\" id=\"addToWishlistFromPopular\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1842, "\"", 1875, 3);
            WriteAttributeValue("", 1852, "AddToWishlist(", 1852, 14, true);
#nullable restore
#line 40 "D:\Developer\ASP.NET Core\MovieStore - Jorgos\MovieStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 1866, item.Id, 1866, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1874, ")", 1874, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"fas fa-plus\"></i> &nbsp; Add To Wishlist\r\n                        </button>\r\n                        <button class=\"btn btn-success btn-block\" id=\"addToCartFromPopular\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2085, "\"", 2114, 3);
            WriteAttributeValue("", 2095, "AddToCart(", 2095, 10, true);
#nullable restore
#line 43 "D:\Developer\ASP.NET Core\MovieStore - Jorgos\MovieStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 2105, item.Id, 2105, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2113, ")", 2113, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"fas fa-cart-plus\"></i> &nbsp; Add To Cart\r\n                        </button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 49 "D:\Developer\ASP.NET Core\MovieStore - Jorgos\MovieStore\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<hr />\r\n\r\n");
            WriteLiteral("<div class=\"custom-container pt-5\">\r\n    <h2>");
#nullable restore
#line 57 "D:\Developer\ASP.NET Core\MovieStore - Jorgos\MovieStore\Views\Home\Index.cshtml"
   Write(Model.BestSellingDirector.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <h6><em>Popular movies by bestselling director, ");
#nullable restore
#line 58 "D:\Developer\ASP.NET Core\MovieStore - Jorgos\MovieStore\Views\Home\Index.cshtml"
                                               Write(Model.BestSellingDirector.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</em></h6>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 60 "D:\Developer\ASP.NET Core\MovieStore - Jorgos\MovieStore\Views\Home\Index.cshtml"
         foreach (var item in Model.TopPopularMoviesByBestSellingDirector)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-12 col-md-2 mt-5\">\r\n                <div class=\"card h-100\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7eb270610cb851daeaa3d179169c9bb2474e6c6913215", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2802, "~/images/", 2802, 9, true);
#nullable restore
#line 64 "D:\Developer\ASP.NET Core\MovieStore - Jorgos\MovieStore\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2811, item.PhotoURL, 2811, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\"> ");
#nullable restore
#line 66 "D:\Developer\ASP.NET Core\MovieStore - Jorgos\MovieStore\Views\Home\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n                        <h6");
            BeginWriteAttribute("class", " class=\"", 3045, "\"", 3053, 0);
            EndWriteAttribute();
            WriteLiteral("><em>by</em> ");
#nullable restore
#line 67 "D:\Developer\ASP.NET Core\MovieStore - Jorgos\MovieStore\Views\Home\Index.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.DirectorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <hr />\r\n                        <p class=\"card-text\">Category: ");
#nullable restore
#line 69 "D:\Developer\ASP.NET Core\MovieStore - Jorgos\MovieStore\Views\Home\Index.cshtml"
                                                  Write(Html.DisplayFor(modelItem => item.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <button class=\"btn btn-secondary btn-block\" id=\"addToWishlistFromPopularDirector\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3368, "\"", 3401, 3);
            WriteAttributeValue("", 3378, "AddToWishlist(", 3378, 14, true);
#nullable restore
#line 70 "D:\Developer\ASP.NET Core\MovieStore - Jorgos\MovieStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 3392, item.Id, 3392, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3400, ")", 3400, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"fas fa-plus\"></i>  &nbsp; Add To Wishlist\r\n                        </button>\r\n                        <button class=\"btn btn-success btn-block\" id=\"addToCartFromPopularDirector\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3620, "\"", 3649, 3);
            WriteAttributeValue("", 3630, "AddToCart(", 3630, 10, true);
#nullable restore
#line 73 "D:\Developer\ASP.NET Core\MovieStore - Jorgos\MovieStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 3640, item.Id, 3640, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3648, ")", 3648, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"fas fa-cart-plus\"></i> &nbsp; Add To Cart\r\n                        </button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 79 "D:\Developer\ASP.NET Core\MovieStore - Jorgos\MovieStore\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            WriteLiteral("<div class=\"custom-container pt-5\">\r\n    <h2>All Movies!</h2>\r\n    <h6><em>List of all movies!</em></h6>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 88 "D:\Developer\ASP.NET Core\MovieStore - Jorgos\MovieStore\Views\Home\Index.cshtml"
         foreach (var item in Model.AllMovies)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-12 col-md-2 mt-5\">\r\n                <div class=\"card h-100\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7eb270610cb851daeaa3d179169c9bb2474e6c6918472", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4208, "~/images/", 4208, 9, true);
#nullable restore
#line 92 "D:\Developer\ASP.NET Core\MovieStore - Jorgos\MovieStore\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 4217, item.PhotoURL, 4217, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\"> ");
#nullable restore
#line 94 "D:\Developer\ASP.NET Core\MovieStore - Jorgos\MovieStore\Views\Home\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n                        <h6");
            BeginWriteAttribute("class", " class=\"", 4451, "\"", 4459, 0);
            EndWriteAttribute();
            WriteLiteral("><em>by</em> ");
#nullable restore
#line 95 "D:\Developer\ASP.NET Core\MovieStore - Jorgos\MovieStore\Views\Home\Index.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.DirectorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <hr />\r\n                        <p class=\"card-text\">Category: ");
#nullable restore
#line 97 "D:\Developer\ASP.NET Core\MovieStore - Jorgos\MovieStore\Views\Home\Index.cshtml"
                                                  Write(Html.DisplayFor(modelItem => item.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n                        <button class=\"btn btn-secondary btn-block\" id=\"addtowishlist\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4759, "\"", 4792, 3);
            WriteAttributeValue("", 4769, "AddToWishlist(", 4769, 14, true);
#nullable restore
#line 100 "D:\Developer\ASP.NET Core\MovieStore - Jorgos\MovieStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 4783, item.Id, 4783, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4791, ")", 4791, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"fas fa-plus\"></i> &nbsp; Add To Wishlist\r\n                        </button>\r\n\r\n\r\n                        <button class=\"btn btn-success btn-block\" id=\"addToCart\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4995, "\"", 5024, 3);
            WriteAttributeValue("", 5005, "AddToCart(", 5005, 10, true);
#nullable restore
#line 105 "D:\Developer\ASP.NET Core\MovieStore - Jorgos\MovieStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 5015, item.Id, 5015, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5023, ")", 5023, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <i class=\"fas fa-cart-plus\"></i> &nbsp; Add To Cart\r\n                        </button>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 112 "D:\Developer\ASP.NET Core\MovieStore - Jorgos\MovieStore\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script type=""text/javascript"">

        $(document).ready(function () {

            $(""#searchmovie"").keyup(function () {
                var searchString = $(""#searchmovie"").val();
                if (searchString.length >= 2) { // console.log(""> 2"");
                    window.location = 'Search/';
                    //$.ajax({
                    //    type: ""GET"",
                    //    url: ""/Search/Search?keywords="" + searchString,
                    //    success: function (data) {
                    //        console.log(""Success"");
                    //        console.log(data);

                    //    },
                    //    error: function () {
                    //        alert(""error"");
                    //    }
                    //});
                }
            });

        });

        function AddToWishlist(id) {
            $.ajax({
                type: ""POST"",
                url: ""/Home/AddToWishlist/"" + id,
                succ");
                WriteLiteral(@"ess: function (data) {
                    //console.log(data);
                    if (data.data != """") {
                        new Noty({
                            type: 'alert',
                            layout: 'bottomLeft',
                            timeout: 3000,
                            text: 'Successfully Added To Wishlist',
                            theme: 'sunset'
                        }).show();
                    } else {
                        new Noty({
                            type: 'error',
                            layout: 'bottomLeft',
                            timeout: 3000,
                            progressBar: true,
                            text: 'Movie Already Exists In The Wishlist',
                            theme: 'sunset'
                        }).show();
                    }
                },
                error: function () {
                    alert(""error"");
                }
            });
        };

        func");
                WriteLiteral(@"tion AddToCart(id) {
            $.ajax({
                type: ""POST"",
                url: ""/ShopCart/AddToCart/"" + id,
                success: function (data) {
                    console.log(""Success"");
                    console.log(data);
                    new Noty({
                        type: 'success',
                        layout: 'bottomLeft',
                        timeout: 3000,
                        text: 'Added To Cart',
                        theme: 'sunset'
                    }).show();
                },
                error: function () {
                    alert(""error"");
                }
            });
        }

    </script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieStore.Models.MovieViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
