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
    public partial class ShowGame : Form
    {
        EFContext context = new EFContext();
        public ShowGame()
        {
            InitializeComponent();
            foreach (var item in context.Games)
            {
                dgvGame.Rows.Add(item.Id,item.Name, item.Team1Id, item.Team2Id,item.DateOfGame);
            }
        }
    }
}
