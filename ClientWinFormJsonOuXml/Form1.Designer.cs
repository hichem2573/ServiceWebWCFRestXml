namespace ClientWinForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtJSON = new System.Windows.Forms.RadioButton();
            this.rbtXML = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.rbtJSON);
            this.groupBox1.Controls.Add(this.rbtXML);
            this.groupBox1.Location = new System.Drawing.Point(3, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 313);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choix d\'echange des données";
            // 
            // rbtJSON
            // 
            this.rbtJSON.AutoSize = true;
            this.rbtJSON.Location = new System.Drawing.Point(149, 39);
            this.rbtJSON.Name = "rbtJSON";
            this.rbtJSON.Size = new System.Drawing.Size(72, 17);
            this.rbtJSON.TabIndex = 1;
            this.rbtJSON.TabStop = true;
            this.rbtJSON.Text = "FluxJSON";
            this.rbtJSON.UseVisualStyleBackColor = true;
            this.rbtJSON.CheckedChanged += new System.EventHandler(this.RadioButton_ChackedChanged);
            // 
            // rbtXML
            // 
            this.rbtXML.AutoSize = true;
            this.rbtXML.Checked = true;
            this.rbtXML.Location = new System.Drawing.Point(9, 39);
            this.rbtXML.Name = "rbtXML";
            this.rbtXML.Size = new System.Drawing.Size(66, 17);
            this.rbtXML.TabIndex = 0;
            this.rbtXML.TabStop = true;
            this.rbtXML.Text = "FluxXML";
            this.rbtXML.UseVisualStyleBackColor = true;
            this.rbtXML.CheckedChanged += new System.EventHandler(this.RadioButton_ChackedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 71);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(497, 214);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 357);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Appel Web Service avec un choix du format d\'echange ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtJSON;
        private System.Windows.Forms.RadioButton rbtXML;
        private System.Windows.Forms.TextBox textBox1;
    }
}

