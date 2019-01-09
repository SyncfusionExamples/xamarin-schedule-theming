using System;
using Syncfusion.SfSchedule.XForms;
using Xamarin.Forms;

namespace ScheduleTheme
{
    public class ScheduleViewModel
    {
        public ScheduleAppointmentCollection Appointments { get; set; } = new ScheduleAppointmentCollection();
        public ScheduleViewModel()
        {
            for (int i = 0; i < 10; i++)
            {
                var appointment = new ScheduleAppointment();
                appointment.StartTime = DateTime.Now.Date.AddHours(10).AddDays(i);
                appointment.EndTime = appointment.StartTime.AddHours(2);
                appointment.Color = Color.Red;
                appointment.Subject = appointment.StartTime.ToString();
                Appointments.Add(appointment);
            }
        }
    }
}
