using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
   public class Gate
    {
        public double Height { get; set; }
        public double Width { get; set; }
        private string _gateStyle;

        public string gateStyle
        {
            get
            {
                return _gateStyle;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _gateStyle = null;

                }
                else
                {
                    _gateStyle = value;
                }
               
            }
        }
        public double? Price { get; set; }
        //default
        public Gate()
        {

        }
        //greedy
        public Gate(double height, double width, string style,double? price)
        {
            Height = height;
            Width = width;
            gateStyle = style;
            Price = Price;
        }
        
        //read-only property
        //contains NO set{}
        //data used in this property
        //      is data that is currently
        //      within the instance of this class
        public double GateArea
        {
            get
            {
                return Height * Width;
            }

        }

    }
}
