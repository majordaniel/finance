﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Frapid.Configuration;
    using Frapid.Dashboard;
    using Frapid.DataAccess;
    using Frapid.DbPolicy;
    using Frapid.Framework;
    using Frapid.i18n;
    using Frapid.Messaging;
    using Frapid.NPoco;
    using Frapid.WebsiteBuilder;
    using MixERP.Finance;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Tasks/JournalEntry/Checklist.cshtml")]
    public partial class _Views_Tasks_JournalEntry_Checklist_cshtml : System.Web.Mvc.WebViewPage<long>
    {
        public _Views_Tasks_JournalEntry_Checklist_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Tasks\JournalEntry\Checklist.cshtml"
  
    ViewBag.Title = "Checklist";
    Layout = ViewBag.FinanceLayoutPath;

            
            #line default
            #line hidden
WriteLiteral("\r\n<style>\r\niframe{\r\n\tdisplay: block;\r\n\tmargin-top:1em;\r\n\twidth: 800px;\r\n\theight: " +
"800px;\r\n\tborder:1px solid #ccc;\r\n}    \r\n</style>\r\n<div");

WriteLiteral(" class=\"ui attached page segment\"");

WriteLiteral(" style=\"min-height: 100%; padding: 3em;\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"ui huge header\"");

WriteLiteral(">Journal Entry</div>\r\n    <div");

WriteLiteral(" class=\"ui divider\"");

WriteLiteral("></div>\r\n\r\n    <div");

WriteLiteral(" class=\"ui positive message\"");

WriteLiteral(">The transaction was posted successfully.</div>\r\n\r\n    <a");

WriteLiteral(" href=\"/dashboard/finance/tasks/journal/entry\"");

WriteLiteral(" class=\"ui green button\"");

WriteLiteral(">\r\n        View Transactions\r\n    </a>\r\n    <a");

WriteLiteral(" href=\"/dashboard/finance/tasks/journal/entry/new\"");

WriteLiteral(" class=\"ui red button\"");

WriteLiteral(">\r\n        Add a New Transaction\r\n    </a>\r\n    <iframe");

WriteAttribute("src", Tuple.Create(" src=\"", 733), Tuple.Create("\"", 839)
, Tuple.Create(Tuple.Create("", 739), Tuple.Create("/dashboard/reports/source/Areas/MixERP.Finance/Reports/JournalEntry.xml?transacti" +
"on_master_id=", 739), true)
            
            #line 28 "..\..\Views\Tasks\JournalEntry\Checklist.cshtml"
                                , Tuple.Create(Tuple.Create("", 833), Tuple.Create<System.Object, System.Int32>(Model
            
            #line default
            #line hidden
, 833), false)
);

WriteLiteral("></iframe>\r\n</div>\r\n\r\n\r\n<script>\r\n    window.overridePath = \"/dashboard/finance/t" +
"asks/journal/entry\";\r\n</script>");

        }
    }
}
#pragma warning restore 1591
