using System.Collections.Generic;

namespace Appointments
{
    public interface IAppointmentManager
    {
        void ReadData();
        void WriteData();
        int Create(Appointment apt);
        void Update(Appointment apt);
        void Delete(Appointment apt);
        List<Appointment> FindAll();
        Appointment FindById(int id);
        List<Appointment> FindBetween(System.DateTime dateFrom, System.DateTime dateTo);
        List<Appointment> FindForDate(System.DateTime dateOn);
    }
}
