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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlmaconBasic));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabColdStuff = new System.Windows.Forms.TabPage();
            this.txtFloorLoad = new System.Windows.Forms.TextBox();
            this.lblFloorLoad = new System.Windows.Forms.Label();
            this.btnSyncExcelData = new System.Windows.Forms.Button();
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.joistDistanceErrorPRovider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabColdStuff.SuspendLayout();
            this.grpBoxDirection.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.TabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.joistDistanceErrorPRovider)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 458);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(461, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // tabColdStuff
            // 
            this.tabColdStuff.BackColor = System.Drawing.SystemColors.Control;
            this.tabColdStuff.Controls.Add(this.txtFloorLoad);
            this.tabColdStuff.Controls.Add(this.lblFloorLoad);
            this.tabColdStuff.Controls.Add(this.btnSyncExcelData);
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
            this.tabColdStuff.Location = new System.Drawing.Point(4, 28);
            this.tabColdStuff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabColdStuff.Name = "tabColdStuff";
            this.tabColdStuff.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabColdStuff.Size = new System.Drawing.Size(511, 409);
            this.tabColdStuff.TabIndex = 1;
            this.tabColdStuff.Text = "Cold Stuff";
            // 
            // txtFloorLoad
            // 
            this.txtFloorLoad.Location = new System.Drawing.Point(233, 378);
            this.txtFloorLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFloorLoad.Name = "txtFloorLoad";
            this.txtFloorLoad.ReadOnly = true;
            this.txtFloorLoad.Size = new System.Drawing.Size(132, 22);
            this.txtFloorLoad.TabIndex = 132;
            // 
            // lblFloorLoad
            // 
            this.lblFloorLoad.AutoSize = true;
            this.lblFloorLoad.Location = new System.Drawing.Point(229, 357);
            this.lblFloorLoad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFloorLoad.Name = "lblFloorLoad";
            this.lblFloorLoad.Size = new System.Drawing.Size(68, 16);
            this.lblFloorLoad.TabIndex = 131;
            this.lblFloorLoad.Text = "Floor load";
            // 
            // btnSyncExcelData
            // 
            this.btnSyncExcelData.Location = new System.Drawing.Point(295, 110);
            this.btnSyncExcelData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSyncExcelData.Name = "btnSyncExcelData";
            this.btnSyncExcelData.Size = new System.Drawing.Size(205, 66);
            this.btnSyncExcelData.TabIndex = 130;
            this.btnSyncExcelData.Text = "Sync excel data";
            this.btnSyncExcelData.UseVisualStyleBackColor = true;
            this.btnSyncExcelData.Click += new System.EventHandler(this.btnSyncExcelData_Click_1);
            // 
            // cmbBeamProfile
            // 
            this.cmbBeamProfile.FormattingEnabled = true;
            this.cmbBeamProfile.Items.AddRange(new object[] {
            "SADEF-C+350X3.00"});
            this.cmbBeamProfile.Location = new System.Drawing.Point(16, 242);
            this.cmbBeamProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBeamProfile.Name = "cmbBeamProfile";
            this.cmbBeamProfile.Size = new System.Drawing.Size(211, 24);
            this.cmbBeamProfile.TabIndex = 129;
            this.cmbBeamProfile.Text = "SADEF-C+350X3.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 128;
            this.label2.Text = "C-profile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(13, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 127;
            this.label3.Text = "Beam info";
            // 
            // txtJoistDistance
            // 
            this.txtJoistDistance.Location = new System.Drawing.Point(233, 325);
            this.txtJoistDistance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtJoistDistance.Name = "txtJoistDistance";
            this.txtJoistDistance.ReadOnly = true;
            this.txtJoistDistance.Size = new System.Drawing.Size(132, 22);
            this.txtJoistDistance.TabIndex = 122;
            this.txtJoistDistance.TextChanged += new System.EventHandler(this.txtJoistDistance_TextChanged);
            // 
            // txtXSpan
            // 
            this.txtXSpan.Location = new System.Drawing.Point(11, 30);
            this.txtXSpan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtXSpan.Name = "txtXSpan";
            this.txtXSpan.ReadOnly = true;
            this.txtXSpan.Size = new System.Drawing.Size(132, 22);
            this.txtXSpan.TabIndex = 90;
            // 
            // txtYSpan
            // 
            this.txtYSpan.Location = new System.Drawing.Point(11, 78);
            this.txtYSpan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtYSpan.Name = "txtYSpan";
            this.txtYSpan.ReadOnly = true;
            this.txtYSpan.Size = new System.Drawing.Size(132, 22);
            this.txtYSpan.TabIndex = 91;
            // 
            // txtFlooring
            // 
            this.txtFlooring.Location = new System.Drawing.Point(296, 30);
            this.txtFlooring.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFlooring.Name = "txtFlooring";
            this.txtFlooring.ReadOnly = true;
            this.txtFlooring.Size = new System.Drawing.Size(132, 22);
            this.txtFlooring.TabIndex = 95;
            this.txtFlooring.Text = "38";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(296, 78);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.ReadOnly = true;
            this.txtHeight.Size = new System.Drawing.Size(207, 22);
            this.txtHeight.TabIndex = 96;
            // 
            // txtJoistQnt
            // 
            this.txtJoistQnt.Location = new System.Drawing.Point(155, 78);
            this.txtJoistQnt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtJoistQnt.Name = "txtJoistQnt";
            this.txtJoistQnt.Size = new System.Drawing.Size(132, 22);
            this.txtJoistQnt.TabIndex = 103;
            this.txtJoistQnt.Text = "1";
            // 
            // txtBeamQnt
            // 
            this.txtBeamQnt.Location = new System.Drawing.Point(155, 30);
            this.txtBeamQnt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBeamQnt.Name = "txtBeamQnt";
            this.txtBeamQnt.Size = new System.Drawing.Size(132, 22);
            this.txtBeamQnt.TabIndex = 102;
            this.txtBeamQnt.Text = "1";
            // 
            // grpBoxDirection
            // 
            this.grpBoxDirection.Controls.Add(this.rdbYdirection);
            this.grpBoxDirection.Controls.Add(this.rdbXdirection);
            this.grpBoxDirection.Location = new System.Drawing.Point(8, 110);
            this.grpBoxDirection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxDirection.Name = "grpBoxDirection";
            this.grpBoxDirection.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxDirection.Size = new System.Drawing.Size(172, 74);
            this.grpBoxDirection.TabIndex = 126;
            this.grpBoxDirection.TabStop = false;
            // 
            // rdbYdirection
            // 
            this.rdbYdirection.AutoSize = true;
            this.rdbYdirection.Location = new System.Drawing.Point(5, 41);
            this.rdbYdirection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbYdirection.Name = "rdbYdirection";
            this.rdbYdirection.Size = new System.Drawing.Size(143, 20);
            this.rdbYdirection.TabIndex = 109;
            this.rdbYdirection.Text = "Beam in Y direction";
            this.rdbYdirection.UseVisualStyleBackColor = true;
            // 
            // rdbXdirection
            // 
            this.rdbXdirection.AutoSize = true;
            this.rdbXdirection.Checked = true;
            this.rdbXdirection.Location = new System.Drawing.Point(5, 12);
            this.rdbXdirection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbXdirection.Name = "rdbXdirection";
            this.rdbXdirection.Size = new System.Drawing.Size(142, 20);
            this.rdbXdirection.TabIndex = 108;
            this.rdbXdirection.TabStop = true;
            this.rdbXdirection.Text = "Beam in X direction";
            this.rdbXdirection.UseVisualStyleBackColor = true;
            this.rdbXdirection.CheckedChanged += new System.EventHandler(this.rdbXdirection_CheckedChanged);
            // 
            // lblJoistDistanceCS
            // 
            this.lblJoistDistanceCS.AutoSize = true;
            this.lblJoistDistanceCS.Location = new System.Drawing.Point(229, 304);
            this.lblJoistDistanceCS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJoistDistanceCS.Name = "lblJoistDistanceCS";
            this.lblJoistDistanceCS.Size = new System.Drawing.Size(89, 16);
            this.lblJoistDistanceCS.TabIndex = 121;
            this.lblJoistDistanceCS.Text = "Joist distance";
            // 
            // cmbJoistProfile
            // 
            this.cmbJoistProfile.FormattingEnabled = true;
            this.cmbJoistProfile.Items.AddRange(new object[] {
            "SADEF-C265X1.75"});
            this.cmbJoistProfile.Location = new System.Drawing.Point(13, 324);
            this.cmbJoistProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbJoistProfile.Name = "cmbJoistProfile";
            this.cmbJoistProfile.Size = new System.Drawing.Size(211, 24);
            this.cmbJoistProfile.TabIndex = 120;
            this.cmbJoistProfile.Text = "SADEF-C265X1.75";
            this.cmbJoistProfile.SelectedIndexChanged += new System.EventHandler(this.cmbJoistProfileCS_SelectedIndexChanged);
            // 
            // lblCprofCS
            // 
            this.lblCprofCS.AutoSize = true;
            this.lblCprofCS.Location = new System.Drawing.Point(12, 304);
            this.lblCprofCS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCprofCS.Name = "lblCprofCS";
            this.lblCprofCS.Size = new System.Drawing.Size(57, 16);
            this.lblCprofCS.TabIndex = 119;
            this.lblCprofCS.Text = "C-profile";
            // 
            // lblJoistTextCS
            // 
            this.lblJoistTextCS.AutoSize = true;
            this.lblJoistTextCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblJoistTextCS.Location = new System.Drawing.Point(11, 273);
            this.lblJoistTextCS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJoistTextCS.Name = "lblJoistTextCS";
            this.lblJoistTextCS.Size = new System.Drawing.Size(89, 25);
            this.lblJoistTextCS.TabIndex = 118;
            this.lblJoistTextCS.Text = "Joist info";
            // 
            // lblXmaxCS
            // 
            this.lblXmaxCS.AutoSize = true;
            this.lblXmaxCS.Location = new System.Drawing.Point(19, 10);
            this.lblXmaxCS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXmaxCS.Name = "lblXmaxCS";
            this.lblXmaxCS.Size = new System.Drawing.Size(50, 16);
            this.lblXmaxCS.TabIndex = 92;
            this.lblXmaxCS.Text = "Span X";
            // 
            // lblYmaxCS
            // 
            this.lblYmaxCS.AutoSize = true;
            this.lblYmaxCS.Location = new System.Drawing.Point(19, 58);
            this.lblYmaxCS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYmaxCS.Name = "lblYmaxCS";
            this.lblYmaxCS.Size = new System.Drawing.Size(51, 16);
            this.lblYmaxCS.TabIndex = 93;
            this.lblYmaxCS.Text = "Span Y";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(295, 183);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(205, 66);
            this.btnStart.TabIndex = 94;
            this.btnStart.Text = "Draw";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblFlooringCS
            // 
            this.lblFlooringCS.AutoSize = true;
            this.lblFlooringCS.Location = new System.Drawing.Point(305, 10);
            this.lblFlooringCS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlooringCS.Name = "lblFlooringCS";
            this.lblFlooringCS.Size = new System.Drawing.Size(116, 16);
            this.lblFlooringCS.TabIndex = 97;
            this.lblFlooringCS.Text = "Thickness flooring";
            // 
            // lblHeightCS
            // 
            this.lblHeightCS.AutoSize = true;
            this.lblHeightCS.Location = new System.Drawing.Point(316, 58);
            this.lblHeightCS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeightCS.Name = "lblHeightCS";
            this.lblHeightCS.Size = new System.Drawing.Size(75, 16);
            this.lblHeightCS.TabIndex = 98;
            this.lblHeightCS.Text = "Height floor";
            // 
            // lblSpansYCS
            // 
            this.lblSpansYCS.AutoSize = true;
            this.lblSpansYCS.Location = new System.Drawing.Point(163, 58);
            this.lblSpansYCS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpansYCS.Name = "lblSpansYCS";
            this.lblSpansYCS.Size = new System.Drawing.Size(80, 16);
            this.lblSpansYCS.TabIndex = 105;
            this.lblSpansYCS.Text = "No. spans Y";
            // 
            // lblSpansXCS
            // 
            this.lblSpansXCS.AutoSize = true;
            this.lblSpansXCS.Location = new System.Drawing.Point(163, 10);
            this.lblSpansXCS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpansXCS.Name = "lblSpansXCS";
            this.lblSpansXCS.Size = new System.Drawing.Size(79, 16);
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
            this.tabGeneral.Location = new System.Drawing.Point(4, 28);
            this.tabGeneral.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabGeneral.Size = new System.Drawing.Size(511, 409);
            this.tabGeneral.TabIndex = 2;
            this.tabGeneral.Text = "General";
            // 
            // btnOrigin
            // 
            this.btnOrigin.AutoSize = true;
            this.btnOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOrigin.Location = new System.Drawing.Point(39, 219);
            this.btnOrigin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrigin.Name = "btnOrigin";
            this.btnOrigin.Size = new System.Drawing.Size(211, 43);
            this.btnOrigin.TabIndex = 6;
            this.btnOrigin.Text = "Pick origin point";
            this.btnOrigin.UseVisualStyleBackColor = true;
            this.btnOrigin.Click += new System.EventHandler(this.btnOrigin_Click);
            // 
            // txtZcoordinate
            // 
            this.txtZcoordinate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtZcoordinate.Location = new System.Drawing.Point(89, 161);
            this.txtZcoordinate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtZcoordinate.Name = "txtZcoordinate";
            this.txtZcoordinate.Size = new System.Drawing.Size(143, 30);
            this.txtZcoordinate.TabIndex = 5;
            this.txtZcoordinate.Text = "0";
            // 
            // txtYcoordinate
            // 
            this.txtYcoordinate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtYcoordinate.Location = new System.Drawing.Point(89, 101);
            this.txtYcoordinate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtYcoordinate.Name = "txtYcoordinate";
            this.txtYcoordinate.Size = new System.Drawing.Size(143, 30);
            this.txtYcoordinate.TabIndex = 4;
            this.txtYcoordinate.Text = "0";
            // 
            // txtXcoordinate
            // 
            this.txtXcoordinate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtXcoordinate.Location = new System.Drawing.Point(89, 48);
            this.txtXcoordinate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtXcoordinate.Name = "txtXcoordinate";
            this.txtXcoordinate.Size = new System.Drawing.Size(143, 30);
            this.txtXcoordinate.TabIndex = 3;
            this.txtXcoordinate.Text = "0";
            // 
            // lblZcoordinate
            // 
            this.lblZcoordinate.AutoSize = true;
            this.lblZcoordinate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblZcoordinate.Location = new System.Drawing.Point(33, 165);
            this.lblZcoordinate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZcoordinate.Name = "lblZcoordinate";
            this.lblZcoordinate.Size = new System.Drawing.Size(45, 25);
            this.lblZcoordinate.TabIndex = 2;
            this.lblZcoordinate.Text = "Z :  ";
            // 
            // lblYcoordinate
            // 
            this.lblYcoordinate.AutoSize = true;
            this.lblYcoordinate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblYcoordinate.Location = new System.Drawing.Point(33, 105);
            this.lblYcoordinate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYcoordinate.Name = "lblYcoordinate";
            this.lblYcoordinate.Size = new System.Drawing.Size(41, 25);
            this.lblYcoordinate.TabIndex = 1;
            this.lblYcoordinate.Text = "Y : ";
            // 
            // lblXcoordinate
            // 
            this.lblXcoordinate.AutoSize = true;
            this.lblXcoordinate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblXcoordinate.Location = new System.Drawing.Point(33, 52);
            this.lblXcoordinate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXcoordinate.Name = "lblXcoordinate";
            this.lblXcoordinate.Size = new System.Drawing.Size(47, 25);
            this.lblXcoordinate.TabIndex = 0;
            this.lblXcoordinate.Text = "X :  ";
            // 
            // TabControl
            // 
            this.TabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.TabControl.Controls.Add(this.tabGeneral);
            this.TabControl.Controls.Add(this.tabColdStuff);
            this.TabControl.Location = new System.Drawing.Point(16, 15);
            this.TabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(519, 441);
            this.TabControl.TabIndex = 44;
            this.TabControl.Tag = "";
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // joistDistanceErrorPRovider
            // 
            this.joistDistanceErrorPRovider.ContainerControl = this;
            // 
            // frmAlmaconBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 651);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAlmaconBasic";
            this.Text = "Almacon Basic Configurator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabColdStuff.ResumeLayout(false);
            this.tabColdStuff.PerformLayout();
            this.grpBoxDirection.ResumeLayout(false);
            this.grpBoxDirection.PerformLayout();
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.TabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.joistDistanceErrorPRovider)).EndInit();
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
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.ComboBox cmbBeamProfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider joistDistanceErrorPRovider;
        private System.Windows.Forms.Button btnSyncExcelData;
        private System.Windows.Forms.TextBox txtFloorLoad;
        private System.Windows.Forms.Label lblFloorLoad;
    }
}