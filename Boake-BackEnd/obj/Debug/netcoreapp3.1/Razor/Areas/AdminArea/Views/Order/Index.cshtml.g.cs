#pragma checksum "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Areas\AdminArea\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3708d877976881872d770ee56aec0badfae20cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminArea_Views_Order_Index), @"mvc.1.0.view", @"/Areas/AdminArea/Views/Order/Index.cshtml")]
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
#line 1 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Areas\AdminArea\Views\_ViewImports.cshtml"
using Boake_BackEnd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Areas\AdminArea\Views\_ViewImports.cshtml"
using Boake_BackEnd.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3708d877976881872d770ee56aec0badfae20cf", @"/Areas/AdminArea/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1bca56df32dcac1e194cf68d95af45ee31e140b", @"/Areas/AdminArea/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_AdminArea_Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "adminarea", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning  "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Areas\AdminArea\Views\Order\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int counter = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid pt-4 px-4"">
    <div class=""row g-4"">
        <div class=""col-sm-12 col-xl-12"">
            <div class=""bg-secondary rounded h-100 p-4"">
                <h6 class=""mb-4"">Basic Table</h6>
                <table class=""table"">
                    <thead>
                        <tr>
                            <th scope=""col"">#</th>
                            <th scope=""col"">Country</th>
                            <th scope=""col"">Date</th>
                            <th scope=""col"">Total</th>
                            <th scope=""col"">Order Status</th>
                            <th scope=""col"">#</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 24 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Areas\AdminArea\Views\Order\Index.cshtml"
                         foreach (var item in Model)
                        {
                            counter++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <th scope=\"row\">");
#nullable restore
#line 28 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Areas\AdminArea\Views\Order\Index.cshtml"
                                           Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                <td>");
#nullable restore
#line 29 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Areas\AdminArea\Views\Order\Index.cshtml"
                               Write(item.CountryRegion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 30 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Areas\AdminArea\Views\Order\Index.cshtml"
                               Write(item.Date.ToString("dddd, dd MMMM yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n                                <td>");
#nullable restore
#line 32 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Areas\AdminArea\Views\Order\Index.cshtml"
                               Write(item.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 33 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Areas\AdminArea\Views\Order\Index.cshtml"
                                 if (item.Status == null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>Gözlənilir</td>\n");
#nullable restore
#line 36 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Areas\AdminArea\Views\Order\Index.cshtml"
                                }
                                else if (item.Status == true)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>Qəbul edildi</td>\n");
#nullable restore
#line 40 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Areas\AdminArea\Views\Order\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>Rədd edilib</td>\n");
#nullable restore
#line 44 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Areas\AdminArea\Views\Order\Index.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 \n                                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3708d877976881872d770ee56aec0badfae20cf8573", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Areas\AdminArea\Views\Order\Index.cshtml"
                                                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n\n                            </tr>\n");
#nullable restore
#line 50 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Areas\AdminArea\Views\Order\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </tbody>\n                </table>\n            </div>\n        </div>\n    </div>\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
