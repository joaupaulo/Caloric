#pragma checksum "C:\Users\João Paulo\source\repos\Caloric\Caloric\Views\NutrientesAlimentos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "559ccde57e02f451a590876717243be5ac7b4515"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NutrientesAlimentos_Index), @"mvc.1.0.view", @"/Views/NutrientesAlimentos/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"559ccde57e02f451a590876717243be5ac7b4515", @"/Views/NutrientesAlimentos/Index.cshtml")]
    public class Views_NutrientesAlimentos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Caloric.Models.NutrientesAlimentos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\João Paulo\source\repos\Caloric\Caloric\Views\NutrientesAlimentos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\João Paulo\source\repos\Caloric\Caloric\Views\NutrientesAlimentos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Alimentos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\João Paulo\source\repos\Caloric\Caloric\Views\NutrientesAlimentos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nutrientes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "C:\Users\João Paulo\source\repos\Caloric\Caloric\Views\NutrientesAlimentos\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "C:\Users\João Paulo\source\repos\Caloric\Caloric\Views\NutrientesAlimentos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Alimentos.AlimentosId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\João Paulo\source\repos\Caloric\Caloric\Views\NutrientesAlimentos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nutrientes.NutrientesId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\João Paulo\source\repos\Caloric\Caloric\Views\NutrientesAlimentos\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 35 "C:\Users\João Paulo\source\repos\Caloric\Caloric\Views\NutrientesAlimentos\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 36 "C:\Users\João Paulo\source\repos\Caloric\Caloric\Views\NutrientesAlimentos\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 39 "C:\Users\João Paulo\source\repos\Caloric\Caloric\Views\NutrientesAlimentos\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Caloric.Models.NutrientesAlimentos>> Html { get; private set; }
    }
}
#pragma warning restore 1591