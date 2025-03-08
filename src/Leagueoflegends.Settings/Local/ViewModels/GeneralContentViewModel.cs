using Jamesnet.Foundation;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leagueoflegends.Collection.Local.ViewModels;

public class GeneralContentViewModel : ViewModelBase, IViewFirstLoadable
{
    private readonly IOptionDataLoader _optionData;
    private Option _currentWindowSize;
    private List<Option> _windowSizes;

    public Option CurrentWindowSize
    {
        get => _currentWindowSize;
        set => SetProperty(ref _currentWindowSize, value);
    }

    public List<Option> WindowSizes
    { 
        get => _windowSizes;
        set => SetProperty(ref _windowSizes, value);
    }

    public GeneralContentViewModel(IOptionDataLoader optionData)
    {
        _optionData = optionData;
    }

    public async void OnFirstLoad(object view)
    {
        await Task.Delay(100);
        WindowSizes = _optionData.GetByCategory("WindowSize");
        CurrentWindowSize = WindowSizes.FirstOrDefault();
    }
}
