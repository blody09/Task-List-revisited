#pragma checksum "C:\Users\Lock\OneDrive\Desktop\Assignments\TaskListRevisited\TaskListRevisited\Views\Tasks\UpdateTasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09fb3019f98422e56a3dece3d2cfc63e5eb2bdea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tasks_UpdateTasks), @"mvc.1.0.view", @"/Views/Tasks/UpdateTasks.cshtml")]
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
#line 1 "C:\Users\Lock\OneDrive\Desktop\Assignments\TaskListRevisited\TaskListRevisited\Views\_ViewImports.cshtml"
using TaskListRevisited;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lock\OneDrive\Desktop\Assignments\TaskListRevisited\TaskListRevisited\Views\_ViewImports.cshtml"
using TaskListRevisited.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09fb3019f98422e56a3dece3d2cfc63e5eb2bdea", @"/Views/Tasks/UpdateTasks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c29955b6777ccd0af545b495ba19ff10d165125", @"/Views/_ViewImports.cshtml")]
    public class Views_Tasks_UpdateTasks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tasks>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("../Tasks/UpdateTasks"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Lock\OneDrive\Desktop\Assignments\TaskListRevisited\TaskListRevisited\Views\Tasks\UpdateTasks.cshtml"
  
    ViewData["Title"] = "UpdateTasks";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>UpdateTasks</h1>\r\n\r\n");
            WriteLiteral("<h1>Update Tasks</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09fb3019f98422e56a3dece3d2cfc63e5eb2bdea4346", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 200, "\"", 217, 1);
#nullable restore
#line 12 "C:\Users\Lock\OneDrive\Desktop\Assignments\TaskListRevisited\TaskListRevisited\Views\Tasks\UpdateTasks.cshtml"
WriteAttributeValue("", 208, Model.Id, 208, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 257, "\"", 283, 1);
#nullable restore
#line 13 "C:\Users\Lock\OneDrive\Desktop\Assignments\TaskListRevisited\TaskListRevisited\Views\Tasks\UpdateTasks.cshtml"
WriteAttributeValue("", 265, Model.TaskOwnerId, 265, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"text\" name=\"TaskDescription\"");
                BeginWriteAttribute("value", " value=\"", 334, "\"", 364, 1);
#nullable restore
#line 14 "C:\Users\Lock\OneDrive\Desktop\Assignments\TaskListRevisited\TaskListRevisited\Views\Tasks\UpdateTasks.cshtml"
WriteAttributeValue("", 342, Model.TaskDescription, 342, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 365, "\"", 401, 1);
#nullable restore
#line 14 "C:\Users\Lock\OneDrive\Desktop\Assignments\TaskListRevisited\TaskListRevisited\Views\Tasks\UpdateTasks.cshtml"
WriteAttributeValue("", 379, Model.TaskDescription, 379, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"date\" name=\"DueDate\"");
                BeginWriteAttribute("value", " value=\"", 444, "\"", 466, 1);
#nullable restore
#line 15 "C:\Users\Lock\OneDrive\Desktop\Assignments\TaskListRevisited\TaskListRevisited\Views\Tasks\UpdateTasks.cshtml"
WriteAttributeValue("", 452, Model.DueDate, 452, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 467, "\"", 495, 1);
#nullable restore
#line 15 "C:\Users\Lock\OneDrive\Desktop\Assignments\TaskListRevisited\TaskListRevisited\Views\Tasks\UpdateTasks.cshtml"
WriteAttributeValue("", 481, Model.DueDate, 481, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"checkbox\" name=\"Complete\" value=\"true\" />\r\n    <input type=\"hidden\" value=\"false\" name=\"Complete\" />\r\n\r\n    <input type=\"submit\" value=\"update Task\" />\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tasks> Html { get; private set; }
    }
}
#pragma warning restore 1591
