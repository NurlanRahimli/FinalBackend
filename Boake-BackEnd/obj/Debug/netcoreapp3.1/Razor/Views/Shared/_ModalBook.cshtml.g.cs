#pragma checksum "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Shared\_ModalBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c84b9c29715465d760f36c0ed2eecbc0aeec90f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ModalBook), @"mvc.1.0.view", @"/Views/Shared/_ModalBook.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c84b9c29715465d760f36c0ed2eecbc0aeec90f", @"/Views/Shared/_ModalBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27f1f4c8baf891ff3a4b0f55edd338885cdda375", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__ModalBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-lg-6 col-12\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7c84b9c29715465d760f36c0ed2eecbc0aeec90f3939", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 89, "~/assets/img/feature-collection/", 89, 32, true);
#nullable restore
#line 6 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Shared\_ModalBook.cshtml"
AddHtmlAttributeValue("", 121, Model.ImageUrl, 121, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-lg-6 col-12\">\r\n        <h2 class=\"title geometric text-white ls-1\">");
#nullable restore
#line 9 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Shared\_ModalBook.cshtml"
                                               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <span class=\"price\">\r\n");
#nullable restore
#line 11 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Shared\_ModalBook.cshtml"
             if (Model.CampaignId == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"money text-fusion  fw-bold fs-4\">$");
#nullable restore
#line 13 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Shared\_ModalBook.cshtml"
                                                          Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 14 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Shared\_ModalBook.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"money text-white  fs-4\" style=\"text-decoration:line-through\">$");
#nullable restore
#line 17 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Shared\_ModalBook.cshtml"
                                                                                      Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <span class=\"money text-fusion ps-3 fw-bold fs-4\">$");
#nullable restore
#line 18 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Shared\_ModalBook.cshtml"
                                                               Write((Model.Price * (100 - Model.Campaign.DiscountPercent) / 100).ToString("0.##"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 19 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Shared\_ModalBook.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </span>\r\n\r\n\r\n");
            WriteLiteral("        <p class=\"description text-white pt-4\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Shared\_ModalBook.cshtml"
       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <div class=\"variants_selects variants_margin\">\r\n            <div class=\"quickview-plus-minus d-flex align-items-center pt-4\">\r\n                <div class=\"quickview-btn-cart ps-4\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1298, "\"", 1332, 2);
            WriteAttributeValue("", 1305, "/basket/addbasket/", 1305, 18, true);
#nullable restore
#line 32 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Shared\_ModalBook.cshtml"
WriteAttributeValue("", 1323, Model.Id, 1323, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""bg-grey px-3 py-2 hover3 t-5 border-0""
                       style=""outline: none;color:white;text-decoration:none;"">
                        Add to Cart
                    </a>
                </div>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
