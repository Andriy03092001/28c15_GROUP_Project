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
    public partial class ShowPlayer : Form
    {
        EFContext context = new EFContext();
        public ShowPlayer()
        {
            InitializeComponent();
            foreach(var item in context.Players)
            {
                dgvPlayer.Rows.Add(item.Id,item.Name,item.TeamId);
            }

        }
    }
}
