#pragma checksum "C:\Users\João Paulo\source\repos\Caloric\Caloric\Views\CaracteristicasFisicas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bd49c70a9aeacbefc4ac9dd9ea7c962143f095e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CaracteristicasFisicas_Details), @"mvc.1.0.view", @"/Views/CaracteristicasFisicas/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bd49c70a9aeacbefc4ac9dd9ea7c962143f095e", @"/Views/CaracteristicasFisicas/Details.cshtml")]
    public class Views_CaracteristicasFisicas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Caloric.Models.CaracteristicasFisicas>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\João Paulo\source\repos\Caloric\Caloric\Views\CaracteristicasFisicas\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>CaracteristicasFisicas</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\João Paulo\source\repos\Caloric\Caloric\Views\CaracteristicasFisicas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Altura));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\João Paulo\source\repos\Caloric\Caloric\Views\CaracteristicasFisicas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Altura));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\João Paulo\source\repos\Caloric\Caloric\Views\CaracteristicasFisicas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Peso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\João Paulo\source\repos\Caloric\Caloric\Views\CaracteristicasFisicas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Peso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\João Paulo\source\repos\Caloric\Caloric\Views\CaracteristicasFisicas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Biotipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\João Paulo\source\repos\Caloric\Caloric\Views\CaracteristicasFisicas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Biotipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\João Paulo\source\repos\Caloric\Caloric\Views\CaracteristicasFisicas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PessoaId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\João Paulo\source\repos\Caloric\Caloric\Views\CaracteristicasFisicas\Details.cshtml"
       Write(Html.DisplayFor(model => model.PessoaId.PessoasId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1081, "\"", 1119, 1);
#nullable restore
#line 40 "C:\Users\João Paulo\source\repos\Caloric\Caloric\Views\CaracteristicasFisicas\Details.cshtml"
WriteAttributeValue("", 1096, Model.CaracteFisicasId, 1096, 23, false);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Caloric.Models.CaracteristicasFisicas> Html { get; private set; }
    }
}
#pragma warning restore 1591
