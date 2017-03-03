namespace Assignment_2
{
    partial class MainMenu
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
            this.btnConfigData = new System.Windows.Forms.Button();
            this.btnLoadConstituencyData = new System.Windows.Forms.Button();
            this.btnAllParty = new System.Windows.Forms.Button();
            this.btnDisplayElectedCandi = new System.Windows.Forms.Button();
            this.btnWinner = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConfigData
            // 
            this.btnConfigData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigData.Location = new System.Drawing.Point(76, 21);
            this.btnConfigData.Name = "btnConfigData";
            this.btnConfigData.Size = new System.Drawing.Size(244, 65);
            this.btnConfigData.TabIndex = 3;
            this.btnConfigData.Text = "Create Config Data";
            this.btnConfigData.UseVisualStyleBackColor = true;
            this.btnConfigData.Click += new System.EventHandler(this.btnConfigData_Click);
            // 
            // btnLoadConstituencyData
            // 
            this.btnLoadConstituencyData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadConstituencyData.Location = new System.Drawing.Point(76, 101);
            this.btnLoadConstituencyData.Name = "btnLoadConstituencyData";
            this.btnLoadConstituencyData.Size = new System.Drawing.Size(244, 65);
            this.btnLoadConstituencyData.TabIndex = 6;
            this.btnLoadConstituencyData.Text = "Load Constituency Data";
            this.btnLoadConstituencyData.UseVisualStyleBackColor = true;
            this.btnLoadConstituencyData.Click += new System.EventHandler(this.btnLoadConstituencyData_Click);
            // 
            // btnAllParty
            // 
            this.btnAllParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllParty.Location = new System.Drawing.Point(76, 265);
            this.btnAllParty.Name = "btnAllParty";
            this.btnAllParty.Size = new System.Drawing.Size(244, 65);
            this.btnAllParty.TabIndex = 7;
            this.btnAllParty.Text = "Display All Parties";
            this.btnAllParty.UseVisualStyleBackColor = true;
            this.btnAllParty.Click += new System.EventHandler(this.btnAllParty_Click);
            // 
            // btnDisplayElectedCandi
            // 
            this.btnDisplayElectedCandi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayElectedCandi.Location = new System.Drawing.Point(76, 182);
            this.btnDisplayElectedCandi.Name = "btnDisplayElectedCandi";
            this.btnDisplayElectedCandi.Size = new System.Drawing.Size(244, 65);
            this.btnDisplayElectedCandi.TabIndex = 8;
            this.btnDisplayElectedCandi.Text = "Display All Elected Candidates";
            this.btnDisplayElectedCandi.UseVisualStyleBackColor = true;
            this.btnDisplayElectedCandi.Click += new System.EventHandler(this.btnDisplayElectedCandi_Click);
            // 
            // btnWinner
            // 
            this.btnWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWinner.Location = new System.Drawing.Point(76, 345);
            this.btnWinner.Name = "btnWinner";
            this.btnWinner.Size = new System.Drawing.Size(244, 65);
            this.btnWinner.TabIndex = 9;
            this.btnWinner.Text = "Display The Winner";
            this.btnWinner.UseVisualStyleBackColor = true;
            this.btnWinner.Click += new System.EventHandler(this.btnWinner_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(76, 426);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(244, 65);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit Application";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 518);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnWinner);
            this.Controls.Add(this.btnDisplayElectedCandi);
            this.Controls.Add(this.btnAllParty);
            this.Controls.Add(this.btnLoadConstituencyData);
            this.Controls.Add(this.btnConfigData);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfigData;
        private System.Windows.Forms.Button btnLoadConstituencyData;
        private System.Windows.Forms.Button btnAllParty;
        private System.Windows.Forms.Button btnDisplayElectedCandi;
        private System.Windows.Forms.Button btnWinner;
        private System.Windows.Forms.Button btnExit;
    }
}