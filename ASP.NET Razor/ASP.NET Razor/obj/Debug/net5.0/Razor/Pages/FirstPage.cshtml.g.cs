#pragma checksum "E:\File năm 3 kì 2\Lập trình web nâng cao (1)\ASP.NET Razor\ASP.NET Razor\Pages\FirstPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "732694edbc5cd4907ef06e71b450555996011f22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_FirstPage), @"mvc.1.0.razor-page", @"/Pages/FirstPage.cshtml")]
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
#line 2 "E:\File năm 3 kì 2\Lập trình web nâng cao (1)\ASP.NET Razor\ASP.NET Razor\Pages\FirstPage.cshtml"
using ASP.NET_Razor.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/trang-dau-tien/{solanlap:int?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"732694edbc5cd4907ef06e71b450555996011f22", @"/Pages/FirstPage.cshtml")]
    #nullable restore
    public class Pages_FirstPage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("    <h1 style=\"color:orangered\">");
#nullable restore
#line 6 "E:\File năm 3 kì 2\Lập trình web nâng cao (1)\ASP.NET Razor\ASP.NET Razor\Pages\FirstPage.cshtml"
                           Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h2>");
#nullable restore
#line 7 "E:\File năm 3 kì 2\Lập trình web nâng cao (1)\ASP.NET Razor\ASP.NET Razor\Pages\FirstPage.cshtml"
   Write(ViewData["mydata"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <p>Học lập trình ASP.NET Core (<strong>");
#nullable restore
#line 8 "E:\File năm 3 kì 2\Lập trình web nâng cao (1)\ASP.NET Razor\ASP.NET Razor\Pages\FirstPage.cshtml"
                                      Write(System.DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>)</p>\r\n");
#nullable restore
#line 9 "E:\File năm 3 kì 2\Lập trình web nâng cao (1)\ASP.NET Razor\ASP.NET Razor\Pages\FirstPage.cshtml"

    var a = 2;
    int b = 3;

    var solanlapstring = this.Request.RouteValues["solanlap"] ?? "0";

    int solanlap = Int32.Parse(solanlapstring.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p> Can bac hai cua ");
#nullable restore
#line 16 "E:\File năm 3 kì 2\Lập trình web nâng cao (1)\ASP.NET Razor\ASP.NET Razor\Pages\FirstPage.cshtml"
                   Write(a);

#line default
#line hidden
#nullable disable
            WriteLiteral(" la ");
#nullable restore
#line 16 "E:\File năm 3 kì 2\Lập trình web nâng cao (1)\ASP.NET Razor\ASP.NET Razor\Pages\FirstPage.cshtml"
                         Write(Math.Sqrt(a));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Tong cuar ");
#nullable restore
#line 17 "E:\File năm 3 kì 2\Lập trình web nâng cao (1)\ASP.NET Razor\ASP.NET Razor\Pages\FirstPage.cshtml"
            Write(a);

#line default
#line hidden
#nullable disable
            WriteLiteral(" va ");
#nullable restore
#line 17 "E:\File năm 3 kì 2\Lập trình web nâng cao (1)\ASP.NET Razor\ASP.NET Razor\Pages\FirstPage.cshtml"
                  Write(b);

#line default
#line hidden
#nullable disable
            WriteLiteral(" la ");
#nullable restore
#line 17 "E:\File năm 3 kì 2\Lập trình web nâng cao (1)\ASP.NET Razor\ASP.NET Razor\Pages\FirstPage.cshtml"
                         Write(a + b);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
            WriteLiteral("\r\n\r\n<ol>\r\n");
#nullable restore
#line 24 "E:\File năm 3 kì 2\Lập trình web nâng cao (1)\ASP.NET Razor\ASP.NET Razor\Pages\FirstPage.cshtml"
     for (int i = 1; i <= solanlap; i++)
    {
        // ...

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>Muc thu ");
#nullable restore
#line 27 "E:\File năm 3 kì 2\Lập trình web nâng cao (1)\ASP.NET Razor\ASP.NET Razor\Pages\FirstPage.cshtml"
               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 28 "E:\File năm 3 kì 2\Lập trình web nâng cao (1)\ASP.NET Razor\ASP.NET Razor\Pages\FirstPage.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ol>\r\n\r\n<p>");
#nullable restore
#line 31 "E:\File năm 3 kì 2\Lập trình web nâng cao (1)\ASP.NET Razor\ASP.NET Razor\Pages\FirstPage.cshtml"
Write(Model.Welcome("Vu Van Hung"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FirstPage> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FirstPage> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FirstPage>)PageContext?.ViewData;
        public FirstPage Model => ViewData.Model;
    }
}
#pragma warning restore 1591