using MyPract.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace MyPract
{
    public partial class AddGamesForm : Form
    {
        EFContext _efcontext = new EFContext();
        public AddGamesForm(EFContext context)
        {
            InitializeComponent();
            _efcontext = context;
            int countAll = _efcontext.Teams.Count();
            int halfcount =(int)countAll / 2;
            int halfcount2 =countAll- halfcount;
            List<Team> listteam = _efcontext.Teams.ToList();
            for (int i=0;i<halfcount;i++)
            {
                ItemTeam it = new ItemTeam()
                {
                    Id= listteam[i].Id,
                    Name = listteam[i].Name
                };
                cbFirstTeam.Items.Add(it);
            }
            List<Team> listteam2 = _efcontext.Teams.ToList();
            for (int i = halfcount; i < countAll; i++)
            {
                ItemTeam it = new ItemTeam()
                {
                    Id = listteam2[i].Id,
                    Name = listteam2[i].Name
                };
                cbSecondTeam.Items.Add(it);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var team1 = (ItemTeam)cbFirstTeam.SelectedItem;
            var team2 = (ItemTeam)cbSecondTeam.SelectedItem;
            using (TransactionScope ts = new TransactionScope())
            {
                SecondTeam st = new SecondTeam()
                {
                    Id = team2.Id
                };
                _efcontext.SecondTeam.Add(st);
                Game game = new Game()
                {
                    Name = txtName.Text,
                    DateOfGame = dtpDate.Value,
                    Team1Id = team1.Id,
                    Team2Id = st.Id
                };
                _efcontext.Games.Add(game);
                _efcontext.SaveChanges();
                ts.Complete();
            }


            
        }
    }
}
