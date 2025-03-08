using Jamesnet.Foundation;
using Leagueoflegends.Support.Local.Services;
using System.Windows.Input;

namespace Leagueoflegends.Navigate.Local.ViewModels;
public class OptionMenuContentViewModel : ViewModelBase, IViewFirstLoadable
{
    private readonly IMenuManager _menu;

    public ICommand MenuCommand { get; private set; }

    public OptionMenuContentViewModel(IMenuManager menu)
    {
        _menu = menu;

        MenuCommand = new RelayCommand<string>(OnMenu);
    }

    private void OnMenu(string menuName)
    {
        _menu.NavigateToOption(menuName);
    }

    public void OnFirstLoad(object view)
    {
        _menu.NavigateToOption("General");
    }
}
