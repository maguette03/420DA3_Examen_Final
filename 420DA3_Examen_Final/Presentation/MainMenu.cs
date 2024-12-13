using _420DA3_Examen_Final.Business.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _420DA3_Examen_Final.Presentation
{
    internal partial class MainMenu : Form
    {
        private MyApplication parentApp;
        public MainMenu(MyApplication parentApp)
        {

            InitializeComponent();
            this.parentApp = parentApp;
        }

        private void btnCreateLivre_Click(object sender, EventArgs e)
        {
            Livre? newLivre = this.parentApp.LivreServices.OpenViewForCreation();
            if (newLivre != null)
            {
                this.searchResults.Items.Add(newLivre);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Livre? selectedLivre = this.searchResults.SelectedItem as Livre;
            if (selectedLivre != null)
            {
                this.parentApp.LivreServices.OpenViewForView(selectedLivre);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Livre? selectedLivre = this.searchResults.SelectedItem as Livre;
            if (selectedLivre != null)
            {
                this.parentApp.LivreServices.OpenViewForModification(selectedLivre);
                this.LoadSearchResult();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Livre? selectedLivre = this.searchResults.SelectedItem as Livre;
            if (selectedLivre != null)
            {
                this.parentApp.LivreServices.OpenViewForDeletion(selectedLivre);
                this.LoadSearchResult();
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void searchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadSearchResult();
            Livre? selectedLivre = this.searchResults.SelectedItem as Livre;
            if (selectedLivre != null)
            {
                this.btnView.Enabled = true;
                this.btnEdit.Enabled = true;
                this.btnDelete.Enabled = true;
            }
            else
            {
                this.btnView.Enabled = false;
                this.btnEdit.Enabled = false;
                this.btnDelete.Enabled = false;
            }
        }
        private void LoadSearchResult()
        {
            List<Livre> result = this.parentApp.LivreServices.SearchLivre(this.searchTextBox.Text.Trim());
            this.searchResults.SelectedItem = null;
            this.searchResults.SelectedIndex = -1;
            this.searchResults.Items.Clear();
            foreach (Livre livre in result)
            {
                this.searchResults.Items.Add(livre);
            }

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            this.LoadSearchResult();
        }
    }
}
