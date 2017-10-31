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
using System.Data.Entity;

namespace MyPract
{
    public partial class ShowPlayer : Form
    {
        EFContext _context = new EFContext();
        public ShowPlayer(EFContext context)
        {
            _context = context;
            InitializeComponent();
            var Players = context.Players.Include(t => t.Team);
                
            foreach(var item in Players)
            {
                dgvPlayer.Rows.Add(item.Id,item.Name,item.Team.Name);
            }

        }
    }
}
