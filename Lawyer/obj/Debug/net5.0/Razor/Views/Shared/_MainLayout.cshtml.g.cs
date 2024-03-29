#pragma checksum "C:\Users\Hamed\source\repos\LawyerProject\Lawyer\Views\Shared\_MainLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61c42aa4d6a0b004c5d1df80e08d3dd5d335d316"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MainLayout), @"mvc.1.0.view", @"/Views/Shared/_MainLayout.cshtml")]
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
#line 1 "C:\Users\Hamed\source\repos\LawyerProject\Lawyer\Views\_ViewImports.cshtml"
using Lawyer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61c42aa4d6a0b004c5d1df80e08d3dd5d335d316", @"/Views/Shared/_MainLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dde3d9002607590b209b5c42fcaea7ee9a06653", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__MainLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />-->\r\n");
            WriteLiteral("<!--<link rel=\"stylesheet\" href=\"~/lib/bootstrap/dist/css/bootstrap.min.css\" />-->\r\n");
            WriteLiteral(@"<!--</head>
<body>
    <header>
        <nav class=""navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3"">
            <div class=""container"">
                <a class=""navbar-brand"" asp-area="""" asp-controller=""Home"" asp-action=""Index"">Lawyer</a>
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target="".navbar-collapse"" aria-controls=""navbarSupportedContent""
                        aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""navbar-collapse collapse d-sm-inline-flex justify-content-between"">
                    <ul class=""navbar-nav flex-grow-1"">
                        <li class=""nav-item"">
                            <a class=""nav-link text-dark"" asp-area="""" asp-controller=""Home"" asp-action=""Index"">Home</a>
                        </li>
                        <li class=""nav-item"">
   ");
            WriteLiteral(@"                         <a class=""nav-link text-dark"" asp-area="""" asp-controller=""Home"" asp-action=""Privacy"">Privacy</a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
    </header>
    <div class=""container"">
        <main role=""main"" class=""pb-3"">-->
");
            WriteLiteral(@"<!--</main>
</div>

<footer class=""border-top footer text-muted"">
    <div class=""container"">
        &copy; 2022 - Lawyer - <a asp-area="""" asp-controller=""Home"" asp-action=""Privacy"">Privacy</a>
    </div>
</footer>
<script src=""~/lib/jquery/dist/jquery.min.js""></script>
<script src=""~/lib/bootstrap/dist/js/bootstrap.bundle.min.js""></script>
<script src=""~/js/site.js"" asp-append-version=""true""></script>-->
");
            WriteLiteral("<!--</body>\r\n</html>-->\r\n \r\n\r\n\r\n\r\n\r\n<!doctype html>\r\n<html lang=\"fa\" dir=\"rtl\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61c42aa4d6a0b004c5d1df80e08d3dd5d335d3165422", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\r\n    <title>");
#nullable restore
#line 60 "C:\Users\Hamed\source\repos\LawyerProject\Lawyer\Views\Shared\_MainLayout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>
    <!-- CSS Styles -->
    <link rel=""stylesheet"" href=""assets/css/bootstrap.rtl.min.css"">
    <link rel=""stylesheet"" href=""assets/plugins/fontawesome/css/all.min.css"">
    <link rel=""stylesheet"" href=""assets/plugins/aos-master/dist/aos.css"">
    <link rel=""stylesheet"" href=""assets/plugins/hover-master/css/hover-min.css"">
    <link rel=""stylesheet"" href=""assets/css/ionicons.css"">
    <link rel=""stylesheet"" href=""assets/css/droopmenu.css"">
    <link rel=""stylesheet"" href=""assets/css/highlight.css"">
    <link rel=""stylesheet"" href=""assets/css/nouislider.min.css"">
    <link rel=""stylesheet"" href=""assets/css/style.css"">
    <!-- /CSS Styles -->
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61c42aa4d6a0b004c5d1df80e08d3dd5d335d3167572", async() => {
                WriteLiteral("\r\n    <!-- Header -->\r\n    ");
#nullable restore
#line 75 "C:\Users\Hamed\source\repos\LawyerProject\Lawyer\Views\Shared\_MainLayout.cshtml"
Write(await Component.InvokeAsync("Header"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <!-- /Header -->\r\n    <!-- Slider Section -->\r\n    ");
#nullable restore
#line 78 "C:\Users\Hamed\source\repos\LawyerProject\Lawyer\Views\Shared\_MainLayout.cshtml"
Write(await Component.InvokeAsync("MainSlider"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <!-- /Slider Section -->\r\n    <!-- Featured Products Section -->\r\n\r\n    ");
#nullable restore
#line 82 "C:\Users\Hamed\source\repos\LawyerProject\Lawyer\Views\Shared\_MainLayout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n    <!-- Footer -->\r\n    ");
#nullable restore
#line 86 "C:\Users\Hamed\source\repos\LawyerProject\Lawyer\Views\Shared\_MainLayout.cshtml"
Write(await Component.InvokeAsync("Footer"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <!-- /Footer -->
    <!-- Copyright -->
    <section class=""py-2"" id=""copyright"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12 col-sm-6"" id=""social-links"">
                    <span>ما را دنبال کنید</span>
                    <a href=""#""><img src=""assets/images/social/insta.png""");
                BeginWriteAttribute("alt", " alt=\"", 3886, "\"", 3892, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                    <a href=\"#\"><img src=\"assets/images/social/facebook.png\"");
                BeginWriteAttribute("alt", " alt=\"", 3976, "\"", 3982, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                    <a href=\"#\"><img src=\"assets/images/social/linkedin.png\"");
                BeginWriteAttribute("alt", " alt=\"", 4066, "\"", 4072, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                    <a href=\"#\"><img src=\"assets/images/social/twitter.png\"");
                BeginWriteAttribute("alt", " alt=\"", 4155, "\"", 4161, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                    <a href=\"#\"><img src=\"assets/images/social/youtube.png\"");
                BeginWriteAttribute("alt", " alt=\"", 4244, "\"", 4250, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                </div>
                <div class=""col-12 col-sm-6 text-sm-end pt-2 pt-sm-0"">
                    <span>کلیه حقوق و مادی معنوی محفوط است.</span>
                </div>
            </div>
        </div>
    </section>
    <!-- Copyright -->
    <!-- Scripts -->
    <script src=""assets/js/jquery.min.js""></script>
    <script src=""assets/js/bootstrap.bundle.min.js""></script>
    <script src=""assets/plugins/fontawesome/js/all.min.js""></script>
    <script src=""assets/plugins/aos-master/dist/aos.js""></script>
    <script src=""assets/js/droopmenu.js""></script>
    <script src=""assets/js/nouislider.min.js""></script>
    <script src=""assets/js/pagination.js""></script>
    <script src=""assets/js/scripts.js""></script>
    <!-- /Scripts -->
");
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
            WriteLiteral("\r\n</html>\r\n");
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
