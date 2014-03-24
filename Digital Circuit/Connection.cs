using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Digital_Circuit
{
    class Connection
    {
        // Field
        private Boolean value;
        private int startX, startY, endX, endY;
        private Gate startgate;
        private Gate endgate;
        private static Brush[] myBrushes =
        { new SolidBrush(Color.Green),
          new SolidBrush(Color.Black),
          new SolidBrush(Color.Red)  };
        private Color connectioncolor;

        // Constructor
        public Connection(Gate startgate, Gate endgate)
        {
            //this.value = startgate.MyOutputValue;
            this.startgate = startgate;
            this.endgate = endgate;
            this.connectioncolor = Color.Black;
        }

        // Properties

        public Boolean Value 
        {
            get { return value; }
        }

        public int StartX 
        {
            get { return startX; }
        }

        public int StartY 
        {
            get { return startY; }
        }
        public int EndX
        {
            get { return endX; }
        }
        public int EndY
        {
            get { return endY; }
        }
        public Gate Startgate
        {
            get { return startgate; }
        }

        public Gate Endgate
        {
            get { return endgate; }
        }

        // Methods

        /// <summary>
        /// checks if the point (xmouse,ymouse) is on this connection.
        /// </summary>
        /// <param name="xmouse"></param>
        /// <param name="ymouse"></param>
        /// <returns></returns>
        public bool ContainsPoint(int xmouse, int ymouse)
        {
            
        }
        /// <summary>
        /// Draws a connection on it's location
        /// </summary>
        /// <param name="gr"></param>
        public void DrawConnection(Graphics gr)
        {
            gr.DrawLine(Pens.Black, startX, startY, endX, endY);
           

        }
    }
}
