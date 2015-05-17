using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace Appointments
{
    public class DataSetManager : IAppointmentManager
    {
        private const string DataFile = "data.xml";
        private const string SetName = "calendar";
        private const string TableName = "appointments";
        private const string ColumnContent = "content";
        private const string ColumnStart = "start";
        private const string ColumnEnd = "end";

        private readonly DataSet _dataSet = new DataSet();

        public DataTable GetTable()
        {
            return _dataSet.Tables[TableName];
        }

        public void ReadData()
        {
            if (!File.Exists(DataFile))
            {
                CreateSkeleton();
            }
            _dataSet.ReadXml(DataFile);
        }

        public void WriteData()
        {
            _dataSet.WriteXml(DataFile);
        }
        

        public int Create(Appointment apt)
        {
            var row = _dataSet.Tables[TableName].NewRow();
            row[ColumnContent] = apt.Content;
            row[ColumnStart] = apt.DateStart;
            row[ColumnEnd] = apt.DateEnd;
            _dataSet.Tables[TableName].Rows.Add(row);
            return _dataSet.Tables[TableName].Rows.IndexOf(row);
        }


        public void Update(Appointment apt)
        {
            if ((apt.Id < 0)) return;
            var row = _dataSet.Tables[TableName].Rows[apt.Id];
            row[ColumnContent] = apt.Content;
            row[ColumnStart] = apt.DateStart;
            row[ColumnEnd] = apt.DateEnd;
        }

        public void Delete(Appointment apt)
        {
            if (apt.Id >= 0)
            {
                _dataSet.Tables[TableName].Rows.RemoveAt(apt.Id);
            }
        }

        //  See IAppointmentManager.FindAll
        public List<Appointment> FindAll()
        {
            return CreateAppointmentList(_dataSet.Tables[TableName].Select());
        }

        //  See IAppointmentManager.FindById
        public Appointment FindById(int id)
        {
            return CreateAppointment(_dataSet.Tables[TableName].Rows[id]);
        }

        // See IAppointmentManager.FindBetween
        public List<Appointment> FindBetween(DateTime dateFrom, DateTime dateTo)
        {
            var expression = ColumnStart + " >= #" + dateFrom + "# AND " + ColumnEnd + " <= #" + dateTo + "#";

            return CreateAppointmentList(_dataSet.Tables[TableName].Select(expression));
        }

        // See IAppointmentManager.FindForDate
        public List<Appointment> FindForDate(DateTime dateOn)
        {
            var dateFrom = new DateTime(dateOn.Year, dateOn.Month, dateOn.Day, 0, 0, 0);
            var dateTo = new DateTime(dateOn.Year, dateOn.Month, dateOn.Day, 23, 59, 59);

            return FindBetween(dateFrom, dateTo);
        }


        // creates dataset XML skeleton; used if no file was found
        private void CreateSkeleton()
        {
            var ds = new DataSet(SetName);

            var table = ds.Tables.Add(TableName);
            table.Columns.Add(ColumnStart, typeof(string));
            table.Columns.Add(ColumnEnd, typeof(string));
            table.Columns.Add(ColumnContent, typeof(string));

            var row = ds.Tables[TableName].NewRow();
            row[ColumnStart] = "1970-01-01 00:00:00";
            row[ColumnEnd] = "1970-01-01 00:00:00";
            row[ColumnContent] = "Dummy appointment";

            ds.Tables[TableName].Rows.Add(row);
            ds.WriteXml(DataFile);
        }

        // create a new appointment instance from row
        private Appointment CreateAppointment(DataRow row)
        {
            return new Appointment(row[ColumnContent].ToString(), (DateTime)row[ColumnStart], (DateTime) row[ColumnEnd], _dataSet.Tables[TableName].Rows.IndexOf(row));
        }

        // create a list of appointments from row collection
        private List<Appointment> CreateAppointmentList(IEnumerable<DataRow> collection)
        {
            return collection.Select(CreateAppointment).ToList();
        }
    }
}
