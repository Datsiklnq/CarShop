#pragma checksum "C:\Users\tst11\Source\Repos\CarShop2\CarShop\Views\Cars\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cd95a8d5bdeb64b548090b2a873be7ccdb3e13a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_Index), @"mvc.1.0.view", @"/Views/Cars/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cars/Index.cshtml", typeof(AspNetCore.Views_Cars_Index))]
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
#line 1 "C:\Users\tst11\Source\Repos\CarShop2\CarShop\Views\_ViewImports.cshtml"
using CarShop;

#line default
#line hidden
#line 2 "C:\Users\tst11\Source\Repos\CarShop2\CarShop\Views\_ViewImports.cshtml"
using CarShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cd95a8d5bdeb64b548090b2a873be7ccdb3e13a", @"/Views/Cars/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe4c0d735d051fba12fbf7807849e7c1ea31600c", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CarShop.Models.Car>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\tst11\Source\Repos\CarShop2\CarShop\Views\Cars\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
            BeginContext(84, 122, true);
            WriteLiteral("\r\n<div class=\"latestCars\">\r\n    <h2>Latest Super Cars</h2>\r\n</div>\r\n<div class=\"container\">\r\n    <div class=\" car-list\">\r\n");
            EndContext();
#line 13 "C:\Users\tst11\Source\Repos\CarShop2\CarShop\Views\Cars\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(255, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(267, 569, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1f353e5ccba4399997aa2d45abae881", async() => {
                BeginContext(315, 92, true);
                WriteLiteral("\r\n                <div class=\"each-car\">\r\n                    <h3>\r\n                        ");
                EndContext();
                BeginContext(408, 40, false);
#line 18 "C:\Users\tst11\Source\Repos\CarShop2\CarShop\Views\Cars\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Brand));

#line default
#line hidden
                EndContext();
                BeginContext(448, 78, true);
                WriteLiteral("\r\n                    </h3>\r\n                    <p>\r\n                        ");
                EndContext();
                BeginContext(527, 40, false);
#line 21 "C:\Users\tst11\Source\Repos\CarShop2\CarShop\Views\Cars\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Model));

#line default
#line hidden
                EndContext();
                BeginContext(567, 54, true);
                WriteLiteral("\r\n                    </p>\r\n\r\n                    <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 621, "\"", 654, 1);
#line 24 "C:\Users\tst11\Source\Repos\CarShop2\CarShop\Views\Cars\Index.cshtml"
WriteAttributeValue("", 627, Url.Content(item.ImageUrl), 627, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(655, 72, true);
                WriteLiteral(" alt=\"url image\" />\r\n                    <p>\r\n\r\n                        ");
                EndContext();
                BeginContext(728, 40, false);
#line 27 "C:\Users\tst11\Source\Repos\CarShop2\CarShop\Views\Cars\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
                EndContext();
                BeginContext(768, 64, true);
                WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 15 "C:\Users\tst11\Source\Repos\CarShop2\CarShop\Views\Cars\Index.cshtml"
                                      WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(836, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 31 "C:\Users\tst11\Source\Repos\CarShop2\CarShop\Views\Cars\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(849, 26, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CarShop.Models.Car>> Html { get; private set; }
    }
}
#pragma warning restore 1591
