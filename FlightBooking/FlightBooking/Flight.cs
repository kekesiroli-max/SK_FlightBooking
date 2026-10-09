using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBooking
{
    public class Flight
    {
        private string _code;
        private string _destination;
        private int _basePrice;
        private int _freeSeats;

        public string Code { get { return _code; } set { _code = value; } }
        public string Destination { get { return _destination; } set { _destination = value; } }
        public int BasePrice { get { return _basePrice; } set { _basePrice = value; } }
        public int FreeSeats { get { return _freeSeats; } set { _freeSeats = value; } }

        public Flight(string code, string destination, int basePrice, int freeSeats)
        {
            _code = code;
            _destination = destination;
            _basePrice = basePrice;
            _freeSeats = freeSeats;
        }

        public bool BookSeat()
        {
            if (_freeSeats > 0)
            {
                _freeSeats--;
                return true;
            }
            return false;
        }

        public string Describe()
        {
            if (_freeSeats > 0)
            {
                return $"{_code} {_destination}, {_basePrice} Ft, {_freeSeats} szabad hely.";
            }
            else
            {
                return $"{_code} {_destination}, {_basePrice} Ft, teltház.";
            }
        }
    }
}
