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
    public partial class AddPlayerForm : Form
    {
        EFContext _context;
        public AddPlayerForm(EFContext context)
        {
            InitializeComponent();
            _context = context;
            foreach (var item in _context.Teams)
            {
                ItemTeam it = new ItemTeam()
                {
                    Id = item.Id,
                    Name = item.Name
                };
                cbComands.Items.Add(it);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var temp = (ItemTeam)cbComands.SelectedItem;
            Player Player = new Player()
            {
                Name = txtName.Text,
                TeamId = temp.Id
            };
            _context.Players.Add(Player);
            _context.SaveChanges();
        }
    }
    public class ItemTeam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
