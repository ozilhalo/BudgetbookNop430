#pragma checksum "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\ScheduleTask\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c89fa3a3f4ec568d735345d239cd9ccaed2797c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ScheduleTask_List), @"mvc.1.0.view", @"/Areas/Admin/Views/ScheduleTask/List.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 7 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Domain.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Services.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Affiliates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Customers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Directory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Discounts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ExternalAuthentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Forums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Messages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Payments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins.Marketplace;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Polls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Reports;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Security;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Shipping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Stores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tax;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Templates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Vendors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models.DataTables;

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Honeypot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c89fa3a3f4ec568d735345d239cd9ccaed2797c6", @"/Areas/Admin/Views/ScheduleTask/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9afeeb77ddd3a4a2e0698ab1d31f0fa32cb5e81", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ScheduleTask_List : Nop.Web.Framework.Mvc.Razor.NopRazorPage<ScheduleTaskSearchModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\ScheduleTask\List.cshtml"
  
    //page title
    ViewBag.PageTitle = T("Admin.System.ScheduleTasks").Text;
    //active menu item (system name)
    Html.SetActiveMenuItemSystemName("Schedule tasks");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"content-header clearfix\">\r\n    <h1 class=\"pull-left\">\r\n        ");
#nullable restore
#line 12 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\ScheduleTask\List.cshtml"
   Write(T("Admin.System.ScheduleTasks"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h1>\r\n    <div class=\"pull-right\">\r\n        &nbsp;\r\n        ");
#nullable restore
#line 16 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\ScheduleTask\List.cshtml"
   Write(await Component.InvokeAsync("AdminWidget", new { widgetZone = AdminWidgetZones.ScheduleTaskListButtons }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\"#schedule-tasks-grid\").on(\"click\", \".run-now\", function (e) {\r\n            showThrobber(\'");
#nullable restore
#line 23 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\ScheduleTask\List.cshtml"
                     Write(Html.Raw(JavaScriptEncoder.Default.Encode(T("Admin.System.ScheduleTasks.RunNow.Progress").Text)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"');
        });
    });
</script>

<div class=""content"">
    <div class=""form-horizontal"">
        <div class=""panel-group"">
            <div class=""panel panel-default"">
                <div class=""panel-body"">
                    <p>
                        ");
#nullable restore
#line 34 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\ScheduleTask\List.cshtml"
                   Write(T("Admin.System.ScheduleTasks.24days"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <p>\r\n                        <strong>");
#nullable restore
#line 37 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\ScheduleTask\List.cshtml"
                           Write(T("Admin.System.ScheduleTasks.RestartApplication"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                    </p>\r\n\r\n                    ");
#nullable restore
#line 40 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\ScheduleTask\List.cshtml"
               Write(await Html.PartialAsync("Table", new DataTablesModel
                    {
                        Name = "schedule-tasks-grid",
                        UrlRead = new DataUrl("List", "ScheduleTask", null),
                        UrlUpdate = new DataUrl("TaskUpdate", "ScheduleTask", null),
                        Length = Model.PageSize,
                        LengthMenu = Model.AvailablePageSizes,
                        ColumnCollection = new List<ColumnProperty>
                            {
                                new ColumnProperty(nameof(ScheduleTaskModel.Name))
                                {
                                    Title = T("Admin.System.ScheduleTasks.Name").Text,
                                    Width = "300",
                                    Editable = true,
                                    EditType = EditType.String
                                },
                                new ColumnProperty(nameof(ScheduleTaskModel.Seconds))
                                {
                                    Title = T("Admin.System.ScheduleTasks.Seconds").Text,
                                    Width = "150",
                                    Editable = true,
                                    EditType = EditType.Number
                                },
                                new ColumnProperty(nameof(ScheduleTaskModel.Enabled))
                                {
                                    Title = T("Admin.System.ScheduleTasks.Enabled").Text,
                                    Width = "100",
                                    ClassName = NopColumnClassDefaults.CenterAll,
                                    Render = new RenderBoolean(),
                                    Editable = true,
                                    EditType = EditType.Checkbox
                                },
                                new ColumnProperty(nameof(ScheduleTaskModel.StopOnError))
                                {
                                    Title = T("Admin.System.ScheduleTasks.StopOnError").Text,
                                    Width = "100",
                                    ClassName = NopColumnClassDefaults.CenterAll,
                                    Render = new RenderBoolean(),
                                    Editable = true,
                                    EditType = EditType.Checkbox
                                },
                                new ColumnProperty(nameof(ScheduleTaskModel.LastStartUtc))
                                {
                                    Title = T("Admin.System.ScheduleTasks.LastStart").Text,
                                    Width = "200"
                                },
                                new ColumnProperty(nameof(ScheduleTaskModel.LastEndUtc))
                                {
                                    Title = T("Admin.System.ScheduleTasks.LastEnd").Text,
                                    Width = "200"
                                },
                                new ColumnProperty(nameof(ScheduleTaskModel.LastSuccessUtc))
                                {
                                    Title = T("Admin.System.ScheduleTasks.LastSuccess").Text,
                                    Width = "200"
                                },
                                new ColumnProperty(nameof(ScheduleTaskModel.Id))
                                {
                                    Title = T("Admin.System.ScheduleTasks.RunNow").Text,
                                    Width = "100",
                                    ClassName =  NopColumnClassDefaults.Button,
                                    Render = new RenderCustom("renderColumnRunNow")
                                },
                                new ColumnProperty(nameof(ScheduleTaskModel.Id))
                                {
                                    Title = T("Admin.Common.Edit").Text,
                                    Width = "200",
                                    ClassName =  NopColumnClassDefaults.Button,
                                    Render = new RenderButtonsInlineEdit()
                                }
                            }
                    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    \r\n                    <script>\r\n                        function renderColumnRunNow(data, type, row, meta) {\r\n                            return \'<a href=\"");
#nullable restore
#line 115 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\ScheduleTask\List.cshtml"
                                        Write(Url.Content("~/Admin/ScheduleTask/RunNow/"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' + row.Id +\'\" class=\"btn bg-green\">");
#nullable restore
#line 115 "C:\Project\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\ScheduleTask\List.cshtml"
                                                                                                                        Write(T("Admin.System.ScheduleTasks.RunNow"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\';\r\n                        }\r\n                    </script>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWorkContext workContext { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Nop.Services.Common.IGenericAttributeService genericAttributeService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ScheduleTaskSearchModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
