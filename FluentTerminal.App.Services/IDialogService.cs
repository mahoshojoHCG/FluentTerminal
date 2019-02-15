using FluentTerminal.Models;
using System.Threading.Tasks;

namespace FluentTerminal.App.Services
{
    public enum DialogButton
    {
        确认,
        取消
    }

    public interface IDialogService
    {
        Task<DialogButton> ShowMessageDialogAsnyc(string title, string content, params DialogButton[] buttons);

        Task<ShellProfile> ShowProfileSelectionDialogAsync();

        Task<KeyBinding> ShowCreateKeyBindingDialog();
        Task<string> ShowInputDialogAsync(string title);
    }
}