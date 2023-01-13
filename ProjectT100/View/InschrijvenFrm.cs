using Microsoft.VisualBasic.ApplicationServices;
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

namespace ProjectT100
{
    public partial class InschrijvenFrm : Form
    {
        public InschrijvenFrm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int rowsAffected = 0;

            StudModel create = new StudModel();
            // de ingevulde gegevens ophalen 


            create.Studentnummer = int.Parse(TbStud.Text);  
            create.voornaam = Tbvoor.Text;
  
            // kijken of het gelukt is met een messagebox
            StudController addControl = new StudController();

            // een nieuwe regele met gegevens wordt toegevoegd
            rowsAffected = addControl.CreatePatient(create);

            // het de uitvoering is gelukt wordt er een nieuwe regel toegevoegd met de nieuwe gegevens
            if (rowsAffected > 0)
            {
                MessageBox.Show("Student is Toegevoegd");
            }
            else
            {
                // als het niet werkt dan geeft het iets aan dat het niet werkt
                MessageBox.Show("niet geslaagd " + rowsAffected + MessageBoxButtons.OK +
                    MessageBoxIcon.Error);
            }

            DialogResult = DialogResult.OK;

            this.Close();

        }
    }
    
}
