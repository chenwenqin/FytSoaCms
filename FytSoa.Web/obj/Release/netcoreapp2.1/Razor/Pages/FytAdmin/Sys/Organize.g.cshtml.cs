#pragma checksum "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\Organize.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e71c1db3d12c40c0392a924e5e631b5866337aa9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Sys.Pages_FytAdmin_Sys_Organize), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Sys/Organize.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Sys/Organize.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Sys.Pages_FytAdmin_Sys_Organize), null)]
namespace FytSoa.Web.Pages.FytAdmin.Sys
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e71c1db3d12c40c0392a924e5e631b5866337aa9", @"/Pages/FytAdmin/Sys/Organize.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Sys_Organize : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/ztree/css/metroStyle/metroStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 3 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\Organize.cshtml"
  
    ViewData["Title"] = "部门管理";
    Layout = AdminLayout.Pjax(HttpContext);

#line default
#line hidden
            BeginContext(144, 690, true);
            WriteLiteral(@"<div id=""container"">
    <div class=""layui-col-220"">
        <div class=""layui-nav-title"">组织架构</div>
        <ul id=""tree"" class=""ztree layui-tree-cus""></ul>
    </div>
    <div class=""right-col-body"">
        <div class=""list-wall"">
            <div class=""layui-form list-search"">
                <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""organizeAdd""><i class=""layui-icon""></i> 新增</button>
                <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""organizeDel""><i class=""layui-icon""></i> 删除</button>
            </div>
            <table class=""layui-hide"" id=""tablist"" lay-filter=""tool""></table>
        </div>
    </div>
    ");
            EndContext();
            BeginContext(834, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cd62b6688a9848ba8243f47d22990901", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(925, 5371, true);
            WriteLiteral(@"
    <script type=""text/html"" id=""switchTpl"">
        <input type=""checkbox"" name=""status"" value=""{{d.guid}}"" lay-skin=""switch"" lay-text=""ON|OFF"" lay-filter=""statusedit"" {{ d.status?'checked':''}}>
    </script>

    <script>
        layui.config({
            base: '/themes/js/modules/'
        }).use(['table', 'layer', 'jquery', 'ztree', 'common'],
            function () {
                var table = layui.table,
                    layer = layui.layer,
                    $ = layui.jquery,
                    ztree = layui.ztree,
                    os = layui.common,
                    form = layui.form;
                table.render({
                    elem: '#tablist',
                    url: '/api/organize/getpages',
                    cols: [
                        [
                            { type: 'checkbox', fixed: 'left' },
                            { field: 'name', title: '组织名称', sort: true, fixed: 'left' },
                            { field: 'parentName', titl");
            WriteLiteral(@"e: '父节点名称' },
                            { field: 'sort', width: 150, title: '排序', sort: true },
                            { field: 'status', width: 150, title: '状态', templet: '#switchTpl' },
                            { width: 100, title: '操作', templet: '#tool' }
                        ]
                    ],
                    page: true,
                    limit:15,
                    id: 'tables'
                });
                var setting = {
                    async: {
                        enable: true,
                        url: ""/api/organize/gettree""
                    },
                    callback: {
                        onClick: onClick
                    }
                };
                var guid = '', typeName = '', active = {
                    reload: function () {
                        table.reload('tables',
                            {
                                page: {
                                    curr: 1
                 ");
            WriteLiteral(@"               },
                                where: {
                                    key: guid
                                }
                            });
                    },
                    organizeAdd: function () {
                        os.Open('添加部门', '/fytadmin/sys/organizemodify', '620px', '370px', function () {
                            active.reload();
                            var tree = $.fn.zTree.getZTreeObj(""tree"");
                            tree.reAsyncChildNodes(null, ""refresh"");
                        });
                    },
                    organizeDel: function () {
                        var checkStatus = table.checkStatus('tables')
                            , data = checkStatus.data;
                        if (data.length === 0) {
                            os.warning(""请选择要删除的项目~"");
                            return;
                        }
                        var str = '';
                        $.each(data, function (");
            WriteLiteral(@"i, item) {
                            str += item.guid + "","";
                        });
                        layer.confirm('确定要执行批量删除吗？', function (index) {
                            layer.close(index);
                            var loadindex = layer.load(1, {
                                shade: [0.1, '#000']
                            });
                            os.ajax('api/organize/delete/', { parm: str }, function (res) {
                                layer.close(loadindex);
                                if (res.statusCode === 200) {
                                    active.reload();
                                    var tree = $.fn.zTree.getZTreeObj(""tree"");
                                    tree.reAsyncChildNodes(null, ""refresh"");
                                    os.success('删除成功！');
                                } else {
                                    os.error(res.message);
                                }
                            });
       ");
            WriteLiteral(@"                 });

                    }
                };
                $.fn.zTree.init($(""#tree""), setting);
                $('.list-search .layui-btn').on('click', function () {
                    var type = $(this).data('type');
                    active[type] ? active[type].call(this) : '';
                });
                function onClick(event, treeId, treeNode, clickFlag) {
                    guid = treeNode.guid;
                    active.reload();
                }
                //监听工具条
                table.on('tool(tool)', function (obj) {
                    var data = obj.data;
                    if (obj.event === 'edit') {
                        os.Open('编辑部门', '/fytadmin/sys/organizemodify/?guid=' + data.guid, '620px', '370px', function () {
                            var tree = $.fn.zTree.getZTreeObj(""tree"");
                            tree.reAsyncChildNodes(null, ""refresh"");
                            active.reload();
                        })
    ");
            WriteLiteral("                }\r\n                });\r\n            });\r\n    </script>\r\n    <script type=\"text/html\" id=\"tool\">\r\n        <a class=\"layui-btn layui-btn-primary layui-btn-xs\" lay-event=\"edit\"><i class=\"layui-icon\"></i> 修改</a>\r\n    </script>\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Sys.OrganizeModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Sys.OrganizeModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Sys.OrganizeModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Sys.OrganizeModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
