using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Appointments;
using Controls.Annotations;

namespace Controls
{
    public partial class AppointmentList : UserControl
    {

    private sealed class AppointmentLabel : Label
    {
        private readonly Appointment _appointment;
        private AppointmentList ParentInstance { set; [UsedImplicitly] get; }
        
        public AppointmentLabel(Appointment appointment, AppointmentList parentInstance)
        {
            _appointment = appointment;
            ParentInstance = parentInstance;
            Click += parentInstance.AppointmentLabel_Click;
            BorderStyle = BorderStyle.Fixed3D;
        }

        public Appointment GetAppointment()
        {
            return _appointment;
        }

        public void MarkAsSelected()
        {
            BorderStyle = BorderStyle.FixedSingle;
        }

        public void MarkAsUnselected()
        {
            BorderStyle = BorderStyle.Fixed3D;
        }
    }
    public static int StepHeight = 13;
    public static int MinutesPerStep = 30;
    public static int OffsetLeft = 50;
    private AppointmentLabel _selectedAppointment;

    public void SetAppointmentList(List<Appointment> aptList)
    {
        _selectedAppointment = null;
        PaintHours();
        PaintAppointments(aptList);
    }

    private void PaintAppointments(IEnumerable<Appointment> aptList)
    {
        ListBox1.Controls.Clear();
        foreach (var apt in aptList)
        {
            PaintAppointment(apt);
        }
    }
    private void PaintHours()
    {
        ListBox1.Items.Clear();
        for (var i = 0; i <= 23; i++) {
            ListBox1.Items.Add(ToHour(i));
            ListBox1.Items.Add(ToHour(i, 30));
        }
    }
    private string ToHour(int hour, int minutes = 0)
    {
        var h = hour < 10 ? "0" + hour : hour.ToString(CultureInfo.InvariantCulture);
        var m = minutes < 10 ? "0" + minutes : minutes.ToString(CultureInfo.InvariantCulture);
        return h + ":" + m;
    }
    private void PaintAppointment(Appointment apt)
    {
        var element = new AppointmentLabel(apt, this);
        var y = (apt.DateStart.Hour * 2 * StepHeight) + Math.Floor(((double)apt.DateStart.Minute / MinutesPerStep)) * StepHeight;
        var h = Math.Floor( (double)(apt.DateStart - apt.DateEnd).Minutes / MinutesPerStep) * StepHeight;
        var w = ListBox1.Width - OffsetLeft;
        w = w > 100 ? w : 100;

        element.Text = apt.Content;
        element.BackColor = Color.DodgerBlue;
        element.Location = new Point(OffsetLeft, (int)y);
        element.Size = new Size(w, (int)h);
        element.BringToFront();
        ListBox1.Controls.Add(element);
    }
    private void AppointmentLabel_Click(object sender, EventArgs e)
    {
        if ((_selectedAppointment != null)) {
            _selectedAppointment.MarkAsUnselected();
        }
        _selectedAppointment = (AppointmentLabel)sender;
        _selectedAppointment.MarkAsSelected();
    }
    }
}
