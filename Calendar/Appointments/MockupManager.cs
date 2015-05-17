using System;
using System.Collections.Generic;

namespace Appointments
{
    public class MockupManager : IAppointmentManager
    {
        public int Create(Appointment apt)
        {
            return 0;
        }
        public void Delete(Appointment apt)
        {
        }
        public List<Appointment> FindAll()
        {
            return new List<Appointment>();
        }
        public List<Appointment> FindBetween(DateTime dateFrom, DateTime dateTo)
        {
            return new List<Appointment>();
        }
        public List<Appointment> FindForDate(DateTime dateOn)
        {
            return new List<Appointment>();
        }
        public Appointment FindById(int id)
        {
            return new Appointment();
        }
        public void ReadData()
        {
        }
        public void Update(Appointment apt)
        {
        }
        public void WriteData()
        {
        }
    }
}
