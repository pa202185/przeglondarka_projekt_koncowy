namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.tabKarty = new System.Windows.Forms.TabControl();
            this.tabDodaj = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabKarty.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabKarty
            // 
            this.tabKarty.Controls.Add(this.tabDodaj);
            this.tabKarty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabKarty.Location = new System.Drawing.Point(0, 0);
            this.tabKarty.Name = "tabKarty";
            this.tabKarty.SelectedIndex = 0;
            this.tabKarty.Size = new System.Drawing.Size(638, 430);
            this.tabKarty.TabIndex = 0;
            this.tabKarty.Click += new System.EventHandler(this.tabKarty_Click);
            // 
            // tabDodaj
            // 
            this.tabDodaj.Location = new System.Drawing.Point(4, 22);
            this.tabDodaj.Name = "tabDodaj";
            this.tabDodaj.Padding = new System.Windows.Forms.Padding(3);
            this.tabDodaj.Size = new System.Drawing.Size(630, 404);
            this.tabDodaj.TabIndex = 0;
            this.tabDodaj.Text = "Dodaj nową kartę";
            this.tabDodaj.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabKarty);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 430);
            this.panel2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 430);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Przeglądarka";
            this.tabKarty.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabKarty;
        private System.Windows.Forms.TabPage tabDodaj;
        private System.Windows.Forms.Panel panel2;
    }
}

