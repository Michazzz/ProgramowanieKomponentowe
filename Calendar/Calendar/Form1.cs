using System;
using System.Windows.Forms;
using Appointments;

namespace Calendar
{
    public partial class Form1 : Form
    {
        private IAppointmentManager _am;
        private EventForm _withEventsFieldEventForm;
        private EventForm EventForm
        {
            get { return _withEventsFieldEventForm; }
            set
            {
                if (_withEventsFieldEventForm != null)
                {
                    _withEventsFieldEventForm.FormClosing -= eventForm_FormClosing;
                }
                _withEventsFieldEventForm = value;
                if (_withEventsFieldEventForm != null)
                {
                    _withEventsFieldEventForm.FormClosing += eventForm_FormClosing;
                }
            }

        }

        public Form1()
        {
            InitializeComponent();
            Load += MainForm_Load;
            _am = new DataSetManager();
            _am.ReadData();
            InitializeComponent();
            dailyView1.SetAppointmentManager(_am);
            dailyView1.Search();
        }



    // calendar-event manager


    private void MainForm_Load(object sender, EventArgs e)
    {
        SetView(VIEW.Daily);
    }

    private void SetView(VIEW view)
    {
        dailyView1.Visible = false;
        DailyToolStripMenuItem.Checked = false;
        WeeklyToolStripMenuItem.Checked = false;
        MonthlyToolStripMenuItem.Checked = false;

        switch (view) {
            case VIEW.Daily:
                dailyView1.Visible = true;
                DailyToolStripMenuItem.Checked = true;
                break;
            case VIEW.Weekly:
                WeeklyToolStripMenuItem.Checked = true;
                break;
            case VIEW.Monthly:
                MonthlyToolStripMenuItem.Checked = true;
                break;
        }
    }

    // New Event menu popup
    private void NewToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if ((EventForm == null)) {
            EventForm = new EventForm(_am);
        }

        EventForm.Show();
    }

    // Set view menu event handlers
    private void DailyToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.SetView(VIEW.Daily);
    }

    private void WeeklyToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.SetView(VIEW.Weekly);
    }

    private void MonthlyToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.SetView(VIEW.Monthly);
    }

    private void eventForm_FormClosing(object sende, EventArgs e)
    {
        try {
            DailyView1.Search();
        } finally {
            EventForm = null;
        }
    }
}
}
