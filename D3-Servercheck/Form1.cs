using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D3_Servercheck
{
    public partial class startForm : Form
    {
        private OpenConnections myCon = new OpenConnections();
        public startForm()
        {
            InitializeComponent();
            ipOutput.Text = myCon.getServerIP();
        }
    }
}
