#pragma checksum "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Shared\_basketPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47d82d98020d3a4ef0576427a383c09f47aaabab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__basketPartial), @"mvc.1.0.view", @"/Views/Shared/_basketPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47d82d98020d3a4ef0576427a383c09f47aaabab", @"/Views/Shared/_basketPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27f1f4c8baf891ff3a4b0f55edd338885cdda375", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__basketPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "basket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("removeb"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration-none text-white border hover3 t-5  py-2 d-block work-sans text-uppercase fw-semibold "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration-none text-white border hover3 t-5 py-2 d-block work-sans text-uppercase fw-semibold mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Basket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Shared\_basketPartial.cshtml"
   BasketVM basket = await layoutService.ShowBasket(); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 5 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Shared\_basketPartial.cshtml"
 if (layoutService.ShowBasket().Result.BasketItems.Count == 0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""cart-wrap"">
    <div class=""dropdown"">
        <div id=""iconCartI"" class=""icon "">
            <span class=""icon-cart"">
                <svg viewBox=""0 0 32 32"" class=""t-5"" xmlns=""http://www.w3.org/2000/svg"">
                    <g id=""Layer_2"" data-name=""Layer 2"">
                        <path d=""m16 17.82a6 6 0 0 1 -5.89-4.82 1 1 0 0 1 1-1.15 1 1 0 0 1 1 .83 4 4 0 0 0 7.83 0 1 1 0 0 1 1-.83 1 1 0 0 1 1 1.15 6 6 0 0 1 -5.94 4.82z"">
                        </path>
                        <path d=""m24.9 31h-17.8a3 3 0 0 1 -3-3.15l.81-17.24a3 3 0 0 1 3-2.87h16.18a3 3 0 0 1 3 2.87l.81 17.24a3 3 0 0 1 -3 3.15zm-16.99-21.25a1 1 0 0 0 -1 1l-.81 17.2a1 1 0 0 0 1 1.05h17.8a1 1 0 0 0 1-1.05l-.81-17.24a1 1 0 0 0 -1-1z"">
                        </path>
                        <path d=""m22 8.75h-2v-1.75a4 4 0 0 0 -8 0v1.75h-2v-1.75a6 6 0 0 1 12 0z""></path>
                    </g>
                </svg>
                <span class=""count-style bigcounter"">0</span>
            </span>
        </div>
        <ul");
            WriteLiteral(" class=\"cartDropDown text-start list-unstyled\">\n            <li");
            BeginWriteAttribute("class", " class=\"", 1271, "\"", 1279, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                <div class=\"shopping-cart-content\">\n                    <div class=\"d-flex px-4 align-items-center justify-content-between\">\n                        <h5 class=\"text-white py-4\">Shopping Cart</h5>\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1520, "\"", 1527, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""cart-close "">
                            <i class=""fa-regular fa-circle-xmark hover2 t-5 text-white""></i>
                        </a>
                    </div>

                    <ul class=""scrollbasket bg-myrtle"">
                        <li style=""list-style:none;"" class=""item "">
                            <div class="" pt-3 row justify-content-between align-items-center"">

                                <div class=""col-lg-8 shopping-cart-title"">
                                    <h4>
                                        <a");
            BeginWriteAttribute("href", " href=\"", 2078, "\"", 2085, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""text-decoration-none text-white hover2 t-5 fw-normal work-sans "">
                                            Your Cart Is Empty
                                        </a>
                                    </h4>
                                </div>
                            </div>
                        </li>
                    </ul>
                </div>
            </li>
        </ul>
    </div>
</div>
");
#nullable restore
#line 53 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Shared\_basketPartial.cshtml"
                
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""cart-wrap"">
                    <div class=""dropdown"">
                        <div id=""iconCartI"" class=""icon "">
                            <span class=""icon-cart"">
                                <svg viewBox=""0 0 32 32"" class=""t-5"" xmlns=""http://www.w3.org/2000/svg"">
                                    <g id=""Layer_2"" data-name=""Layer 2"">
                                        <path d=""m16 17.82a6 6 0 0 1 -5.89-4.82 1 1 0 0 1 1-1.15 1 1 0 0 1 1 .83 4 4 0 0 0 7.83 0 1 1 0 0 1 1-.83 1 1 0 0 1 1 1.15 6 6 0 0 1 -5.94 4.82z"">
                                        </path>
                                        <path d=""m24.9 31h-17.8a3 3 0 0 1 -3-3.15l.81-17.24a3 3 0 0 1 3-2.87h16.18a3 3 0 0 1 3 2.87l.81 17.24a3 3 0 0 1 -3 3.15zm-16.99-21.25a1 1 0 0 0 -1 1l-.81 17.2a1 1 0 0 0 1 1.05h17.8a1 1 0 0 0 1-1.05l-.81-17.24a1 1 0 0 0 -1-1z"">
                                        </path>
                                        <path d=""m22 8.75h-2v-1.75a4 4 0 0 0 -8 0v1.75h-2v-1.75a6 6 0");
            WriteLiteral(" 0 1 12 0z\"></path>\n                                    </g>\n                                </svg>\n                                <span class=\"count-style bigcounter\">");
#nullable restore
#line 70 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Shared\_basketPartial.cshtml"
                                                                Write(basket.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                            </span>\n                        </div>\n                        <ul class=\"cartDropDown text-start list-unstyled\">\n                            <li");
            BeginWriteAttribute("class", " class=\"", 3926, "\"", 3934, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <div class=""shopping-cart-content"">
                                    <div class=""d-flex px-4 align-items-center justify-content-between"">
                                        <h5 class=""text-white py-4"">Shopping Cart</h5>
                                        <a");
            BeginWriteAttribute("href", " href=\"", 4239, "\"", 4246, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""cart-close "">
                                            <i class=""fa-regular fa-circle-xmark hover2 t-5 text-white""></i>
                                        </a>
                                    </div>

                                    <ul class=""scrollbasket bg-myrtle"">
");
#nullable restore
#line 84 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Shared\_basketPartial.cshtml"
                                         foreach (var item in layoutService.ShowBasket().Result.BasketItems)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li style=""list-style:none;"" class=""item "">
                            <div class="" pt-3 row justify-content-between align-items-center"">
                                <div class=""col-lg-4 shopping-cart-img position-relative text-start"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 4993, "\"", 5026, 2);
            WriteAttributeValue("", 5000, "/shop/detail/", 5000, 13, true);
#nullable restore
#line 89 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Shared\_basketPartial.cshtml"
WriteAttributeValue("", 5013, item.Book.Id, 5013, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 5027, "\"", 5035, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "47d82d98020d3a4ef0576427a383c09f47aaabab14146", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5088, "~/assets/img/feature-collection/", 5088, 32, true);
#nullable restore
#line 90 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Shared\_basketPartial.cshtml"
AddHtmlAttributeValue("", 5120, item.Book.ImageUrl, 5120, 19, false);

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
            WriteLiteral("\n                                    </a>\n                                    <div class=\"item-close\">\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47d82d98020d3a4ef0576427a383c09f47aaabab15978", async() => {
                WriteLiteral("\n                                            <i class=\"fa-regular fa-circle-xmark text-white\"></i>\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Shared\_basketPartial.cshtml"
                                                                                         WriteLiteral(item.Book.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    </div>\n                                </div>\n                                <div class=\"col-lg-8 shopping-cart-title\">\n                                    <h4>\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 5781, "\"", 5814, 2);
            WriteAttributeValue("", 5788, "/shop/detail/", 5788, 13, true);
#nullable restore
#line 100 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Shared\_basketPartial.cshtml"
WriteAttributeValue("", 5801, item.Book.Id, 5801, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-decoration-none text-white hover2 t-5 fw-normal work-sans \">\n                                            ");
#nullable restore
#line 101 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Shared\_basketPartial.cshtml"
                                       Write(item.Book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </a>\n                                    </h4>\n                                    <span class=\"text-white fw-semibold ls-1\">\n                                        ");
#nullable restore
#line 105 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Shared\_basketPartial.cshtml"
                                   Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" x <span class=\"money fw-semibold ls-1\">\n                                            $");
#nullable restore
#line 106 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Shared\_basketPartial.cshtml"
                                              if (item.Book.CampaignId == null)
                                            {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Shared\_basketPartial.cshtml"
                   Write(item.Book.Price);

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Shared\_basketPartial.cshtml"
                                         }
                    else
                    { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Shared\_basketPartial.cshtml"
                  Write(item.Book.Price * (100 - item.Book.Campaign.DiscountPercent) / 100);

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Shared\_basketPartial.cshtml"
                                                                                           }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </span>\n                                    </span>\n                                </div>\n                            </div>\n                        </li>");
#nullable restore
#line 115 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Shared\_basketPartial.cshtml"
                             }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </ul>
                                    <ul class=""list-unstyled"">
                                        <li class=""px-4 pb-5"">
                                            <div class=""single-product-cart cart-bottom"">
                                                <div class=""shopping-cart-total py-2 border-top"">
                                                    <h4 class=""text-white fw-light  work-sans d-flex justify-content-between align-items-center"">
                                                        <span");
            BeginWriteAttribute("class", " class=\"", 7254, "\"", 7262, 0);
            EndWriteAttribute();
            WriteLiteral(">Total:</span>\n                                                        <span class=\"work-sans\">$");
#nullable restore
#line 123 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Shared\_basketPartial.cshtml"
                                                                            Write(basket.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                    </h4>
                                                </div>
                                                <div class=""shopping-cart-btn btn-hover text-center"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47d82d98020d3a4ef0576427a383c09f47aaabab23449", async() => {
                WriteLiteral("Checkout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47d82d98020d3a4ef0576427a383c09f47aaabab24946", async() => {
                WriteLiteral("View Cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                </div>
                                            </div>
                                        </li>
                                    </ul>


                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
");
#nullable restore
#line 140 "C:\Users\Lenovo\Desktop\25.01.2023-main\Boake-BackEnd\Views\Shared\_basketPartial.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"




<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script src=""//cdn.jsdelivr.net/npm/sweetalert2@11""></script>
<script>
    $("".removeb"").click(function (e) {
        e.preventDefault()
        console.log($(this).attr(""href""))
        Swal.fire({
            title: 'Are you Sure?',
            text: ""There is no way back!"",
            icon: 'Xəbərdarlıq',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Yes delete it!'
        }).then((result) => {
            if (result.isConfirmed) {
                var link = $(this).attr(""href"");
                fetch(link).then(response => response.json()).then(data => {
                    if (data.status == 200) {
                        location.reload(true)
                    } else {
                        Swal.fire(
                            'Tapılmadı!',
                            'Fayl silinmiş ola bilər.',
     ");
            WriteLiteral("                       \'Uğursuz cəhd\'\n                        )\n                    }\n                });\n            }\n        })\n    })\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Boake_BackEnd.Services.LayoutService layoutService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
