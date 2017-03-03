namespace Assignment_2
{
    partial class DisplayElectedCandidatesForm
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
            this.btnMenu = new System.Windows.Forms.Button();
            this.lstElectCandi = new System.Windows.Forms.ListBox();
            this.lblElectDet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(12, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 34);
            this.btnMenu.TabIndex = 11;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // lstElectCandi
            // 
            this.lstElectCandi.FormattingEnabled = true;
            this.lstElectCandi.Location = new System.Drawing.Point(25, 75);
            this.lstElectCandi.Name = "lstElectCandi";
            this.lstElectCandi.Size = new System.Drawing.Size(195, 121);
            this.lstElectCandi.TabIndex = 9;
            this.lstElectCandi.SelectedIndexChanged += new System.EventHandler(this.lstElectCandi_SelectedIndexChanged);
            // 
            // lblElectDet
            // 
            this.lblElectDet.BackColor = System.Drawing.Color.White;
            this.lblElectDet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblElectDet.Location = new System.Drawing.Point(25, 212);
            this.lblElectDet.Name = "lblElectDet";
            this.lblElectDet.Size = new System.Drawing.Size(195, 71);
            this.lblElectDet.TabIndex = 12;
            this.lblElectDet.Text = "Select Details";
            // 
            // DisplayElectedCandidatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 302);
            this.ControlBox = false;
            this.Controls.Add(this.lblElectDet);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lstElectCandi);
            this.Name = "DisplayElectedCandidatesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display Elected Candidates";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DisplayElectedCandidatesForm_Close);
            this.Load += new System.EventHandler(this.DisplayElectedCandidatesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ListBox lstElectCandi;
        private System.Windows.Forms.Label lblElectDet;
    }
}