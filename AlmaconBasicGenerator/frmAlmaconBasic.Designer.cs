namespace AlmaconBasicGenerator
{
    partial class frmAlmaconBasic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlmaconBasic));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabColdStuff = new System.Windows.Forms.TabPage();
            this.cmbBeamProfile = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJoistDistance = new System.Windows.Forms.TextBox();
            this.txtXSpan = new System.Windows.Forms.TextBox();
            this.txtYSpan = new System.Windows.Forms.TextBox();
            this.txtFlooring = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtJoistQnt = new System.Windows.Forms.TextBox();
            this.txtBeamQnt = new System.Windows.Forms.TextBox();
            this.grpBoxDirection = new System.Windows.Forms.GroupBox();
            this.rdbYdirection = new System.Windows.Forms.RadioButton();
            this.rdbXdirection = new System.Windows.Forms.RadioButton();
            this.lblJoistDistanceCS = new System.Windows.Forms.Label();
            this.cmbJoistProfile = new System.Windows.Forms.ComboBox();
            this.lblCprofCS = new System.Windows.Forms.Label();
            this.lblJoistTextCS = new System.Windows.Forms.Label();
            this.lblXmaxCS = new System.Windows.Forms.Label();
            this.lblYmaxCS = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblFlooringCS = new System.Windows.Forms.Label();
            this.lblHeightCS = new System.Windows.Forms.Label();
            this.lblSpansYCS = new System.Windows.Forms.Label();
            this.lblSpansXCS = new System.Windows.Forms.Label();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.btnOrigin = new System.Windows.Forms.Button();
            this.txtZcoordinate = new System.Windows.Forms.TextBox();
            this.txtYcoordinate = new System.Windows.Forms.TextBox();
            this.txtXcoordinate = new System.Windows.Forms.TextBox();
            this.lblZcoordinate = new System.Windows.Forms.Label();
            this.lblYcoordinate = new System.Windows.Forms.Label();
            this.lblXcoordinate = new System.Windows.Forms.Label();
            this.tabSystemSelection = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabColdStuff.SuspendLayout();
            this.grpBoxDirection.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabSystemSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 372);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // tabColdStuff
            // 
            this.tabColdStuff.BackColor = System.Drawing.SystemColors.Control;
            this.tabColdStuff.Controls.Add(this.cmbBeamProfile);
            this.tabColdStuff.Controls.Add(this.label2);
            this.tabColdStuff.Controls.Add(this.label3);
            this.tabColdStuff.Controls.Add(this.txtJoistDistance);
            this.tabColdStuff.Controls.Add(this.txtXSpan);
            this.tabColdStuff.Controls.Add(this.txtYSpan);
            this.tabColdStuff.Controls.Add(this.txtFlooring);
            this.tabColdStuff.Controls.Add(this.txtHeight);
            this.tabColdStuff.Controls.Add(this.txtJoistQnt);
            this.tabColdStuff.Controls.Add(this.txtBeamQnt);
            this.tabColdStuff.Controls.Add(this.grpBoxDirection);
            this.tabColdStuff.Controls.Add(this.lblJoistDistanceCS);
            this.tabColdStuff.Controls.Add(this.cmbJoistProfile);
            this.tabColdStuff.Controls.Add(this.lblCprofCS);
            this.tabColdStuff.Controls.Add(this.lblJoistTextCS);
            this.tabColdStuff.Controls.Add(this.lblXmaxCS);
            this.tabColdStuff.Controls.Add(this.lblYmaxCS);
            this.tabColdStuff.Controls.Add(this.btnStart);
            this.tabColdStuff.Controls.Add(this.lblFlooringCS);
            this.tabColdStuff.Controls.Add(this.lblHeightCS);
            this.tabColdStuff.Controls.Add(this.lblSpansYCS);
            this.tabColdStuff.Controls.Add(this.lblSpansXCS);
            this.tabColdStuff.Location = new System.Drawing.Point(4, 25);
            this.tabColdStuff.Name = "tabColdStuff";
            this.tabColdStuff.Padding = new System.Windows.Forms.Padding(3);
            this.tabColdStuff.Size = new System.Drawing.Size(381, 329);
            this.tabColdStuff.TabIndex = 1;
            this.tabColdStuff.Text = "Cold Stuff";
            // 
            // cmbBeamProfile
            // 
            this.cmbBeamProfile.FormattingEnabled = true;
            this.cmbBeamProfile.Items.AddRange(new object[] {
            "SADEF-C+350X3.00"});
            this.cmbBeamProfile.Location = new System.Drawing.Point(12, 197);
            this.cmbBeamProfile.Name = "cmbBeamProfile";
            this.cmbBeamProfile.Size = new System.Drawing.Size(159, 21);
            this.cmbBeamProfile.TabIndex = 129;
            this.cmbBeamProfile.Text = "SADEF-C+350X3.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 128;
            this.label2.Text = "C-profile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(10, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 127;
            this.label3.Text = "Beam info";
            // 
            // txtJoistDistance
            // 
            this.txtJoistDistance.Location = new System.Drawing.Point(175, 264);
            this.txtJoistDistance.Name = "txtJoistDistance";
            this.txtJoistDistance.Size = new System.Drawing.Size(100, 20);
            this.txtJoistDistance.TabIndex = 122;
            this.txtJoistDistance.Text = "875";
            // 
            // txtXSpan
            // 
            this.txtXSpan.Location = new System.Drawing.Point(8, 24);
            this.txtXSpan.Name = "txtXSpan";
            this.txtXSpan.Size = new System.Drawing.Size(100, 20);
            this.txtXSpan.TabIndex = 90;
            this.txtXSpan.Text = "5000";
            // 
            // txtYSpan
            // 
            this.txtYSpan.Location = new System.Drawing.Point(8, 63);
            this.txtYSpan.Name = "txtYSpan";
            this.txtYSpan.Size = new System.Drawing.Size(100, 20);
            this.txtYSpan.TabIndex = 91;
            this.txtYSpan.Text = "5000";
            // 
            // txtFlooring
            // 
            this.txtFlooring.Location = new System.Drawing.Point(222, 24);
            this.txtFlooring.Name = "txtFlooring";
            this.txtFlooring.ReadOnly = true;
            this.txtFlooring.Size = new System.Drawing.Size(100, 20);
            this.txtFlooring.TabIndex = 95;
            this.txtFlooring.Text = "38";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(222, 63);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(156, 20);
            this.txtHeight.TabIndex = 96;
            this.txtHeight.Text = "3500";
            // 
            // txtJoistQnt
            // 
            this.txtJoistQnt.Location = new System.Drawing.Point(116, 63);
            this.txtJoistQnt.Name = "txtJoistQnt";
            this.txtJoistQnt.Size = new System.Drawing.Size(100, 20);
            this.txtJoistQnt.TabIndex = 103;
            this.txtJoistQnt.Text = "3";
            // 
            // txtBeamQnt
            // 
            this.txtBeamQnt.Location = new System.Drawing.Point(116, 24);
            this.txtBeamQnt.Name = "txtBeamQnt";
            this.txtBeamQnt.Size = new System.Drawing.Size(100, 20);
            this.txtBeamQnt.TabIndex = 102;
            this.txtBeamQnt.Text = "3";
            // 
            // grpBoxDirection
            // 
            this.grpBoxDirection.Controls.Add(this.rdbYdirection);
            this.grpBoxDirection.Controls.Add(this.rdbXdirection);
            this.grpBoxDirection.Location = new System.Drawing.Point(6, 89);
            this.grpBoxDirection.Name = "grpBoxDirection";
            this.grpBoxDirection.Size = new System.Drawing.Size(129, 60);
            this.grpBoxDirection.TabIndex = 126;
            this.grpBoxDirection.TabStop = false;
            // 
            // rdbYdirection
            // 
            this.rdbYdirection.AutoSize = true;
            this.rdbYdirection.Location = new System.Drawing.Point(4, 33);
            this.rdbYdirection.Name = "rdbYdirection";
            this.rdbYdirection.Size = new System.Drawing.Size(116, 17);
            this.rdbYdirection.TabIndex = 109;
            this.rdbYdirection.Text = "Beam in Y direction";
            this.rdbYdirection.UseVisualStyleBackColor = true;
            // 
            // rdbXdirection
            // 
            this.rdbXdirection.AutoSize = true;
            this.rdbXdirection.Checked = true;
            this.rdbXdirection.Location = new System.Drawing.Point(4, 10);
            this.rdbXdirection.Name = "rdbXdirection";
            this.rdbXdirection.Size = new System.Drawing.Size(116, 17);
            this.rdbXdirection.TabIndex = 108;
            this.rdbXdirection.TabStop = true;
            this.rdbXdirection.Text = "Beam in X direction";
            this.rdbXdirection.UseVisualStyleBackColor = true;
            // 
            // lblJoistDistanceCS
            // 
            this.lblJoistDistanceCS.AutoSize = true;
            this.lblJoistDistanceCS.Location = new System.Drawing.Point(172, 247);
            this.lblJoistDistanceCS.Name = "lblJoistDistanceCS";
            this.lblJoistDistanceCS.Size = new System.Drawing.Size(71, 13);
            this.lblJoistDistanceCS.TabIndex = 121;
            this.lblJoistDistanceCS.Text = "Joist distance";
            // 
            // cmbJoistProfile
            // 
            this.cmbJoistProfile.FormattingEnabled = true;
            this.cmbJoistProfile.Items.AddRange(new object[] {
            "SADEF-C265X1.75"});
            this.cmbJoistProfile.Location = new System.Drawing.Point(10, 263);
            this.cmbJoistProfile.Name = "cmbJoistProfile";
            this.cmbJoistProfile.Size = new System.Drawing.Size(159, 21);
            this.cmbJoistProfile.TabIndex = 120;
            this.cmbJoistProfile.Text = "SADEF-C265X1.75";
            this.cmbJoistProfile.SelectedIndexChanged += new System.EventHandler(this.cmbJoistProfileCS_SelectedIndexChanged);
            // 
            // lblCprofCS
            // 
            this.lblCprofCS.AutoSize = true;
            this.lblCprofCS.Location = new System.Drawing.Point(9, 247);
            this.lblCprofCS.Name = "lblCprofCS";
            this.lblCprofCS.Size = new System.Drawing.Size(45, 13);
            this.lblCprofCS.TabIndex = 119;
            this.lblCprofCS.Text = "C-profile";
            // 
            // lblJoistTextCS
            // 
            this.lblJoistTextCS.AutoSize = true;
            this.lblJoistTextCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblJoistTextCS.Location = new System.Drawing.Point(8, 222);
            this.lblJoistTextCS.Name = "lblJoistTextCS";
            this.lblJoistTextCS.Size = new System.Drawing.Size(72, 20);
            this.lblJoistTextCS.TabIndex = 118;
            this.lblJoistTextCS.Text = "Joist info";
            // 
            // lblXmaxCS
            // 
            this.lblXmaxCS.AutoSize = true;
            this.lblXmaxCS.Location = new System.Drawing.Point(14, 8);
            this.lblXmaxCS.Name = "lblXmaxCS";
            this.lblXmaxCS.Size = new System.Drawing.Size(42, 13);
            this.lblXmaxCS.TabIndex = 92;
            this.lblXmaxCS.Text = "Span X";
            // 
            // lblYmaxCS
            // 
            this.lblYmaxCS.AutoSize = true;
            this.lblYmaxCS.Location = new System.Drawing.Point(14, 47);
            this.lblYmaxCS.Name = "lblYmaxCS";
            this.lblYmaxCS.Size = new System.Drawing.Size(42, 13);
            this.lblYmaxCS.TabIndex = 93;
            this.lblYmaxCS.Text = "Span Y";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(271, 294);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 94;
            this.btnStart.Text = "Draw";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblFlooringCS
            // 
            this.lblFlooringCS.AutoSize = true;
            this.lblFlooringCS.Location = new System.Drawing.Point(229, 8);
            this.lblFlooringCS.Name = "lblFlooringCS";
            this.lblFlooringCS.Size = new System.Drawing.Size(93, 13);
            this.lblFlooringCS.TabIndex = 97;
            this.lblFlooringCS.Text = "Thickness flooring";
            // 
            // lblHeightCS
            // 
            this.lblHeightCS.AutoSize = true;
            this.lblHeightCS.Location = new System.Drawing.Point(237, 47);
            this.lblHeightCS.Name = "lblHeightCS";
            this.lblHeightCS.Size = new System.Drawing.Size(61, 13);
            this.lblHeightCS.TabIndex = 98;
            this.lblHeightCS.Text = "Height floor";
            // 
            // lblSpansYCS
            // 
            this.lblSpansYCS.AutoSize = true;
            this.lblSpansYCS.Location = new System.Drawing.Point(122, 47);
            this.lblSpansYCS.Name = "lblSpansYCS";
            this.lblSpansYCS.Size = new System.Drawing.Size(65, 13);
            this.lblSpansYCS.TabIndex = 105;
            this.lblSpansYCS.Text = "No. spans Y";
            // 
            // lblSpansXCS
            // 
            this.lblSpansXCS.AutoSize = true;
            this.lblSpansXCS.Location = new System.Drawing.Point(122, 8);
            this.lblSpansXCS.Name = "lblSpansXCS";
            this.lblSpansXCS.Size = new System.Drawing.Size(65, 13);
            this.lblSpansXCS.TabIndex = 104;
            this.lblSpansXCS.Text = "No. spans X";
            // 
            // tabGeneral
            // 
            this.tabGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.tabGeneral.Controls.Add(this.btnOrigin);
            this.tabGeneral.Controls.Add(this.txtZcoordinate);
            this.tabGeneral.Controls.Add(this.txtYcoordinate);
            this.tabGeneral.Controls.Add(this.txtXcoordinate);
            this.tabGeneral.Controls.Add(this.lblZcoordinate);
            this.tabGeneral.Controls.Add(this.lblYcoordinate);
            this.tabGeneral.Controls.Add(this.lblXcoordinate);
            this.tabGeneral.Location = new System.Drawing.Point(4, 25);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(381, 329);
            this.tabGeneral.TabIndex = 2;
            this.tabGeneral.Text = "General";
            // 
            // btnOrigin
            // 
            this.btnOrigin.AutoSize = true;
            this.btnOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOrigin.Location = new System.Drawing.Point(29, 178);
            this.btnOrigin.Name = "btnOrigin";
            this.btnOrigin.Size = new System.Drawing.Size(158, 35);
            this.btnOrigin.TabIndex = 6;
            this.btnOrigin.Text = "Pick origin point";
            this.btnOrigin.UseVisualStyleBackColor = true;
            this.btnOrigin.Click += new System.EventHandler(this.btnOrigin_Click);
            // 
            // txtZcoordinate
            // 
            this.txtZcoordinate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtZcoordinate.Location = new System.Drawing.Point(67, 131);
            this.txtZcoordinate.Name = "txtZcoordinate";
            this.txtZcoordinate.Size = new System.Drawing.Size(108, 26);
            this.txtZcoordinate.TabIndex = 5;
            this.txtZcoordinate.Text = "0";
            // 
            // txtYcoordinate
            // 
            this.txtYcoordinate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtYcoordinate.Location = new System.Drawing.Point(67, 82);
            this.txtYcoordinate.Name = "txtYcoordinate";
            this.txtYcoordinate.Size = new System.Drawing.Size(108, 26);
            this.txtYcoordinate.TabIndex = 4;
            this.txtYcoordinate.Text = "0";
            // 
            // txtXcoordinate
            // 
            this.txtXcoordinate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtXcoordinate.Location = new System.Drawing.Point(67, 39);
            this.txtXcoordinate.Name = "txtXcoordinate";
            this.txtXcoordinate.Size = new System.Drawing.Size(108, 26);
            this.txtXcoordinate.TabIndex = 3;
            this.txtXcoordinate.Text = "0";
            // 
            // lblZcoordinate
            // 
            this.lblZcoordinate.AutoSize = true;
            this.lblZcoordinate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblZcoordinate.Location = new System.Drawing.Point(25, 134);
            this.lblZcoordinate.Name = "lblZcoordinate";
            this.lblZcoordinate.Size = new System.Drawing.Size(35, 20);
            this.lblZcoordinate.TabIndex = 2;
            this.lblZcoordinate.Text = "Z :  ";
            // 
            // lblYcoordinate
            // 
            this.lblYcoordinate.AutoSize = true;
            this.lblYcoordinate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblYcoordinate.Location = new System.Drawing.Point(25, 85);
            this.lblYcoordinate.Name = "lblYcoordinate";
            this.lblYcoordinate.Size = new System.Drawing.Size(32, 20);
            this.lblYcoordinate.TabIndex = 1;
            this.lblYcoordinate.Text = "Y : ";
            // 
            // lblXcoordinate
            // 
            this.lblXcoordinate.AutoSize = true;
            this.lblXcoordinate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblXcoordinate.Location = new System.Drawing.Point(25, 42);
            this.lblXcoordinate.Name = "lblXcoordinate";
            this.lblXcoordinate.Size = new System.Drawing.Size(36, 20);
            this.lblXcoordinate.TabIndex = 0;
            this.lblXcoordinate.Text = "X :  ";
            // 
            // tabSystemSelection
            // 
            this.tabSystemSelection.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabSystemSelection.Controls.Add(this.tabGeneral);
            this.tabSystemSelection.Controls.Add(this.tabColdStuff);
            this.tabSystemSelection.Location = new System.Drawing.Point(12, 12);
            this.tabSystemSelection.Name = "tabSystemSelection";
            this.tabSystemSelection.SelectedIndex = 0;
            this.tabSystemSelection.Size = new System.Drawing.Size(389, 358);
            this.tabSystemSelection.TabIndex = 44;
            // 
            // frmAlmaconBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 529);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabSystemSelection);
            this.Name = "frmAlmaconBasic";
            this.Text = "Hot Stuff";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabColdStuff.ResumeLayout(false);
            this.tabColdStuff.PerformLayout();
            this.grpBoxDirection.ResumeLayout(false);
            this.grpBoxDirection.PerformLayout();
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.tabSystemSelection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabColdStuff;
        private System.Windows.Forms.TextBox txtJoistDistance;
        private System.Windows.Forms.TextBox txtXSpan;
        private System.Windows.Forms.TextBox txtYSpan;
        private System.Windows.Forms.TextBox txtFlooring;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtJoistQnt;
        private System.Windows.Forms.TextBox txtBeamQnt;
        private System.Windows.Forms.GroupBox grpBoxDirection;
        private System.Windows.Forms.RadioButton rdbYdirection;
        private System.Windows.Forms.RadioButton rdbXdirection;
        private System.Windows.Forms.Label lblJoistDistanceCS;
        private System.Windows.Forms.ComboBox cmbJoistProfile;
        private System.Windows.Forms.Label lblCprofCS;
        private System.Windows.Forms.Label lblJoistTextCS;
        private System.Windows.Forms.Label lblXmaxCS;
        private System.Windows.Forms.Label lblYmaxCS;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblFlooringCS;
        private System.Windows.Forms.Label lblHeightCS;
        private System.Windows.Forms.Label lblSpansYCS;
        private System.Windows.Forms.Label lblSpansXCS;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.Button btnOrigin;
        private System.Windows.Forms.TextBox txtZcoordinate;
        private System.Windows.Forms.TextBox txtYcoordinate;
        private System.Windows.Forms.TextBox txtXcoordinate;
        private System.Windows.Forms.Label lblZcoordinate;
        private System.Windows.Forms.Label lblYcoordinate;
        private System.Windows.Forms.Label lblXcoordinate;
        private System.Windows.Forms.TabControl tabSystemSelection;
        private System.Windows.Forms.ComboBox cmbBeamProfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}