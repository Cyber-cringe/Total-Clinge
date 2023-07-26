namespace Total_Cringe
{
    partial class MainForm
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
            this.WayBox = new System.Windows.Forms.TextBox();
            this.ContentBox = new System.Windows.Forms.ListBox();
            this.Backbutton = new System.Windows.Forms.Button();
            this.DiskBox = new System.Windows.Forms.ComboBox();
            this.Createbutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WayBox
            // 
            this.WayBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WayBox.Location = new System.Drawing.Point(12, 12);
            this.WayBox.Name = "WayBox";
            this.WayBox.Size = new System.Drawing.Size(427, 27);
            this.WayBox.TabIndex = 0;
            // 
            // ContentBox
            // 
            this.ContentBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentBox.FormattingEnabled = true;
            this.ContentBox.ItemHeight = 20;
            this.ContentBox.Location = new System.Drawing.Point(12, 115);
            this.ContentBox.Name = "ContentBox";
            this.ContentBox.Size = new System.Drawing.Size(822, 484);
            this.ContentBox.TabIndex = 1;
            this.ContentBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // Backbutton
            // 
            this.Backbutton.Location = new System.Drawing.Point(12, 63);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(120, 35);
            this.Backbutton.TabIndex = 2;
            this.Backbutton.Text = "Вернуться";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // DiskBox
            // 
            this.DiskBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DiskBox.FormattingEnabled = true;
            this.DiskBox.Location = new System.Drawing.Point(445, 12);
            this.DiskBox.Name = "DiskBox";
            this.DiskBox.Size = new System.Drawing.Size(117, 28);
            this.DiskBox.TabIndex = 6;
            this.DiskBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Createbutton
            // 
            this.Createbutton.Location = new System.Drawing.Point(136, 63);
            this.Createbutton.Name = "Createbutton";
            this.Createbutton.Size = new System.Drawing.Size(120, 35);
            this.Createbutton.TabIndex = 7;
            this.Createbutton.Text = "Создать";
            this.Createbutton.UseVisualStyleBackColor = true;
            this.Createbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.Location = new System.Drawing.Point(262, 63);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(120, 35);
            this.Updatebutton.TabIndex = 8;
            this.Updatebutton.Text = "Обновить";
            this.Updatebutton.UseVisualStyleBackColor = true;
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(388, 63);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(120, 35);
            this.Deletebutton.TabIndex = 9;
            this.Deletebutton.Text = "Удалить";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Total_Cringe.Properties.Resources.Hardrive;
            this.pictureBox1.Location = new System.Drawing.Point(579, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 67);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(650, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 41);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total Cringe";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 623);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.Createbutton);
            this.Controls.Add(this.DiskBox);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.ContentBox);
            this.Controls.Add(this.WayBox);
            this.Name = "MainForm";
            this.Text = "Total Cringe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox WayBox;
        private ListBox ContentBox;
        private Button Backbutton;
        private ComboBox DiskBox;
        private Button Createbutton;
        private Button Updatebutton;
        private Button Deletebutton;
        private PictureBox pictureBox1;
        private Label label1;
    }
}