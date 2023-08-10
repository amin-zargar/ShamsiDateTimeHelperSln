using System.Globalization;

/// <summary>
/// A customized validator for Jalali date and time
/// </summary>
public class ShamsiDateTime
{
    #region Private Fields

    private PersianCalendar pc = new PersianCalendar();
    private string _dateString = string.Empty;
    private string _timeString = string.Empty;

    #endregion

    #region Properties

    public int Year
    {
        get
        {
            int value;
            if (int.TryParse(DateTimeString.Substring(0, 4), out value))
                return value;
            return 0;
        }
    }

    public int Month
    {
        get
        {
            int value;
            if (int.TryParse(DateTimeString.Substring(5, 2), out value))
                return value;
            return 0;
        }
    }

    public int Day
    {
        get
        {
            int value;
            if (int.TryParse(DateTimeString.Substring(8, 2), out value))
                return value;
            return 0;
        }
    }

    public int Hour
    {
        get
        {
            try
            {
                int value;
                if (int.TryParse(DateTimeString.Substring(11, 2), out value))
                    return value;
                return 0;
            }
            catch
            {
                return 0;
            }

        }
    }

    public int Minute
    {
        get
        {
            try
            {
                int value;
                if (int.TryParse(DateTimeString.Substring(14, 2), out value))
                    return value;
                return 0;
            }
            catch
            {
                return 0;
            }

        }
    }

    public int Second
    {
        get
        {
            try
            {
                int value;
                if (int.TryParse(DateTimeString.Substring(17, 2), out value))
                    return value;
                return 0;
            }
            catch
            {
                return 0;
            }

        }
    }

    public static ShamsiDateTime Now
    {
        get
        {
            return new ShamsiDateTime(DateTime.Now);
        }
    }

    public static ShamsiDateTime Today
    {
        get 
        {
            ShamsiDateTime shamsiDateTime = new ShamsiDateTime(DateTime.Now);
            return new ShamsiDateTime(shamsiDateTime.Year, shamsiDateTime.Month, shamsiDateTime.Day);
        }
    }

    public string DateTimeString
    {
        get
        {
            return _dateString + (!string.IsNullOrEmpty(_timeString) ? " " + _timeString : "");
        }
    }

    public string DateTimeStringWithoutLeadingZero
    {
        get
        {
            return string.Format("{0}/{1}/{2} {3}:{4}:{5}", Year, Month, Day, Hour, Minute, Second); ;
        }
    }

    public string DateString
    {
        get
        {
            return _dateString;
        }
    }

    public string DateStringWithoutLeadingZero
    {
        get
        {
            return string.Format("{0}/{1}/{2}", Year, Month, Day); ;
        }
    }

    public string TimeString
    {
        get
        {
            return _timeString;
        }
    }

    public string TimeStringWithoutLeadingZero
    {
        get
        {
            return string.Format("{0}:{1}:{2}", Hour, Minute, Second); ;
        }
    }

    #endregion

    #region Constructors

