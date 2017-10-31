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
    public partial class ShowGame : Form
    {
        EFContext _context=new EFContext();
        public ShowGame(EFContext eFContext)
        {
            InitializeComponent();
            var Games = _context
                .Games
                .Include(t=>t.team1)
                .Include(t => t.team2)
                .Include(t=>t.team2.Team)
                .ToList();
            foreach (var item in Games)
            {
                dgvGame.Rows.Add(item.Id,item.Name, item.team1.Name, item.team2.Team.Name,item.DateOfGame);
            }
        }
    }
}
