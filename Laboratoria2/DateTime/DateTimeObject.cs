using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime
{
    class DateTimeObject
    {
        public string Date { set; get; }
        public string Time { set; get; }

        public DateTimeObject(string date, string time)
        {
            Date = date;
            Time = time;
        }

        public override string ToString()
        {
            return string.Format(" {0},  {1}", Date, Time);
        }
    }
}
