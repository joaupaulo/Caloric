#pragma checksum "C:\Users\João Paulo\source\repos\Caloric\Caloric\Views\RelatorioPrincipals\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd34b4ca5d32ebe117687f44fe0037cf3465cc7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RelatorioPrincipals_Details), @"mvc.1.0.view", @"/Views/RelatorioPrincipals/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd34b4ca5d32ebe117687f44fe0037cf3465cc7a", @"/Views/RelatorioPrincipals/Details.cshtml")]
    public class Views_RelatorioPrincipals_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Caloric.Models.RelatorioPrincipal>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\João Paulo\source\repos\Caloric\Caloric\Views\RelatorioPrincipals\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>RelatorioPrincipal</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\João Paulo\source\repos\Caloric\Caloric\Views\RelatorioPrincipals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pessoas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\João Paulo\source\repos\Caloric\Caloric\Views\RelatorioPrincipals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pessoas.PessoasId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 452, "\"", 494, 1);
#nullable restore
#line 22 "C:\Users\João Paulo\source\repos\Caloric\Caloric\Views\RelatorioPrincipals\Details.cshtml"
WriteAttributeValue("", 467, Model.RelatorioPrincipalId, 467, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Caloric.Models.RelatorioPrincipal> Html { get; private set; }
    }
}
#pragma warning restore 1591