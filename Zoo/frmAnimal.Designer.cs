namespace Zoo
{
    partial class frmAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnimal));
            this.lblName = new System.Windows.Forms.Label();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.comboSpecies = new System.Windows.Forms.ComboBox();
            this.lblLegs = new System.Windows.Forms.Label();
            this.txtBoxLegs = new System.Windows.Forms.TextBox();
            this.txtBoxContextual = new System.Windows.Forms.TextBox();
            this.lblContextual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(66, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecies.Location = new System.Drawing.Point(50, 63);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(66, 18);
            this.lblSpecies.TabIndex = 1;
            this.lblSpecies.Text = "Species";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(122, 22);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(207, 20);
            this.txtBoxName.TabIndex = 2;
            // 
            // comboSpecies
            // 
            this.comboSpecies.FormattingEnabled = true;
            this.comboSpecies.Location = new System.Drawing.Point(122, 60);
            this.comboSpecies.Name = "comboSpecies";
            this.comboSpecies.Size = new System.Drawing.Size(207, 21);
            this.comboSpecies.TabIndex = 3;
            // 
            // lblLegs
            // 
            this.lblLegs.AutoSize = true;
            this.lblLegs.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegs.Location = new System.Drawing.Point(28, 104);
            this.lblLegs.Name = "lblLegs";
            this.lblLegs.Size = new System.Drawing.Size(88, 18);
            this.lblLegs.TabIndex = 4;
            this.lblLegs.Text = "No. of Legs";
            // 
            // txtBoxLegs
            // 
            this.txtBoxLegs.Location = new System.Drawing.Point(122, 102);
            this.txtBoxLegs.Name = "txtBoxLegs";
            this.txtBoxLegs.Size = new System.Drawing.Size(207, 20);
            this.txtBoxLegs.TabIndex = 5;
            // 
            // txtBoxContextual
            // 
            this.txtBoxContextual.Location = new System.Drawing.Point(122, 144);
            this.txtBoxContextual.Name = "txtBoxContextual";
            this.txtBoxContextual.Size = new System.Drawing.Size(207, 20);
            this.txtBoxContextual.TabIndex = 6;
            // 
            // lblContextual
            // 
            this.lblContextual.AutoSize = true;
            this.lblContextual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContextual.Location = new System.Drawing.Point(-12, 146);
            this.lblContextual.Name = "lblContextual";
            this.lblContextual.Size = new System.Drawing.Size(128, 18);
            this.lblContextual.TabIndex = 7;
            this.lblContextual.Text = "PLACEHOLDER";
            this.lblContextual.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 508);
            this.Controls.Add(this.lblContextual);
            this.Controls.Add(this.txtBoxContextual);
            this.Controls.Add(this.txtBoxLegs);
            this.Controls.Add(this.lblLegs);
            this.Controls.Add(this.comboSpecies);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblSpecies);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAnimal";
            this.Text = "Animal Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.ComboBox comboSpecies;
        private System.Windows.Forms.Label lblLegs;
        private System.Windows.Forms.TextBox txtBoxLegs;
        private System.Windows.Forms.TextBox txtBoxContextual;
        private System.Windows.Forms.Label lblContextual;
    }
}