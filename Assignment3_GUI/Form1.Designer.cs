namespace Assignment3_GUI
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
            this.Scopebbt = new System.Windows.Forms.Button();
            this.Silencerbbt = new System.Windows.Forms.Button();
            this.Caliberbbt = new System.Windows.Forms.Button();
            this.chooseweaponcombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listviewofweapons = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.scopevalue = new System.Windows.Forms.Label();
            this.silencervalue = new System.Windows.Forms.Label();
            this.calibervalue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Scopebbt
            // 
            this.Scopebbt.Location = new System.Drawing.Point(1556, 133);
            this.Scopebbt.Name = "Scopebbt";
            this.Scopebbt.Size = new System.Drawing.Size(189, 65);
            this.Scopebbt.TabIndex = 0;
            this.Scopebbt.Text = "ScopeInc";
            this.Scopebbt.UseVisualStyleBackColor = true;
            this.Scopebbt.Click += new System.EventHandler(this.button1_Click);
            // 
            // Silencerbbt
            // 
            this.Silencerbbt.Location = new System.Drawing.Point(1556, 251);
            this.Silencerbbt.Name = "Silencerbbt";
            this.Silencerbbt.Size = new System.Drawing.Size(189, 65);
            this.Silencerbbt.TabIndex = 1;
            this.Silencerbbt.Text = "SilencerInc";
            this.Silencerbbt.UseVisualStyleBackColor = true;
            // 
            // Caliberbbt
            // 
            this.Caliberbbt.Location = new System.Drawing.Point(1556, 392);
            this.Caliberbbt.Name = "Caliberbbt";
            this.Caliberbbt.Size = new System.Drawing.Size(189, 65);
            this.Caliberbbt.TabIndex = 2;
            this.Caliberbbt.Text = "CaliberInc";
            this.Caliberbbt.UseVisualStyleBackColor = true;
            // 
            // chooseweaponcombobox
            // 
            this.chooseweaponcombobox.FormattingEnabled = true;
            this.chooseweaponcombobox.Location = new System.Drawing.Point(52, 97);
            this.chooseweaponcombobox.Name = "chooseweaponcombobox";
            this.chooseweaponcombobox.Size = new System.Drawing.Size(202, 39);
            this.chooseweaponcombobox.TabIndex = 3;
            this.chooseweaponcombobox.SelectedIndexChanged += new System.EventHandler(this.chooseweaponcombobox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose weapon";
            // 
            // listviewofweapons
            // 
            this.listviewofweapons.Location = new System.Drawing.Point(353, 97);
            this.listviewofweapons.Name = "listviewofweapons";
            this.listviewofweapons.Size = new System.Drawing.Size(881, 665);
            this.listviewofweapons.TabIndex = 5;
            this.listviewofweapons.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Overview of Weapons";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1550, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Modificeres";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 887);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(535, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Your weapon has a Scope with the value:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 973);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(558, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Your weapon has a Silencer with the value:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 1067);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(545, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Your weapon has a Caliber with the value:";
            // 
            // scopevalue
            // 
            this.scopevalue.AutoSize = true;
            this.scopevalue.Location = new System.Drawing.Point(748, 886);
            this.scopevalue.Name = "scopevalue";
            this.scopevalue.Size = new System.Drawing.Size(93, 32);
            this.scopevalue.TabIndex = 11;
            this.scopevalue.Text = "label7";
            // 
            // silencervalue
            // 
            this.silencervalue.AutoSize = true;
            this.silencervalue.Location = new System.Drawing.Point(748, 973);
            this.silencervalue.Name = "silencervalue";
            this.silencervalue.Size = new System.Drawing.Size(93, 32);
            this.silencervalue.TabIndex = 12;
            this.silencervalue.Text = "label8";
            // 
            // calibervalue
            // 
            this.calibervalue.AutoSize = true;
            this.calibervalue.Location = new System.Drawing.Point(748, 1067);
            this.calibervalue.Name = "calibervalue";
            this.calibervalue.Size = new System.Drawing.Size(93, 32);
            this.calibervalue.TabIndex = 13;
            this.calibervalue.Text = "label9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1894, 1185);
            this.Controls.Add(this.calibervalue);
            this.Controls.Add(this.silencervalue);
            this.Controls.Add(this.scopevalue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listviewofweapons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseweaponcombobox);
            this.Controls.Add(this.Caliberbbt);
            this.Controls.Add(this.Silencerbbt);
            this.Controls.Add(this.Scopebbt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Scopebbt;
        private System.Windows.Forms.Button Silencerbbt;
        private System.Windows.Forms.Button Caliberbbt;
        private System.Windows.Forms.ComboBox chooseweaponcombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listviewofweapons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label scopevalue;
        private System.Windows.Forms.Label silencervalue;
        private System.Windows.Forms.Label calibervalue;
    }
}

