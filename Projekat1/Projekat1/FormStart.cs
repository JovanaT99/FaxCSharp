using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat1
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            Program.otvoriAdmin();
        }

        private void buttonProdaja_Click(object sender, EventArgs e)
        {
            Program.otvoriProdaju();
        }
    }
}
