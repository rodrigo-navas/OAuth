#pragma checksum "C:\_DiscoLocal\GIT\GitHub\OAuth\Site\OAuth.Site\Views\Account\MinhaConta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "611d381e8f65507c7b890f4c7955118cd72a09d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_MinhaConta), @"mvc.1.0.view", @"/Views/Account/MinhaConta.cshtml")]
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
#line 1 "C:\_DiscoLocal\GIT\GitHub\OAuth\Site\OAuth.Site\Views\_ViewImports.cshtml"
using OAuth.Site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\_DiscoLocal\GIT\GitHub\OAuth\Site\OAuth.Site\Views\_ViewImports.cshtml"
using OAuth.Site.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"611d381e8f65507c7b890f4c7955118cd72a09d7", @"/Views/Account/MinhaConta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"986afeb30b78bbc72975044497dd73d939d1c5d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_MinhaConta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\_DiscoLocal\GIT\GitHub\OAuth\Site\OAuth.Site\Views\Account\MinhaConta.cshtml"
   ViewData["Title"] = "Minha Conta";
    Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container main-container headerOffset\">\n    <div class=\"row\">\n        <div class=\"breadcrumbDiv col-lg-12\">\n            <ul class=\"breadcrumb\">\n                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "611d381e8f65507c7b890f4c7955118cd72a09d74118", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                <li class=""active""> Minha conta</li>
            </ul>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-lg-9 col-md-9 col-sm-7"">
            <h1 class=""section-title-inner""><span><i class=""fa fa-unlock-alt""></i> Minha conta </span></h1>

            <div class=""row userInfo"">
                <div class=""col-xs-12 col-sm-12"">
                    <h2 class=""block-title-2"">
                        <span>Bem vindo a sua conta. Aqui você consegue gerenciar seus dados pessoais.</span>
                    </h2>
                    <ul class=""myAccountList row "">
                        <li class=""col-lg-2 col-md-2 col-sm-3 col-xs-4  text-center "">
                            <div class=""thumbnail"">
                                <a title=""My addresses"" href=""my-address.html"">
                                    <i class=""fa fa-map-marker""></i> Meus endereços
                                </a>
                            </div>
                        </li>
            ");
            WriteLiteral(@"            <li class=""col-lg-2 col-md-2 col-sm-3 col-xs-4  text-center "">
                            <div class=""thumbnail"">
                                <a title=""Add  address"" href=""add-address.html"">
                                    <i class=""fa fa-edit""> </i> Adicionar endereços
                                </a>
                            </div>
                        </li>
                        <li class=""col-lg-2 col-md-2 col-sm-3 col-xs-4  text-center "">
                            <div class=""thumbnail"">
                                <a title=""Personal information""
                                   href=""user-information.html"">
                                    <i class=""fa fa-cog""></i>
                                    Informações pessoais
                                </a>
                            </div>
                        </li>
                    </ul>
                    <div class=""clear clearfix""></div>
                </div>
            </div>
            <!--/r");
            WriteLiteral("ow end-->\n\n        </div>\n        <div class=\"col-lg-3 col-md-3 col-sm-5\"></div>\n    </div>\n    <!--/row-->\n\n    <div style=\"clear:both\"></div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
