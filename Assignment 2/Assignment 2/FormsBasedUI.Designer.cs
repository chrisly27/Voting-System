namespace Assignment_2
{
    partial class FormsBasedUI
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
            this.lbxShowConstituencyNames = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnconfig = new System.Windows.Forms.Button();
            this.lblFinalResult = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.btnLoadConstituencyData = new System.Windows.Forms.Button();
            this.btnShowAllConstituencyNameOnly = new System.Windows.Forms.Button();
            this.lblReport = new System.Windows.Forms.Label();
            this.lbxShowAllCandidateDetails = new System.Windows.Forms.ListBox();
            this.lbxShowHighestElectedCandidate = new System.Windows.Forms.ListBox();
            this.btnShowAllCandidateDetails = new System.Windows.Forms.Button();
            this.btnShowHighestElectedCandidate = new System.Windows.Forms.Button();
            this.lbxShowPartyNames = new System.Windows.Forms.ListBox();
            this.btnShowAllPartyNames = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxShowConstituencyNames
            // 
            this.lbxShowConstituencyNames.FormattingEnabled = true;
            this.lbxShowConstituencyNames.Location = new System.Drawing.Point(277, 186);
            this.lbxShowConstituencyNames.Name = "lbxShowConstituencyNames";
            this.lbxShowConstituencyNames.Size = new System.Drawing.Size(123, 82);
            this.lbxShowConstituencyNames.TabIndex = 0;
            this.lbxShowConstituencyNames.SelectedIndexChanged += new System.EventHandler(this.lbxDisplayResult_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(264, 12);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(147, 24);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Current Status:";
            // 
            // btnconfig
            // 
            this.btnconfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfig.Location = new System.Drawing.Point(12, 12);
            this.btnconfig.Name = "btnconfig";
            this.btnconfig.Size = new System.Drawing.Size(244, 65);
            this.btnconfig.TabIndex = 2;
            this.btnconfig.Text = "Create Config Data";
            this.btnconfig.UseVisualStyleBackColor = true;
            this.btnconfig.Click += new System.EventHandler(this.btnconfig_Click);
            // 
            // lblFinalResult
            // 
            this.lblFinalResult.AutoSize = true;
            this.lblFinalResult.BackColor = System.Drawing.Color.White;
            this.lblFinalResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalResult.Location = new System.Drawing.Point(278, 109);
            this.lblFinalResult.Name = "lblFinalResult";
            this.lblFinalResult.Size = new System.Drawing.Size(214, 37);
            this.lblFinalResult.TabIndex = 3;
            this.lblFinalResult.Text = "Final Results";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.Location = new System.Drawing.Point(417, 12);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(220, 24);
            this.lblProgress.TabIndex = 4;
            this.lblProgress.Text = "Awaiting Data Creation";
            // 
            // btnLoadConstituencyData
            // 
            this.btnLoadConstituencyData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadConstituencyData.Location = new System.Drawing.Point(12, 83);
            this.btnLoadConstituencyData.Name = "btnLoadConstituencyData";
            this.btnLoadConstituencyData.Size = new System.Drawing.Size(244, 65);
            this.btnLoadConstituencyData.TabIndex = 5;
            this.btnLoadConstituencyData.Text = "Load Constituency Data";
            this.btnLoadConstituencyData.UseVisualStyleBackColor = true;
            this.btnLoadConstituencyData.Click += new System.EventHandler(this.btnRunProducerConsumer_Click);
            // 
            // btnShowAllConstituencyNameOnly
            // 
            this.btnShowAllConstituencyNameOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllConstituencyNameOnly.Location = new System.Drawing.Point(12, 204);
            this.btnShowAllConstituencyNameOnly.Name = "btnShowAllConstituencyNameOnly";
            this.btnShowAllConstituencyNameOnly.Size = new System.Drawing.Size(244, 65);
            this.btnShowAllConstituencyNameOnly.TabIndex = 6;
            this.btnShowAllConstituencyNameOnly.Text = "Show All Constituency Name Only";
            this.btnShowAllConstituencyNameOnly.UseVisualStyleBackColor = true;
            this.btnShowAllConstituencyNameOnly.Click += new System.EventHandler(this.btnFinalResult_Click);
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Location = new System.Drawing.Point(490, 493);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(0, 13);
            this.lblReport.TabIndex = 8;
            this.lblReport.Visible = false;
            // 
            // lbxShowAllCandidateDetails
            // 
            this.lbxShowAllCandidateDetails.FormattingEnabled = true;
            this.lbxShowAllCandidateDetails.Location = new System.Drawing.Point(277, 424);
            this.lbxShowAllCandidateDetails.Name = "lbxShowAllCandidateDetails";
            this.lbxShowAllCandidateDetails.Size = new System.Drawing.Size(580, 342);
            this.lbxShowAllCandidateDetails.TabIndex = 12;
            // 
            // lbxShowHighestElectedCandidate
            // 
            this.lbxShowHighestElectedCandidate.FormattingEnabled = true;
            this.lbxShowHighestElectedCandidate.Location = new System.Drawing.Point(426, 185);
            this.lbxShowHighestElectedCandidate.Name = "lbxShowHighestElectedCandidate";
            this.lbxShowHighestElectedCandidate.Size = new System.Drawing.Size(431, 199);
            this.lbxShowHighestElectedCandidate.TabIndex = 13;
            // 
            // btnShowAllCandidateDetails
            // 
            this.btnShowAllCandidateDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllCandidateDetails.Location = new System.Drawing.Point(12, 397);
            this.btnShowAllCandidateDetails.Name = "btnShowAllCandidateDetails";
            this.btnShowAllCandidateDetails.Size = new System.Drawing.Size(244, 64);
            this.btnShowAllCandidateDetails.TabIndex = 14;
            this.btnShowAllCandidateDetails.Text = "Show All The Candidate Details";
            this.btnShowAllCandidateDetails.UseVisualStyleBackColor = true;
            this.btnShowAllCandidateDetails.Click += new System.EventHandler(this.btnShowAllTheCandidateDetails_Click);
            // 
            // btnShowHighestElectedCandidate
            // 
            this.btnShowHighestElectedCandidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowHighestElectedCandidate.Location = new System.Drawing.Point(12, 493);
            this.btnShowHighestElectedCandidate.Name = "btnShowHighestElectedCandidate";
            this.btnShowHighestElectedCandidate.Size = new System.Drawing.Size(244, 64);
            this.btnShowHighestElectedCandidate.TabIndex = 15;
            this.btnShowHighestElectedCandidate.Text = "Show The Highest Elected Candidate";
            this.btnShowHighestElectedCandidate.UseVisualStyleBackColor = true;
            this.btnShowHighestElectedCandidate.Click += new System.EventHandler(this.btnShowHighestElectedCandidate_Click);
            // 
            // lbxShowPartyNames
            // 
            this.lbxShowPartyNames.FormattingEnabled = true;
            this.lbxShowPartyNames.Location = new System.Drawing.Point(277, 302);
            this.lbxShowPartyNames.Name = "lbxShowPartyNames";
            this.lbxShowPartyNames.Size = new System.Drawing.Size(123, 82);
            this.lbxShowPartyNames.TabIndex = 16;
            // 
            // btnShowAllPartyNames
            // 
            this.btnShowAllPartyNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllPartyNames.Location = new System.Drawing.Point(12, 302);
            this.btnShowAllPartyNames.Name = "btnShowAllPartyNames";
            this.btnShowAllPartyNames.Size = new System.Drawing.Size(244, 64);
            this.btnShowAllPartyNames.TabIndex = 17;
            this.btnShowAllPartyNames.Text = "Show All Party Names";
            this.btnShowAllPartyNames.UseVisualStyleBackColor = true;
            this.btnShowAllPartyNames.Click += new System.EventHandler(this.btnShowAllPartyNames_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(268, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 678);
            this.label1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Constituencies";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "All Candidate Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Party Names";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(422, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "The Elected Candidates";
            // 
            // FormsBasedUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 785);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShowAllPartyNames);
            this.Controls.Add(this.lbxShowPartyNames);
            this.Controls.Add(this.btnShowHighestElectedCandidate);
            this.Controls.Add(this.btnShowAllCandidateDetails);
            this.Controls.Add(this.lbxShowHighestElectedCandidate);
            this.Controls.Add(this.lbxShowAllCandidateDetails);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.btnShowAllConstituencyNameOnly);
            this.Controls.Add(this.btnLoadConstituencyData);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.lblFinalResult);
            this.Controls.Add(this.btnconfig);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lbxShowConstituencyNames);
            this.Controls.Add(this.label1);
            this.Name = "FormsBasedUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormsBasedUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxShowConstituencyNames;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnconfig;
        private System.Windows.Forms.Label lblFinalResult;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button btnLoadConstituencyData;
        private System.Windows.Forms.Button btnShowAllConstituencyNameOnly;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.ListBox lbxShowAllCandidateDetails;
        private System.Windows.Forms.ListBox lbxShowHighestElectedCandidate;
        private System.Windows.Forms.Button btnShowAllCandidateDetails;
        private System.Windows.Forms.Button btnShowHighestElectedCandidate;
        private System.Windows.Forms.ListBox lbxShowPartyNames;
        private System.Windows.Forms.Button btnShowAllPartyNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

