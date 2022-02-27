#pragma checksum "C:\Users\selim\Desktop\Csharp\AspNet\Relation\Views\Author\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c84dabe761477674aaa007a090286fa9e1a7badc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_List), @"mvc.1.0.view", @"/Views/Author/List.cshtml")]
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
#line 1 "C:\Users\selim\Desktop\Csharp\AspNet\Relation\Views\_ViewImports.cshtml"
using Relation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selim\Desktop\Csharp\AspNet\Relation\Views\_ViewImports.cshtml"
using Relation.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\selim\Desktop\Csharp\AspNet\Relation\Views\_ViewImports.cshtml"
using Relation.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c84dabe761477674aaa007a090286fa9e1a7badc", @"/Views/Author/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6915e6ac8f738b6f680d8ad0b1a374351f6ce60f", @"/Views/_ViewImports.cshtml")]
    public class Views_Author_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div>
    <a href=""/Author/Create"" style=""width:100%"" class=""btn btn-success"">Add</a>
</div>
<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>Id</th>
            <th>AuthorName</th>
            <th>BookName</th>
            <th>Page</th>
            <th>CRUD</th>

        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 19 "C:\Users\selim\Desktop\Csharp\AspNet\Relation\Views\Author\List.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th scope=\"row\">");
#nullable restore
#line 22 "C:\Users\selim\Desktop\Csharp\AspNet\Relation\Views\Author\List.cshtml"
                       Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th scope=\"row\">");
#nullable restore
#line 23 "C:\Users\selim\Desktop\Csharp\AspNet\Relation\Views\Author\List.cshtml"
                       Write(item.Authors.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\selim\Desktop\Csharp\AspNet\Relation\Views\Author\List.cshtml"
           Write(item.BookName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\selim\Desktop\Csharp\AspNet\Relation\Views\Author\List.cshtml"
           Write(item.Page);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 643, "\"", 671, 2);
            WriteAttributeValue("", 650, "/Author/Edit/", 650, 13, true);
#nullable restore
#line 27 "C:\Users\selim\Desktop\Csharp\AspNet\Relation\Views\Author\List.cshtml"
WriteAttributeValue("", 663, item.ID, 663, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:green\"><i class=\"fas fa-edit\"></i></a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 744, "\"", 774, 2);
            WriteAttributeValue("", 751, "/Author/Delete/", 751, 15, true);
#nullable restore
#line 28 "C:\Users\selim\Desktop\Csharp\AspNet\Relation\Views\Author\List.cshtml"
WriteAttributeValue("", 766, item.ID, 766, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Are you delete?\')\" style=\"color:red\"><i class=\"fas fa-trash-alt\"></i></a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 894, "\"", 925, 2);
            WriteAttributeValue("", 901, "/Author/Details/", 901, 16, true);
#nullable restore
#line 29 "C:\Users\selim\Desktop\Csharp\AspNet\Relation\Views\Author\List.cshtml"
WriteAttributeValue("", 917, item.ID, 917, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:steelblue\">About</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\selim\Desktop\Csharp\AspNet\Relation\Views\Author\List.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
