#pragma checksum "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\VisionCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2afc125429a845e348300b3a786107f5432e1c99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_VisionCreate), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/VisionCreate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2afc125429a845e348300b3a786107f5432e1c99", @"/Areas/Admin/Views/Home/VisionCreate.cshtml")]
    public class Areas_Admin_Views_Home_VisionCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebSiteBackend.WebUI.Areas.Admin.Models.VisionModels.VisionCreateModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/build/ckeditor.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\VisionCreate.cshtml"
  
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\VisionCreate.cshtml"
 using (Html.BeginForm("VisionCreate", "Home", FormMethod.Post, new { enctype = "multipart/form-data" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\VisionCreate.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\r\n        <div class=\"card-header\">\r\n            Vision\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 16 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\VisionCreate.cshtml"
           Write(Html.LabelFor(m => m.Content, new { @class = "col-sm-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 17 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\VisionCreate.cshtml"
           Write(Html.TextAreaFor(m => m.Content, new { @class = "form-control form-control-user" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 18 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\VisionCreate.cshtml"
           Write(Html.ValidationMessageFor(m => m.Content, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 21 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\VisionCreate.cshtml"
           Write(Html.DropDownListFor(m => m.Language, new List<SelectListItem>{
                new SelectListItem {Text="Türkçe",Value="1"},
                new SelectListItem {Text="İngilizce",Value="2"}
            }, new { @class = "form-control form-control-user" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 25 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\VisionCreate.cshtml"
           Write(Html.ValidationMessageFor(m => m.Language, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <input type=\"submit\" value=\"Kaydet\" class=\"btn btn-primary\" />\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 30 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\VisionCreate.cshtml"
}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2afc125429a845e348300b3a786107f5432e1c996488", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"


    <script>

				class MyUploadAdapter {
		constructor( loader ) {
			// The file loader instance to use during the upload. It sounds scary but do not
			// worry — the loader will be passed into the adapter later on in this guide.
			this.loader = loader;
		}


			upload() {
			return this.loader.file
				.then( file => new Promise( ( resolve, reject ) => {
					this._initRequest();
					this._initListeners( resolve, reject, file );
					this._sendRequest( file );
				} ) );
		}

		// Aborts the upload process.
		abort() {
			if ( this.xhr ) {
				this.xhr.abort();
			}
		}
		// Initializes the XMLHttpRequest object using the URL passed to the constructor.
		_initRequest() {
			const xhr = this.xhr = new XMLHttpRequest();

			// Note that your request may look different. It is up to you and your editor
			// integration to choose the right communication channel. This example uses
			// a POST request with JSON as a data structure but your configuration
			// could be di");
                WriteLiteral("fferent.\r\n\t\t\txhr.open( \'POST\', \'");
#nullable restore
#line 69 "C:\Users\ÇİĞDEM\Documents\GitHub\WebSiteBackend\WebSiteBackend.WebUI\Areas\Admin\Views\Home\VisionCreate.cshtml"
                          Write(Url.Action("UploadImage","Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"', true );
			xhr.responseType = 'json';
		}
		// Initializes XMLHttpRequest listeners.
		_initListeners( resolve, reject, file ) {
			const xhr = this.xhr;
			const loader = this.loader;
			const genericErrorText = `Couldn't upload file: ${ file.name }.`;

			xhr.addEventListener( 'error', () => reject( genericErrorText ) );
			xhr.addEventListener( 'abort', () => reject() );
			xhr.addEventListener( 'load', () => {
				const response = xhr.response;

				// This example assumes the XHR server's ""response"" object will come with
				// an ""error"" which has its own ""message"" that can be passed to reject()
				// in the upload promise.
				//
				// Your integration may handle upload errors in a different way so make sure
				// it is done properly. The reject() function must be called when the upload fails.
				if ( !response || response.error ) {
					return reject( response && response.error ? response.error.message : genericErrorText );
				}

				// If the upload is successful, reso");
                WriteLiteral(@"lve the upload promise with an object containing
				// at least the ""default"" URL, pointing to the image on the server.
				// This URL will be used to display the image in the content. Learn more in the
				// UploadAdapter#upload documentation.
				resolve( {
					default: response.url
				} );
			} );

			// Upload progress when it is supported. The file loader has the #uploadTotal and #uploaded
			// properties which are used e.g. to display the upload progress bar in the editor
			// user interface.
			if ( xhr.upload ) {
				xhr.upload.addEventListener( 'progress', evt => {
					if ( evt.lengthComputable ) {
						loader.uploadTotal = evt.total;
						loader.uploaded = evt.loaded;
					}
				} );
			}
		}
		 // Prepares the data and sends the request.
		_sendRequest( file ) {
			// Prepare the form data.
			const data = new FormData();

			data.append( 'upload', file );

			// Important note: This is the right place to implement security mechanisms
			// like authentication");
                WriteLiteral(@" and CSRF protection. For instance, you can use
			// XMLHttpRequest.setRequestHeader() to set the request headers containing
			// the CSRF token generated earlier by your application.

			// Send the request.
			this.xhr.send( data );
		}
	}

	function MyCustomUploadAdapterPlugin( editor ) {
		editor.plugins.get( 'FileRepository' ).createUploadAdapter = ( loader ) => {
			// Configure the URL to the upload script in your back-end here!
			return new MyUploadAdapter( loader );
		};
	}


				ClassicEditor.create( document.querySelector( '#Content' ), {
					extraPlugins: [ MyCustomUploadAdapterPlugin ],
					toolbar: {
						items: [
							'heading',
							'|',
							'fontColor',
							'fontFamily',
							'fontSize',
							'bold',
							'italic',
							'alignment',
							'codeBlock',
							'|',
							'numberedList',
							'bulletedList',
							'link',
							'|',
							'outdent',
							'indent',
							'|',
							'imageUpload',
							'blockQuote',
					");
                WriteLiteral(@"		'insertTable',
							'mediaEmbed',
							'undo',
							'redo'
						]
					},
					language: 'tr',
					image: {
						toolbar: [
							'imageTextAlternative',
							'imageStyle:inline',
							'imageStyle:block',
							'imageStyle:side'
						]
					},
					table: {
						contentToolbar: [
							'tableColumn',
							'tableRow',
							'mergeTableCells'
						]
					},
						licenseKey: '',



					} )
					.then( editor => {
						window.editor = editor;




					} )
					.catch( error => {
						console.error( 'Oops, something went wrong!' );
						console.error( 'Please, report the following error on https://github.com/ckeditor/ckeditor5/issues with the build id and the error stack trace:' );
						console.warn( 'Build id: fdgu51bobskf-84ezib4fqubo' );
						console.error( error );
					} );
    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebSiteBackend.WebUI.Areas.Admin.Models.VisionModels.VisionCreateModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
