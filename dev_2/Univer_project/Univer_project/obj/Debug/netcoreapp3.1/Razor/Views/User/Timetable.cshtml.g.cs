#pragma checksum "O:\Programming\VS Projects\Univer_project\Univer_project\Views\User\Timetable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5b0831f3b2dcc986423f57143737b0040b18ec2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Timetable), @"mvc.1.0.view", @"/Views/User/Timetable.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5b0831f3b2dcc986423f57143737b0040b18ec2", @"/Views/User/Timetable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e086d3797964325d4793fc43a7a006ce0ffba45f", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Timetable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TimetableService>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/GroupsSearch"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-mode", new global::Microsoft.AspNetCore.Html.HtmlString("replace"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-update", new global::Microsoft.AspNetCore.Html.HtmlString("groups"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "O:\Programming\VS Projects\Univer_project\Univer_project\Views\User\Timetable.cshtml"
  
    Layout = "~/Views/Shared/_LayoutForLogged.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    body {\r\n        background: #ffffff;\r\n    }\r\n    tr {\r\n        border-spacing: 20px 20px;\r\n        height: 50px;\r\n    }\r\n    th{\r\n        margin-left: 100px;\r\n        width: 70px;\r\n    }\r\n</style>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5b0831f3b2dcc986423f57143737b0040b18ec26202", async() => {
                WriteLiteral("\r\n    <h4>Институт</h4>\r\n    <select id=\"institute\" name=\"institute_name\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5b0831f3b2dcc986423f57143737b0040b18ec26550", async() => {
                    WriteLiteral("Выберите институт");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 24 "O:\Programming\VS Projects\Univer_project\Univer_project\Views\User\Timetable.cshtml"
         foreach (var i in Model.GetInstitutes())
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5b0831f3b2dcc986423f57143737b0040b18ec28059", async() => {
#nullable restore
#line 26 "O:\Programming\VS Projects\Univer_project\Univer_project\Views\User\Timetable.cshtml"
               Write(i.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 27 "O:\Programming\VS Projects\Univer_project\Univer_project\Views\User\Timetable.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </select>\r\n    <h4>Группа</h4>\r\n    <select id=\"groups\" name=\"group_name\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5b0831f3b2dcc986423f57143737b0040b18ec29535", async() => {
                    WriteLiteral("\r\n            Выбери группу\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </select>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<table id=\"timetable\" style=\"border-spacing: 7px\">\r\n\r\n</table>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.1.1.min.js""></script>
    <script>
        $(document).ready(function () {
            $(""#groups"").change(loadGroups).change();
        });

        $(function loadGroups() {
            $(""#institute"").on(""change"", function () {
                console.log('Я работаю!' + $(this).val());
                var name_of_institute = $(this).val();
                $.ajax({
                    url: '");
#nullable restore
#line 53 "O:\Programming\VS Projects\Univer_project\Univer_project\Views\User\Timetable.cshtml"
                     Write(Url.Action("GroupsSearch"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                    type: ""POST"",
                    data: { institute_name: name_of_institute },
                    dataType: ""json"",
                    success: function (response) {
                        $(""#groups"").empty();
                        $(""#groups"").append(""<option value=''>Выберите группу</option>"");
                        response.forEach(function (gr_name) {
                            var option = $('<option />');
                            option.val(gr_name.name);
                            option.text(gr_name.name);
                            $('#groups').append(option);
                        })

                    },
                    failure: function (response) {
                        console.log('fail');
                        alert(response);
                    }
                })
            });
        });
    </script>
    <script>
    $(function () {
        $(""#groups"").on(""change"", function () {
            $(""#timetable"").empty");
                WriteLiteral("();\r\n                console.log(\'Я работаю!\' + $(this).val());\r\n                var name_of_group = $(this).val();\r\n                $.ajax({\r\n                    url: \'");
#nullable restore
#line 83 "O:\Programming\VS Projects\Univer_project\Univer_project\Views\User\Timetable.cshtml"
                     Write(Url.Action("TimetableSearch"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                    type: ""POST"",
                    data: { group_name: name_of_group },
                    dataType: ""json"",
                    success: function (response) {
                        if (response.length > 0) {
                            $(""#timetable"").append(""<thead>"" +
                                ""<tr>"" +
                                '<th style=""margin: 200px;""> Время </th>' +
                                ""<th> Предмет </th>"" +
                                ""<th> Преподаватель </th>"" +
                                ""<th> Аудитория </th>"" +
                                ""<th> Здание </th>"" +
                                ""</tr>"" +
                                ""</thead>"");
                        }
                        $(""#timetable"").append(""<tbody>"");
                        var day_of_week = response[0].day_of_week;
                        console.log(response[0].day_of_week)
                        $(""#timetable"").append('<tr> <td>' + day");
                WriteLiteral(@"_of_week + "" </td></tr>"")
                        response.forEach(function (timetable) {
                            if (timetable.day_of_week != day_of_week) {
                                console.log(day_of_week)
                                $(""#timetable"").append('<tr> <td>' + timetable.day_of_week + "" </td></tr>"")
                                day_of_week = timetable.day_of_week
                            }
                            $(""#timetable"").append(""<tr>"" + 
                                ""<td>"" + timetable.timetable_cell.time_interval + ""</td>""
                                + ""<td>"" + timetable.timetable_cell.subject + ""</td>"" + 
                                ""<td>"" + timetable.timetable_cell.teacher + ""</td>"" +
                                ""<td>"" + timetable.timetable_cell.audience + ""</td>"" +
                                ""<td>"" + timetable.timetable_cell.building + ""</td>"" + ""</tr>""
                            );
                        })
                  ");
                WriteLiteral(@"      $(""#timetable"").append(""</tbody>"");
                    },
                    failure: function (response) {
                        console.log('fail');
                        alert(response);
                    }
                })
            });
        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TimetableService> Html { get; private set; }
    }
}
#pragma warning restore 1591
