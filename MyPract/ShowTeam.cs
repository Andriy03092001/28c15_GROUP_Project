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
    public partial class ShowTeam : Form
    {
        public Entity.EFContext _eFContext = new Entity.EFContext();
        public Entity.EFContext _eFContext2 = new Entity.EFContext();

        public ShowTeam()
        {
            InitializeComponent();
            int count = 0;

            foreach (var item in _eFContext.Teams)
            {
                foreach (var item2 in _eFContext2.Players)
                {
                    if (item2.TeamId == item.Id)
                    {
                        count++;
                    }
                }
                dgvTeam.Rows.Add(item.Id, item.Name, count);
            }
        }
    }
}
