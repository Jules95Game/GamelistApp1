namespace GamelistApp1.WinForms
{
    partial class GamesOverview
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
            searchBox = new TextBox();
            listBox1 = new ListBox();
            btnAdd = new Button();
            btnRemove = new Button();
            lblTitle = new Label();
            lblPlat = new Label();
            lblDev = new Label();
            lblPub = new Label();
            txtTitle = new TextBox();
            txtPlat = new TextBox();
            txtDev = new TextBox();
            txtPub = new TextBox();
            txtDesc = new TextBox();
            lblDesc = new Label();
            SuspendLayout();
            // 
            // searchBox
            // 
            searchBox.Location = new Point(12, 12);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(275, 23);
            searchBox.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 41);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(275, 394);
            listBox1.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 451);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(135, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(153, 451);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(134, 23);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(331, 44);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(32, 15);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Title:";
            // 
            // lblPlat
            // 
            lblPlat.AutoSize = true;
            lblPlat.Location = new Point(307, 73);
            lblPlat.Name = "lblPlat";
            lblPlat.Size = new Size(56, 15);
            lblPlat.TabIndex = 4;
            lblPlat.Text = "Platform:";
            // 
            // lblDev
            // 
            lblDev.AutoSize = true;
            lblDev.Location = new Point(300, 102);
            lblDev.Name = "lblDev";
            lblDev.Size = new Size(63, 15);
            lblDev.TabIndex = 4;
            lblDev.Text = "Developer:";
            // 
            // lblPub
            // 
            lblPub.AutoSize = true;
            lblPub.Location = new Point(304, 131);
            lblPub.Name = "lblPub";
            lblPub.Size = new Size(59, 15);
            lblPub.TabIndex = 4;
            lblPub.Text = "Publisher:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(369, 41);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(478, 23);
            txtTitle.TabIndex = 5;
            // 
            // txtPlat
            // 
            txtPlat.Location = new Point(369, 70);
            txtPlat.Name = "txtPlat";
            txtPlat.ReadOnly = true;
            txtPlat.Size = new Size(478, 23);
            txtPlat.TabIndex = 5;
            // 
            // txtDev
            // 
            txtDev.Location = new Point(369, 99);
            txtDev.Name = "txtDev";
            txtDev.ReadOnly = true;
            txtDev.Size = new Size(478, 23);
            txtDev.TabIndex = 5;
            // 
            // txtPub
            // 
            txtPub.Location = new Point(369, 128);
            txtPub.Name = "txtPub";
            txtPub.ReadOnly = true;
            txtPub.Size = new Size(478, 23);
            txtPub.TabIndex = 5;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(369, 157);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.ReadOnly = true;
            txtDesc.ScrollBars = ScrollBars.Vertical;
            txtDesc.Size = new Size(478, 322);
            txtDesc.TabIndex = 6;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(293, 160);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(70, 15);
            lblDesc.TabIndex = 7;
            lblDesc.Text = "Description:";
            // 
            // GamesOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 486);
            Controls.Add(lblDesc);
            Controls.Add(txtDesc);
            Controls.Add(txtPub);
            Controls.Add(txtDev);
            Controls.Add(txtPlat);
            Controls.Add(txtTitle);
            Controls.Add(lblPub);
            Controls.Add(lblDev);
            Controls.Add(lblPlat);
            Controls.Add(lblTitle);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(listBox1);
            Controls.Add(searchBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "GamesOverview";
            Text = "Game Collection";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchBox;
        private ListBox listBox1;
        private Button btnAdd;
        private Button btnRemove;
        private Label lblTitle;
        private Label lblPlat;
        private Label lblDev;
        private Label lblPub;
        private TextBox txtTitle;
        private TextBox txtPlat;
        private TextBox txtDev;
        private TextBox txtPub;
        private TextBox txtDesc;
        private Label lblDesc;
    }
}