#pragma checksum "C:\Users\AcaPC\source\repos\WebBioskop\WebBioskop\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9550d59387dea09696921325ccfcf37f8c00c39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
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
#line 1 "C:\Users\AcaPC\source\repos\WebBioskop\WebBioskop\Views\_ViewImports.cshtml"
using WebBioskop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AcaPC\source\repos\WebBioskop\WebBioskop\Views\_ViewImports.cshtml"
using WebBioskop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9550d59387dea09696921325ccfcf37f8c00c39", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2f7556788d189cf58b10fda801d257b6aa0788a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebBioskop.Models.Collection>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2 class=\"text-white\">Movies with \"");
#nullable restore
#line 2 "C:\Users\AcaPC\source\repos\WebBioskop\WebBioskop\Views\Home\Search.cshtml"
                               Write(ViewBag.inputSrch);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" filter</h2>\r\n<hr style=\"border-color:white;\" />\r\n\r\n<br />\r\n\r\n<div class=\"container-fluid\">\r\n    <div class=\"grid-container\">\r\n\r\n");
#nullable restore
#line 10 "C:\Users\AcaPC\source\repos\WebBioskop\WebBioskop\Views\Home\Search.cshtml"
         foreach (var item in Model.Movies)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 287, "\"", 321, 2);
            WriteAttributeValue("", 294, "/Movie/Review/", 294, 14, true);
#nullable restore
#line 12 "C:\Users\AcaPC\source\repos\WebBioskop\WebBioskop\Views\Home\Search.cshtml"
WriteAttributeValue("", 308, item.movieId, 308, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""text-decoration:none;"">
            <div class=""bg-dark d-inline-block"" style=""width:190px;height:370px;border-radius:8px;margin-left:7px;margin-top:7px;"">

                <div style=""width:180px;height:220px;padding:15px;margin-left:4px;"">
                    <img id=""kartica"" class=""card-img-top"" style=""height:200px;""");
            BeginWriteAttribute("src", " src=\"", 656, "\"", 735, 2);
            WriteAttributeValue("", 662, "https://image.tmdb.org/t/p/w185/", 662, 32, true);
#nullable restore
#line 16 "C:\Users\AcaPC\source\repos\WebBioskop\WebBioskop\Views\Home\Search.cshtml"
WriteAttributeValue("", 694, Html.DisplayFor(model=>item.poster_path), 694, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div style=\"width:180px;height:60px;padding-top:5px;font-weight:bold;\">\r\n                    <p style=\"color:white;text-align:center;\">");
#nullable restore
#line 19 "C:\Users\AcaPC\source\repos\WebBioskop\WebBioskop\Views\Home\Search.cshtml"
                                                         Write(Html.DisplayFor(model => item.title));

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 19 "C:\Users\AcaPC\source\repos\WebBioskop\WebBioskop\Views\Home\Search.cshtml"
                                                                                                Write(Html.DisplayFor(model => item.release_date.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral(")</p>\r\n                </div>\r\n                <div style=\"width:180px;height:80px; padding-left:20px;\">\r\n                    <p style=\"color:white;text-align:left;\"><i class=\"fa fa-star\" style=\"color:yellow; margin-right:3px;\" aria-hidden=\"true\"></i>");
#nullable restore
#line 22 "C:\Users\AcaPC\source\repos\WebBioskop\WebBioskop\Views\Home\Search.cshtml"
                                                                                                                                            Write(Html.DisplayFor(model => item.vote_average));

#line default
#line hidden
#nullable disable
            WriteLiteral("/10 (");
#nullable restore
#line 22 "C:\Users\AcaPC\source\repos\WebBioskop\WebBioskop\Views\Home\Search.cshtml"
                                                                                                                                                                                             Write(Html.DisplayFor(model => item.vote_count));

#line default
#line hidden
#nullable disable
            WriteLiteral(")</p>\r\n                    <hr />\r\n                    <p style=\"color:white;text-align:left;padding-right:20px;\"></p>\r\n                </div>\r\n            </div>\r\n        </a>\r\n");
#nullable restore
#line 28 "C:\Users\AcaPC\source\repos\WebBioskop\WebBioskop\Views\Home\Search.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <br />\r\n\r\n</div>\r\n<hr style=\"border-color:white;\" />\r\n<h2 class=\"text-white\">Series with \"");
#nullable restore
#line 37 "C:\Users\AcaPC\source\repos\WebBioskop\WebBioskop\Views\Home\Search.cshtml"
                               Write(ViewBag.inputSrch);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" filter</h2>\r\n<hr style=\"border-color:white;\" />\r\n\r\n<br />\r\n\r\n<div class=\"container-fluid\">\r\n    <div class=\"grid-container\">\r\n\r\n");
#nullable restore
#line 45 "C:\Users\AcaPC\source\repos\WebBioskop\WebBioskop\Views\Home\Search.cshtml"
         foreach (var item in Model.Series)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 1861, "\"", 1895, 2);
            WriteAttributeValue("", 1868, "/Serie/Review/", 1868, 14, true);
#nullable restore
#line 47 "C:\Users\AcaPC\source\repos\WebBioskop\WebBioskop\Views\Home\Search.cshtml"
WriteAttributeValue("", 1882, item.serieId, 1882, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""text-decoration:none;"">
            <div class=""bg-dark d-inline-block"" style=""width:190px;height:370px;border-radius:8px;margin-left:7px;margin-top:7px;"">

                <div style=""width:180px;height:220px;padding:15px;margin-left:4px;"">
                    <img id=""kartica"" class=""card-img-top"" style=""height:200px;""");
            BeginWriteAttribute("src", " src=\"", 2230, "\"", 2309, 2);
            WriteAttributeValue("", 2236, "https://image.tmdb.org/t/p/w185/", 2236, 32, true);
