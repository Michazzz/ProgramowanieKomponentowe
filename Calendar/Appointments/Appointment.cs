using System;
namespace Appointments
{
    public class Appointment
    {

        public static string DateFormat = "yyyy-MM-dd HH:mm";
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }

        public Appointment(string content, DateTime dateStart, DateTime dateEnd, int id = 0)
        {
            Content = content;
            DateStart = dateStart;
            DateEnd = dateEnd;
            Id = id;
        }

        public Appointment()
            : this("", DateTime.Now, DateTime.Now)
        {
        }

        public override string ToString()
        {
            return (Content + " [" + DateStart.ToString(DateFormat) + " - " + DateEnd.ToString(DateFormat) + "]");
        }
    }
}
