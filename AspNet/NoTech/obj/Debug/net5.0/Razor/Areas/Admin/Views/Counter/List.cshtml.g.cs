#pragma checksum "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Counter\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f4069d7c19b15b5b5474914737d428d409dafa6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Counter_List), @"mvc.1.0.view", @"/Areas/Admin/Views/Counter/List.cshtml")]
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
#nullable restore
#line 4 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f4069d7c19b15b5b5474914737d428d409dafa6", @"/Areas/Admin/Views/Counter/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bef577ee86d64056018fcfe73dd3cb32a2966ca2", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Counter_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Counter>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Counter\List.cshtml"
 if (TempData["Success"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-primary\" role=\"alert\">\r\n        ");
#nullable restore
#line 6 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Counter\List.cshtml"
   Write(TempData["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 8 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Counter\List.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<style>
    .addcreate {
        display:inline-block
    }
</style>

<div class=""addcreate"">
    <a href=""/Admin/Counter/Create"" class=""btn btn-success"">Add</a>
</div>

<button type=""button"" class=""btn btn-primary"" data-bs-toggle=""modal"" data-bs-target=""#createModal"">
    Create (Ajax)
</button>

<div class=""table-responsive scrollbar"">
    <table class=""table table-hover"">
        <thead>
            <tr>
                <th scope=""col"">ID</th>
                <th scope=""col"">Odometer</th>
                <th scope=""col"">Title</th>
                <th scope=""col"">Text</th>
                <th scope=""col"">Icon</th>

                <th class=""text-end"" scope=""col"">Actions</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 39 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Counter\List.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 42 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Counter\List.cshtml"
                   Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 43 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Counter\List.cshtml"
                   Write(item.Odometer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 44 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Counter\List.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Counter\List.cshtml"
                   Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 46 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Counter\List.cshtml"
                   Write(item.Icon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td class=\"text-end\">\r\n                        <div>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1323, "\"", 1358, 2);
            WriteAttributeValue("", 1330, "/Admin/Counter/Edit/", 1330, 20, true);
#nullable restore
#line 50 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Counter\List.cshtml"
WriteAttributeValue("", 1350, item.ID, 1350, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-edit\"></i></a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1423, "\"", 1460, 2);
            WriteAttributeValue("", 1430, "/Admin/Counter/Delete/", 1430, 22, true);
#nullable restore
#line 51 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Counter\List.cshtml"
WriteAttributeValue("", 1452, item.ID, 1452, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Are you delete?\')\"><i class=\"fas fa-trash-alt\"></i></a>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 55 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Counter\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>

<!-- Modal -->
<div class=""modal fade"" id=""createModal"" tabindex=""-1"" aria-labelledby=""createModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""createModalLabel""> Create Form</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f4069d7c19b15b5b5474914737d428d409dafa69145", async() => {
                WriteLiteral(@"
                    <div class=""mb-3"">

                        <label class=""form-label"">odometer</label>
                        <input type=""text"" class=""form-control"" id=""odometerCreate"">

                        <label class=""form-label"">title</label>
                        <input type=""text"" class=""form-control"" id=""titleCreate"">

                        <label class=""form-label"">text</label>
                        <input type=""text"" class=""form-control"" id=""textCreate"">

                        <label class=""form-label"">icon</label>
                        <input type=""text"" class=""form-control"" id=""iconCreate"">

                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>
                <button id=""btnCreate"" type=""button"" class=""btn btn-primary"">SaveChanges</button>
            </div>
        </div>
    </div>
</div>




");
            DefineSection("script", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js"" referrerpolicy=""no-referrer""></script>


    <script>
        $(document).ready(() => {
            $(document).on('click', '#btnCreate', (e) => {
                $.ajax({
                    url: '/Admin/Counter/CreateAjax',
                    type: 'POST',
                    data: { icon: $('#iconCreate').val(), odometer: $('#odometerCreate').val(), title: $('#titleCreate').val(), text: $('#textCreate').val()},
                    success: (Response) => {
                        if (Response.hasOwnProperty('status') && Response.status === 200) {
                            location.href = '/Admin/Counter/List';
                        }
                        else if (Response.status === 400) {
");
                WriteLiteral("                            alert(\"Not Fount\")\r\n                        }\r\n                    }\r\n                })\r\n            })\r\n        })\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Counter>> Html { get; private set; }
    }
}
#pragma warning restore 1591
