using OpenSilver;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Browser;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Leagueoflegends.Support.Local.Services
{
    public class    ImageManager
    {
        static ImageManager()
        {
            var url = Interop.ExecuteJavaScript("window.location.origin;");
            ImagePath = $"{url}/Images";
        }

        public static string ImagePath { get; }
        public static ImageSource HeadlineDefaultImageSource => new BitmapImage(new Uri($"{ImagePath}/wallpaper-caitlyn.jpg", UriKind.RelativeOrAbsolute));
        public static ImageSource ATypeImageSource => new BitmapImage(new Uri($"{ImagePath}/wallpaper-maokai.jpg", UriKind.RelativeOrAbsolute));
        public static ImageSource BTypeImageSource => new BitmapImage(new Uri($"{ImagePath}/wallpaper-leesin.png", UriKind.RelativeOrAbsolute));
        public static ImageSource CTypeImageSource => new BitmapImage(new Uri($"{ImagePath}/wallpaper-ezreal.jpg", UriKind.RelativeOrAbsolute));
        public static ImageSource DTypeImageSource => new BitmapImage(new Uri($"{ImagePath}/wallpaper-thumb-1.png", UriKind.RelativeOrAbsolute));
        public static ImageSource ETypeImageSource => new BitmapImage(new Uri($"{ImagePath}/wallpaper-thumb-2.png", UriKind.RelativeOrAbsolute));

        public static ImageSource ATypeSaleImageSource => new BitmapImage(new Uri($"{ImagePath}/Skins/skin_leesin_11.jpg", UriKind.RelativeOrAbsolute));
        public static ImageSource BTypeSaleImageSource => new BitmapImage(new Uri($"{ImagePath}/Skins/skin_corki_18.jpg", UriKind.RelativeOrAbsolute));
        public static ImageSource CTypeSaleImageSource => new BitmapImage(new Uri($"{ImagePath}/Skins/skin_janna_05.jpg", UriKind.RelativeOrAbsolute));
        public static ImageSource DTypeSaleImageSource => new BitmapImage(new Uri($"{ImagePath}/Skins/skin_gangplank_05.jpg", UriKind.RelativeOrAbsolute));
        public static ImageSource ETypeSaleImageSource => new BitmapImage(new Uri($"{ImagePath}/Skins/skin_kogmaw_09.jpg", UriKind.RelativeOrAbsolute));
        public static ImageSource FTypeSaleImageSource => new BitmapImage(new Uri($"{ImagePath}/Skins/skin_lux_08.jpg", UriKind.RelativeOrAbsolute));

        public static ImageSource ChampionBadgeImageSource => new BitmapImage(new Uri($"{ImagePath}/badge_champion1.png", UriKind.RelativeOrAbsolute));

        public static ImageSource TranscendImageSource => new BitmapImage(new Uri($"{ImagePath}/skin_transcend.png", UriKind.RelativeOrAbsolute));
        public static ImageSource MythImageSource => new BitmapImage(new Uri($"{ImagePath}/skin_myth.png", UriKind.RelativeOrAbsolute));
        public static ImageSource LegendImageSource => new BitmapImage(new Uri($"{ImagePath}/skin_legend.png", UriKind.RelativeOrAbsolute));
        public static ImageSource EpicImageSource => new BitmapImage(new Uri($"{ImagePath}/skin_epic.png", UriKind.RelativeOrAbsolute));
        public static ImageSource LimitImageSource => new BitmapImage(new Uri($"{ImagePath}/skin_limit.png", UriKind.RelativeOrAbsolute));
        public static ImageSource ChromaImageSource => new BitmapImage(new Uri($"{ImagePath}/skin_chroma.png", UriKind.RelativeOrAbsolute));

        public static ImageSource SummaryImageSource => new BitmapImage(new Uri($"{ImagePath}/worlds_2022.png", UriKind.RelativeOrAbsolute));

        public static ImageSource LogoImageSource => new BitmapImage(new Uri($"{ImagePath}/logo.png", UriKind.RelativeOrAbsolute));

        public static ImageSource TopPositionImageSource => new BitmapImage(new Uri($"{ImagePath}/Positions/top.png", UriKind.RelativeOrAbsolute));
        public static ImageSource JunglePositionImageSource => new BitmapImage(new Uri($"{ImagePath}/Positions/jungle.png", UriKind.RelativeOrAbsolute));
        public static ImageSource MidPositionImageSource => new BitmapImage(new Uri($"{ImagePath}/Positions/mid.png", UriKind.RelativeOrAbsolute));
        public static ImageSource BottomPositionImageSource => new BitmapImage(new Uri($"{ImagePath}/Positions/bottom.png", UriKind.RelativeOrAbsolute));
        public static ImageSource SupportPositionImageSource => new BitmapImage(new Uri($"{ImagePath}/Positions/support.png", UriKind.RelativeOrAbsolute));

        public static ImageSource StarImageSource => new BitmapImage(new Uri($"{ImagePath}/Pieces/star-piece.png", UriKind.RelativeOrAbsolute));

        public static ImageSource RpIconImageSource => new BitmapImage(new Uri($"{ImagePath}/Pieces/rp.png", UriKind.RelativeOrAbsolute));
        public static ImageSource BeIconImageSource => new BitmapImage(new Uri($"{ImagePath}/Pieces/blue-essence.png", UriKind.RelativeOrAbsolute));

        public static ImageSource DefaultProfileImageSource => new BitmapImage(new Uri($"{ImagePath}/profile-default.png", UriKind.RelativeOrAbsolute));

        public static ImageSource FioraWallpaperImageSource => new BitmapImage(new Uri($"{ImagePath}/wallpaper-fiora.jpg", UriKind.RelativeOrAbsolute));
        public static ImageSource LuxWallpaperImageSource => new BitmapImage(new Uri($"{ImagePath}/wallpaper-lux.jpg", UriKind.RelativeOrAbsolute));
        public static ImageSource MaokaiWallpaperImageSource => new BitmapImage(new Uri($"{ImagePath}/wallpaper-maokai.jpg", UriKind.RelativeOrAbsolute));
        public static ImageSource CaitlynWallpaperImageSource => new BitmapImage(new Uri($"{ImagePath}/wallpaper-caitlyn.jpg", UriKind.RelativeOrAbsolute));

        public static ImageSource GitHubSource => new BitmapImage(new Uri($"{ImagePath}/publish/github.png", UriKind.RelativeOrAbsolute));
        public static ImageSource OpenSilverSource => new BitmapImage(new Uri($"{ImagePath}/publish/opensilver2.png", UriKind.RelativeOrAbsolute));
    }
}
