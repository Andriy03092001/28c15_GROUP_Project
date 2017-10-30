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
    public partial class AddCommandForm : Form
    {
        EFContext _context;
        public AddCommandForm(EFContext eFContext)
        {
            _context = eFContext;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Team NEwTeam = new Team()
            {
                Name = textBox1.Text
            };
            _context.Teams.Add(NEwTeam);
            _context.SaveChanges();
        }
    }
}
