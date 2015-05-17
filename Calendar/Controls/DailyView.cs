using System;
using System.Windows.Forms;
using Appointments;

namespace Controls
{
    public partial class DailyView : UserControl
    {
        public DailyView()
        {
            InitializeComponent();
        }

        private IAppointmentManager _am;

        public void SetAppointmentManager(IAppointmentManager am)
        {
            _am = am;
        }

        public void Search()
        {
            appointmentList1.SetAppointmentList(_am.FindForDate(dateTimePicker1.Value));
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
