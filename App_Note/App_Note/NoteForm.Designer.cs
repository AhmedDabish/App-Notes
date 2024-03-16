namespace App_Note
{
    partial class NoteForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteForm));
            NewBtn = new Button();
            SaveBtn = new Button();
            ReadBtn = new Button();
            DeleteBtn = new Button();
            Message = new Label();
            TitleLabel = new Label();
            TitleEntryBox = new TextBox();
            MessageEntryBox = new TextBox();
            savedNotesTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)savedNotesTable).BeginInit();
            SuspendLayout();
            // 
            // NewBtn
            // 
            NewBtn.BackColor = Color.Indigo;
            NewBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            NewBtn.ForeColor = Color.WhiteSmoke;
            NewBtn.Location = new Point(88, 370);
            NewBtn.Name = "NewBtn";
            NewBtn.Size = new Size(94, 29);
            NewBtn.TabIndex = 1;
            NewBtn.Text = "New";
            NewBtn.UseVisualStyleBackColor = false;
            NewBtn.Click += NewBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.Indigo;
            SaveBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBtn.ForeColor = Color.White;
            SaveBtn.Location = new Point(250, 370);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(94, 29);
            SaveBtn.TabIndex = 2;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // ReadBtn
            // 
            ReadBtn.BackColor = Color.Indigo;
            ReadBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ReadBtn.ForeColor = Color.White;
            ReadBtn.Location = new Point(440, 370);
            ReadBtn.Name = "ReadBtn";
            ReadBtn.Size = new Size(94, 29);
            ReadBtn.TabIndex = 3;
            ReadBtn.Text = "Read";
            ReadBtn.UseVisualStyleBackColor = false;
            ReadBtn.Click += ReadBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Indigo;
            DeleteBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(612, 370);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(94, 29);
            DeleteBtn.TabIndex = 4;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // Message
            // 
            Message.AutoSize = true;
            Message.BackColor = Color.Transparent;
            Message.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Message.ForeColor = SystemColors.ControlLightLight;
            Message.Location = new Point(12, 126);
            Message.Name = "Message";
            Message.Size = new Size(105, 28);
            Message.TabIndex = 5;
            Message.Text = "Message :";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.BackColor = Color.Transparent;
            TitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TitleLabel.ForeColor = Color.Cornsilk;
            TitleLabel.Location = new Point(60, 67);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(66, 28);
            TitleLabel.TabIndex = 6;
            TitleLabel.Text = "Title :";
            TitleLabel.Click += TitleLabel_Click;
            // 
            // TitleEntryBox
            // 
            TitleEntryBox.Location = new Point(137, 67);
            TitleEntryBox.Name = "TitleEntryBox";
            TitleEntryBox.Size = new Size(308, 27);
            TitleEntryBox.TabIndex = 7;
            TitleEntryBox.TextChanged += TitleEntryBox_TextChanged;
            // 
            // MessageEntryBox
            // 
            MessageEntryBox.Location = new Point(137, 130);
            MessageEntryBox.Multiline = true;
            MessageEntryBox.Name = "MessageEntryBox";
            MessageEntryBox.Size = new Size(330, 196);
            MessageEntryBox.TabIndex = 8;
            // 
            // savedNotesTable
            // 
            savedNotesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            savedNotesTable.Location = new Point(473, 67);
            savedNotesTable.Name = "savedNotesTable";
            savedNotesTable.RowHeadersWidth = 51;
            savedNotesTable.RowTemplate.Height = 29;
            savedNotesTable.Size = new Size(289, 259);
            savedNotesTable.TabIndex = 9;
            // 
            // NoteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            BackgroundImage = Properties.Resources._1;
            ClientSize = new Size(800, 450);
            Controls.Add(savedNotesTable);
            Controls.Add(MessageEntryBox);
            Controls.Add(TitleEntryBox);
            Controls.Add(TitleLabel);
            Controls.Add(Message);
            Controls.Add(DeleteBtn);
            Controls.Add(ReadBtn);
            Controls.Add(SaveBtn);
            Controls.Add(NewBtn);
            ForeColor = Color.Brown;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NoteForm";
            Text = "Notes";
            Load += NoteForm_Load;
            ((System.ComponentModel.ISupportInitialize)savedNotesTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NewBtn;
        private Button SaveBtn;
        private Button ReadBtn;
        private Button DeleteBtn;
        private Label Message;
        private Label TitleLabel;
        private TextBox TitleEntryBox;
        private TextBox MessageEntryBox;
        private DataGridView savedNotesTable;
    }
}
