#pragma checksum "E:\Programs\SimpleNews\SimpleNews\Views\Main\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e18ca571c0b9582feb3cfb13505cc536a1d45c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Index), @"mvc.1.0.view", @"/Views/Main/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Main/Index.cshtml", typeof(AspNetCore.Views_Main_Index))]
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
#line 1 "E:\Programs\SimpleNews\SimpleNews\Views\_ViewImports.cshtml"
using SimpleNews;

#line default
#line hidden
#line 2 "E:\Programs\SimpleNews\SimpleNews\Views\_ViewImports.cshtml"
using SimpleNews.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e18ca571c0b9582feb3cfb13505cc536a1d45c8", @"/Views/Main/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5058051dc9a7eb7f8937a4e12e681d689252e6a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<News>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewNews", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Main", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(67, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 6 "E:\Programs\SimpleNews\SimpleNews\Views\Main\Index.cshtml"
  
    ViewData["Title"] = "Simple News";

#line default
#line hidden
            BeginContext(120, 222, true);
            WriteLiteral("\r\n    <div class=\"col\">\r\n        <table class=\"table table-striped\">\r\n            <thead>\r\n                <tr>\r\n                    <th scope=\"col\"></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 18 "E:\Programs\SimpleNews\SimpleNews\Views\Main\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(407, 160, true);
            WriteLiteral("                    <tr>\r\n                        <td scope=\"row\">\r\n                            <div>\r\n                                <div class=\"row h4 ml-1\">");
            EndContext();
            BeginContext(567, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e18ca571c0b9582feb3cfb13505cc536a1d45c84658", async() => {
                BeginContext(639, 10, false);
#line 23 "E:\Programs\SimpleNews\SimpleNews\Views\Main\Index.cshtml"
                                                                                                                           Write(item.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 23 "E:\Programs\SimpleNews\SimpleNews\Views\Main\Index.cshtml"
                                                                                                          WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(653, 64, true);
            WriteLiteral("</div>\r\n                                <div class=\"row m-1 h6\">");
            EndContext();
            BeginContext(718, 12, false);
#line 24 "E:\Programs\SimpleNews\SimpleNews\Views\Main\Index.cshtml"
                                                   Write(item.Summary);

#line default
#line hidden
            EndContext();
            BeginContext(730, 112, true);
            WriteLiteral("</div>\r\n                                <div class=\"row\">\r\n                                    <div class=\"col\">");
            EndContext();
            BeginContext(843, 9, false);
#line 26 "E:\Programs\SimpleNews\SimpleNews\Views\Main\Index.cshtml"
                                                Write(item.Tags);

#line default
#line hidden
            EndContext();
            BeginContext(852, 72, true);
            WriteLiteral("</div>\r\n                                    <div class=\"col text-right\">");
            EndContext();
            BeginContext(925, 18, false);
#line 27 "E:\Programs\SimpleNews\SimpleNews\Views\Main\Index.cshtml"
                                                           Write(item.DatePublished);

#line default
#line hidden
            EndContext();
            BeginContext(943, 142, true);
            WriteLiteral("</div>\r\n                                </div>\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 32 "E:\Programs\SimpleNews\SimpleNews\Views\Main\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1104, 214, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n        <div class=\"row mt-3 pl-3 pr-3\">\r\n            <button type=\"button\" class=\"btn btn-primary w-100\" id=\"MoreNews\">Больше новостей</button>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
