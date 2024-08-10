using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using GuitarApp.Enums;

namespace GuitarApp.Model
{
    public class GuitarSpec
    {
        private string _model;
        public Types TypeOfGuitar { get; set; }

        public Builder Builder { get; set; }
        public Wood BackWood { get; set; }
        public Wood TopWood { get; set; }

        public int NumberOfStrings { get; set; }





        public GuitarSpec(Builder builder, string model, Types type, Wood backwood, Wood topwood, int numberOfStrings)
        {
            Builder = builder;
            _model = model;
            TypeOfGuitar = type;
            BackWood = backwood;
            TopWood = topwood;
            NumberOfStrings = numberOfStrings;
        }


        public Builder GetBuilder()
        {
            return Builder;
        }

        public string GetModel()
        {
            return _model;
        }

        public Types GetType()
        {
            return TypeOfGuitar;
        }

        public Wood GetBackWood()
        {
            return BackWood;
        }

        public Wood GetTopWood()
        {
            return TopWood;
        }


    }
}
