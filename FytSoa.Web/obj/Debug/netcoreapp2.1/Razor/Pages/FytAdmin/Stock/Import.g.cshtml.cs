#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Import.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa36d20bbe09af5e1b3c557f2a1195026f2810dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Stock.Pages_FytAdmin_Stock_Import), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Stock/Import.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Stock/Import.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Stock.Pages_FytAdmin_Stock_Import), null)]
namespace FytSoa.Web.Pages.FytAdmin.Stock
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa36d20bbe09af5e1b3c557f2a1195026f2810dc", @"/Pages/FytAdmin/Stock/Import.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Stock_Import : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Import.cshtml"
  
    ViewData["Title"] = "入库管理";
    Layout = AdminLayout.Pjax(HttpContext);

#line default
#line hidden
            BeginContext(144, 479, true);
            WriteLiteral(@"<div id=""container"">
    <style>
        .layui-col-220 {
            width: 400px;
        }

        .right-col-body {
            left: 400px;
        }
    </style>
    <div class=""layui-col-220"" id=""app"">
        <div class=""layui-nav-title"">入库单　　　<button class=""layui-btn layui-btn-sm"" id=""addIn""><i class=""layui-icon""></i>新增入库单</button></div>
        <ul class=""fyt-utree"">
            <li v-for=""it in list"" v-cloak :class=""{active: activeName == it.guid}"" ");
            EndContext();
            BeginContext(624, 73, true);
            WriteLiteral("@click=\"selected(it.guid)\">\r\n                <a class=\"layui-elip title\" ");
            EndContext();
            BeginContext(698, 188, true);
            WriteLiteral("@click=\"getList(it)\">{{it.packName}}</a>\r\n                <a class=\"layui-elip sums\"><span class=\"layui-badge layui-bg-blue\">{{it.goodsSum}}</span></a>\r\n                <span class=\"tool\" ");
            EndContext();
            BeginContext(887, 193, true);
            WriteLiteral("@click=\"tools(it,$event)\"><i class=\"layui-icon layui-icon-more\"></i></span>\r\n            </li>\r\n        </ul>\r\n        <dl class=\"layui-nav-child fyt-task-menu layui-hide\">\r\n            <dd><a ");
            EndContext();
            BeginContext(1081, 48, true);
            WriteLiteral("@click=\"edit()\">修改</a></dd>\r\n            <dd><a ");
            EndContext();
            BeginContext(1130, 467, true);
            WriteLiteral(@"@click=""deletes()"">删除</a></dd>
        </dl>
    </div>
    <div class=""right-col-body"">
        <div class=""list-wall"">
            <div class=""layui-form list-search"">
                <div class=""layui-inline"">
                    <input class=""layui-input"" id=""key"" autocomplete=""off"" placeholder=""请输入关键字查询"">
                </div>
                <div class=""layui-inline"">
                    <select id=""shops"" lay-search="""">
                        ");
            EndContext();
            BeginContext(1597, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e340b6373a440419448212a59c13f33", async() => {
                BeginContext(1614, 11, true);
                WriteLiteral("--可根据店铺搜索--");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1634, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 40 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Import.cshtml"
                          
                            foreach (var item in Model.shopList)
                            {

#line default
#line hidden
            BeginContext(1761, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1793, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f820f53e1afb48658ae348c8cef71e11", async() => {
                BeginContext(1821, 13, false);
#line 43 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Import.cshtml"
                                                      Write(item.ShopName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 43 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Import.cshtml"
                                   WriteLiteral(item.Guid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1843, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 44 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Import.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(1903, 387, true);
            WriteLiteral(@"                    </select>
                </div>
                <div class=""layui-inline lay-time-icon"">
                    <input class=""layui-input"" id=""times"" autocomplete=""off"" placeholder=""时间区间""><i class=""layui-icon layui-icon-date""></i>
                </div>
                <div class=""layui-inline"">
                    <select id=""branks"">
                        ");
            EndContext();
            BeginContext(2290, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbd772777497468b92b8f2ddc2515e26", async() => {
                BeginContext(2307, 11, true);
                WriteLiteral("--可根据品牌搜索--");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2327, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 54 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Import.cshtml"
                          
                            foreach (var item in Model.codeList)
                            {

#line default
#line hidden
            BeginContext(2454, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(2486, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "958ce034eca34f9b8308bd8e83620d27", async() => {
                BeginContext(2514, 9, false);
#line 57 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Import.cshtml"
                                                      Write(item.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 57 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Import.cshtml"
                                   WriteLiteral(item.Guid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2532, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 58 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Import.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(2592, 14413, true);
            WriteLiteral(@"                    </select>
                </div>
                <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolSearch"">
                    <i class=""layui-icon layui-icon-search""></i> 搜索
                </button>
            </div>
            <table class=""layui-hide"" id=""tablist"" lay-filter=""tool""></table>
        </div>
    </div>
    <script type=""text/html"" id=""toolbar"">
        <div class=""layui-btn-container"">
            <button type=""button"" class=""layui-btn layui-btn-sm layui-hide"" lay-event=""toolAdd""><i class=""layui-icon""></i> 新增</button>
            <button type=""button"" class=""layui-btn layui-btn-sm"" lay-event=""toolBatchAdd""><i class=""layui-icon""></i> 批量新增</button>
            <button type=""button"" class=""layui-btn layui-btn-sm"" lay-event=""toolDel""><i class=""layui-icon""></i> 删除</button>
            <button type=""button"" class=""layui-btn layui-btn-sm"" lay-event=""toolPrint""><i class=""layui-icon layui-icon-print""></i> 打印入库单</button>
            <button ty");
            WriteLiteral(@"pe=""button"" class=""layui-btn layui-btn-sm"" lay-event=""toolContrast""><i class=""layui-icon layui-icon layui-icon-read""></i> 入库单效验</button>
        </div>
    </script>
    <div class=""os-print layui-hide"" id=""appprint"">
        <div class=""print"" style=""padding:20px;"">
            <h4 style=""border-bottom:dashed 1px #000; text-align:center; font-size:18px; font-weight:bold; padding-bottom:10px; margin-bottom:10px;"">入库单详情</h4>
            <table id=""tab-info"" style=""width:100%"">
                <tr>
                    <td style=""padding:8px;"">名称：{{model.packName}}</td>
                    <td style=""padding:8px;"">订单号：{{model.number}}</td>
                </tr>
                <tr>
                    <td style=""padding:8px;"">数量：{{model.goodsSum}}</td>
                    <td style=""padding:8px;"">时间：{{model.addDate}}</td>
                </tr>
            </table>
            <p class=""lines"" style=""border-bottom:dashed 1px #000; margin:10px 0;""></p>
            <table id=""tab-list"" style=""width");
            WriteLiteral(@":100%"">
                <tr>
                    <td style=""padding:8px; border:1px solid #e6e7e8;;"">条形码</td>
                    <td style=""padding:8px; border:1px solid #e6e7e8;width:100px"">品牌</td>
                    <td style=""padding:8px; border:1px solid #e6e7e8;width:100px"">款式</td>
                    <td style=""padding:8px; border:1px solid #e6e7e8;width:80px"">数量</td>
                </tr>
                <tr v-for=""it in list"" v-cloak>
                    <td style=""padding:8px; border:1px solid #e6e7e8;"">{{it.code}}</td>
                    <td style=""padding:8px; border:1px solid #e6e7e8;"">{{it.brankName}}</td>
                    <td style=""padding:8px; border:1px solid #e6e7e8;"">{{it.styleName}}</td>
                    <td style=""padding:8px; border:1px solid #e6e7e8;"">{{it.stockSum}}</td>
                </tr>
            </table>
        </div>
    </div>
    <script>
        layui.define(['layer', 'printarea'], function (exports) {
            ""use strict"";
            expo");
            WriteLiteral(@"rts('print', null);
        });
        var prints = new Vue({
            el: '#appprint',
            data: {
                model: {},
                list: []
            }
        });
        var funTool, vm = new Vue({
            el: ""#app"",
            data: {
                list: [],
                curModel: {},
                activeName: ''
            },
            methods: {
                selected: function (m) {
                    this.activeName = m;
                },
                getList: function (m) {
                    funTool.getGoodsSku(m);
                },
                tools: function (m, event) {
                    this.curModel = m;
                    funTool.tool(event);
                },
                edit: function () {
                    funTool.edit();
                },
                deletes: function () {
                    funTool.deletes();
                }
            }
        });
        layui.config({
         ");
            WriteLiteral(@"   base: '/themes/js/modules/'
        }).use(['table', 'layer', 'jquery', 'common', 'form', 'laydate'],
            function () {
                var table = layui.table,
                    layer = layui.layer,
                    $ = layui.jquery,
                    os = layui.common,
                    laydate = layui.laydate,
                    form = layui.form;
                form.render('select');
                laydate.render({
                    elem: '#times'
                    , theme: '#393D49'
                    , format: 'yyyy/MM/dd'
                    , range: true
                });
                $(""ul.fyt-utree"").css({ 'height': $(window).height() - 130 });
                table.render({
                    toolbar: '#toolbar',
                    elem: '#tablist',
                    url: '/api/stock/inoutlist',
                    cols: [
                        [
                            { type: 'checkbox', fixed: 'left' },
                          ");
            WriteLiteral(@"  { field: 'code', width: 200, title: '条形码', fixed: 'left' },
                            { field: 'brankName', title: '品牌' },
                            { field: 'styleName', title: '款式' },
                            { field: 'stockSum', width: 150, title: '入库数量', sort: true },
                            { field: 'addDate', title: '添加时间' },
                            { width: 100, title: '操作', templet: '#tool' }
                        ]
                    ],
                    page: { limits: [10, 20, 50, 100, 500, 1000, 5000, 10000], groups: 8 },
                    limit: 15,
                    id: 'tables'
                });

                $(document).click(function (e) {
                    var _target = $(e.target);
                    if (_target.closest("".fyt-task-menu"").length == 0) {
                        $("".fyt-task-menu"").addClass('layui-hide');
                    }
                });


                var packguid = '', active = {
                    reload: ");
            WriteLiteral(@"function () {
                        table.reload('tables',
                            {
                                page: {
                                    curr: 1
                                },
                                where: {
                                    packGuid: packguid,
                                    types: 1,
                                    guid: $('#shops').val(),
                                    key: $('#key').val(),
                                    brank: $('#branks').val()
                                }
                            });
                    },
                    toolSearch: function () {
                        active.reload();
                    },
                    addIn: function () {
                        os.Open('添加入库单', '/fytadmin/stock/packlog/?types=1', '600px', '400px', function () {
                            funTool.packPage();
                        });
                    },
                   ");
            WriteLiteral(@" toolAdd: function () {
                        if (packguid === '') {
                            os.warning('请选择入库单~');
                            return;
                        }
                        os.Open('添加入库信息', '/fytadmin/stock/importmodify/?packguid=' + packguid, '600px', '350px', function () {
                            active.reload();
                        });
                    },
                    toolDel: function () {
                        var checkStatus = table.checkStatus('tables')
                            , data = checkStatus.data;
                        if (data.length === 0) {
                            os.warning(""请选择要删除的项目~"");
                            return;
                        }
                        var str = '';
                        $.each(data, function (i, item) {
                            str += item.guid + "","";
                        });
                        layer.confirm('确定要执行批量删除吗？删除后平台库存会减少相应入库数量', function (index) {");
            WriteLiteral(@"
                            layer.close(index);
                            var loadindex = layer.load(1, {
                                shade: [0.1, '#000']
                            });
                            os.ajax('api/stock/delinout/', { parm: str }, function (res) {
                                layer.close(loadindex);
                                if (res.statusCode === 200) {
                                    active.reload();
                                    funTool.packPage();
                                    os.success('删除成功！');
                                } else {
                                    os.error(res.message);
                                }
                            });
                        });
                    },
                    /* 打印出库单 */
                    toolPrint: function () {
                        if (packguid === '') {
                            os.error('请选择入库单~');
                            return;
       ");
            WriteLiteral(@"                 }
                        $("".print"").print();
                    },
                    //批量新增入库信息
                    toolBatchAdd: function () {
                        if (packguid === '') {
                            os.error('请选择入库单~');
                            return;
                        }
                        os.Open('批量添加入库信息', '/fytadmin/stock/importbatchadd/?packguid=' + packguid, '860px', '600px', function () {
                            active.reload();
                            funTool.packPage();
                        });
                    },
                    /* 入库单信息核对 */
                    toolContrast: function () {
                        if (packguid === '') {
                            os.error('请选择入库单~');
                            return;
                        }
                        os.Open('入库单效验', '/fytadmin/stock/importvalidation?pack=' + packguid, '1200px', '700px');
                    }
                };

    ");
            WriteLiteral(@"            funTool = {
                    getGoodsSku: function (obj) {
                        console.log(obj);
                        packguid = obj.guid;
                        prints.model = obj;
                        active.reload();
                        os.get('api/stock/inoutlist?types=1', { packGuid: packguid, limit: 10000 }, function (res) {
                            prints.list = res.data;
                        });
                    },
                    packPage: function () {
                        os.ajax('api/stock/packloglist', { types: 1, time: $('#times').val(), guid: $('#shops').val(), key: $('#key').val() }, function (res) {
                            if (res.statusCode === 200) {
                                vm.list = res.data.items;
                            } else {
                                os.error(res.message);
                            }
                        });
                    },
                    edit: function () {
     ");
            WriteLiteral(@"                   $("".fyt-task-menu"").addClass('layui-hide');
                        os.Open('修改入库单', '/fytadmin/stock/packlog/?guid=' + vm.curModel.guid, '600px', '400px', function () {
                            funTool.packPage();
                        });
                    },
                    deletes: function () {
                        $("".fyt-task-menu"").addClass('layui-hide');
                        os.error('为了保证数据一致性，不允许删除入库单！');
                        /*layer.confirm('确定要执行批量删除吗？', function (index) {
                            layer.close(index);
                            var loadindex = layer.load(1, {
                                shade: [0.1, '#000']
                            });
                            os.ajax('api/stock/delpacklog/', { parm: vm.curModel.guid }, function (res) {
                                layer.close(loadindex);
                                if (res.statusCode === 200) {
                                    funTool.packPage();
    ");
            WriteLiteral(@"                                os.success('删除成功！');
                                } else {
                                    os.error(res.message);
                                }
                            });
                        });*/
                    },
                    tool: function (event) {
                        event.stopPropagation();
                        event.preventDefault();
                        var obj = $(event.target).offset();
                        $("".fyt-task-menu"").css({ 'top': obj.top - 30, 'left': '275px' });
                        if ($('.fyt-task-menu').hasClass('layui-hide')) {
                            $("".fyt-task-menu"").removeClass('layui-hide');
                        } else {
                            $("".fyt-task-menu"").addClass('layui-hide');
                        }
                    }
                };
                //初始化入库单管理
                funTool.packPage();

                $(""#addIn"").on('click', function () ");
            WriteLiteral(@"{
                    active.addIn();
                });
                table.on('toolbar(tool)', function (obj) {
                    active[obj.event] ? active[obj.event].call(this) : '';
                });
                $('.list-search .layui-btn').on('click', function () {
                    var type = $(this).data('type');
                    active[type] ? active[type].call(this) : '';
                    funTool.packPage();
                });
                //监听工具条
                table.on('tool(tool)', function (obj) {
                    var data = obj.data;
                    if (obj.event === 'edit') {
                        os.Open('修改入库信息', '/fytadmin/stock/importmodify/?guid=' + data.guid, '600px', '350px', function () {
                            active.reload();
                        });
                    }
                });
            });
    </script>
    <script type=""text/html"" id=""tool"">
        <a class=""layui-btn layui-btn-primary layui-btn-xs"" l");
            WriteLiteral("ay-event=\"edit\"><i class=\"layui-icon\"></i> 修改</a>\r\n    </script>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Stock.ImportModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Stock.ImportModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Stock.ImportModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Stock.ImportModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
