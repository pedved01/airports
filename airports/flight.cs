using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace airports
{
    public enum Flight_Type
    {
        arrival,
        depature
    }
    internal class Flight
    {
        public DateTime date_time { get; set; }
        public int ID { set; get; }
        public char terminal { set; get; }
        public string aviacompany { set; get; }
        public int gate { set; get; }
        public Flight_Type flight_Type { set; get; }
    }
}

