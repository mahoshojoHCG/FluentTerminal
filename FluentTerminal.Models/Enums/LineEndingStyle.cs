using System.ComponentModel;

namespace FluentTerminal.Models.Enums
{
    public enum LineEndingStyle
    {
        [Description("不改变行尾")]
        DoNotModify,

        [Description("改变行尾为CR+LF(Windows)")]
        ToCRLF,

        [Description("改变行尾为LF(Unix)")]
        ToLF
    }
}
