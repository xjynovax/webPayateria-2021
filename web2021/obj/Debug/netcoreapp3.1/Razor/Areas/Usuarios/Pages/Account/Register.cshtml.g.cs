#pragma checksum "D:\Universidad\Ciclo 9\Ing. WEB\PROYECTO\web2021\web2021\Areas\Usuarios\Pages\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "989db2f9054709565be862b5e6d63d320e18b87f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(web2021.Areas.Usuarios.Pages.Account.Account.Areas_Usuarios_Pages_Account_Register), @"mvc.1.0.razor-page", @"/Areas/Usuarios/Pages/Account/Register.cshtml")]
namespace web2021.Areas.Usuarios.Pages.Account.Account
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
#line 1 "D:\Universidad\Ciclo 9\Ing. WEB\PROYECTO\web2021\web2021\Areas\Usuarios\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Universidad\Ciclo 9\Ing. WEB\PROYECTO\web2021\web2021\Areas\Usuarios\Pages\_ViewImports.cshtml"
using web2021.Areas.Usuarios.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/Users/Register")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"989db2f9054709565be862b5e6d63d320e18b87f", @"/Areas/Usuarios/Pages/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bd2db614068f38ad68f6f65c8784d55447190cd", @"/Areas/Usuarios/Pages/_ViewImports.cshtml")]
    public class Areas_Usuarios_Pages_Account_Register : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Universidad\Ciclo 9\Ing. WEB\PROYECTO\web2021\web2021\Areas\Usuarios\Pages\Account\Register.cshtml"
  
    var image = "/images/images/user.jpg";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container p-4"">
    <form method=""post"" enctype=""multipart/form-data"">
        <div class=""row"">
            <div class=""col-sm-6 col-md-3"">
                <div class=""card text-center"">
                    <div class=""card-header"">
                        <output id=""imageUser"">
                            <img");
            BeginWriteAttribute("src", " src=", 435, "", 446, 1);
#nullable restore
#line 15 "D:\Universidad\Ciclo 9\Ing. WEB\PROYECTO\web2021\web2021\Areas\Usuarios\Pages\Account\Register.cshtml"
WriteAttributeValue("", 440, image, 440, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""imageUser"" />
                        </output>
                    </div>
                    <div class=""card-body"">
                        <div class=""caption text-center"">
                            <label class=""btn btn-primary"" for=""files"">cargar foto</label>
                            <input asp-for=""Input.AvatarImage"" accept=""image/*"" type=""file"" id=""files"" />
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-xs-6 col-md-5"">
                <div class=""panel panel-primary"">
                    <div class=""panel-heading"">
                        <h3 class=""panel-title"">Registrar Usuario</h3>
                    </div>
                    <div class=""panel-body"">
                        <div class=""accordion"" id=""accordionExample"">
                            <div class=""card"">
                                <div clas=""card-header"" id=""headingOne"">
                                    <div id=""he");
            WriteLiteral(@"ader"" class=""bg-info"">
                                        <h2 class=""mb-0 t"">
                                            <button class=""btn btn-link text-light"" type=""button"" data-toggle=""collapse""
                                                    data-target=""#collapseOne"" aria-expanded=""true"" aria-controls=""collapseOne"">
                                                Ingresar Informacion
                                            </button>

                                        </h2>
                                    </div>
                                </div>
                                <div id=""collapseOne"" class=""collapse show"" aria-labelledby=""headingOne""
                                     data-parent=""#accordionExample"">
                                    <div class=""card-body"">
                                        <div class=""form-group"">
                                            <input asp-for=""Input.NID"" placeholder=""NID"" class=""form-control"" autofocus />
 ");
            WriteLiteral(@"                                           <span asp-validation-for=""Input.NID"" class=""text-danger""></span>
                                        </div>
                                        <div class=""form-group"">
                                            <input asp-for=""Input.Name"" placeholder=""Name"" class=""form-control"" />
                                            <span asp-validation-for=""Input.Name"" class=""text-danger""></span>
                                        </div>
                                        <div class=""form-group"">
                                            <input asp-for=""Input.LastName"" placeholder=""LastName"" class=""form-control"" />
                                            <span asp-validation-for=""Input.LastName"" class=""text-danger""></span>
                                        </div>
                                        <div class=""form-group"">
                                            <input asp-for=""Input.PhoneNumber"" placeholder=""PhoneNumber"" cl");
            WriteLiteral(@"ass=""form-control"" />
                                            <span asp-validation-for=""Input.PhoneNumber"" class=""text-danger""></span>
                                        </div>
                                        <div class=""form-group"">
                                            <input asp-for=""Input.Email"" placeholder=""Email"" class=""form-control"" />
                                            <span asp-validation-for=""Input.Email"" class=""text-danger""></span>
                                        </div>
                                        <div class=""form-group"">
                                            <input asp-for=""Input.Password"" placeholder=""Password"" class=""form-control"" />
                                            <span asp-validation-for=""Input.Password"" class=""text-danger""></span>
                                        </div>
                                        <div class=""form-group"">
                                            ");
#nullable restore
#line 73 "D:\Universidad\Ciclo 9\Ing. WEB\PROYECTO\web2021\web2021\Areas\Usuarios\Pages\Account\Register.cshtml"
                                       Write(Html.DropDownList("Input.Role", new SelectList(Model.Input.rolesLista, "Text", "Text"), "Seleccione un role", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
                                        </div>
                                        <div class=""form-group"">
                                            <button type=""submit"" class=""btn btn-primary btn-block"">Register</button>
                                        </div>
                                        <div class=""form-group"">
                                            <label class=""text-danger"">");
#nullable restore
#line 79 "D:\Universidad\Ciclo 9\Ing. WEB\PROYECTO\web2021\web2021\Areas\Usuarios\Pages\Account\Register.cshtml"
                                                                  Write(Html.DisplayFor(m => m.Input.ErrorMessage));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  </label>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</div>
    </form>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterModel>)PageContext?.ViewData;
        public RegisterModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
