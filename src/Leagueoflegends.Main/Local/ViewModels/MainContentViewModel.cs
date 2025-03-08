using Jamesnet.Foundation;
using Leagueoflegends.Support.Local.Services;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Leagueoflegends.Main.Local.ViewModels;

public class MainContentViewModel : ViewModelBase, IViewFirstLoadable
{
    private readonly IMenuManager _menu;
    private string _currentMenu;

    public string CurrentMenu
    {
        get => _currentMenu;
        set => SetProperty(ref _currentMenu, value);
    }

    public ICommand MenuCommand { get; private set; }
    public ICommand SettingsCommand { get; private set; }

    public MainContentViewModel(IMenuManager menu)
    {
        _menu = menu;
        MenuCommand = new RelayCommand<string>(SelectMenu);
        SettingsCommand = new RelayCommand(OpenSettings);
    }

    private void OpenSettings()
    {
        _menu.OpenOverlay("OptionContent");
    }

    private void SelectMenu(string menuName)
    {
        CurrentMenu = menuName;
        _menu.NavigateToMenu(menuName);
    }

    public async void OnFirstLoad(object view)
    {
        await Task.Delay(1000);
        SelectMenu("HOME");
    }
}
