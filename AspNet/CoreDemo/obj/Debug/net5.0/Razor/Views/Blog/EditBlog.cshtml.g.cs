#pragma checksum "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Blog\EditBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "597f0143df5118471557523e1412c62ef3b75ae1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_EditBlog), @"mvc.1.0.view", @"/Views/Blog/EditBlog.cshtml")]
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
#line 1 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"597f0143df5118471557523e1412c62ef3b75ae1", @"/Views/Blog/EditBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_EditBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Blog\EditBlog.cshtml"
  
    ViewData["Title"] = "EditBlog";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>EditBlog</h1>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Blog\EditBlog.cshtml"
 using (Html.BeginForm("EditBlog", "Blog", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Id"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x => x.Id,new { @class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br/>\r\n");
#nullable restore
#line 18 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Title"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x => x.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.ValidationMessageFor(x => x.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 24 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Image"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x => x.Image, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.ValidationMessageFor(x => x.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 30 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("ThumbnailImage"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x => x.ThumbnailImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 39 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Message"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.TextAreaFor(x => x.Content, 15, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.ValidationMessageFor(x => x.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 44 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Blog\EditBlog.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
