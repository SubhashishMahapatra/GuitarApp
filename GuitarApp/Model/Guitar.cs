using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarApp.Enums;

namespace GuitarApp.Model
{
    public class Guitar
    {
        private string _serialNumber;
        private double _price;

        public GuitarSpec specs;
        
        public Guitar(string serialNumber, GuitarSpec guitarSpec , double price) 
        {
            _serialNumber = serialNumber;

            specs = guitarSpec;
            
            _price = price;
        }


        public string GetSerialNumber()
        {
            return _serialNumber; 
        }

        public double GetPrice ()
        {
            return _price; 
        }
        public void SetPrice(float newPrice)
        {
            this._price = newPrice;
        }


    }
}
