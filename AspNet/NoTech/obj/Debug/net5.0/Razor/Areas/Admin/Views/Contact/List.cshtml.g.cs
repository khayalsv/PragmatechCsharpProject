#pragma checksum "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Contact\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30f3038e0d9f3ec33c7c1f2ca35203781b3d2fd6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Contact_List), @"mvc.1.0.view", @"/Areas/Admin/Views/Contact/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30f3038e0d9f3ec33c7c1f2ca35203781b3d2fd6", @"/Areas/Admin/Views/Contact/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bef577ee86d64056018fcfe73dd3cb32a2966ca2", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Contact_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Contact>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Contact\List.cshtml"
 if (TempData["Success"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-primary\" role=\"alert\">\r\n        ");
#nullable restore
#line 6 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Contact\List.cshtml"
   Write(TempData["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 8 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Contact\List.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""table-responsive scrollbar"">
    <table class=""table table-hover"">
        <thead>
            <tr>
                <th scope=""col"">ID</th>
                <th scope=""col"">Name</th>
                <th scope=""col"">Email</th>
                <th scope=""col"">Message</th>
      

                <th class=""text-end"" scope=""col"">Actions</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 25 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Contact\List.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Contact\List.cshtml"
                   Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Contact\List.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Contact\List.cshtml"
                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Contact\List.cshtml"
                   Write(item.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                  \r\n                    <td class=\"text-end\">\r\n                        <div>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 950, "\"", 987, 2);
            WriteAttributeValue("", 957, "/Admin/Contact/Delete/", 957, 22, true);
#nullable restore
#line 35 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Contact\List.cshtml"
WriteAttributeValue("", 979, item.ID, 979, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Are you delete?\')\"><i class=\"fas fa-trash-alt\"></i></a>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 39 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\Contact\List.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591
