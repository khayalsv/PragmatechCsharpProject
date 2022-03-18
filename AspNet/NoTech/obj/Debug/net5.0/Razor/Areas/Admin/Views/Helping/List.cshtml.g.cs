#pragma checksum "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Helping\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48a811431c4c03138fb6ec7f9d8f0bb5ebc4ce0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Helping_List), @"mvc.1.0.view", @"/Areas/Admin/Views/Helping/List.cshtml")]
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
#line 1 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\_ViewImports.cshtml"
using NoTech;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\_ViewImports.cshtml"
using NoTech.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\_ViewImports.cshtml"
using NoTech.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48a811431c4c03138fb6ec7f9d8f0bb5ebc4ce0c", @"/Areas/Admin/Views/Helping/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb19270f775237d817e8fe39c4b1c6ac3015960f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Helping_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Helping>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Helping\List.cshtml"
 if (TempData["Success"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-primary\" role=\"alert\">\r\n        ");
#nullable restore
#line 6 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Helping\List.cshtml"
   Write(TempData["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 8 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Helping\List.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <a href=""/Admin/Helping/Create"" class=""btn btn-success"">Add</a>
</div>

<div class=""table-responsive scrollbar"">
    <table class=""table table-hover"">
        <thead>
            <tr>
                <th scope=""col"">ID</th>
                <th scope=""col"">Title</th>
                <th scope=""col"">Text</th>
                <th scope=""col"">Icon</th>
                <th scope=""col"">SubTitle</th>
                <th scope=""col"">SubText</th>
                <th scope=""col"">Image</th>

                <th class=""text-end"" scope=""col"">Actions</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 30 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Helping\List.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Helping\List.cshtml"
                   Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Helping\List.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Helping\List.cshtml"
                   Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Helping\List.cshtml"
                   Write(item.Icon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Helping\List.cshtml"
                   Write(item.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Helping\List.cshtml"
                   Write(item.SubText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "48a811431c4c03138fb6ec7f9d8f0bb5ebc4ce0c7354", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1207, "~/assets/images/backgrounds/", 1207, 28, true);
#nullable restore
#line 40 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Helping\List.cshtml"
AddHtmlAttributeValue("", 1235, item.Image, 1235, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td class=\"text-end\">\r\n                        <div>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1383, "\"", 1418, 2);
            WriteAttributeValue("", 1390, "/Admin/Helping/Edit/", 1390, 20, true);
#nullable restore
#line 45 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Helping\List.cshtml"
WriteAttributeValue("", 1410, item.ID, 1410, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-edit\"></i></a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1483, "\"", 1520, 2);
            WriteAttributeValue("", 1490, "/Admin/Helping/Delete/", 1490, 22, true);
#nullable restore
#line 46 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Helping\List.cshtml"
WriteAttributeValue("", 1512, item.ID, 1512, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Are you delete?\')\"><i class=\"fas fa-trash-alt\"></i></a>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 50 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Helping\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Helping>> Html { get; private set; }
    }
}
#pragma warning restore 1591