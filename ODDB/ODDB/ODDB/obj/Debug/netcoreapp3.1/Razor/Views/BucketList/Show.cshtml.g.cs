#pragma checksum "C:\Users\jeroe\Desktop\S2-Software\ODDB\ODDB\ODDB\Views\BucketList\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69c724569e5bc37b9cc728beeb87893652a4cdc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BucketList_Show), @"mvc.1.0.view", @"/Views/BucketList/Show.cshtml")]
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
#line 1 "C:\Users\jeroe\Desktop\S2-Software\ODDB\ODDB\ODDB\Views\_ViewImports.cshtml"
using ODDB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jeroe\Desktop\S2-Software\ODDB\ODDB\ODDB\Views\_ViewImports.cshtml"
using ODDB.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\jeroe\Desktop\S2-Software\ODDB\ODDB\ODDB\Views\BucketList\Show.cshtml"
using ODDB.Common.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69c724569e5bc37b9cc728beeb87893652a4cdc0", @"/Views/BucketList/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f3d94faca526d6a36e35aaf8e411b309afdcad4", @"/Views/_ViewImports.cshtml")]
    public class Views_BucketList_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BucketListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n <table style=\"width:100%\">\r\n        <tr>\r\n            <th>Naam</th>\r\n            <th>Type</th>\r\n            <th>Omschrijving</th>\r\n            <th>Alcohol percentage</th>\r\n        </tr>\r\n");
#nullable restore
#line 11 "C:\Users\jeroe\Desktop\S2-Software\ODDB\ODDB\ODDB\Views\BucketList\Show.cshtml"
         foreach (Drank drank in Model.Drankjes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 14 "C:\Users\jeroe\Desktop\S2-Software\ODDB\ODDB\ODDB\Views\BucketList\Show.cshtml"
           Write(drank.Naam);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>");
#nullable restore
#line 15 "C:\Users\jeroe\Desktop\S2-Software\ODDB\ODDB\ODDB\Views\BucketList\Show.cshtml"
           Write(drank.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\jeroe\Desktop\S2-Software\ODDB\ODDB\ODDB\Views\BucketList\Show.cshtml"
           Write(drank.Omschrijving);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\jeroe\Desktop\S2-Software\ODDB\ODDB\ODDB\Views\BucketList\Show.cshtml"
           Write(drank.AlcoholPecentage);

#line default
#line hidden
#nullable disable
            WriteLiteral(" % </td>\r\n        </tr>\r\n");
#nullable restore
#line 19 "C:\Users\jeroe\Desktop\S2-Software\ODDB\ODDB\ODDB\Views\BucketList\Show.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BucketListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591