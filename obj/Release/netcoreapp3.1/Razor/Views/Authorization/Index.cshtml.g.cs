#pragma checksum "C:\Users\mlaym\OneDrive\Документы\GitHub\Psychology\Views\Authorization\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53ad7a4e07842d1b811a9b5f1c7686c4f7570813"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authorization_Index), @"mvc.1.0.view", @"/Views/Authorization/Index.cshtml")]
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
#line 1 "C:\Users\mlaym\OneDrive\Документы\GitHub\Psychology\Views\_ViewImports.cshtml"
using Psychology;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mlaym\OneDrive\Документы\GitHub\Psychology\Views\_ViewImports.cshtml"
using Psychology.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\mlaym\OneDrive\Документы\GitHub\Psychology\Views\Authorization\Index.cshtml"
using Psychology.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53ad7a4e07842d1b811a9b5f1c7686c4f7570813", @"/Views/Authorization/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"639ce787e3b9395d23e60e3d857c35ac7374684a", @"/Views/_ViewImports.cshtml")]
    public class Views_Authorization_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AuthorizationViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\mlaym\OneDrive\Документы\GitHub\Psychology\Views\Authorization\Index.cshtml"
  
    Layout = "_Authorization";
    ViewData["Title"] = "Главная";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p><center>Определитесь, кто Вы, и перейдите на соответствующую вкладку</center></p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AuthorizationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
