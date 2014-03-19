using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Circuit
{
    public partial class FormDigitalCircuit : Form
    {
        GridObjects gridob;

        public FormDigitalCircuit()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            gridob = new GridObjects();
        }
    }
}
