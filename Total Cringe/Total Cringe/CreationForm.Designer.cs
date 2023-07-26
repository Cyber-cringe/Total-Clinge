namespace Total_Cringe
{
    partial class CreationForm
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.OKbutton = new System.Windows.Forms.Button();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(22, 61);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(232, 27);
            this.NameBox.TabIndex = 0;
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(101, 103);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(153, 67);
            this.OKbutton.TabIndex = 1;
            this.OKbutton.Text = "ОК";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.batton1_Click_1);
            // 
            // TypeBox
            // 
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Location = new System.Drawing.Point(260, 60);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(80, 28);
            this.TypeBox.TabIndex = 2;
            // 
            // CreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 233);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.NameBox);
            this.Name = "CreationForm";
            this.Text = "Создание элемента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox NameBox;
        private Button OKbutton;
        private ComboBox TypeBox;
    }
}