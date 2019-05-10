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
        //default
        public Gate()
        {

        }
        //greedy
        public Gate(double height, double width, string style)
        {
            Height = height;
            Width = width;
            gateStyle = style;
        }

    }
}
