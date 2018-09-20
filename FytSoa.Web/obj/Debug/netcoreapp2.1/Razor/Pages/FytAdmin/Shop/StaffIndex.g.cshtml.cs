#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\StaffIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0326d291eda245c0fa4298330dfc3b9004b86f27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Shop.Pages_FytAdmin_Shop_StaffIndex), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Shop/StaffIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Shop/StaffIndex.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Shop.Pages_FytAdmin_Shop_StaffIndex), null)]
namespace FytSoa.Web.Pages.FytAdmin.Shop
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0326d291eda245c0fa4298330dfc3b9004b86f27", @"/Pages/FytAdmin/Shop/StaffIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Shop_StaffIndex : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\StaffIndex.cshtml"
  
    ViewData["Title"] = "员工管理";
    Layout = string.IsNullOrEmpty(Model.shopGuid)?AdminLayout.Pjax(HttpContext): "~/Pages/FytAdmin/_Layout.cshtml";

#line default
#line hidden
            BeginContext(219, 1494, true);
            WriteLiteral(@"<div id=""container"">
    <div class=""list-wall"">
        <div class=""layui-form list-search"">
            <div class=""layui-inline"">
                <input class=""layui-input"" id=""key"" autocomplete=""off"" placeholder=""请输入关键字查询"">
            </div>
            <div class=""layui-inline lay-time-icon"">
                <input class=""layui-input"" id=""times"" autocomplete=""off"" placeholder=""时间区间""><i class=""layui-icon layui-icon-date""></i>
            </div>
            <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolSearch""><i class=""layui-icon layui-icon-search""></i> 搜索</button>
        </div>
        <table class=""layui-hide"" id=""tablist"" lay-filter=""tool""></table>
    </div>
    <div class=""list-wall"">
        <table class=""layui-hide"" id=""tablist"" lay-filter=""tool""></table>
    </div>
    <script>
        layui.config({
            base: '/themes/js/modules/'
        }).use(['table', 'layer', 'jquery', 'common', 'laydate'],
            function () {
                var tab");
            WriteLiteral(@"le = layui.table,
                    layer = layui.layer,
                    $ = layui.jquery,
                    os = layui.common
                    , laydate = layui.laydate;
                laydate.render({
                    elem: '#times'
                    , theme: '#393D49'
                    , format: 'yyyy/MM/dd'
                    , range: true
                });
                var urls = '/api/shops/stafflist';
                if ('");
            EndContext();
            BeginContext(1714, 14, false);
#line 40 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\StaffIndex.cshtml"
                Write(Model.shopGuid);

#line default
#line hidden
            EndContext();
            BeginContext(1728, 46, true);
            WriteLiteral("\' != \'\') {\r\n                    urls +=\'?guid=");
            EndContext();
            BeginContext(1775, 14, false);
#line 41 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\StaffIndex.cshtml"
                             Write(Model.shopGuid);

#line default
#line hidden
            EndContext();
            BeginContext(1789, 1681, true);
            WriteLiteral(@"'
                }
                table.render({
                    toolbar: true,
                    elem: '#tablist',
                    url: urls,
                    cols: [
                        [
                            { field: 'trueName', title: '姓名', sort: true, fixed: 'left' },
                            { field: 'mobile', title: '手机号码' },
                            { field: 'sex', title: '性别' },
                            { field: 'addDate', title: '注册时间', sort: true },
                            { field: 'lastLoginDate', title: '最后登录时间' }
                        ]
                    ],
                    page: true,
                    limit:15,
                    id: 'tables'
                });
                var guid = '', active = {
                    reload: function () {
                        table.reload('tables',
                            {
                                page: {
                                    curr: 1
                  ");
            WriteLiteral(@"              },
                                where: {
                                    key: $(""#key"").val(),
                                    time: $(""#times"").val()
                                }
                            });
                    },
                    toolSearch: function () {
                        active.reload();
                    }
                };
                $('.list-search .layui-btn').on('click', function () {
                    var type = $(this).data('type');
                    active[type] ? active[type].call(this) : '';
                });
            });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Shop.StaffIndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Shop.StaffIndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Shop.StaffIndexModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Shop.StaffIndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
