#pragma checksum "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20513f44596509ec790d97306506e9432ba97bbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
#line 1 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\_ViewImports.cshtml"
using Boake_BackEnd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\_ViewImports.cshtml"
using Boake_BackEnd.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20513f44596509ec790d97306506e9432ba97bbb", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27f1f4c8baf891ff3a4b0f55edd338885cdda375", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("  text-decoration-none text-white work-sans hover2 t-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Account\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<section class=\"breadcrumb-area py-5 py-sm-0\">\n    <div class=\" bg-shade text-center py-4\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20513f44596509ec790d97306506e9432ba97bbb4441", async() => {
                WriteLiteral("HOME ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <span class="" text-white"">/</span>
        <span class="" text-white work-sans"">Account</span>
    </div>
</section>

<div class=""customer-page theme-default-margin my-account-page"" style=""background-color:wheat;"">
    <div class=""container"">
        <hr class=""hr--small"">
        <div class=""grid"">
            <div class=""grid__item two-thirds medium-down--one-whole"">
                <h2 class=""h4"">Order History</h2>
                <div class=""table-wrap"">
                    <table class=""full"">
                        <thead>
                            <tr>
                                <th>Order Id</th>
                                <th>Date</th>
                                <th>Payment Status</th>
                                <th>Fulfillment Status</th>
                                <th>Total</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 33 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Account\Index.cshtml"
                             if (User.Identity.IsAuthenticated)
                            {

                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Account\Index.cshtml"
                                 foreach (var item in Model)
                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\n                                        <td>");
#nullable restore
#line 40 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Account\Index.cshtml"
                                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 41 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Account\Index.cshtml"
                                       Write(item.Date.ToString("MMMM dd,yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n");
#nullable restore
#line 42 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Account\Index.cshtml"
                                         if (item.Status == null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td>Pending</td>\n");
#nullable restore
#line 45 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Account\Index.cshtml"
                                        }
                                        else if (item.Status == true)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td>Accepted</td>\n");
#nullable restore
#line 49 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Account\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td>Rejected</td>\n");
#nullable restore
#line 53 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Account\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>Unfulfilled</td>\n                                        <td><span class=\"money\" >$");
#nullable restore
#line 55 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Account\Index.cshtml"
                                                             Write(item.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n                                    </tr>\n");
#nullable restore
#line 57 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Account\Index.cshtml"

                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Account\Index.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\n                    </table>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591