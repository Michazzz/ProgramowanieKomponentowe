using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime
{
    public partial class OwnDateTimePicker : UserControl
    {
        private DateTimeObject currDateTime;

        public OwnDateTimePicker()
        {
            InitializeComponent();
            var mDate = datePicker.Value.Date.ToString("dd - MM - yyyy");
            var mTime = timePicker.Value.ToString("HH:mm:ss");
            currDateTime = new DateTimeObject(mDate, mTime);
            tvCurrentDateTime.Text = currDateTime.ToString();
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            var mDate = datePicker.Value.Date.ToString("dd - MM - yyyy");
            currDateTime.Date = mDate;
            tvCurrentDateTime.Clear();
            tvCurrentDateTime.Text = currDateTime.ToString();
        }

        private void timePicker_ValueChanged(object sender, EventArgs e)
        {
            var mTime = timePicker.Value.ToString("HH:mm:ss");
            currDateTime.Time = mTime;
            tvCurrentDateTime.Clear();
            tvCurrentDateTime.Text = currDateTime.ToString();
        }
    }
}
