#pragma checksum "C:\Users\Mert\source\repos\UdemyProje1\Views\Shared\Components\News\red.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "419993fa02001f6392d0b8c61f2ec610dbf0cfa046eb994679fe909acb9f92d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_News_red), @"mvc.1.0.view", @"/Views/Shared/Components/News/red.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\Mert\source\repos\UdemyProje1\Views\_ViewImports.cshtml"
using UdemyProje1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mert\source\repos\UdemyProje1\Views\_ViewImports.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"419993fa02001f6392d0b8c61f2ec610dbf0cfa046eb994679fe909acb9f92d3", @"/Views/Shared/Components/News/red.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b2743d9716fc86c4c5dce0fcd90d410ab1d5e208f0bfc1431bd8e3506773b6cc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_News_red : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<News>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<ul class=\"list-group\">\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Mert\source\repos\UdemyProje1\Views\Shared\Components\News\red.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-group-item text-danger\" aria-current=\"true\">");
#nullable restore
#line 7 "C:\Users\Mert\source\repos\UdemyProje1\Views\Shared\Components\News\red.cshtml"
                                                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 8 "C:\Users\Mert\source\repos\UdemyProje1\Views\Shared\Components\News\red.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<News>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
