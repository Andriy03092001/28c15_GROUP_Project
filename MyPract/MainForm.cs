using MyPract.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPract
{
    
    public partial class MainForm : Form
    {
        EFContext _context = new EFContext();
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddGamesForm dlg = new AddGamesForm();
            dlg.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddCommandForm dlg = new AddCommandForm(_context);
            dlg.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPlayerForm dlg = new AddPlayerForm(_context);
            dlg.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowGame dlg = new ShowGame();
            dlg.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowTeam dlg = new ShowTeam();
            dlg.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowPlayer dlg = new ShowPlayer();
            dlg.ShowDialog();
        }
    }
}
