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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Setup/ChartOfAccounts.cshtml")]
    public partial class _Views_Setup_ChartOfAccounts_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Setup_ChartOfAccounts_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Setup\ChartOfAccounts.cshtml"
  
    ViewBag.Title = "Chart of Accounts";
    Layout = ViewBag.Layout;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<script>\r\n    var scrudFactory = new Object();\r\n\r\n    scrudFactory.title = \"C" +
"hart of Accounts\";\r\n\r\n    scrudFactory.viewAPI = \"/api/views/finance/account-scr" +
"ud-view\";\r\n    scrudFactory.viewTableName = \"finance.account_scrud_view\";\r\n\r\n   " +
" scrudFactory.formAPI = \"/api/forms/finance/accounts\";\r\n    scrudFactory.formTab" +
"leName = \"finance.accounts\";\r\n\r\n    scrudFactory.excludedColumns = [\"audit_user_" +
"id\", \"audit_ts\"];\r\n\r\n    scrudFactory.allowDelete = true;\r\n    scrudFactory.allo" +
"wEdit = true;\r\n\r\n    scrudFactory.live = \"AccountName\";\r\n\r\n    scrudFactory.card" +
" = {\r\n        header: \"account_name\",\r\n        meta: \"account_number\",\r\n        " +
"description: \"account_master\"        \r\n    };\r\n\r\n    scrudFactory.layout = [\r\n  " +
"      {\r\n            tab: \"\",\r\n            fields: [\r\n                [\"AccountI" +
"d\", \"\"],\r\n                [\"\", \"\"],\r\n            ]\r\n        }\r\n    ];\r\n\r\n    scr" +
"udFactory.keys = [\r\n        {\r\n            property: \"AccountMasterId\",\r\n       " +
"     url: \'/api/forms/finance/account-masters/display-fields\',\r\n            data" +
": null,\r\n            valueField: \"Key\",\r\n            textField: \"Value\"\r\n       " +
" },\r\n        {\r\n            property: \"CurrencyCode\",\r\n            url: \'/api/fo" +
"rms/core/currencies/display-fields\',\r\n            data: null,\r\n            value" +
"Field: \"Key\",\r\n            textField: \"Value\"\r\n        },\r\n        {\r\n          " +
"  property: \"ParentAccountId\",\r\n            url: \'/api/forms/finance/accounts/di" +
"splay-fields\',\r\n            data: null,\r\n            valueField: \"Key\",\r\n       " +
"     textField: \"Value\"\r\n        }\r\n    ];\r\n\r\n\r\n\r\n    $.get(\'/ScrudFactory/View." +
"html\', function (view) {\r\n        $.get(\'/ScrudFactory/Form.html\', function (for" +
"m) {\r\n            $(\"#ScrudFactoryView\").html(view);\r\n            $(\"#ScrudFacto" +
"ryForm\").html(form);\r\n            $.cachedScript(\"/assets/js/scrudfactory-view.j" +
"s\");\r\n            $.cachedScript(\"/assets/js/scrudfactory-form.js\");\r\n        })" +
";\r\n    });\r\n</script>\r\n\r\n<div");

WriteLiteral(" id=\"ScrudFactoryForm\"");

WriteLiteral("></div>\r\n<div");

WriteLiteral(" id=\"ScrudFactoryView\"");

WriteLiteral("></div>");

        }
    }
}
#pragma warning restore 1591
