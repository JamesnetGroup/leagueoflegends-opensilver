﻿using Jamesnet.Foundation;
using Leagueoflegends.Clash.Local.Datas;
using Leagueoflegends.Clash.Local.ViewModels;
using Leagueoflegends.Clash.UI.Views;
using Leagueoflegends.Collection.Local.Datas;
using Leagueoflegends.Collection.Local.ViewModels;
using Leagueoflegends.Collection.UI.Views;
using Leagueoflegends.Home.Local.ViewModels;
using Leagueoflegends.Home.UI.Views;
using Leagueoflegends.Main.Local.ViewModels;
using Leagueoflegends.Main.UI.Views;
using Leagueoflegends.Navigate.Local.Datas;
using Leagueoflegends.Navigate.Local.Services;
using Leagueoflegends.Navigate.Local.ViewModels;
using Leagueoflegends.Navigate.UI.Views;
using Leagueoflegends.Profile.Local.Datas;
using Leagueoflegends.Profile.Local.ViewModels;
using Leagueoflegends.Profile.UI.Views;
using Leagueoflegends.Shop.UI.Views;
using Leagueoflegends.Social.Local.Datas;
using Leagueoflegends.Social.Local.ViewModels;
using Leagueoflegends.Social.UI.Views;
using Leagueoflegends.Store.Local.Datas;
using Leagueoflegends.Store.UI.Views;
using Leagueoflegends.Support.Local.Datas;
using Leagueoflegends.Support.Local.Services;
using Leagueoflegends.Tft.Local.Datas;
using Leagueoflegends.Tft.Local.ViewModels;
using Leagueoflegends.Tft.UI.Views;

namespace Leagueoflegends;

public class LeagueOfLegendsBootstrapper : AppBootstrapper
{
    protected override void RegisterDependencies(IContainer container)
    {
        ViewModelMapper.Register<MainContent, MainContentViewModel>();
        ViewModelMapper.Register<OptionContent, OptionContentViewModel>();
        ViewModelMapper.Register<SocialContent, SocialContentViewModel>();
        ViewModelMapper.Register<OverviewContent, OverviewContentViewModel>();
        ViewModelMapper.Register<TftContent, TftContentViewModel>();
        ViewModelMapper.Register<SubMenuContent, SubMenuContentViewModel>();
        ViewModelMapper.Register<OptionMenuContent, OptionMenuContentViewModel>();

        ViewModelMapper.Register<ChampionsContent, ChampionsContentViewModel>();
        ViewModelMapper.Register<SkinsContent, SkinsContentViewModel>();
        ViewModelMapper.Register<SpellsContent, SpellsContentViewModel>();
        ViewModelMapper.Register<HistoryContent, HistoryContentViewModel>();
        ViewModelMapper.Register<HubContent, HubContentViewModel>();
        ViewModelMapper.Register<StoreChampContent, StoreChampContentViewModel>();
        ViewModelMapper.Register<GeneralContent, GeneralContentViewModel>();
        ViewModelMapper.Register<VoiceContent, VoiceContentViewModel>();
    }

    protected override void RegisterViewModels(IViewModelMapper viewModelMapper)
    {
        Container.RegisterSingleton<IMenuManager, MenuManager>();

        Container.RegisterSingleton<IFriendDataLoader, FriendDataLoader>();
        Container.RegisterSingleton<IMenuDataLoader, MenuDataLoader>();
        Container.RegisterSingleton<IChampStatsDataLoader, ChampStatsDataLoader>();
        Container.RegisterSingleton<IOptionDataLoader, OptionDataLoader>();
        Container.RegisterSingleton<ISkinsDataLoader, SkinsDataLoader>();
        Container.RegisterSingleton<ISpellsDataLoader, SpellsDataLoader>();
        Container.RegisterSingleton<IMatchHistoryDataLoader, MatchHistoryDataLoader>();
        Container.RegisterSingleton<IPlayChampDataLoader, PlayChampDataLoader>();
        Container.RegisterSingleton<IRecentDataLoader, RecentDataLoader>();
        Container.RegisterSingleton<IScheduleDataLoader, ScheduleDataLoader>();
        Container.RegisterSingleton<ITeamFightsDataLoader, TeamFightsDataLoader>();
        Container.RegisterSingleton<IStoreChampDataLoader, StoreChampDataLoader>();

        Container.RegisterSingleton<IView, MainContent>();
        Container.RegisterSingleton<IView, SubMenuContent>();
        Container.RegisterSingleton<IView, OptionMenuContent>();
        Container.RegisterSingleton<IView, SocialContent>();

        Container.RegisterSingleton<IView, OptionContent>("OptionContent");
        Container.RegisterSingleton<IView, TftContent>("TftContent");
        Container.RegisterSingleton<IView, ShopContent>("ShopContent");
        Container.RegisterSingleton<IView, OverviewContent>("HomeOverviewContent");
        Container.RegisterSingleton<IView, HubContent>("ClashHubContent");
        Container.RegisterSingleton<IView, ChampionsContent>("CollectionChampionsContent");
        Container.RegisterSingleton<IView, SkinsContent>("CollectionSkinsContent");
        Container.RegisterSingleton<IView, SpellsContent>("CollectionSpellsContent");
        Container.RegisterSingleton<IView, HistoryContent>("ProfileMatchHistoryContent");
        Container.RegisterSingleton<IView, StoreChampContent>("StoreChampionsContent");
        Container.RegisterSingleton<IView, GeneralContent>("GeneralContent");
        Container.RegisterSingleton<IView, NoticeContent>("NoticeContent");
        Container.RegisterSingleton<IView, ChatContent>("ChatContent");
        Container.RegisterSingleton<IView, SoundContent>("SoundContent");
        Container.RegisterSingleton<IView, VoiceContent>("VoiceContent");
        Container.RegisterSingleton<IView, HotKeyContent>("HotKeyContent");
        Container.RegisterSingleton<IView, VolumeContent>("VolumeContent");
    }

    protected override void SettingsLayer(ILayerManager layer, IContainer container)
    {
        IView mainContent = Container.Resolve<MainContent>();
        IView socialContent = Container.Resolve<SocialContent>();
        IView subMenuContent = Container.Resolve<SubMenuContent>();
        IView optionMenuContent = Container.Resolve<OptionMenuContent>();

        Layer.Mapping("MainLayer", mainContent);
        Layer.Mapping("SocialLayer", socialContent);
        Layer.Mapping("SubMenuLayer", subMenuContent);
        Layer.Mapping("OptionMenuLayer", optionMenuContent);
    }
}

