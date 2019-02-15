using System.ComponentModel;

namespace FluentTerminal.Models.Enums
{
    public enum Command
    {
        [Description("切换窗口")]
        ToggleWindow,

        [Description("下一个标签页")]
        NextTab,

        [Description("上一个标签页")]
        PreviousTab,

        [Description("新建标签页")]
        NewTab,

        [Description("配置新标签页")]
        ConfigurableNewTab,

        [Description("更改标签页名称")]
        ChangeTabTitle,

        [Description("关闭标签页")]
        CloseTab,

        [Description("新建窗口")]
        NewWindow,

        [Description("显示设置")]
        ShowSettings,

        [Description("复制")]
        Copy,

        [Description("粘贴")]
        Paste,

        [Description("去回车粘贴")]
        PasteWithoutNewlines,

        [Description("搜索")]
        Search,

        [Description("切换全屏")]
        ToggleFullScreen,

        [Description("全选")]
        SelectAll,

        [Description("清除")]
        Clear,

        [Description("切换到1号终端")]
        SwitchToTerm1,

        [Description("切换到2号终端")]
        SwitchToTerm2,

        [Description("切换到3号终端")]
        SwitchToTerm3,

        [Description("切换到4号终端")]
        SwitchToTerm4,

        [Description("切换到5号终端")]
        SwitchToTerm5,

        [Description("切换到6号终端")]
        SwitchToTerm6,

        [Description("切换到7号终端")]
        SwitchToTerm7,

        [Description("切换到8号终端")]
        SwitchToTerm8,

        [Description("切换到9号终端")]
        SwitchToTerm9
    }
}