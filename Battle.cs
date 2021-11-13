using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_cock_and_bull_adventure
{
    public partial class Battle : Form
    {

        Move moveForm;
        //Create the form we are going to load.


        public Battle()
        {
            InitializeComponent();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            moveForm = new Move();
            moveForm.Show();
            this.Hide();
        }
    }
}
