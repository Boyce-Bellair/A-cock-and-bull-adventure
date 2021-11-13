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
    public partial class Move : Form
    {

        public Battle BattleForm;

        public Move()
        {
            InitializeComponent();


        }

        private void onward_Click(object sender, EventArgs e)
        {
            BattleForm = new Battle();
            BattleForm.Show();
            this.Hide();
        }
    }
}