    public ShamsiDateTime(int year, int month, int day, int hour = 0, int minute = 0, int second = 0)
    {
        try
        {
            string input = string.Format("{0}/{1}/{2} {3}:{4}:{5}", year, month > 0 ? month.ToString("D2") : "00", day > 0 ? day.ToString("D2") : "00", hour > 0 ? hour.ToString("D2") : "00", minute > 0 ? minute.ToString("D2") : "00",  second > 0 ? second.ToString("D2") : "00");
            if (ShamsiDateTimeValidator.Validate(input))
            {
                string[] date_time = input.Trim().Split(' ');

                _dateString = date_time.Length > 0 ? date_time[0] : String.Empty;
                _timeString = date_time.Length > 1 ? date_time[1] : String.Empty;
            }
            else
            {
                throw new Exception("Invalid Date");
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public ShamsiDateTime(string ShamsiDateTimeString)
    {
        try
        {
            if (ShamsiDateTimeValidator.Validate(ShamsiDateTimeString))
            {
                string[] date_time = ShamsiDateTimeString.Trim().Split(' ');

                string date = date_time.Length > 0 ? date_time[0] : String.Empty;
                string time = date_time.Length > 1 ? date_time[1] : String.Empty;

                string[] dateParts = date.Split('/');
                int year = int.Parse(dateParts[0]);
                int month = int.Parse(dateParts[1]);
                int day = int.Parse(dateParts[2]);

                string[] timeParts = time.Split(':');
                int hour = !string.IsNullOrEmpty(time) && timeParts.Length > 0 ? int.Parse(timeParts[0]) : 0;
                int minute = !string.IsNullOrEmpty(time) && timeParts.Length > 1 ? int.Parse(timeParts[1]) : 0;
                int second = !string.IsNullOrEmpty(time) && timeParts.Length > 2 ? int.Parse(timeParts[2]) : 0;

                _dateString = string.Format("{0}/{1}/{2}", year, month.ToString("D2"), day.ToString("D2"));
                _timeString = string.Format("{0}:{1}:{2}", hour > 0 ? hour.ToString("D2") : "00", minute > 0 ? minute.ToString("D2") : "00", second > 0 ? second.ToString("D2") : "00");
            }
            else
            {
                throw new Exception("Invalid Date");
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public ShamsiDateTime(DateTime GregorianDateTime)
    {
        _dateString = string.Format("{0}/{1}/{2}",
                                            pc.GetYear(GregorianDateTime),
                                            pc.GetMonth(GregorianDateTime).ToString("00"),
                                            pc.GetDayOfMonth(GregorianDateTime).ToString("00"));

        _timeString = string.Format("{0}:{1}:{2}",
                                            pc.GetHour(GregorianDateTime).ToString("00"),
                                            pc.GetMinute(GregorianDateTime).ToString("00"),
                                            pc.GetSecond(GregorianDateTime).ToString("00"));
    }

    #endregion

    #region Operators

    public static bool operator >(ShamsiDateTime date1, ShamsiDateTime date2)
    {
        try
        {
            if (string.IsNullOrEmpty(date1.DateTimeString) || string.IsNullOrEmpty(date2.DateTimeString)) throw new Exception("عملوندها معتبر نیستند");
            int datediff = string.Compare(date1.DateTimeString, date2.DateTimeString);
            if (datediff > 0) return true;
            return false;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static bool operator >=(ShamsiDateTime date1, ShamsiDateTime date2)
    {
        try
        {
            if (string.IsNullOrEmpty(date1.DateTimeString) || string.IsNullOrEmpty(date2.DateTimeString)) throw new Exception("عملوندها معتبر نیستند");
            int datediff = string.Compare(date1.DateTimeString, date2.DateTimeString);
            if (datediff > 0 || string.Equals(date1.DateTimeString, date2.DateTimeString)) return true;
            return false;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static bool operator <(ShamsiDateTime date1, ShamsiDateTime date2)
    {
        try
        {
            if (string.IsNullOrEmpty(date1.DateTimeString) || string.IsNullOrEmpty(date2.DateTimeString)) throw new Exception("عملوندها معتبر نیستند");
            int datediff = string.Compare(date1.DateTimeString, date2.DateTimeString);
            if (datediff < 0) return true;
            return false;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static bool operator <=(ShamsiDateTime date1, ShamsiDateTime date2)
    {
        try
        {
            if (string.IsNullOrEmpty(date1.DateTimeString) || string.IsNullOrEmpty(date2.DateTimeString)) throw new Exception("عملوندها معتبر نیستند");
            int datediff = string.Compare(date1.DateTimeString, date2.DateTimeString);
            if (datediff < 0 || string.Equals(date1.DateTimeString, date2.DateTimeString)) return true;
            return false;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static bool operator ==(ShamsiDateTime date1, ShamsiDateTime date2)
    {
        try
        {
            if (string.IsNullOrEmpty(date1.DateTimeString) || string.IsNullOrEmpty(date2.DateTimeString)) throw new Exception("عملوندها معتبر نیستند");
            if (string.Equals(date1.DateTimeString, date2.DateTimeString)) return true;
            return false;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static bool operator !=(ShamsiDateTime date1, ShamsiDateTime date2)
    {
        try
        {
            if (string.IsNullOrEmpty(date1.DateTimeString) || string.IsNullOrEmpty(date2.DateTimeString)) throw new Exception("عملوندها معتبر نیستند");
            if (!string.Equals(date1.DateTimeString, date2.DateTimeString)) return true;
            return false;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    #endregion

    #region Override Methods
    
    public override bool Equals(object obj)
    {
        var item = obj as ShamsiDateTime;

        if (item is null)
        {
            return false;
        }

        return this.DateTimeString.Equals(item.DateTimeString);
    }

    public override int GetHashCode()
    {
        return this.DateTimeString.GetHashCode();
    }

    #endregion

    #region Methods

    public DateTime ToGregorianDateTime()
    {
        DateTime dt = new DateTime(Year, Month, Day, Hour, Minute, Second, pc);
        
        return dt;
    }

    public int DaysInMonth()
    {
        return pc.GetDaysInMonth(Year, Month);

    }

    public string GetDayOfWeek()
    {
        DateTimeFormatInfo dtfi = CultureInfo.GetCultureInfo("fa-IR").DateTimeFormat;
        return dtfi.GetDayName(pc.GetDayOfWeek(ToGregorianDateTime()));
    }

    #endregion
}