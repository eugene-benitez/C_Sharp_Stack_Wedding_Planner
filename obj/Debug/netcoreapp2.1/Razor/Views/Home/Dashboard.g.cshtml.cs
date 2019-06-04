#pragma checksum "/Users/eugenebenitez/Desktop/C_Sharp/ASP/Wedding_Planner/Views/Home/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4ad083e2438b1048878dcc0fe682a9365b5c076"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
#line 1 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/Wedding_Planner/Views/_ViewImports.cshtml"
using Wedding_Planner;

#line default
#line hidden
#line 1 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/Wedding_Planner/Views/Home/Dashboard.cshtml"
using Wedding_Planner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4ad083e2438b1048878dcc0fe682a9365b5c076", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84b0732bfebbac067a62d1314c0d18406fc96ec4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User_Weddings>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RSVP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 283, true);
            WriteLiteral(@"
<h1>Welcome to the Wedding Planner! <span style=""float:right; margin-right: 12px;""><a href=""/"">Log Out</a></span></h1>
<br>
<br>
<table class=""table"">
    <thead>
        <th scope=""col"">Wedding</th>
        <th>Date</th>
        <th>Guest</th>
        <th>Action</th>
    </thead>
");
            EndContext();
#line 14 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/Wedding_Planner/Views/Home/Dashboard.cshtml"
     foreach (var w in @ViewBag.AllWeddings)
    {

#line default
#line hidden
            BeginContext(385, 35, true);
            WriteLiteral("    <tr scope=\"row\">\n        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 420, "\"", 447, 2);
            WriteAttributeValue("", 427, "wedding/", 427, 8, true);
#line 17 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/Wedding_Planner/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 435, w.WeddingId, 435, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(448, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(450, 11, false);
#line 17 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/Wedding_Planner/Views/Home/Dashboard.cshtml"
                                      Write(w.WedderOne);

#line default
#line hidden
            EndContext();
            BeginContext(461, 5, true);
            WriteLiteral(" and ");
            EndContext();
            BeginContext(467, 11, false);
#line 17 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/Wedding_Planner/Views/Home/Dashboard.cshtml"
                                                       Write(w.WedderTwo);

#line default
#line hidden
            EndContext();
            BeginContext(478, 23, true);
            WriteLiteral(" </a></td>\n        <td>");
            EndContext();
            BeginContext(502, 6, false);
#line 18 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/Wedding_Planner/Views/Home/Dashboard.cshtml"
       Write(w.Date);

#line default
#line hidden
            EndContext();
            BeginContext(508, 18, true);
            WriteLiteral("</td>\n        <td>");
            EndContext();
            BeginContext(527, 20, false);
#line 19 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/Wedding_Planner/Views/Home/Dashboard.cshtml"
       Write(w.RSVP_Wedding.Count);

#line default
#line hidden
            EndContext();
            BeginContext(547, 19, true);
            WriteLiteral("</td>\n        <td>\n");
            EndContext();
#line 21 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/Wedding_Planner/Views/Home/Dashboard.cshtml"
             if (@ViewBag.UserId == @w.CreatorId) {

#line default
#line hidden
            BeginContext(618, 18, true);
            WriteLiteral("                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 636, "\"", 662, 2);
            WriteAttributeValue("", 643, "delete/", 643, 7, true);
#line 22 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/Wedding_Planner/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 650, w.WeddingId, 650, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(663, 12, true);
            WriteLiteral(">Delete</a>\n");
            EndContext();
#line 23 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/Wedding_Planner/Views/Home/Dashboard.cshtml"
                }
            else
            {
                int isGuest = 0;
                

#line default
#line hidden
#line 27 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/Wedding_Planner/Views/Home/Dashboard.cshtml"
                 foreach(var guest in @w.RSVP_Wedding)
                {
                    

#line default
#line hidden
#line 29 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/Wedding_Planner/Views/Home/Dashboard.cshtml"
                     if (@guest.User.UserId == @ViewBag.UserId) {
                    isGuest = 1;
                    }

#line default
#line hidden
#line 31 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/Wedding_Planner/Views/Home/Dashboard.cshtml"
                     
                }

#line default
#line hidden
#line 34 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/Wedding_Planner/Views/Home/Dashboard.cshtml"
                     if (isGuest == 1) {

#line default
#line hidden
            BeginContext(1011, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1033, "\"", 1060, 2);
            WriteAttributeValue("", 1040, "decline/", 1040, 8, true);
#line 35 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/Wedding_Planner/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1048, w.WeddingId, 1048, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1061, 13, true);
            WriteLiteral(">UN-RSVP</a>\n");
            EndContext();
#line 36 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/Wedding_Planner/Views/Home/Dashboard.cshtml"
                    }

                    else {

#line default
#line hidden
            BeginContext(1124, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1144, 223, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8e9195028784eb3ae273675733bbb69", async() => {
                BeginContext(1204, 58, true);
                WriteLiteral("\n                    <input type=\"hidden\" name=\"WeddingId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1262, "\"", 1282, 1);
#line 40 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/Wedding_Planner/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1270, w.WeddingId, 1270, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1283, 77, true);
                WriteLiteral(">\n                    <input value=\"RSVP\" type=\"submit\">\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1367, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 43 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/Wedding_Planner/Views/Home/Dashboard.cshtml"
                }

#line default
#line hidden
#line 43 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/Wedding_Planner/Views/Home/Dashboard.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(1400, 24, true);
            WriteLiteral("        </td>\n    </tr>\n");
            EndContext();
#line 47 "/Users/eugenebenitez/Desktop/C_Sharp/ASP/Wedding_Planner/Views/Home/Dashboard.cshtml"
    }

#line default
#line hidden
            BeginContext(1430, 92, true);
            WriteLiteral("</table>\n<a name=\"\" id=\"\" class=\"btn btn-primary\" href=\"/new\" role=\"button\">New Wedding</a>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User_Weddings> Html { get; private set; }
    }
}
#pragma warning restore 1591
