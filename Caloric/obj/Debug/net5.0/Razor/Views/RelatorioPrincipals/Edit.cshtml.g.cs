#pragma checksum "C:\Users\João Paulo\source\repos\Caloric\Caloric\Views\RelatorioPrincipals\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f33aa43bda8d0fa6ac52df38cc7e902bb20c383"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RelatorioPrincipals_Edit), @"mvc.1.0.view", @"/Views/RelatorioPrincipals/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f33aa43bda8d0fa6ac52df38cc7e902bb20c383", @"/Views/RelatorioPrincipals/Edit.cshtml")]
    public class Views_RelatorioPrincipals_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Caloric.Models.RelatorioPrincipal>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\João Paulo\source\repos\Caloric\Caloric\Views\RelatorioPrincipals\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>RelatorioPrincipal</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""RelatorioPrincipalId"" />
            <div class=""form-group"">
                <label asp-for=""PessoasId"" class=""control-label""></label>
                <select asp-for=""PessoasId"" class=""form-control"" asp-items=""ViewBag.PessoasId""></select>
                <span asp-validation-for=""PessoasId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\Users\João Paulo\source\repos\Caloric\Caloric\Views\RelatorioPrincipals\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
