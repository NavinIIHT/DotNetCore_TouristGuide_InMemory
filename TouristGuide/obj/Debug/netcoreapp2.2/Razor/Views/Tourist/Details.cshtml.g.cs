#pragma checksum "D:\IIHT DATA\InMemory Artifacts_3.0\TouristGuide_CleanCode\TouristGuide\Views\Tourist\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82266594927d2a54a653b77726eec85bc955d183"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tourist_Details), @"mvc.1.0.view", @"/Views/Tourist/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tourist/Details.cshtml", typeof(AspNetCore.Views_Tourist_Details))]
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
#line 1 "D:\IIHT DATA\InMemory Artifacts_3.0\TouristGuide_CleanCode\TouristGuide\Views\_ViewImports.cshtml"
using TouristGuide;

#line default
#line hidden
#line 2 "D:\IIHT DATA\InMemory Artifacts_3.0\TouristGuide_CleanCode\TouristGuide\Views\_ViewImports.cshtml"
using TouristGuide.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82266594927d2a54a653b77726eec85bc955d183", @"/Views/Tourist/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42e6067a946f12667a5bca57837da501ff6d5d30", @"/Views/_ViewImports.cshtml")]
    public class Views_Tourist_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TouristGuide.Entities.Place>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\IIHT DATA\InMemory Artifacts_3.0\TouristGuide_CleanCode\TouristGuide\Views\Tourist\Details.cshtml"
  
    ViewData["Title"] = "Place Details";

#line default
#line hidden
            BeginContext(85, 498, true);
            WriteLiteral(@"<div class=""card"" style=""width:100%; margin-top:10px;"">
    <div class=""card-header bg-dark text-white"">
        <h5>Place Details</h5>
    </div>
    <div class=""card-body"">
        <div class=""row mb-2"">
            <div class=""col-md-12"">
                <div class=""card flex-md-row mb-4 box-shadow h-auto"">
                    <div class=""card-body d-flex flex-column align-items-start"">
                        <strong class=""d-inline-block mb-2 text-primary"">Place By Experiences : ");
            EndContext();
            BeginContext(584, 35, false);
#line 14 "D:\IIHT DATA\InMemory Artifacts_3.0\TouristGuide_CleanCode\TouristGuide\Views\Tourist\Details.cshtml"
                                                                                           Write(Html.DisplayFor(m => m.Experiences));

#line default
#line hidden
            EndContext();
            BeginContext(619, 112, true);
            WriteLiteral("</strong>\r\n                        <h3 class=\"mb-0\">\r\n                            <a class=\"text-dark\" href=\"#\">");
            EndContext();
            BeginContext(732, 28, false);
#line 16 "D:\IIHT DATA\InMemory Artifacts_3.0\TouristGuide_CleanCode\TouristGuide\Views\Tourist\Details.cshtml"
                                                     Write(Html.DisplayFor(m => m.Name));

#line default
#line hidden
            EndContext();
            BeginContext(760, 129, true);
            WriteLiteral("</a>\r\n                        </h3>\r\n                        <div class=\"mb-1 text-muted\"><strong>Place By Attraction : </strong>");
            EndContext();
            BeginContext(890, 34, false);
#line 18 "D:\IIHT DATA\InMemory Artifacts_3.0\TouristGuide_CleanCode\TouristGuide\Views\Tourist\Details.cshtml"
                                                                                       Write(Html.DisplayFor(m => m.Attraction));

#line default
#line hidden
            EndContext();
            BeginContext(924, 61, true);
            WriteLiteral("</div>\r\n                        <p class=\"card-text mb-auto\">");
            EndContext();
            BeginContext(986, 35, false);
#line 19 "D:\IIHT DATA\InMemory Artifacts_3.0\TouristGuide_CleanCode\TouristGuide\Views\Tourist\Details.cshtml"
                                                Write(Html.DisplayFor(m => m.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1021, 119, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(1141, 87, false);
#line 25 "D:\IIHT DATA\InMemory Artifacts_3.0\TouristGuide_CleanCode\TouristGuide\Views\Tourist\Details.cshtml"
       Write(Html.ActionLink("Back to Home", "Index", "Tourist", new { @class = "btn btn-primary" }));

#line default
#line hidden
            EndContext();
            BeginContext(1228, 34, true);
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TouristGuide.Entities.Place> Html { get; private set; }
    }
}
#pragma warning restore 1591
