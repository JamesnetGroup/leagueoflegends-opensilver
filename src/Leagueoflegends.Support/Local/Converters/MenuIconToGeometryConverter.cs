using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;

namespace Leagueoflegends.Support.Local.Converters;

public class MenuIconToGeometryConverter : IValueConverter
{
    private static readonly IReadOnlyDictionary<string, string> IconGeometries = new Dictionary<string, string>
    {
        { "Profile", "M12,19.2C9.5,19.2 7.29,17.92 6,16C6.03,14 10,12.9 12,12.9C14,12.9 17.97,14 18,16C16.71,17.92 14.5,19.2 12,19.2M12,5A3,3 0 0,1 15,8A3,3 0 0,1 12,11A3,3 0 0,1 9,8A3,3 0 0,1 12,5M12,2A10,10 0 0,0 2,12A10,10 0 0,0 12,22A10,10 0 0,0 22,12C22,6.47 17.5,2 12,2Z " },
        { "Collection", "M14.79,10.62L3.5,21.9L2.1,20.5L13.38,9.21L14.79,10.62M19.27,7.73L19.86,7.14L19.07,6.35L19.71,5.71L18.29,4.29L17.65,4.93L16.86,4.14L16.27,4.73C14.53,3.31 12.57,2.17 10.47,1.37L9.64,3.16C11.39,4.08 13,5.19 14.5,6.5L14,7L17,10L17.5,9.5C18.81,11 19.92,12.61 20.84,14.36L22.63,13.53C21.83,11.43 20.69,9.47 19.27,7.73Z" },
        { "Loot", "M22 19H2V21H22V19M4 15C4 15.5 4.2 16 4.6 16.4C5 16.8 5.5 17 6 17V6C5.5 6 5 6.2 4.6 6.6C4.2 7 4 7.5 4 8V15M13.5 6H10.5C10.5 5.6 10.6 5.2 10.9 4.9C11.2 4.6 11.5 4.5 12 4.5C12.4 4.5 12.8 4.6 13.1 4.9C13.3 5.2 13.5 5.6 13.5 6M7 6V17H17V6H15C15 5.2 14.7 4.5 14.1 3.9S12.8 3 12 3C11.2 3 10.5 3.3 9.9 3.9C9.3 4.5 9 5.2 9 6H7M18 17C18.5 17 19 16.8 19.4 16.4C19.8 16 20 15.5 20 15V8C20 7.5 19.8 7 19.4 6.6C19 6.2 18.5 6 18 6V17Z" },
        { "Shop", "M11.19,2.25C11.97,2.26 12.71,2.73 13,3.5L18,15.45C18.09,15.71 18.14,16 18.13,16.25C18.11,17 17.65,17.74 16.9,18.05L9.53,21.1C9.27,21.22 9,21.25 8.74,21.25C7.97,21.23 7.24,20.77 6.93,20L1.97,8.05C1.55,7.04 2.04,5.87 3.06,5.45L10.42,2.4C10.67,2.31 10.93,2.25 11.19,2.25M14.67,2.25H16.12A2,2 0 0,1 18.12,4.25V10.6L14.67,2.25M20.13,3.79L21.47,4.36C22.5,4.78 22.97,5.94 22.56,6.96L20.13,12.82V3.79M11.19,4.22L3.8,7.29L8.77,19.3L16.17,16.24L11.19,4.22M8.65,8.54L11.88,10.95L11.44,14.96L8.21,12.54L8.65,8.54Z" },
        { "Store", "M20 4H4A2 2 0 0 0 2 6V18A2 2 0 0 0 4 20H20A2 2 0 0 0 22 18V6A2 2 0 0 0 20 4M20 11H4V8H20M7 22H9V24H7V22M11 22H13V24H11V22M15 22H17V24H15Z" }
    };

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is string key && IconGeometries.TryGetValue(key, out var geometry))
        {
            return geometry;
        }
        return string.Empty;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
