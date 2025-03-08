using Jamesnet.Foundation;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Leagueoflegends.Tft.Local.ViewModels;

public class TftContentViewModel : ViewModelBase, IViewFirstLoadable
{
    private readonly ITeamFightsDataLoader _teamFightsData;
    private TeamFight _current;
    private List<TeamFight> _teamFights;

    public TeamFight Current
    {
        get => _current;
        set => SetProperty(ref _current, value);
    }

    public List<TeamFight> TeamFights
    {
        get => _teamFights;
        set => SetProperty(ref _teamFights, value);
    }

    public TftContentViewModel(ITeamFightsDataLoader teamFightsData)
    {
        _teamFightsData = teamFightsData;
    }

    public void OnFirstLoad(object view)
    {
        Console.WriteLine("TftContentViewModel.FirstLoaded");
        TeamFights = _teamFightsData.LoadTeamFights();
        Current = TeamFights.FirstOrDefault();
    }
}
