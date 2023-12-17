namespace NoteProject.UI
{
    partial class AdminScreen
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
            btnDurum = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // btnDurum
            // 
            btnDurum.Location = new Point(492, 39);
            btnDurum.Margin = new Padding(4);
            btnDurum.Name = "btnDurum";
            btnDurum.Size = new Size(256, 59);
            btnDurum.TabIndex = 7;
            btnDurum.Text = "Aktif / Pasif";
            btnDurum.UseVisualStyleBackColor = true;
            btnDurum.Click += btnDurum_Click;
            // 
            // listView1
            // 
            listView1.Activation = ItemActivation.TwoClick;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.Dock = DockStyle.Bottom;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HoverSelection = true;
            listView1.Location = new Point(0, 145);
            listView1.Margin = new Padding(4);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(761, 551);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ad";
            columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Soyad";
            columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Kullanıcı Adı";
            columnHeader3.Width = 240;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Durum";
            columnHeader4.Width = 150;
            // 
            // AdminScreen
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 696);
            Controls.Add(btnDurum);
            Controls.Add(listView1);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "AdminScreen";
            Text = "AdminScreen";
            Load += AdminScreen_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnDurum;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}