using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Digital_Circuit
{
    class Gate
    {
        // Fields
        private int x, y; // The x and y coordinates of a gate
        private List<Connection> myConnections; // A list of connections of the gate
        private List<Boolean> myInputValues; // The input values of the gate
        private Boolean myOutputValue; // The output values of the gate
        // something to paint the pictures, we don't know yet how. (Or hold an image - private Image myimage).
       
        // Delegates and events

        // Constructor
        public Gate(int x, int y)
        {
            this.x = x;
            this.y = y;
            myConnections = new List<Connection>();
            myInputValues = new List<Boolean>();
            myOutputValue = false;
        }

        // Properties
        public int X
        {
            get { return this.x; }
        }

        public int Y
        {
            get { return this.y; }
        }


        // Methods


        /// <summary>
        /// checks if the point (xmouse,ymouse) is on this gate.
        /// </summary>
        /// <param name="xmouse"></param>
        /// <param name="ymouse"></param>
        /// <returns>Returns true or false</returns>
        public bool ContainsPoint(int xmouse, int ymouse)
        {
            return true;
        }

        /// <summary>
        /// Draws a gate on it's location
        /// </summary>
        /// <param name="gr"></param>
        public void DrawGate(Graphics gr)
        {
            return;
        }
    }
}
