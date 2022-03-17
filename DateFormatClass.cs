using System;
using System.Globalization;

public class DateFormatClass{
      public static DateTime unixTimeStampToDateTime(double unixTimeStamp, bool dateOnly = false) {
            try {
                System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
                if (!dateOnly)
                    return dtDateTime;
                return dtDateTime.Date;
            } catch (Exception) {
                return new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            }
        }
       public static long getTimeStamp(
                        int year, int month, int day,
                        int hour, int minute, int second, int milliseconds) {
            DateTime value = new DateTime(year, month, day);
            var date = new DateTime(1970, 1, 1, 0, 0, 0, value.Kind);   
            var unixTimestamp = System.Convert.ToInt64((value - date).TotalSeconds);
            return unixTimestamp;
        }
    public static long convertToUnix(string dateString) 
        {
           DateTime dateTime = DateTime.Parse(dateString, CultureInfo.InvariantCulture);
           return getTimeStamp(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second, dateTime.Millisecond);
        }
}
