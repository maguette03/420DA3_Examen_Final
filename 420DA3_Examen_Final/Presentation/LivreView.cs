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

    public enum ViewAction
    {
        Create, 
        View,
        Update,
        Delete
    }
    internal partial class LivreView : Form
    {
        private MyApplication parentApp;
        private ViewAction currentAction;
        private Livre currentInstance = null!;
        private bool isInitialized = false;
        public LivreView(MyApplication parentApp)
        {
            this.parentApp = parentApp;
            InitializeComponent();
            this.TitreValue.MaxLength = Livre.MAX_LENGTH_TITRE;
            this.IsbnValue.MaxLength = Livre.MAX_LENGTH_ISBN;
        }


       public  DialogResult OpenForCreation(Livre newLivre)
        {
            try
            {
                this.Initialize();
                this.currentAction = ViewAction.Create;
                this.LoadLivreData(newLivre);
                this.BtnAction.Text = "Create";
                this.TitreValue.Enabled = true;
                this.IsbnValue.Enabled = true;
                this.AuteurValue.Enabled = true;
                return this.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DialogResult.Abort;
            }
        }

        public DialogResult OpenForView(Livre livre)
        {
            try
            {
                this.Initialize();
                this.currentAction = ViewAction.View;
                this.LoadLivreData(livre);
                this.BtnAction.Text = "OK";
                this.TitreValue.Enabled = false;
                this.IsbnValue.Enabled = false;
                this.AuteurValue.Enabled = false;
                return this.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DialogResult.Abort;
            }
        }

        public DialogResult OpenForModification(Livre livre)
        {

            try
            {
                this.Initialize();
                this.currentAction = ViewAction.Update;
                this.LoadLivreData(livre);
                this.BtnAction.Text = "Save";
                this.TitreValue.Enabled = true;
                this.IsbnValue.Enabled = true;
                this.AuteurValue.Enabled = true;
                return this.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DialogResult.Abort;
            }

        }
        public DialogResult OpenForDeletion(Livre livre)
        {
            try
            {
                this.Initialize();
                this.currentAction = ViewAction.Delete;
                this.LoadLivreData(livre);
                this.BtnAction.Text = "Confirm";
                this.TitreValue.Enabled = false;
                this.IsbnValue.Enabled = false;
                this.AuteurValue.Enabled = false;
                return this.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DialogResult.Abort;
            }


        }

        private void LoadLivreData(Livre livre)
        {
            this.currentInstance = livre;

            this.IdValue.Value = livre.Id;
            this.TitreValue.Text = livre.Titre;
            this.IsbnValue.Text = livre.Isbn;

            this.AuteurValue.SelectedItem = null;
            this.AuteurValue.SelectedIndex = -1;
            this.AuteurValue.SelectedItems.Clear();
            foreach (Auteur auteur in livre.Auteurs)
            {
                this.AuteurValue.SelectedItems.Add(auteur);
            }

        }
        public void Initialize()
        {
            if (!this.isInitialized)
            {
                List<Auteur> auteurs = this.parentApp.AuteurServices.GetAll();
                foreach (Auteur auteur in auteurs)
                {
                    this.AuteurValue.Items.Add(auteur);
                }
            }

            this.isInitialized = true;
        }
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            switch (this.currentAction)
            {
                case ViewAction.Create:
                    this.currentInstance.Titre = this.TitreValue.Text;
                    this.currentInstance.Isbn = this.IsbnValue.Text;

                    this.currentInstance.Auteurs.Clear();
                    this.currentInstance.Auteurs = this.AuteurValue.SelectedItems.Cast<Auteur>().ToList();
                    this.parentApp.LivreServices.InsertLivre(this.currentInstance);
                    break;
                case ViewAction.Update:
                    this.currentInstance.Titre = this.TitreValue.Text;
                    this.currentInstance.Isbn = this.IsbnValue.Text;

                    this.currentInstance.Auteurs.Clear();
                    this.currentInstance.Auteurs = this.AuteurValue.SelectedItems.Cast<Auteur>().ToList();
                    this.parentApp.LivreServices.UpdateLivre(this.currentInstance);
                    break;

                case ViewAction.Delete:
                    this.parentApp.LivreServices.DeleteLivre(this.currentInstance);
                    break;
                case ViewAction.View:
                default:
                    break;
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
