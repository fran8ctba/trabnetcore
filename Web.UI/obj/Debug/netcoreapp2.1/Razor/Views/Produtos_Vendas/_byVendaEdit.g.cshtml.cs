#pragma checksum "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Produtos_Vendas\_byVendaEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54f54224f3d5ce695f24855ee560e933f5b8363e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produtos_Vendas__byVendaEdit), @"mvc.1.0.view", @"/Views/Produtos_Vendas/_byVendaEdit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produtos_Vendas/_byVendaEdit.cshtml", typeof(AspNetCore.Views_Produtos_Vendas__byVendaEdit))]
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
#line 1 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\_ViewImports.cshtml"
using Web.UI;

#line default
#line hidden
#line 3 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\_ViewImports.cshtml"
using Web.UI.Models;

#line default
#line hidden
#line 4 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\_ViewImports.cshtml"
using Web.UI.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\_ViewImports.cshtml"
using Web.UI.Models.ManageViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54f54224f3d5ce695f24855ee560e933f5b8363e", @"/Views/Produtos_Vendas/_byVendaEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"916cdad7c8602f1298d29c870924a9ecbec6da80", @"/Views/_ViewImports.cshtml")]
    public class Views_Produtos_Vendas__byVendaEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Produto_VendaVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Produtos_Vendas\_byVendaEdit.cshtml"
  
    ViewBag.Title = "_byVenda";

#line default
#line hidden
            BeginContext(79, 61, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(141, 48, false);
#line 10 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Produtos_Vendas\_byVendaEdit.cshtml"
       Write(Html.DisplayNameFor(model => model.Produto.Name));

#line default
#line hidden
            EndContext();
            BeginContext(189, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(233, 53, false);
#line 13 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Produtos_Vendas\_byVendaEdit.cshtml"
       Write(Html.DisplayNameFor(model => model.QuantidadeProduto));

#line default
#line hidden
            EndContext();
            BeginContext(286, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(330, 49, false);
#line 16 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Produtos_Vendas\_byVendaEdit.cshtml"
       Write(Html.DisplayNameFor(model => model.ValorUnitario));

#line default
#line hidden
            EndContext();
            BeginContext(379, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(423, 41, false);
#line 19 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Produtos_Vendas\_byVendaEdit.cshtml"
       Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
            EndContext();
            BeginContext(464, 30, true);
            WriteLiteral("\r\n        </th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 23 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Produtos_Vendas\_byVendaEdit.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(535, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(584, 47, false);
#line 27 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Produtos_Vendas\_byVendaEdit.cshtml"
           Write(Html.DisplayFor(modelItem => item.Produto.Name));

#line default
#line hidden
            EndContext();
            BeginContext(631, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(687, 52, false);
#line 30 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Produtos_Vendas\_byVendaEdit.cshtml"
           Write(Html.DisplayFor(modelItem => item.QuantidadeProduto));

#line default
#line hidden
            EndContext();
            BeginContext(739, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(795, 48, false);
#line 33 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Produtos_Vendas\_byVendaEdit.cshtml"
           Write(Html.DisplayFor(modelItem => item.ValorUnitario));

#line default
#line hidden
            EndContext();
            BeginContext(843, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(899, 40, false);
#line 36 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Produtos_Vendas\_byVendaEdit.cshtml"
           Write(Html.DisplayFor(modelItem => item.Total));

#line default
#line hidden
            EndContext();
            BeginContext(939, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(995, 201, false);
#line 39 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Produtos_Vendas\_byVendaEdit.cshtml"
           Write(Html.ActionLink("Edit", "Edit", "Produtos_Vemdas", new { Href = "#", data_toggle = "modal", data_target = "#produto_vendaModal", data_url = Url.Action("Edit", "Produtos_Vendas", new { id = item.Id}) }));

#line default
#line hidden
            EndContext();
            BeginContext(1196, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1217, 208, false);
#line 40 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Produtos_Vendas\_byVendaEdit.cshtml"
           Write(Html.ActionLink("Delete", "Delete", "Produtos_Vendas", new { Href = "#", data_toggle = "modal", data_target = "#produto_vendaModal", data_url = Url.Action("Delete", "Produtos_Vendas", new { id = item.Id }) }));

#line default
#line hidden
            EndContext();
            BeginContext(1425, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 43 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Produtos_Vendas\_byVendaEdit.cshtml"
    }

#line default
#line hidden
            BeginContext(1468, 582, true);
            WriteLiteral(@"
</table>

<div class=""modal fade"" id=""produto_vendaModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""modal"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                <h4 class=""modal-title"" id=""modal"">Produto_Venda</h4>
            </div>
            <div class=""modal-body"" id=""produto_vendaModalBody""></div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Produto_VendaVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
