#pragma checksum "C:\Revature_Code\pflug_P1\DowntownDeliWebApp\Controllers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15861e81c1c6a12cf5d28087583066af8cd8d494"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Controllers_Index), @"mvc.1.0.view", @"/Controllers/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15861e81c1c6a12cf5d28087583066af8cd8d494", @"/Controllers/Index.cshtml")]
    public class Controllers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DowntownDeliWebApp.Models.CustomerViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        <form asp-action=\"Create\">\r\n            <div asp-validation-summary=\"ModelOnly\" class=\"text-danger\"></div>\r\n            <div class=\"form-group row\">\r\n                <label");
            BeginWriteAttribute("asp-for", " asp-for=\"", 288, "\"", 314, 1);
#nullable restore
#line 11 "C:\Revature_Code\pflug_P1\DowntownDeliWebApp\Controllers\Index.cshtml"
WriteAttributeValue("", 298, Model.FirstName, 298, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"control-label\"></label>\r\n                <input");
            BeginWriteAttribute("asp-for", " asp-for=\"", 370, "\"", 396, 1);
#nullable restore
#line 12 "C:\Revature_Code\pflug_P1\DowntownDeliWebApp\Controllers\Index.cshtml"
WriteAttributeValue("", 380, Model.FirstName, 380, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" />\r\n                <span");
            BeginWriteAttribute("asp-validation-for", " asp-validation-for=\"", 444, "\"", 481, 1);
#nullable restore
#line 13 "C:\Revature_Code\pflug_P1\DowntownDeliWebApp\Controllers\Index.cshtml"
WriteAttributeValue("", 465, Model.FirstName, 465, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-danger\"></span>\r\n            </div>\r\n            <div class=\"form-group row\">\r\n                <label");
            BeginWriteAttribute("asp-for", " asp-for=\"", 596, "\"", 621, 1);
#nullable restore
#line 16 "C:\Revature_Code\pflug_P1\DowntownDeliWebApp\Controllers\Index.cshtml"
WriteAttributeValue("", 606, Model.LastName, 606, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"control-label\"></label>\r\n                <input");
            BeginWriteAttribute("asp-for", " asp-for=\"", 677, "\"", 702, 1);
#nullable restore
#line 17 "C:\Revature_Code\pflug_P1\DowntownDeliWebApp\Controllers\Index.cshtml"
WriteAttributeValue("", 687, Model.LastName, 687, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" />\r\n                <span");
            BeginWriteAttribute("asp-validation-for", " asp-validation-for=\"", 750, "\"", 786, 1);
#nullable restore
#line 18 "C:\Revature_Code\pflug_P1\DowntownDeliWebApp\Controllers\Index.cshtml"
WriteAttributeValue("", 771, Model.LastName, 771, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 32 "C:\Revature_Code\pflug_P1\DowntownDeliWebApp\Controllers\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DowntownDeliWebApp.Models.CustomerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591