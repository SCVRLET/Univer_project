#pragma checksum "O:\Programming\VS Projects\Univer_project\Univer_project\Views\User\Progress.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d89d1fd7e0e3774c6413c91619a88969458ac66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Progress), @"mvc.1.0.view", @"/Views/User/Progress.cshtml")]
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
#line 1 "O:\Programming\VS Projects\Univer_project\Univer_project\Views\_ViewImports.cshtml"
using Univer_project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "O:\Programming\VS Projects\Univer_project\Univer_project\Views\_ViewImports.cshtml"
using Univer_project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d89d1fd7e0e3774c6413c91619a88969458ac66", @"/Views/User/Progress.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e086d3797964325d4793fc43a7a006ce0ffba45f", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Progress : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Mark>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "O:\Programming\VS Projects\Univer_project\Univer_project\Views\User\Progress.cshtml"
  
    ViewData["Title"] = "Main";
    Layout = "~/Views/Shared/_LayoutForLogged.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    body {
        background: #ffffff;
    }
</style>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Семестр
            </th>
            <th>
                Предмет
            </th>
            <th>
                Баллы за семестр
            </th>
            <th>
                Тип тестирования
            </th>
            <th>
                Дата тестирования
            </th>
            <th>
                Баллы за тестирование
            </th>
            <th>
                Всего баллов
            </th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 40 "O:\Programming\VS Projects\Univer_project\Univer_project\Views\User\Progress.cshtml"
             foreach (var i in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n            <td>");
#nullable restore
#line 43 "O:\Programming\VS Projects\Univer_project\Univer_project\Views\User\Progress.cshtml"
           Write(i.Semester);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 44 "O:\Programming\VS Projects\Univer_project\Univer_project\Views\User\Progress.cshtml"
           Write(i.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 45 "O:\Programming\VS Projects\Univer_project\Univer_project\Views\User\Progress.cshtml"
           Write(i.Points_for_semester);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 46 "O:\Programming\VS Projects\Univer_project\Univer_project\Views\User\Progress.cshtml"
           Write(i.Type_of_test);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 47 "O:\Programming\VS Projects\Univer_project\Univer_project\Views\User\Progress.cshtml"
           Write(i.Date_of_test);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 48 "O:\Programming\VS Projects\Univer_project\Univer_project\Views\User\Progress.cshtml"
           Write(i.Points_for_test);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 49 "O:\Programming\VS Projects\Univer_project\Univer_project\Views\User\Progress.cshtml"
           Write(i.Sum_of_points);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 51 "O:\Programming\VS Projects\Univer_project\Univer_project\Views\User\Progress.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Mark>> Html { get; private set; }
    }
}
#pragma warning restore 1591
