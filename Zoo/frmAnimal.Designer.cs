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
            this.btnContextual = new System.Windows.Forms.Button();
            this.comboExisting = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(121, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecies.Location = new System.Drawing.Point(105, 119);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(66, 18);
            this.lblSpecies.TabIndex = 1;
            this.lblSpecies.Text = "Species";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(177, 78);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(207, 20);
            this.txtBoxName.TabIndex = 2;
            // 
            // comboSpecies
            // 
            this.comboSpecies.FormattingEnabled = true;
            this.comboSpecies.Location = new System.Drawing.Point(177, 116);
            this.comboSpecies.Name = "comboSpecies";
            this.comboSpecies.Size = new System.Drawing.Size(207, 21);
            this.comboSpecies.TabIndex = 3;
            this.comboSpecies.SelectedIndexChanged += new System.EventHandler(this.comboSpecies_SelectedIndexChanged);
            // 
            // lblLegs
            // 
            this.lblLegs.AutoSize = true;
            this.lblLegs.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegs.Location = new System.Drawing.Point(83, 160);
            this.lblLegs.Name = "lblLegs";
            this.lblLegs.Size = new System.Drawing.Size(88, 18);
            this.lblLegs.TabIndex = 4;
            this.lblLegs.Text = "No. of Legs";
            // 
            // txtBoxLegs
            // 
            this.txtBoxLegs.Location = new System.Drawing.Point(177, 158);
            this.txtBoxLegs.Name = "txtBoxLegs";
            this.txtBoxLegs.Size = new System.Drawing.Size(207, 20);
            this.txtBoxLegs.TabIndex = 5;
            // 
            // txtBoxContextual
            // 
            this.txtBoxContextual.Location = new System.Drawing.Point(177, 200);
            this.txtBoxContextual.Name = "txtBoxContextual";
            this.txtBoxContextual.Size = new System.Drawing.Size(207, 20);
            this.txtBoxContextual.TabIndex = 6;
            // 
            // lblContextual
            // 
            this.lblContextual.AutoSize = true;
            this.lblContextual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContextual.Location = new System.Drawing.Point(43, 202);
            this.lblContextual.Name = "lblContextual";
            this.lblContextual.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblContextual.Size = new System.Drawing.Size(0, 18);
            this.lblContextual.TabIndex = 7;
            this.lblContextual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnContextual
            // 
            this.btnContextual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContextual.Location = new System.Drawing.Point(151, 265);
            this.btnContextual.Name = "btnContextual";
            this.btnContextual.Size = new System.Drawing.Size(149, 45);
            this.btnContextual.TabIndex = 8;
            this.btnContextual.Text = "PLACEHOLDER";
            this.btnContextual.UseVisualStyleBackColor = true;
            this.btnContextual.Click += new System.EventHandler(this.btnContextual_Click);
            // 
            // comboExisting
            // 
            this.comboExisting.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboExisting.FormattingEnabled = true;
            this.comboExisting.Location = new System.Drawing.Point(177, 34);
            this.comboExisting.Name = "comboExisting";
            this.comboExisting.Size = new System.Drawing.Size(207, 23);
            this.comboExisting.TabIndex = 9;
            this.comboExisting.Text = "Select Existing Animal";
            // 
            // frmAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 426);
            this.Controls.Add(this.comboExisting);
            this.Controls.Add(this.btnContextual);
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
        private System.Windows.Forms.Button btnContextual;
        private System.Windows.Forms.ComboBox comboExisting;
    }
}