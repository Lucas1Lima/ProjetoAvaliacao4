#pragma checksum "C:\Users\lucas\source\repos\WebApplication1\Views\Saidas\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acbab94cddaf2f75af77db618e59d017645f94af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Saidas_Edit), @"mvc.1.0.view", @"/Views/Saidas/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acbab94cddaf2f75af77db618e59d017645f94af", @"/Views/Saidas/Edit.cshtml")]
    public class Views_Saidas_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Pages.Saida.Saidas>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\lucas\source\repos\WebApplication1\Views\Saidas\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Saidas</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""ID"" />
            <div class=""form-group"">
                <label asp-for=""ValorSaida"" class=""control-label""></label>
                <input asp-for=""ValorSaida"" class=""form-control"" />
                <span asp-validation-for=""ValorSaida"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""NomeSaida"" class=""control-label""></label>
                <input asp-for=""NomeSaida"" class=""form-control"" />
                <span asp-validation-for=""NomeSaida"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""HoraSaida"" class=""control-label""></label>
                <input asp-for=""HoraSaida"" class=""form-control"" />
                <sp");
            WriteLiteral(@"an asp-validation-for=""HoraSaida"" class=""text-danger""></span>
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
#line 43 "C:\Users\lucas\source\repos\WebApplication1\Views\Saidas\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Pages.Saida.Saidas> Html { get; private set; }
    }
}
#pragma warning restore 1591
