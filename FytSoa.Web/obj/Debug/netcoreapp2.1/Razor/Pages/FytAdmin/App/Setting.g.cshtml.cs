#pragma checksum "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\App\Setting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66b517a4ed0ce7942464a03dc63778698ff0d46f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.App.Pages_FytAdmin_App_Setting), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/App/Setting.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/App/Setting.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.App.Pages_FytAdmin_App_Setting), null)]
namespace FytSoa.Web.Pages.FytAdmin.App
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66b517a4ed0ce7942464a03dc63778698ff0d46f", @"/Pages/FytAdmin/App/Setting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_App_Setting : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\App\Setting.cshtml"
  
    ViewData["Title"] = "App版本设置";
    Layout = AdminLayout.Pjax(HttpContext);

#line default
#line hidden
            BeginContext(146, 4785, true);
            WriteLiteral(@"<div id=""container"">
    <div class=""list-wall"">
        <div class=""layui-form list-search"" style=""margin-top:10px;"">
            <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolAdd""><i class=""layui-icon""></i> 新增</button>
            <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolDel""><i class=""layui-icon""></i> 删除</button>
        </div>
        <table class=""layui-hide"" id=""tablist"" lay-filter=""tool""></table>
    </div>
    <script type=""text/html"" id=""switchTpl"">
        <input type=""checkbox"" name=""status"" value=""{{d.guid}}"" lay-skin=""switch"" lay-text=""开|关"" lay-filter=""statusedit"" {{ d.iosAudit==1?'checked':''}}>
    </script>
    <script>
        layui.config({
            base: '/themes/js/modules/'
        }).use(['table', 'layer', 'jquery', 'common'],
            function () {
                var table = layui.table,
                    layer = layui.layer,
                    $ = layui.jquery,
                    os = layui.common;
      ");
            WriteLiteral(@"          table.render({
                    elem: '#tablist',
                    url: '/api/setting/getpages',
                    cols: [
                        [
                            { type: 'checkbox', fixed: 'left' },
                            { field: 'androidVersion',width:120, title: '安卓版本号', fixed: 'left' },
                            { field: 'androidFile', title: '安卓更新文件'},
                            { field: 'iosVersion', width: 120, title: 'Ios版本号' },
                            { field: 'iosFile', title: 'Ios更新文件'},
                            { field: 'iosAudit', width: 150, title: 'Ios审核开关', templet: '#switchTpl' },
                            { field: 'updateDate', width: 200, title: '更新时间', sort: true },
                            { width: 100, title: '操作', templet: '#tool' }
                        ]
                    ],
                    page: true,
                    id: 'tables'
                });

                var guid = '', active = {
        ");
            WriteLiteral(@"            reload: function () {
                        table.reload('tables',
                            {
                                page: {
                                    curr: 1
                                }
                            });
                    },
                    toolAdd: function () {
                        os.Open('添加更新信息', '/fytadmin/app/settingmodify', '650px', '420px', function () {
                            active.reload();
                        });
                    },
                    toolDel: function () {
                        var checkStatus = table.checkStatus('tables')
                            , data = checkStatus.data;
                        if (data.length === 0) {
                            os.error(""请选择要删除的项目~"");
                            return;
                        }
                        var str = '';
                        $.each(data, function (i, item) {
                            str += item.guid + ");
            WriteLiteral(@""","";
                        });
                        layer.confirm('确定要执行批量删除吗？', function (index) {
                            layer.close(index);
                            var loadindex = layer.load(1, {
                                shade: [0.1, '#000']
                            });
                            os.ajax('api/setting/delete/', { parm: str }, function (res) {
                                layer.close(loadindex);
                                if (res.statusCode === 200) {
                                    active.reload();
                                    os.success('删除成功！');
                                } else {
                                    os.error(res.message);
                                }
                            });
                        });

                    }
                };
                $('.list-search .layui-btn').on('click', function () {
                    var type = $(this).data('type');
                    activ");
            WriteLiteral(@"e[type] ? active[type].call(this) : '';
                });
                //监听工具条
                table.on('tool(tool)', function (obj) {
                    var data = obj.data;
                    if (obj.event === 'edit') {
                        os.Open('修改更新信息', '/fytadmin/app/settingmodify/?guid=' + data.guid, '650px', '420px', function () {
                            active.reload();
                        })
                    }
                });
            });
    </script>
    <script type=""text/html"" id=""tool"">
        <a class=""layui-btn layui-btn-primary layui-btn-xs"" lay-event=""edit""><i class=""layui-icon""></i> 修改</a>
    </script>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.App.SettingModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.App.SettingModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.App.SettingModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.App.SettingModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
