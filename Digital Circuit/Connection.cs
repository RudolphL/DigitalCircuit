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
        public Connection(Boolean value, Gate startgate, Gate endgate)
        {
            //this.value = startgate.MyOutputValue;
            this.startgate = startgate;
            this.endgate = endgate;
            this.connectioncolor = Color.Black;
        }

        // Properties

        // Methods

        /// <summary>
        /// checks if the point (xmouse,ymouse) is on this connection.
        /// </summary>
        /// <param name="xmouse"></param>
        /// <param name="ymouse"></param>
        /// <returns></returns>
        public bool ContainsPoint(int xmouse, int ymouse)
        {
            return true;
        }

        /// <summary>
        /// Draws a connection on it's location
        /// </summary>
        /// <param name="gr"></param>
        public void DrawConnection(Graphics gr)
        {
            return;
        }
    }
}
