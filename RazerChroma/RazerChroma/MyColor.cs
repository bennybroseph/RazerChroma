using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corale.Colore.Core;
using ColoreColor = Corale.Colore.Core.Color;

namespace RazerChroma
{
    // The whole point of this class is to allow putting the ColoreColor object into a ComboBox easy 
    class MyColor
    {
        private ColoreColor oColor;     // Holds the actual ColoreColor value 
        private string sName;           // Holds the string that will represent the object in the ComboBox

        // Quick Constructor
        public MyColor(ColoreColor a_oColor, string a_sName)
        {
            oColor = a_oColor;      
            sName = a_sName;
        }

        // Easy way to get the Color
        public ColoreColor Color
        {
            get
            {
                return oColor;
            }

            set
            {
                oColor = value;
            }
        }

        // Easy way to get the Name
        public string Name
        {
            get
            {
                return sName;
            }

            set
            {
                sName = value;
            }
        }

        // With this function we can pass in the MyColor object to the ComboBox, and it will return the sName of the 
        // object to display to the user since it does a ToString call if it finds a complex object instead of a string
        public override string ToString()
        {
            return sName;
        }
    }
}
