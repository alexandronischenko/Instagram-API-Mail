#pragma checksum "/Users/alexandronischenko/Projects/Instagram-API/Instagram-API/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84dbfcd1167f546d3ed2774d4c65d8bf85b53a5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/alexandronischenko/Projects/Instagram-API/Instagram-API/Views/_ViewImports.cshtml"
using Instagram_API;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/alexandronischenko/Projects/Instagram-API/Instagram-API/Views/_ViewImports.cshtml"
using Instagram_API.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84dbfcd1167f546d3ed2774d4c65d8bf85b53a5f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fca5af18516f56244a40199d1f728405a15ef2ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendMail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(@"margin-top: 8px; margin-right: 40px; margin-left: 40px; margin-bottom: 8px; justify-content: flex-start; align-items: stretch; background-color: rgba(var(--d69,0,149,246),.3);
    opacity: 1; border: 1px solid transparent; font-family: Segoe UI,Roboto,Helvetica,Arial,sans-serif;
    font-size: 14px; text-decoration-color: white;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84dbfcd1167f546d3ed2774d4c65d8bf85b53a5f5467", async() => {
                WriteLiteral(@"
    <title>Instagram</title>
    <link rel=""stylesheet"" type=""text/css"" href=""style.css"">
    <style>
        body {
            background-color: #fafafa;
            text-align: center;
            height: 100%;
        }
    </style>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"" integrity=""sha384-HSMxcRTRxnN+Bdg0JdbxYKrThecOKuH5zCYotlSAcp1+c8xmyTe9GYg1l9a69psu"" crossorigin=""anonymous"">

    <!-- Optional theme -->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap-theme.min.css"" integrity=""sha384-6pzBo3FDv/PJ8r2KRkGHifhEocL+1X2rVCTTkUfGk7/0pbek5mMa1upzvWbrUbOZ"" crossorigin=""anonymous"">

    <!-- Latest compiled and minified JavaScript -->
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"" integrity=""sha384-aJ21OjlMXNL5UyIl/XNwTMqvzeRMZH2w8c5cRVpzpU8Y5bApTppSuUkhZXN0VxHd"" crossorigin=""anonymous""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84dbfcd1167f546d3ed2774d4c65d8bf85b53a5f7410", async() => {
                WriteLiteral(@"
    <div style=""display: flex; align-items: stretch; justify-content: center; margin: 32px auto 0; max-width: 935px; padding-bottom: 32px; width: 100%; overflow: hidden;"">

        <div style=""background-image: url(https://www.instagram.com/static/images/homepage/home-phones@2x.png/9364675fb26a.png); flex-basis: 454px; height: 618px; margin-left: -35px; margin-right: -15px; background-size: 454px 618px;"">
        </div>

        <div style=""border-color: black; justify-content: center; margin-top: 12px; max-width: 350px; align-items: center; margin: 0 0 10px;
    padding: 10px 0;"">
            <div style=""background-color: white; width: 350px; height: 380px; border: 1px solid #dbdbdb; margin: 22px auto 12px; align-items: center;"">
                <h1 style=""background-image: url(https://www.instagram.com/static/bundles/es6/sprite_core_2x_bcd90c1d4868.png/bcd90c1d4868.png); background-size: 440px 411px; background-repeat: no-repeat;
      background-position: 0 -130px;
      height: 51px;
      width: 175px;
");
                WriteLiteral(@"      align-items: center; margin: 22px auto 12px;"">
                </h1>
                <div style=""margin-bottom: 10px; margin-top: 24px; max-width: 350px; width: 100%; display: flex; flex-direction: column; align-items: stretch;"">
                    <div style="" display: flex; flex-direction: column; justify-content: center;"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84dbfcd1167f546d3ed2774d4c65d8bf85b53a5f9095", async() => {
                    WriteLiteral(@"
                            <input type=""text"" name=""login"" placeholder=""Phone number, username, or email"" style=""border: 1px solid rgba(var(--ca6,219,219,219),1); border-radius: 3px; margin-top: 24px; margin: 0 40px 6px; stretch"">
                            <input type=""text"" name=""password"" placeholder=""Password"" style=""border: 1px solid rgba(var(--ca6,219,219,219),1); border-radius: 3px; margin: 0 40px 6px;"">
                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84dbfcd1167f546d3ed2774d4c65d8bf85b53a5f9818", async() => {
                        WriteLiteral("\n                                Log In\n                            ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                        <div style=""flex-direction: row; margin: 10px 40px 18px; align-items: stretch;
        border: 0 solid #000; padding: 0;
        display: flex; justify-content: space-around"">


                            <div style=""display: flex; flex-direction: row; align-items: stretch;"">
                                <div style=""background-color: rgba(var(--b38,219,219,219),1);
    height: 1px; top: .45em; background-color: #dbdbdb; flex-grow: 1;""></div>
                                <div>
                                    OR
                                </div>
                                <div style=""background-color: rgba(var(--b38,219,219,219),1);
    height: 1px;""></div>
                            </div>
                        </div>

                        <button style=""border: 0; color: #0095f6; color: rgba(var(--d69,0,149,246),1); display: inline; padding: 0; position: relative; background: 0 0; margin-top: 16px; margin-right: 40px; margin-left: 40px; margin-bottom: 8px; ");
                WriteLiteral(@"flex: 0 0 auto; justify-content: flex-start; font-size: 16"">
                            Log In with Facebook
                        </button>
                        <p style=""font-size: 12; margin-top: 12px;"">Forgot password?</p>

                    </div>
                </div>
            </div>
            <div style=""background-color: white; border-color: black; width: 350px; height: auto; align-items: center; border-radius: 1px; margin: 0 0 10px; padding: 10px 0; display: flex; border: 1px solid #dbdbdb; justify-content: center"">
                <div style=""font-size: 14px;line-height: 18px;margin: -3px 0 -4px;"">
                    <p style=""color: rgba(var(--i1d,38,38,38),1);font-size: 14px; margin: 15px;"">
                        Don't have an account?
                        <a href=""https://www.instagram.com/accounts/emailsignup/"" style=""color: rgba(var(--d69,0,149,246),1);"">
                            Sign up
                        </a>
                    </p>

                </div>
       ");
                WriteLiteral(@"     </div>

            <div style=""display: flex; flex-direction: column;"">
                <p style=""font-size: 14px; line-height: 18px; margin: 10px 20px 10px 20px; text-align: center;"">
                    Get the app.
                </p>
                <div style=""flex-direction: row; justify-content: center; margin: 10px 0 10px 0;"">
                    <a href=""https://apps.apple.com/app/instagram/id389801252?vt=lo"">
                        <img style=""height: 40px;"" src=""https://www.instagram.com/static/images/appstore-install-badges/badge_ios_english-en.png/180ae7a0bcf7.png"">
                    </a>
                    <a href=""https://play.google.com/store/apps/details?id=com.instagram.android&referrer=utm_source%3Dinstagramweb%26utm_campaign%3DloginPage%26ig_mid%3D9A264CDA-D74B-46DD-A8D7-7FD1542FC0F2%26utm_content%3Dlo%26utm_medium%3Dbadge"">
                        <img style=""height: 40px;"" src=""https://www.instagram.com/static/images/appstore-install-badges/badge_android_english-en.png/e9cd846");
                WriteLiteral("dc748.png\">\n                    </a>\n                </div>\n            </div>\n        </div>\n\n\n\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<footer class=""footer"">
    <div style=""margin-bottom: 52px; flex: 0 0 auto; justify-content: flex-start; align-items: stretch;"">
        <div style=""margin-top: 12px; justify-content: flex-start; flex-direction: row; display: flex; justify-content: center;"">
            <a href=""https://about.instagram.com/"" class=""bottom-link"">
                <div>About</div>
            </a>
            <a href=""https://about.instagram.com/blog/"" class=""bottom-link"">
                <div>Blog</div>
            </a>
            <a href=""https://about.instagram.com/"" class=""bottom-link"">
                <div>Jobs</div>
            </a>
            <a href=""https://about.instagram.com/blog/"" class=""bottom-link"">
                <div>Help</div>
            </a>
            <a href=""https://about.instagram.com/"" class=""bottom-link"">
                <div>API</div>
            </a>
            <a href=""https://about.instagram.com/blog/"" class=""bottom-link"">
                <div>Privacy</div>
            </a>
            <a href");
            WriteLiteral(@"=""https://about.instagram.com/"" class=""bottom-link"">
                <div>Terms</div>
            </a>
            <a href=""https://about.instagram.com/blog/"" class=""bottom-link"">
                <div>Top Accounts</div>
            </a>
            <a href=""https://about.instagram.com/"" class=""bottom-link"">
                <div>Hashtags</div>
            </a>
            <a href=""https://about.instagram.com/blog/"" class=""bottom-link"">
                <div>Location</div>
            </a>
            <a href=""https://about.instagram.com/blog/"" class=""bottom-link"">
                <div>Instagram Lite</div>
            </a>
        </div>

        <div style=""margin-top: 0; justify-content: flex-start; flex-direction: row; display: flex; justify-content: center;"">
            <a href=""https://about.instagram.com/"" class=""bottom-link"">
                <div>Beauty</div>
            </a>
            <a href=""https://about.instagram.com/blog/"" class=""bottom-link"">
                <div>Dance</div>
            </a>
   ");
            WriteLiteral(@"         <a href=""https://about.instagram.com/"" class=""bottom-link"">
                <div>Fitness</div>
            </a>
            <a href=""https://about.instagram.com/"" class=""bottom-link"">
                <div>Food & Drink</div>
            </a>
            <a href=""https://about.instagram.com/blog/"" class=""bottom-link"">
                <div>Home & Garden</div>
            </a>
            <a href=""https://about.instagram.com/"" class=""bottom-link"">
                <div>Music</div>
            </a>
            <a href=""https://about.instagram.com/"" class=""bottom-link"">
                <div>Visual Arts</div>
            </a>
        </div>

        <div style=""margin-top: 12px; margin-bottom: 12px; justify-content: flex-start; flex-direction: row; display: flex; justify-content: center;"">
            <a href=""https://about.instagram.com/"" class=""bottom-link"">
                <div>Beauty</div>
            </a>
            <a href=""https://about.instagram.com/blog/"" class=""bottom-link"">
                <div>D");
            WriteLiteral("ance</div>\n            </a>\n        </div>\n    </div>\n</footer>\n</html>\n");
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
