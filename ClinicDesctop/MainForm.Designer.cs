namespace ClinicDesctop
{
    partial class MainForm
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
            this.listViewItem = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPatronomic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBirthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonItems = new System.Windows.Forms.Button();
            this.columnHeaderDocument = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewItem
            // 
            this.listViewItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderSurname,
            this.columnHeaderFirstName,
            this.columnHeaderPatronomic,
            this.columnHeaderBirthday,
            this.columnHeaderDocument});
            this.listViewItem.FullRowSelect = true;
            this.listViewItem.GridLines = true;
            this.listViewItem.HideSelection = false;
            this.listViewItem.Location = new System.Drawing.Point(12, 12);
            this.listViewItem.Name = "listViewItem";
            this.listViewItem.Size = new System.Drawing.Size(1054, 331);
            this.listViewItem.TabIndex = 0;
            this.listViewItem.UseCompatibleStateImageBehavior = false;
            this.listViewItem.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "#";
            // 
            // columnHeaderSurname
            // 
            this.columnHeaderSurname.Text = "Фамилия";
            this.columnHeaderSurname.Width = 150;
            // 
            // columnHeaderFirstName
            // 
            this.columnHeaderFirstName.Text = "Имя";
            this.columnHeaderFirstName.Width = 100;
            // 
            // columnHeaderPatronomic
            // 
            this.columnHeaderPatronomic.Text = "Отчество";
            this.columnHeaderPatronomic.Width = 150;
            // 
            // columnHeaderBirthday
            // 
            this.columnHeaderBirthday.DisplayIndex = 4;
            this.columnHeaderBirthday.Text = "Дата рождения";
            this.columnHeaderBirthday.Width = 150;
            // 
            // buttonItems
            // 
            this.buttonItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonItems.AutoSize = true;
            this.buttonItems.Location = new System.Drawing.Point(950, 364);
            this.buttonItems.Name = "buttonItems";
            this.buttonItems.Size = new System.Drawing.Size(116, 37);
            this.buttonItems.TabIndex = 1;
            this.buttonItems.Text = "Загрузить";
            this.buttonItems.UseVisualStyleBackColor = true;
            this.buttonItems.Click += new System.EventHandler(this.buttonItems_Click);
            // 
            // columnHeaderDocument
            // 
            this.columnHeaderDocument.Text = "Документ";
            this.columnHeaderDocument.Width = 150;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 472);
            this.Controls.Add(this.buttonItems);
            this.Controls.Add(this.listViewItem);
            this.Name = "MainForm";
            this.Text = "Моя клиника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewItem;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderSurname;
        private System.Windows.Forms.ColumnHeader columnHeaderFirstName;
        private System.Windows.Forms.ColumnHeader columnHeaderPatronomic;
        private System.Windows.Forms.ColumnHeader columnHeaderBirthday;
        private System.Windows.Forms.Button buttonItems;
        private System.Windows.Forms.ColumnHeader columnHeaderDocument;
    }
}

