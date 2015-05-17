using System;
using System.Windows.Forms;
using Appointments;

namespace Calendar
{
    public partial class EventForm : Form
    {
        public EventForm(Controls.DateTime dateFrom, Controls.DateTime dateTo)
        {
            _dateFrom = dateFrom;
            _dateTo = dateTo;
            InitializeComponent();
        }

        protected int AppointmentId;
    
        protected IAppointmentManager Am;
        private readonly Controls.DateTime _dateFrom;
        private readonly Controls.DateTime _dateTo;

        public EventForm(IAppointmentManager am, DateTime dateFrom, DateTime dateTo, string title, string description, int appointmentId) 
        {
            InitializeComponent();
            Am = am;
            _dateFrom.SetDateTime(dateFrom);
            _dateTo.SetDateTime(dateTo);
            TitleTextBox.Text = title;
            DescriptionTextBox.Text = description;
            AppointmentId = appointmentId;
        }
    
        public EventForm(IAppointmentManager am, DateTime dateFrom, DateTime dateTo)
        {
            Am = am;
            _dateFrom.SetDateTime(dateFrom);
            _dateTo.SetDateTime(dateTo);
            TitleTextBox.Text = "";
            DescriptionTextBox.Text = "";
            AppointmentId = -1;
        }

        public EventForm(IAppointmentManager am)
        {
            Am = am;
            _dateFrom.SetDateTime(DateTime.Now);
            _dateTo.SetDateTime(DateTime.Now);
            TitleTextBox.Text = "";
            DescriptionTextBox.Text = "";
            AppointmentId = -1;
        }
    
        private void datefrom_Change() {
            if ((dateFrom.GetDateTime() > dateTo.GetDateTime())) {
                dateTo.SetDateTime(dateFrom.GetDateTime());
            }
        }
    
        private void dateto_Change() {
            if ((dateTo.GetDateTime() < dateFrom.GetDateTime())) {
                dateFrom.SetDateTime(dateTo.GetDateTime());
            }
        }
    
        private void Button1_Click(object sender, EventArgs e)
        {
            var apt = new Appointment(DescriptionTextBox.Text, dateFrom.GetDateTime(), dateTo.GetDateTime(), AppointmentId);
            if ((AppointmentId >= 0)) {
                Am.Update(apt);
            }
            else {
                AppointmentId = Am.Create(apt);
                Button1.Text = "Update";
            }
            Am.WriteData();
        }
    }
}
