namespace _420DA3_Examen_Final.Presentation
{
    partial class MainMenu
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
            BottomBarPanel = new Panel();
            btnQuitter = new Button();
            tableLayoutPanel = new TableLayoutPanel();
            centerPanel = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            btnView = new Button();
            searchResults = new ListBox();
            searchTextBox = new TextBox();
            btnCreateLivre = new Button();
            BottomBarPanel.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            centerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topBarPanel
            // 
            topBarPanel.Dock = DockStyle.Top;
            topBarPanel.Location = new Point(0, 0);
            topBarPanel.Name = "topBarPanel";
            topBarPanel.Size = new Size(478, 64);
            topBarPanel.TabIndex = 0;
            // 
            // BottomBarPanel
            // 
            BottomBarPanel.Controls.Add(btnQuitter);
            BottomBarPanel.Dock = DockStyle.Bottom;
            BottomBarPanel.Location = new Point(0, 330);
            BottomBarPanel.Name = "BottomBarPanel";
            BottomBarPanel.Size = new Size(478, 64);
            BottomBarPanel.TabIndex = 1;
            // 
            // btnQuitter
            // 
            btnQuitter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnQuitter.Location = new Point(321, 16);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(145, 36);
            btnQuitter.TabIndex = 0;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = true;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(centerPanel, 1, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 64);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(478, 266);
            tableLayoutPanel.TabIndex = 2;
            // 
            // centerPanel
            // 
            centerPanel.Controls.Add(btnDelete);
            centerPanel.Controls.Add(btnEdit);
            centerPanel.Controls.Add(btnView);
            centerPanel.Controls.Add(searchResults);
            centerPanel.Controls.Add(searchTextBox);
            centerPanel.Controls.Add(btnCreateLivre);
            centerPanel.Dock = DockStyle.Fill;
            centerPanel.Location = new Point(92, 3);
            centerPanel.Name = "centerPanel";
            centerPanel.Size = new Size(294, 260);
            centerPanel.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(200, 217);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 40);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Enabled = false;
            btnEdit.Location = new Point(103, 217);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(81, 40);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnView
            // 
            btnView.Enabled = false;
            btnView.Location = new Point(5, 217);
            btnView.Name = "btnView";
            btnView.Size = new Size(78, 40);
            btnView.TabIndex = 3;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // searchResults
            // 
            searchResults.FormattingEnabled = true;
            searchResults.ItemHeight = 25;
            searchResults.Location = new Point(0, 122);
            searchResults.Name = "searchResults";
            searchResults.Size = new Size(294, 79);
            searchResults.TabIndex = 2;
            searchResults.SelectedIndexChanged += searchResults_SelectedIndexChanged;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(13, 69);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Search Livres";
            searchTextBox.Size = new Size(278, 31);
            searchTextBox.TabIndex = 1;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // btnCreateLivre
            // 
            btnCreateLivre.Location = new Point(11, 12);
            btnCreateLivre.Name = "btnCreateLivre";
            btnCreateLivre.Size = new Size(269, 36);
            btnCreateLivre.TabIndex = 0;
            btnCreateLivre.Text = "Creer Un Nouveau Livre";
            btnCreateLivre.UseVisualStyleBackColor = true;
            btnCreateLivre.Click += btnCreateLivre_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 394);
            Controls.Add(tableLayoutPanel);
            Controls.Add(BottomBarPanel);
            Controls.Add(topBarPanel);
            Name = "MainMenu";
            Text = "MainMenu";
            BottomBarPanel.ResumeLayout(false);
            tableLayoutPanel.ResumeLayout(false);
            centerPanel.ResumeLayout(false);
            centerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel topBarPanel;
        private Panel BottomBarPanel;
        private TableLayoutPanel tableLayoutPanel;
        private Panel centerPanel;
        private TextBox searchTextBox;
        private Button btnCreateLivre;
        private Button btnQuitter;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnView;
        private ListBox searchResults;
    }
}