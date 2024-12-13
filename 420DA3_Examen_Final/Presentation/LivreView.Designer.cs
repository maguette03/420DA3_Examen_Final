namespace _420DA3_Examen_Final.Presentation
{
    partial class LivreView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            topBarPanel = new Panel();
            ButtomBarPanel = new Panel();
            tableLayoutPanel = new TableLayoutPanel();
            PanelCenter = new Panel();
            labelid = new Label();
            labelTitre = new Label();
            label2 = new Label();
            label3 = new Label();
            IdValue = new NumericUpDown();
            TitreValue = new TextBox();
            IsbnValue = new TextBox();
            btnAnnuler = new Button();
            BtnAction = new Button();
            AuteurValue = new ListBox();
            ButtomBarPanel.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            PanelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IdValue).BeginInit();
            SuspendLayout();
            // 
            // topBarPanel
            // 
            topBarPanel.Dock = DockStyle.Top;
            topBarPanel.Location = new Point(0, 0);
            topBarPanel.Name = "topBarPanel";
            topBarPanel.Size = new Size(628, 54);
            topBarPanel.TabIndex = 0;
            // 
            // ButtomBarPanel
            // 
            ButtomBarPanel.Controls.Add(BtnAction);
            ButtomBarPanel.Controls.Add(btnAnnuler);
            ButtomBarPanel.Dock = DockStyle.Bottom;
            ButtomBarPanel.Location = new Point(0, 396);
            ButtomBarPanel.Name = "ButtomBarPanel";
            ButtomBarPanel.Size = new Size(628, 54);
            ButtomBarPanel.TabIndex = 1;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 500F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(PanelCenter, 1, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 54);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(628, 342);
            tableLayoutPanel.TabIndex = 2;
            // 
            // PanelCenter
            // 
            PanelCenter.Controls.Add(AuteurValue);
            PanelCenter.Controls.Add(IsbnValue);
            PanelCenter.Controls.Add(TitreValue);
            PanelCenter.Controls.Add(IdValue);
            PanelCenter.Controls.Add(label3);
            PanelCenter.Controls.Add(label2);
            PanelCenter.Controls.Add(labelTitre);
            PanelCenter.Controls.Add(labelid);
            PanelCenter.Dock = DockStyle.Fill;
            PanelCenter.Location = new Point(67, 3);
            PanelCenter.Name = "PanelCenter";
            PanelCenter.Size = new Size(494, 336);
            PanelCenter.TabIndex = 0;
            // 
            // labelid
            // 
            labelid.Location = new Point(3, 11);
            labelid.Name = "labelid";
            labelid.Size = new Size(201, 31);
            labelid.TabIndex = 0;
            labelid.Text = "Id:";
            labelid.TextAlign = ContentAlignment.TopRight;
            // 
            // labelTitre
            // 
            labelTitre.Location = new Point(3, 57);
            labelTitre.Name = "labelTitre";
            labelTitre.Size = new Size(201, 31);
            labelTitre.TabIndex = 1;
            labelTitre.Text = "Titre:";
            labelTitre.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.Location = new Point(3, 105);
            label2.Name = "label2";
            label2.Size = new Size(201, 31);
            label2.TabIndex = 2;
            label2.Text = "Isbn:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.Location = new Point(3, 161);
            label3.Name = "label3";
            label3.Size = new Size(407, 31);
            label3.TabIndex = 3;
            label3.Text = "Auteur";
            // 
            // IdValue
            // 
            IdValue.Location = new Point(235, 9);
            IdValue.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            IdValue.Name = "IdValue";
            IdValue.Size = new Size(298, 31);
            IdValue.TabIndex = 4;
            // 
            // TitreValue
            // 
            TitreValue.Location = new Point(235, 54);
            TitreValue.Name = "TitreValue";
            TitreValue.PlaceholderText = "Titre du Livre";
            TitreValue.Size = new Size(300, 31);
            TitreValue.TabIndex = 5;
            // 
            // IsbnValue
            // 
            IsbnValue.Location = new Point(235, 102);
            IsbnValue.Name = "IsbnValue";
            IsbnValue.PlaceholderText = "Isbn du Livre";
            IsbnValue.Size = new Size(300, 31);
            IsbnValue.TabIndex = 6;
            // 
            // btnAnnuler
            // 
            btnAnnuler.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnnuler.Location = new Point(438, 6);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(173, 43);
            btnAnnuler.TabIndex = 0;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // BtnAction
            // 
            BtnAction.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnAction.Location = new Point(228, 6);
            BtnAction.Name = "BtnAction";
            BtnAction.Size = new Size(173, 43);
            BtnAction.TabIndex = 1;
            BtnAction.Text = "PLACEHOLDER";
            BtnAction.UseVisualStyleBackColor = true;
            BtnAction.Click += BtnAction_Click;
            // 
            // AuteurValue
            // 
            AuteurValue.FormattingEnabled = true;
            AuteurValue.ItemHeight = 25;
            AuteurValue.Location = new Point(3, 197);
            AuteurValue.Name = "AuteurValue";
            AuteurValue.Size = new Size(489, 129);
            AuteurValue.TabIndex = 7;
            // 
            // LivreView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 450);
            Controls.Add(tableLayoutPanel);
            Controls.Add(ButtomBarPanel);
            Controls.Add(topBarPanel);
            Name = "LivreView";
            Text = "Gestion dees Livres";
            ButtomBarPanel.ResumeLayout(false);
            tableLayoutPanel.ResumeLayout(false);
            PanelCenter.ResumeLayout(false);
            PanelCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IdValue).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel topBarPanel;
        private Panel ButtomBarPanel;
        private TableLayoutPanel tableLayoutPanel;
        private Panel PanelCenter;
        private Label labelid;
        private Label label3;
        private Label label2;
        private Label labelTitre;
        private TextBox IsbnValue;
        private TextBox TitreValue;
        private NumericUpDown IdValue;
        private Button BtnAction;
        private Button btnAnnuler;
        private ListBox AuteurValue;
    }
}