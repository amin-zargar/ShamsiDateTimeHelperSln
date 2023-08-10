using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// A customized validator for Jalali date and time
/// </summary>
public static class ShamsiDateTimeValidator
{
    // Checks ShamsiDate validity
    public static bool Validate(string ShamsiDateTime)
    {
        try
        {
            if (string.IsNullOrEmpty(ShamsiDateTime)) return false;

            string[] date_time = ShamsiDateTime.Trim().Split(' ');

            string datePart = date_time.Length > 0 ? date_time[0] : String.Empty;
            string timePart = date_time.Length > 1 ? date_time[1] : String.Empty;

            if (!IsDateValid(datePart)) return false;
            if (!string.IsNullOrEmpty(timePart) && !IsTimeValid(timePart)) return false;

            return true;
        }
        catch
        {
            return false;
        }
    }

    // Checks if date is in the correct format of a Jalali date
    private static bool IsDateValid(string ShamsiDate)
    {
        try
        {
            // Lead month and day with 0 if needed e.g. 1 -> 01
            string[] dateParts = ShamsiDate.Split('/');
            int yearPart = int.Parse(dateParts[0]);
            int monthPart = int.Parse(dateParts[1]);
            int dayPart = int.Parse(dateParts[2]);
            ShamsiDate = string.Format("{0}/{1}/{2}", yearPart, monthPart.ToString("D2"), dayPart.ToString("D2"));

            String dateFormat = "^(([1-9][0-9][0-9][0-9]))/([0][1-9]|[1][0-2])/([0][1-9]|[1-2][0-9]|[3][0-1])$";
            System.Text.RegularExpressions.Regex regExForDate = new System.Text.RegularExpressions.Regex(dateFormat);
            bool matchFormat = regExForDate.IsMatch(ShamsiDate);
            bool matchRange = IsDateInRange(ShamsiDate);

            if (matchFormat && matchRange)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch
        {
            return false;
        }

    }

    // Checks if time is in 24-hour format HH:MM:SS
    private static bool IsTimeValid(string Time)
    {
        // This function accepts time in HH:MM:SS format e.g. 24:00:00
        // If you want to accept 24:00 or even 24 uncomment the following code
        // 
        //while (Time.Split(':').Length < 3)
        //{
        //    Time += ":00";
        //}

        String timeFormat = @"^(?:(?:([01]?\d|2[0-3]):)?([0-5]?\d):)?([0-5]?\d)$";
        System.Text.RegularExpressions.Regex regExForTime = new System.Text.RegularExpressions.Regex(timeFormat);
        return regExForTime.IsMatch(Time);
    }

    // Checks if date is in the range of valid Jalali dates
    private static bool IsDateInRange(string ShamsiDate)
    {
        try
        {
            string[] dateParts = ShamsiDate.Split('/');

            int yearPart = int.Parse(dateParts[0]);
            int monthPart = int.Parse(dateParts[1]);
            int dayPart = int.Parse(dateParts[2]);

            if ((monthPart >= 1) && (monthPart <= 6))
            {
                if ((dayPart >= 1) && (dayPart <= 31))
                {
                    return true;
                }
            }
            else if ((monthPart >= 7) && (monthPart <= 11))
            {
                if ((dayPart >= 1) && (dayPart <= 30))
                {
                    return true;
                }
            }
            else if (monthPart == 12)
            {
                if ((dayPart >= 1) && (dayPart <= 29))
                {
                    return true;
                }
                else if (dayPart == 30)
                {
                    if (yearPart.ToString().Length == 2)
                    {
                        string tempYear = string.Concat("13", yearPart.ToString());
                        yearPart = int.Parse(tempYear);
                    }

                    if (IsLeapYear(yearPart))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return false;
        }
        catch
        {
            return false;
        }
    }

    // Checks if year is a leap one or not
    private static bool IsLeapYear(int tYear)
    {
        return ((((((tYear - ((tYear > 0) ? 0x1DA : 0x1D9)) % 0xB04) + 0x1DA) + 0x26) * 0x2AA) % 0xB00) < 0x2AA;
    }
}