#nullable restore
#line 51 "C:\Users\AcaPC\source\repos\WebBioskop\WebBioskop\Views\Home\Search.cshtml"
WriteAttributeValue("", 2268, Html.DisplayFor(model=>item.poster_path), 2268, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div style=\"width:180px;height:60px;padding-top:5px;font-weight:bold;\">\r\n                    <p style=\"color:white;text-align:center;\">");
#nullable restore
#line 54 "C:\Users\AcaPC\source\repos\WebBioskop\WebBioskop\Views\Home\Search.cshtml"
                                                         Write(Html.DisplayFor(model => item.name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 54 "C:\Users\AcaPC\source\repos\WebBioskop\WebBioskop\Views\Home\Search.cshtml"
                                                                                               Write(Html.DisplayFor(model => item.first_air_date.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral(")</p>\r\n                </div>\r\n                <div style=\"width:180px;height:80px; padding-left:20px;\">\r\n                    <p style=\"color:white;text-align:left;\"><i class=\"fa fa-star\" style=\"color:yellow; margin-right:3px;\" aria-hidden=\"true\"></i>");
#nullable restore
#line 57 "C:\Users\AcaPC\source\repos\WebBioskop\WebBioskop\Views\Home\Search.cshtml"
                                                                                                                                            Write(Html.DisplayFor(model => item.vote_average));

#line default
#line hidden
#nullable disable
            WriteLiteral("/10 (");
#nullable restore
#line 57 "C:\Users\AcaPC\source\repos\WebBioskop\WebBioskop\Views\Home\Search.cshtml"
                                                                                                                                                                                             Write(Html.DisplayFor(model => item.vote_count));

#line default
#line hidden
#nullable disable
            WriteLiteral(")</p>\r\n                    <hr />\r\n                    <p style=\"color:white;text-align:left;padding-right:20px;\"></p>\r\n                </div>\r\n            </div>\r\n        </a>\r\n");
#nullable restore
#line 63 "C:\Users\AcaPC\source\repos\WebBioskop\WebBioskop\Views\Home\Search.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <br />\r\n    \r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebBioskop.Models.Collection> Html { get; private set; }
    }
}
#pragma warning restore 1591
