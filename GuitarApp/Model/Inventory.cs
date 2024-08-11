using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarApp.Enums;

namespace GuitarApp.Model
{
    public class Inventory
    {

        List<Guitar> guitars = new List<Guitar>();

        public void AddGuitar(string serialNumber, GuitarSpec guitarSpec, double price)
        {
            Guitar guitar = new Guitar(serialNumber, guitarSpec , price);
            guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            foreach (Guitar guitar in guitars)
            {
                if (guitar.GetSerialNumber() == serialNumber)
                {
                    return guitar;
                }
            }
            return null;
        }

        public List<Guitar> SearchGuitar(GuitarSpec searchGuitar)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();


            foreach(Guitar guitar in guitars)
            {
                if(guitar.specs.GetBuilder() ==  searchGuitar.GetBuilder() &&  guitar.specs.GetModel() == searchGuitar.GetModel() && guitar.specs.GetType() == searchGuitar.GetType() && guitar.specs.GetBackWood() == searchGuitar.GetBackWood() && guitar.specs.GetTopWood() == searchGuitar.GetTopWood())
                {
                    matchingGuitars.Add(guitar);
                }
                
            }
            return matchingGuitars;
        }
    }
}

