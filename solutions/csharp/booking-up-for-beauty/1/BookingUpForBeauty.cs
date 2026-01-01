using System.Globalization;
using Microsoft.VisualBasic;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        /*
        - `"7/25/2019 13:45:00"`
        - `"July 25, 2019 13:45:00"`
        - `"Thursday, July 25, 2019 13:45:00"`
        */
        string[] format =
        {
            "M/dd/yyyy HH:mm:ss",
            "M/d/yyyy HH:mm:ss",
            "MMMM d, yyyy HH:mm:ss",
            "dddd, MMMM d, yyyy HH:mm:ss"
        };
        // 用parse来把字符串转换成DateTime类型
        return DateTime.ParseExact(appointmentDateDescription, format, CultureInfo.InvariantCulture,DateTimeStyles.None);

    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        //Appointment.HasPassed(new DateTime(1999, 12, 31, 9, 0, 0))
        // => true
        return appointmentDate < DateTime.Now;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        //Appointment.IsAfternoonAppointment(new DateTime(2019, 03, 29, 15, 0, 0))
        // => true
        return appointmentDate.Hour >= 12 && appointmentDate.Hour < 18;
    }
    public static string Description(DateTime appointmentDate)
    {
        //Appointment.Description(new DateTime(2019, 03, 29, 15, 0, 0))
        // => "You have an appointment on 3/29/2019 3:00:00 PM."
        return $"You have an appointment on {appointmentDate.ToString("M/d/yyyy h:mm:ss tt",CultureInfo.InvariantCulture)}.";
    }

    public static DateTime AnniversaryDate()
    {
        return new DateTime(DateTime.Now.Year, 9, 15, 0, 0, 0);
    }
}
