namespace Inventura
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
            this.btn1_pogled = new System.Windows.Forms.Button();
            this.btn2_vnos = new System.Windows.Forms.Button();
            this.btn3_urejanje = new System.Windows.Forms.Button();
            this.btn4_izbis = new System.Windows.Forms.Button();
            this.lab_pozdrav = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1_pogled
            // 
            this.btn1_pogled.Location = new System.Drawing.Point(57, 254);
            this.btn1_pogled.Name = "btn1_pogled";
            this.btn1_pogled.Size = new System.Drawing.Size(149, 69);
            this.btn1_pogled.TabIndex = 0;
            this.btn1_pogled.Text = "Pregled izdelkov";
            this.btn1_pogled.UseVisualStyleBackColor = true;
            this.btn1_pogled.Click += new System.EventHandler(this.btn1_pogled_Click);
            // 
            // btn2_vnos
            // 
            this.btn2_vnos.Location = new System.Drawing.Point(248, 254);
            this.btn2_vnos.Name = "btn2_vnos";
            this.btn2_vnos.Size = new System.Drawing.Size(149, 69);
            this.btn2_vnos.TabIndex = 1;
            this.btn2_vnos.Text = "vpisi izdelek";
            this.btn2_vnos.UseVisualStyleBackColor = true;
            this.btn2_vnos.Click += new System.EventHandler(this.btn2_vnos_Click);
            // 
            // btn3_urejanje
            // 
            this.btn3_urejanje.Location = new System.Drawing.Point(431, 254);
            this.btn3_urejanje.Name = "btn3_urejanje";
            this.btn3_urejanje.Size = new System.Drawing.Size(149, 69);
            this.btn3_urejanje.TabIndex = 2;
            this.btn3_urejanje.Text = "uredi izdelek";
            this.btn3_urejanje.UseVisualStyleBackColor = true;
            this.btn3_urejanje.Click += new System.EventHandler(this.btn3_urejanje_Click);
            // 
            // btn4_izbis
            // 
            this.btn4_izbis.Location = new System.Drawing.Point(619, 254);
            this.btn4_izbis.Name = "btn4_izbis";
            this.btn4_izbis.Size = new System.Drawing.Size(149, 69);
            this.btn4_izbis.TabIndex = 3;
            this.btn4_izbis.Text = "izbisi izdelek";
            this.btn4_izbis.UseVisualStyleBackColor = true;
            this.btn4_izbis.Click += new System.EventHandler(this.btn4_izbis_Click);
            // 
            // lab_pozdrav
            // 
            this.lab_pozdrav.AutoSize = true;
            this.lab_pozdrav.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_pozdrav.Location = new System.Drawing.Point(319, 103);
            this.lab_pozdrav.Name = "lab_pozdrav";
            this.lab_pozdrav.Size = new System.Drawing.Size(204, 29);
            this.lab_pozdrav.TabIndex = 4;
            this.lab_pozdrav.Text = "POZDRABLJENI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(838, 558);
            this.Controls.Add(this.lab_pozdrav);
            this.Controls.Add(this.btn4_izbis);
            this.Controls.Add(this.btn3_urejanje);
            this.Controls.Add(this.btn2_vnos);
            this.Controls.Add(this.btn1_pogled);
            this.Name = "Form1";
            this.Text = "predstavna_stan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1_pogled;
        private System.Windows.Forms.Button btn2_vnos;
        private System.Windows.Forms.Button btn3_urejanje;
        private System.Windows.Forms.Button btn4_izbis;
        private System.Windows.Forms.Label lab_pozdrav;
    }
}

