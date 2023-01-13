using ProjectT100.Controller;
using ProjectT100.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectT100.View
{
    public partial class LijstFrm : Form
    {
        public LijstFrm()
        {
            InitializeComponent();
        }

        StudController patientControllerdel = new StudController();

        private void FillListView()
        {
            LvStud.Clear();
            LvStud.View = System.Windows.Forms.View.Details;
           
            // maakt kolommen in de listview form
            LvStud.Columns.Add("StudentNummer", 150);
            LvStud.Columns.Add("Voornaam", 100);

            //maakt verbinding met de controller en de model om de aangeklikte gegevens te verwijderen
            List<StudModel> LvStud1 = patientControllerdel.ReadAll();

            foreach (StudModel item in LvStud1)
            {
                // Maak listview items
                // data van delvDoctorsze collomen in en convert ze naar tekst

                ListViewItem lvStud = new ListViewItem(Convert.ToString(item.Studentnummer));
                lvStud.SubItems.Add(Convert.ToString(item.voornaam));

                LvStud.FullRowSelect = true;
                // linkt doctormodel met listview items. 
                LvStud.Tag = item;

                // Voeg item toe aan listview
                LvStud.Items.Add(lvStud);
            }


        }

        private void LijstFrm_Load(object sender, EventArgs e)
        {
            StudController StudController = new StudController();
            FillListView();

        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            // tablad form LoginForm wordt geopend
            InschrijvenFrm form = new InschrijvenFrm();
            form.Show();
            
        }

        private void BtnEmail_Click(object sender, EventArgs e)
        {
            // tablad form LoginForm wordt geopend
            FrmEmail form = new FrmEmail();
            form.Show();

        }
    }
}
