namespace Assignment_2
{
    partial class DisplayConstituency
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lstCandi = new System.Windows.Forms.ListBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lstCandiDatails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(58, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lstCandi
            // 
            this.lstCandi.FormattingEnabled = true;
            this.lstCandi.Location = new System.Drawing.Point(34, 93);
            this.lstCandi.Name = "lstCandi";
            this.lstCandi.Size = new System.Drawing.Size(179, 108);
            this.lstCandi.TabIndex = 1;
            this.lstCandi.SelectedIndexChanged += new System.EventHandler(this.lstCandi_SelectedIndexChanged);
            // 
            // btnMenu
            // 
            this.btnMenu.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(12, 4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 34);
            this.btnMenu.TabIndex = 7;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lstCandiDatails
            // 
            this.lstCandiDatails.BackColor = System.Drawing.Color.White;
            this.lstCandiDatails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCandiDatails.Location = new System.Drawing.Point(34, 215);
            this.lstCandiDatails.Name = "lstCandiDatails";
            this.lstCandiDatails.Size = new System.Drawing.Size(179, 64);
            this.lstCandiDatails.TabIndex = 8;
            this.lstCandiDatails.Text = "Candidate Details";
            // 
            // DisplayConstituency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 298);
            this.ControlBox = false;
            this.Controls.Add(this.lstCandiDatails);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lstCandi);
            this.Controls.Add(this.comboBox1);
            this.Name = "DisplayConstituency";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display Constituency";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DisplayConstituencyForm_Close);
            this.Load += new System.EventHandler(this.DisplayConstituencyForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox lstCandi;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lstCandiDatails;
    }
}