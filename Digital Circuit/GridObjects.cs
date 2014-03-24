using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Digital_Circuit
{
    class GridObjects
    {
        // Fields
        private List<Gate> gates;
        private List<Connection> connections;

        // Delegates and events

        // Constructor
        public GridObjects()
        {
            this.gates = new List<Gate>();
            this.connections = new List<Connection>();
        }

        // Methods

        /// <summary>
        /// Returns a list of all gates
        /// </summary>
        /// <returns></returns>
        public List<Gate> GetAllGates()
        {
            return gates;
        }

        /// <summary>
        /// Returns a list of all connections
        /// </summary>
        /// <returns></returns>
        public List<Connection> GetAllConnections()
        {
            return connections;
        }

        /// <summary>
        /// Looks for a gate in the list of gates that contains the point (xmouse,ymouse)
        /// </summary>
        /// <param name="xmouse"></param>
        /// <param name="ymouse"></param>
        /// <returns>Return gate if found, else return null</returns>
        public Gate GetGate(int xmouse, int ymouse)
        {
            foreach (Gate gate in gates)
            {
                if(gate.ContainsPoint(xmouse, ymouse))
                {
                    return gate;
                }
            }
            return null;
        }

        /// <summary>
        /// Looks for a connection in the list of connectoins that contains the point (xmouse,ymouse)
        /// </summary>
        /// <param name="xmouse"></param>
        /// <param name="ymouse"></param>
        /// <returns>returns connection if found, else null</returns>
        public Connection GetConnection(int xmouse, int ymouse)
        {
            foreach (Connection connection in connections)
            {
                if (connection.ContainsPoint(xmouse, ymouse))
                {
                    return connection;
                }
            }
            return null;
        }

        /// <summary>
        /// Adds a gate to a specific location
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Return true if succesful</returns>
        public void AddGate(int x, int y)
        {
            Gate tempGate = GetGate(x,y);
            if(tempGate != null)
            {
                gates.Remove(tempGate);
            }
            gates.Add(new Gate(x, y));
        }

        // Changed from bool to void
        /// <summary>
        /// Adds a connection between two gates
        /// </summary>
        /// <param name="startgate"></param>
        /// <param name="endgate"></param>
        public void AddConnection(Gate startgate, Gate endgate)
        {
            //Connection tempConnection = new Connection(startgate, endgate);
            //connections.Add(tempConnection);
        }

        // Changed from bool to void
        /// <summary>
        /// Removes a gate from the list of gates.
        /// If the gate has connections to it, these will be deleted too.
        /// </summary>
        /// <param name="currentgate"></param>
        public void RemoveGate(Gate currentgate)
        {
            List<Connection> connectionsToRemove = new List<Connection>();
            //connectionsToRemove = currentgate.myConnections;
            foreach (Connection connection in connectionsToRemove)
            {
                connections.Remove(connection);
            }
        }

        // Changed from bool to void
        /// <summary>
        /// Removes a connection from the list of connections.
        /// </summary>
        /// <param name="currentconnection"></param>
        public void RemoveConnection(Connection currentconnection)
        {
            connections.Remove(currentconnection);
        }

        /// <summary>
        /// Loads a circuit from a file.
        /// </summary>
        /// <param name="filename"></param>
        public void LoadFile(string filename)
        {
            return;
        }

        /// <summary>
        /// Save a circuit to a file.
        /// </summary>
        public void SaveFile()
        {
            return;
        }

        /// <summary>
        /// Draws all the gates of the circuit
        /// </summary>
        /// <param name="gr"></param>
        public void DrawAllGates(Graphics gr)
        {
            return;
        }

        /// <summary>
        /// Draws all the connections of the circuit
        /// Not sure wether to join this with the gates
        /// </summary>
        /// <param name="gr"></param>
        public void DrawAllConnections(Graphics gr)
        {
            return;
        }
    }
}
