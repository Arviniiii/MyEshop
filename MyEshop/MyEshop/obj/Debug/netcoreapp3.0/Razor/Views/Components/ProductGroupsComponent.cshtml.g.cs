#pragma checksum "C:\Users\IHC\Desktop\48_AspNetCore3\MyEshop\MyEshop\Views\Components\ProductGroupsComponent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a2f9a3284cb7019e7949d7dbd316989e3b1ea70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Components_ProductGroupsComponent), @"mvc.1.0.view", @"/Views/Components/ProductGroupsComponent.cshtml")]
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
#line 1 "C:\Users\IHC\Desktop\48_AspNetCore3\MyEshop\MyEshop\Views\_ViewImports.cshtml"
using MyEshop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\IHC\Desktop\48_AspNetCore3\MyEshop\MyEshop\Views\_ViewImports.cshtml"
using MyEshop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a2f9a3284cb7019e7949d7dbd316989e3b1ea70", @"/Views/Components/ProductGroupsComponent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a8216f524d7ee13ea87b096575790f2a3183837", @"/Views/_ViewImports.cshtml")]
    public class Views_Components_ProductGroupsComponent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShowGroupViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<ul class=\"list-group\">\r\n");
#nullable restore
#line 4 "C:\Users\IHC\Desktop\48_AspNetCore3\MyEshop\MyEshop\Views\Components\ProductGroupsComponent.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n       <a");
            BeginWriteAttribute("href", " href=\"", 193, "\"", 231, 4);
            WriteAttributeValue("", 200, "/Group/", 200, 7, true);
#nullable restore
#line 7 "C:\Users\IHC\Desktop\48_AspNetCore3\MyEshop\MyEshop\Views\Components\ProductGroupsComponent.cshtml"
WriteAttributeValue("", 207, item.GroupId, 207, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 220, "/", 220, 1, true);
#nullable restore
#line 7 "C:\Users\IHC\Desktop\48_AspNetCore3\MyEshop\MyEshop\Views\Components\ProductGroupsComponent.cshtml"
WriteAttributeValue("", 221, item.Name, 221, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 7 "C:\Users\IHC\Desktop\48_AspNetCore3\MyEshop\MyEshop\Views\Components\ProductGroupsComponent.cshtml"
                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        <span class=\"badge badge-primary badge-pill\">");
#nullable restore
#line 8 "C:\Users\IHC\Desktop\48_AspNetCore3\MyEshop\MyEshop\Views\Components\ProductGroupsComponent.cshtml"
                                                Write(item.ProductCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </li>\r\n");
#nullable restore
#line 10 "C:\Users\IHC\Desktop\48_AspNetCore3\MyEshop\MyEshop\Views\Components\ProductGroupsComponent.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShowGroupViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591