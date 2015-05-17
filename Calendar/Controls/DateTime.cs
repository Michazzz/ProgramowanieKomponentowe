using System;
using System.Windows.Forms;

namespace Controls
{
    public partial class DateTime : UserControl
    {

	    public static event ChangeEventHandler Change;
        public delegate void ChangeEventHandler();

        public DateTime()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
		    if (Change != null) {
			    Change();
		    }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
		    if (Change != null) {
			    Change();
		    }
        }

        public System.DateTime GetDateTime()
        {
            System.DateTime d1 = dateTimePicker1.Value;
            System.DateTime d2 = dateTimePicker2.Value;

            return new System.DateTime(d1.Year, d1.Month, d1.Day, 
                                        d2.Hour, d2.Minute, 0);
        }

        public void SetDateTime(System.DateTime date)
        {
            dateTimePicker1.Value = new System.DateTime(date.Year, date.Month, date.Day);
            dateTimePicker2.Value = new System.DateTime(date.Hour, date.Minute, 0);
        }
    }
}