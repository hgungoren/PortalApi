#pragma checksum "C:\Users\huseyin.gungoren\Source\Workspaces\Workspace\SK.Portal.Api\src\Serendip.IK.Web.Host\Templates\Mail\Notification.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3abcdda7a9da0b1a354c4d4100dde4aabb25be6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_Mail_Notification), @"mvc.1.0.view", @"/Templates/Mail/Notification.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3abcdda7a9da0b1a354c4d4100dde4aabb25be6b", @"/Templates/Mail/Notification.cshtml")]
    public class Templates_Mail_Notification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<table align=""center"" style=""width: 100%;font-family:Tahoma,'Segoe UI', Geneva, Verdana, sans-serif;"">
    <tr align=""center"">
        <td>
            <table style=""width:600px;margin:0;padding:20px;border:0;"" cellspacing=""0"" cellpadding=""0"">
                <tbody>
                    <tr>
                        <td style=""background-color:#FF725E;padding:30px 24px 24px 24px;"">
                            <a style=""text-align:center;padding-left:40%; border:0;text-decoration:none;"" target=""_blank""");
            BeginWriteAttribute("href", " href=\"", 512, "\"", 533, 1);
#line 8 "C:\Users\huseyin.gungoren\Source\Workspaces\Workspace\SK.Portal.Api\src\Serendip.IK.Web.Host\Templates\Mail\Notification.cshtml"
WriteAttributeValue("", 519, Model.SiteUrl, 519, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(@"><img src=""http://www.fowapps.com/mail-content/crm-logo.png"" height=""38px"" alt=""FOWcrm"" style=""border:0;"" /></a>
                            </br><br />
                            <span style=""font-family:Tahoma,'Segoe UI', Geneva, Verdana, sans-serif;font-size: 19px;color: white;"">
                                <b>");
#line 11 "C:\Users\huseyin.gungoren\Source\Workspaces\Workspace\SK.Portal.Api\src\Serendip.IK.Web.Host\Templates\Mail\Notification.cshtml"
                              Write(Model.Message.NameValue);

#line default
#line hidden
            WriteLiteral("  ");
#line 11 "C:\Users\huseyin.gungoren\Source\Workspaces\Workspace\SK.Portal.Api\src\Serendip.IK.Web.Host\Templates\Mail\Notification.cshtml"
                                                        Write(Model.Message.Operation);

#line default
#line hidden
            WriteLiteral("</b>\r\n                            </span></br>\r\n                            <span style=\"font-family:Tahoma,\'Segoe UI\', Geneva, Verdana, sans-serif;font-size: 13px; color: white;\">\r\n                                ");
#line 14 "C:\Users\huseyin.gungoren\Source\Workspaces\Workspace\SK.Portal.Api\src\Serendip.IK.Web.Host\Templates\Mail\Notification.cshtml"
                           Write(Model.Message.operatingUserValue);

#line default
#line hidden
            WriteLiteral("  ");
#line 14 "C:\Users\huseyin.gungoren\Source\Workspaces\Workspace\SK.Portal.Api\src\Serendip.IK.Web.Host\Templates\Mail\Notification.cshtml"
                                                              Write(Model.Message.operatingUserKey);

#line default
#line hidden
            WriteLiteral(@"
                            </span>
                        </td>
                    </tr>
                    <tr>
                        <td style=""padding: 10px;"">
                            <table style=""width:552px;margin:0;padding:12px;border: 1px solid #E3E3E3;border-radius:8px;"" cellspacing=""0"" cellpadding=""0"">
                                <tr>
                                    <td colspan=""8"">
                                        <span style=""text-align: justify;margin: 0;padding: 24px 12px;font-family:Tahoma,'Segoe UI', Geneva, Verdana, sans-serif;font-size: 14px;color: #303435;""><b>");
#line 23 "C:\Users\huseyin.gungoren\Source\Workspaces\Workspace\SK.Portal.Api\src\Serendip.IK.Web.Host\Templates\Mail\Notification.cshtml"
                                                                                                                                                                                                Write(Model.Message.NameKey);

#line default
#line hidden
            WriteLiteral(" :</b>");
#line 23 "C:\Users\huseyin.gungoren\Source\Workspaces\Workspace\SK.Portal.Api\src\Serendip.IK.Web.Host\Templates\Mail\Notification.cshtml"
                                                                                                                                                                                                                            Write(Model.Message.NameValue);

#line default
#line hidden
            WriteLiteral(" </span>\r\n                                    </td>\r\n                                    <td rowspan=\"3\" colspan=\"4\">\r\n                                        <a style=\"text-decoration:none;\"");
            BeginWriteAttribute("href", " href=\"", 2051, "\"", 2078, 1);
#line 26 "C:\Users\huseyin.gungoren\Source\Workspaces\Workspace\SK.Portal.Api\src\Serendip.IK.Web.Host\Templates\Mail\Notification.cshtml"
WriteAttributeValue("", 2058, Model.ViewDetailUrl, 2058, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(@">
                                            <span style=""padding:0px 5px 0px 5px ;line-height: 40px;text-align: center;float:right; background-color: #FF725E;border-radius: 4px;font-family: Tahoma,'Segoe UI', Geneva, Verdana, sans-serif;font-weight: bold;font-size: 13px;color: #E6F6FC;text-decoration: none;"">");
#line 27 "C:\Users\huseyin.gungoren\Source\Workspaces\Workspace\SK.Portal.Api\src\Serendip.IK.Web.Host\Templates\Mail\Notification.cshtml"
                                                                                                                                                                                                                                                                                                                 Write(Model.ViewDetailText);

#line default
#line hidden
            WriteLiteral("</span>\r\n                                        </a><br />\r\n");
            WriteLiteral(@"                                    </td>
                                </tr>
                                <tr>
                                    <td colspan=""8"">
                                        <span style=""text-align: justify;margin: 0;padding: 24px 12px;font-family:Tahoma,'Segoe UI', Geneva, Verdana, sans-serif;font-size: 14px;color: #303435;""><b>");
#line 34 "C:\Users\huseyin.gungoren\Source\Workspaces\Workspace\SK.Portal.Api\src\Serendip.IK.Web.Host\Templates\Mail\Notification.cshtml"
                                                                                                                                                                                                Write(Model.Message.DateKey);

#line default
#line hidden
            WriteLiteral(" :</b>");
#line 34 "C:\Users\huseyin.gungoren\Source\Workspaces\Workspace\SK.Portal.Api\src\Serendip.IK.Web.Host\Templates\Mail\Notification.cshtml"
                                                                                                                                                                                                                            Write(Model.Message.DateValue);

#line default
#line hidden
            WriteLiteral(@" </span>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan=""8"">
                                        <span style=""text-align: justify;margin: 0;padding: 24px 12px;font-family: Tahoma,'Segoe UI', Geneva, Verdana, sans-serif;font-size: 14px;color: #303435;""><b>");
#line 39 "C:\Users\huseyin.gungoren\Source\Workspaces\Workspace\SK.Portal.Api\src\Serendip.IK.Web.Host\Templates\Mail\Notification.cshtml"
                                                                                                                                                                                                 Write(Model.Message.DescriptionKey);

#line default
#line hidden
            WriteLiteral(" :</b>");
#line 39 "C:\Users\huseyin.gungoren\Source\Workspaces\Workspace\SK.Portal.Api\src\Serendip.IK.Web.Host\Templates\Mail\Notification.cshtml"
                                                                                                                                                                                                                                    Write(Model.Message.DescriptionValue);

#line default
#line hidden
            WriteLiteral(@"</span>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan=""8"">
                                        <span style=""text-align: justify;margin: 0;padding: 24px 12px;font-family: Tahoma,'Segoe UI', Geneva, Verdana, sans-serif;font-size: 14px;color: #303435;""><b>");
#line 44 "C:\Users\huseyin.gungoren\Source\Workspaces\Workspace\SK.Portal.Api\src\Serendip.IK.Web.Host\Templates\Mail\Notification.cshtml"
                                                                                                                                                                                                 Write(Model.Message.ErrorStatusCodeKey);

#line default
#line hidden
            WriteLiteral(" :</b>");
#line 44 "C:\Users\huseyin.gungoren\Source\Workspaces\Workspace\SK.Portal.Api\src\Serendip.IK.Web.Host\Templates\Mail\Notification.cshtml"
                                                                                                                                                                                                                                        Write(Model.Message.ErrorStatusCodeValue);

#line default
#line hidden
            WriteLiteral(@"</span>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </tbody>
            </table>
        </td>
    </tr>
</table>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
