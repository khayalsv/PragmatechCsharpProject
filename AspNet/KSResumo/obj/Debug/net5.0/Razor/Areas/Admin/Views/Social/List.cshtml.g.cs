#pragma checksum "C:\Users\selim\Desktop\Csharp\AspNet\KSResumo\Areas\Admin\Views\Social\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b34dc3e82dd6481872cd872cf81d53216bebdb0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Social_List), @"mvc.1.0.view", @"/Areas/Admin/Views/Social/List.cshtml")]
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
#line 1 "C:\Users\selim\Desktop\Csharp\AspNet\KSResumo\Areas\Admin\Views\_ViewImports.cshtml"
using KS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selim\Desktop\Csharp\AspNet\KSResumo\Areas\Admin\Views\_ViewImports.cshtml"
using KSResumo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\selim\Desktop\Csharp\AspNet\KSResumo\Areas\Admin\Views\_ViewImports.cshtml"
using KSResumo.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b34dc3e82dd6481872cd872cf81d53216bebdb0d", @"/Areas/Admin/Views/Social/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c2307ab9c3238818e2a425e2a76cd8f12b299c6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Social_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Social>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\selim\Desktop\Csharp\AspNet\KSResumo\Areas\Admin\Views\Social\List.cshtml"
 if (TempData["Success"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-primary\" role=\"alert\">\r\n        ");
#nullable restore
#line 6 "C:\Users\selim\Desktop\Csharp\AspNet\KSResumo\Areas\Admin\Views\Social\List.cshtml"
   Write(TempData["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 8 "C:\Users\selim\Desktop\Csharp\AspNet\KSResumo\Areas\Admin\Views\Social\List.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <a href=""/Admin/Social/Create"" class=""btn btn-success"" style=""width:100%"">Add new slider</a>
</div>

<table class=""table table-bordered"">
    <thead>
        <tr>
            <th scope=""col"">ID</th>
            <th scope=""col"">Twitter</th>
            <th scope=""col"">Facebook</th>
            <th scope=""col"">Instagram</th>
            <th>CRUD</th>
        </tr>
    </thead>

    <tbody>

");
#nullable restore
#line 27 "C:\Users\selim\Desktop\Csharp\AspNet\KSResumo\Areas\Admin\Views\Social\List.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th scope=\"row\">");
#nullable restore
#line 30 "C:\Users\selim\Desktop\Csharp\AspNet\KSResumo\Areas\Admin\Views\Social\List.cshtml"
                       Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\selim\Desktop\Csharp\AspNet\KSResumo\Areas\Admin\Views\Social\List.cshtml"
           Write(item.Twitter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\selim\Desktop\Csharp\AspNet\KSResumo\Areas\Admin\Views\Social\List.cshtml"
           Write(item.Facebook);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\selim\Desktop\Csharp\AspNet\KSResumo\Areas\Admin\Views\Social\List.cshtml"
           Write(item.Instagram);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 837, "\"", 871, 2);
            WriteAttributeValue("", 844, "/Admin/Social/Edit/", 844, 19, true);
#nullable restore
#line 37 "C:\Users\selim\Desktop\Csharp\AspNet\KSResumo\Areas\Admin\Views\Social\List.cshtml"
WriteAttributeValue("", 863, item.ID, 863, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:green\"><i class=\"fas fa-edit\"></i></a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 944, "\"", 980, 2);
            WriteAttributeValue("", 951, "/Admin/Social/Delete/", 951, 21, true);
#nullable restore
#line 38 "C:\Users\selim\Desktop\Csharp\AspNet\KSResumo\Areas\Admin\Views\Social\List.cshtml"
WriteAttributeValue("", 972, item.ID, 972, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Are you delete?\')\" style=\"color:red\">\r\n                    <i class=\"fas fa-trash-alt\"></i>\r\n                </a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1140, "\"", 1177, 2);
            WriteAttributeValue("", 1147, "/Admin/Social/Details/", 1147, 22, true);
#nullable restore
#line 41 "C:\Users\selim\Desktop\Csharp\AspNet\KSResumo\Areas\Admin\Views\Social\List.cshtml"
WriteAttributeValue("", 1169, item.ID, 1169, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:red\">Etrafli</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 44 "C:\Users\selim\Desktop\Csharp\AspNet\KSResumo\Areas\Admin\Views\Social\List.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Social>> Html { get; private set; }
    }
}
#pragma warning restore 1591
