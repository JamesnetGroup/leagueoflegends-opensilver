using Jamesnet.Foundation;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Models;
using System.Collections.Generic;
namespace Leagueoflegends.Social.Local.ViewModels;

public class SocialContentViewModel : ViewModelBase, IViewFirstLoadable
{
    private readonly IFriendDataLoader _friendsData;
    private List<FriendCategory> _friends;

    public List<FriendCategory> Friends
    {
        get => _friends;
        set => SetProperty(ref _friends, value);
    }

    public SocialContentViewModel(IFriendDataLoader friendsData)
    {
        _friendsData = friendsData;
    }

    private void LoadFriends()
    {
        Friends = _friendsData.LoadFriends();
    }

    public void OnFirstLoad(object view)
    {
        LoadFriends();
    }
}
