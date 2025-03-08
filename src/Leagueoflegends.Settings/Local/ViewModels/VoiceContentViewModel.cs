using Jamesnet.Foundation;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace Leagueoflegends.Collection.Local.ViewModels;

public enum InputMode
{
    VoiceActivity,
    PushToTalk
}

public class VoiceContentViewModel : ViewModelBase, IViewFirstLoadable
{
    private readonly IOptionDataLoader _optionData;
    private List<Option> _inputs;
    private Option _currentInput;
    private InputMode _selectedInputMode;

    public List<Option> Inputs
    {
        get => _inputs;
        set => SetProperty(ref _inputs, value);
    }

    public Option CurrentInput
    {
        get => _currentInput;
        set => SetProperty(ref _currentInput, value);
    }

    public InputMode SelectedInputMode
    {
        get => _selectedInputMode;
        set => SetProperty(ref _selectedInputMode, value);
    }

    public ICommand ChangeInputModeCommand { get; }

    public VoiceContentViewModel(IOptionDataLoader optionData)
    {
        _optionData = optionData;
        ChangeInputModeCommand = new RelayCommand<string>(OnInputModeChanged);
        SelectedInputMode = InputMode.VoiceActivity;
    }

    private void OnInputModeChanged(string mode)
    {
        InputMode inputMode = (InputMode)Enum.Parse(typeof(InputMode), mode);
        SelectedInputMode = inputMode;
    }

    public void OnFirstLoad(object view)
    {
        Inputs = _optionData.GetByCategory("AudioInput");
        CurrentInput = Inputs.FirstOrDefault();
    }
}
