using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBooking
{
    public class Passenger
    {
        private string _name;
        private int _age;
        private int _bagCount;


        public string Name { get { return _name;} set { value = _name; } }
        public int Age { get { return _age; } set { value = _age; } }
        public int BagCount { get { return _bagCount; } set { value = _bagCount; } }


       public Passenger(string name, int age)
        {
            _name = name;
            _age = age;
            _bagCount =0 ;
        }
        public bool AddBag()
        {
            if( _bagCount <= 2)
            {
                _bagCount++;
                return true;
            }
            else { return false; }
        }
        public bool IsChild()
        {
            if(_age < 12)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
