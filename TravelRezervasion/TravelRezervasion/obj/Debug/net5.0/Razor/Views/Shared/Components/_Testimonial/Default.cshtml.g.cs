#pragma checksum "C:\Users\Berk\Desktop\TravelRezervasion\TravelRezervasion\Views\Shared\Components\_Testimonial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "108be3e30178a53aa7fdc63b58b138517686f7c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__Testimonial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_Testimonial/Default.cshtml")]
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
#line 1 "C:\Users\Berk\Desktop\TravelRezervasion\TravelRezervasion\Views\_ViewImports.cshtml"
using TravelRezervasion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Berk\Desktop\TravelRezervasion\TravelRezervasion\Views\_ViewImports.cshtml"
using TravelRezervasion.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Berk\Desktop\TravelRezervasion\TravelRezervasion\Views\Shared\Components\_Testimonial\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"108be3e30178a53aa7fdc63b58b138517686f7c0", @"/Views/Shared/Components/_Testimonial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38dbb61cc7141861db1fdcd2e86d33fe4aa28650", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__Testimonial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Testimonial>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section class=""w3l-clients"" id=""clients"">
    <!-- /grids -->
    <div class=""cusrtomer-layout py-5"">
        <div class=""container py-lg-4 py-md-3 pb-lg-0"">
            <div class=""heading text-center mx-auto"">
                <h6 class=""sub-title text-center"">Here’s what they have to say</h6>
                <h3 class=""hny-title mb-md-5 mb-4"">our clients do the talking</h3>
            </div>
            <!-- /grids -->
            <div class=""testimonial-width"">
                <div id=""owl-demo1"" class=""owl-two owl-carousel owl-theme"">
");
#nullable restore
#line 15 "C:\Users\Berk\Desktop\TravelRezervasion\TravelRezervasion\Views\Shared\Components\_Testimonial\Default.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""item"">
                    <div class=""testimonial-content"">
                        <div class=""testimonial"">
                            <blockquote>
                                <span class=""fa fa-quote-left"" aria-hidden=""true""></span>
                                ");
#nullable restore
#line 22 "C:\Users\Berk\Desktop\TravelRezervasion\TravelRezervasion\Views\Shared\Components\_Testimonial\Default.cshtml"
                           Write(item.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </blockquote>\n                            <div class=\"testi-des\">\n                                <div class=\"test-img\">\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 1177, "\"", 1200, 1);
#nullable restore
#line 26 "C:\Users\Berk\Desktop\TravelRezervasion\TravelRezervasion\Views\Shared\Components\_Testimonial\Default.cshtml"
WriteAttributeValue("", 1183, item.ClientImage, 1183, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" alt=\"client-img\">\n                                </div>\n                                <div class=\"peopl align-self\">\n                                    <h3>");
#nullable restore
#line 29 "C:\Users\Berk\Desktop\TravelRezervasion\TravelRezervasion\Views\Shared\Components\_Testimonial\Default.cshtml"
                                   Write(item.Client);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                                    <p class=\"indentity\">Example City</p>\n                                </div>\n                            </div>\n                        </div>\n                    </div>\n\n                </div>");
#nullable restore
#line 36 "C:\Users\Berk\Desktop\TravelRezervasion\TravelRezervasion\Views\Shared\Components\_Testimonial\Default.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n        </div>\n        <!-- /grids -->\n    </div>\n    <!-- //grids -->\n</section>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Testimonial>> Html { get; private set; }
    }
}
#pragma warning restore 1591