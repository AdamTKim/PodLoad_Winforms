namespace PodLoad
{
    partial class PodForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PodForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.aircraftInput = new System.Windows.Forms.ComboBox();
            this.aircraftLabel = new System.Windows.Forms.Label();
            this.bannerPicture = new System.Windows.Forms.PictureBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.codeInput = new System.Windows.Forms.ComboBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.commentBox = new System.Windows.Forms.TextBox();
            this.commentLabel = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.displayedTable = new System.Windows.Forms.DataGridView();
            this.Done = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.WorkShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TDY = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AircraftType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TailNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AircraftStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PodNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weighted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DRDNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TorqueWrench = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Range = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConditionCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotEffective = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.downloadingButton = new System.Windows.Forms.RadioButton();
            this.drdnoInput = new System.Windows.Forms.TextBox();
            this.drdnoLabel = new System.Windows.Forms.Label();
            this.editBox = new System.Windows.Forms.CheckBox();
            this.effectiveBox = new System.Windows.Forms.CheckBox();
            this.modePanel = new System.Windows.Forms.Panel();
            this.uploadingButton = new System.Windows.Forms.RadioButton();
            this.podnoInput = new System.Windows.Forms.TextBox();
            this.podnoLabel = new System.Windows.Forms.Label();
            this.programTitle = new System.Windows.Forms.Label();
            this.rangeInput = new System.Windows.Forms.ComboBox();
            this.rangeLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.shift1Button = new System.Windows.Forms.RadioButton();
            this.shift2Button = new System.Windows.Forms.RadioButton();
            this.shift3Button = new System.Windows.Forms.RadioButton();
            this.shift4Button = new System.Windows.Forms.RadioButton();
            this.shiftLabel = new System.Windows.Forms.Label();
            this.shiftPanel = new System.Windows.Forms.Panel();
            this.stationInput = new System.Windows.Forms.ComboBox();
            this.stationLabel = new System.Windows.Forms.Label();
            this.statusmreqButton = new System.Windows.Forms.RadioButton();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.statussprButton = new System.Windows.Forms.RadioButton();
            this.syncBar = new System.Windows.Forms.ProgressBar();
            this.syncButton = new System.Windows.Forms.Button();
            this.tailnoInput = new System.Windows.Forms.TextBox();
            this.tailnoLabel = new System.Windows.Forms.Label();
            this.tdyBox = new System.Windows.Forms.CheckBox();
            this.torqueInput = new System.Windows.Forms.ComboBox();
            this.torqueLabel = new System.Windows.Forms.Label();
            this.unitInput = new System.Windows.Forms.ComboBox();
            this.unitLabel = new System.Windows.Forms.Label();
            this.weightedBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bannerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayedTable)).BeginInit();
            this.modePanel.SuspendLayout();
            this.shiftPanel.SuspendLayout();
            this.statusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // aircraftInput
            // 
            this.aircraftInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.aircraftInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.aircraftInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aircraftInput.FormattingEnabled = true;
            this.aircraftInput.Items.AddRange(new object[] {
            "A-4",
            "A-10",
            "B-52",
            "EA6B",
            "F-1",
            "F-15C",
            "F-15E",
            "F-16",
            "F-18E",
            "F-18G",
            "F-22",
            "F-35",
            "L-159",
            "TORNADO",
            "TYPHOON"});
            this.aircraftInput.Location = new System.Drawing.Point(175, 208);
            this.aircraftInput.Name = "aircraftInput";
            this.aircraftInput.Size = new System.Drawing.Size(267, 26);
            this.aircraftInput.TabIndex = 11;
            this.aircraftInput.SelectedIndexChanged += new System.EventHandler(this.ChangeStationOptions);
            // 
            // aircraftLabel
            // 
            this.aircraftLabel.AutoSize = true;
            this.aircraftLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aircraftLabel.Location = new System.Drawing.Point(27, 208);
            this.aircraftLabel.Name = "aircraftLabel";
            this.aircraftLabel.Size = new System.Drawing.Size(139, 24);
            this.aircraftLabel.TabIndex = 0;
            this.aircraftLabel.Text = "Aircraft Type:";
            // 
            // bannerPicture
            // 
            this.bannerPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bannerPicture.Image = ((System.Drawing.Image)(resources.GetObject("bannerPicture.Image")));
            this.bannerPicture.Location = new System.Drawing.Point(1088, -2);
            this.bannerPicture.Name = "bannerPicture";
            this.bannerPicture.Size = new System.Drawing.Size(503, 111);
            this.bannerPicture.TabIndex = 0;
            this.bannerPicture.TabStop = false;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeButton.Enabled = false;
            this.changeButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(970, 12);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(109, 52);
            this.changeButton.TabIndex = 1;
            this.changeButton.Text = "CHANGE";
            this.changeButton.UseVisualStyleBackColor = false;
            // 
            // codeInput
            // 
            this.codeInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.codeInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.codeInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.codeInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.codeInput.FormattingEnabled = true;
            this.codeInput.Items.AddRange(new object[] {
            "UPLD - Standard Upload",
            "DNLD - Standard Download",
            "CHNG - Record Change",
            "CPMI - Preventative Maintence Inspection",
            "CRNG - Change Range",
            "CRTB - Return To Base",
            "CSTN - Change Station",
            "DNTO - Did Not Turn On",
            "DRDS - DRD Swap",
            "STNS - Station Swap",
            "TCTO - Time Compliance Technical Order",
            "TRVL - Aircraft Needs To Travel",
            "OTHR - Other (Comment Required)"});
            this.codeInput.Location = new System.Drawing.Point(99, 458);
            this.codeInput.Name = "codeInput";
            this.codeInput.Size = new System.Drawing.Size(383, 26);
            this.codeInput.TabIndex = 21;
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeLabel.Location = new System.Drawing.Point(27, 458);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(66, 24);
            this.codeLabel.TabIndex = 0;
            this.codeLabel.Text = "Code:";
            // 
            // commentBox
            // 
            this.commentBox.Location = new System.Drawing.Point(31, 536);
            this.commentBox.Multiline = true;
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(451, 94);
            this.commentBox.TabIndex = 23;
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentLabel.Location = new System.Drawing.Point(27, 508);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(118, 24);
            this.commentLabel.TabIndex = 0;
            this.commentLabel.Text = "Comments:";
            // 
            // currentLabel
            // 
            this.currentLabel.AutoSize = true;
            this.currentLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLabel.Location = new System.Drawing.Point(809, 51);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(86, 19);
            this.currentLabel.TabIndex = 0;
            this.currentLabel.Text = "Currently:";
            // 
            // displayedTable
            // 
            this.displayedTable.AllowUserToAddRows = false;
            this.displayedTable.AllowUserToResizeColumns = false;
            this.displayedTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.displayedTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.displayedTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayedTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Done,
            this.WorkShift,
            this.Unit,
            this.TDY,
            this.AircraftType,
            this.TailNO,
            this.AircraftStatus,
            this.PodNO,
            this.Weighted,
            this.DRDNO,
            this.TorqueWrench,
            this.Station,
            this.Range,
            this.ConditionCode,
            this.NotEffective,
            this.Comments,
            this.Timestamp,
            this.ActionType});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(206)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.displayedTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.displayedTable.Location = new System.Drawing.Point(518, 108);
            this.displayedTable.MultiSelect = false;
            this.displayedTable.Name = "displayedTable";
            this.displayedTable.RowHeadersVisible = false;
            this.displayedTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displayedTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.displayedTable.Size = new System.Drawing.Size(1054, 430);
            this.displayedTable.StandardTab = true;
            this.displayedTable.TabIndex = 24;
            this.displayedTable.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.Datagridview_ClearSelection);
            this.displayedTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Datagridview_Color);
            this.displayedTable.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.Datagridview_Delete);
            this.displayedTable.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Datagridview_Deselect);
            // 
            // Done
            // 
            this.Done.FalseValue = false;
            this.Done.HeaderText = "Done";
            this.Done.Name = "Done";
            this.Done.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Done.TrueValue = true;
            this.Done.Width = 55;
            // 
            // WorkShift
            // 
            this.WorkShift.DataPropertyName = "WorkShift";
            this.WorkShift.HeaderText = "Work Shift";
            this.WorkShift.Name = "WorkShift";
            this.WorkShift.ReadOnly = true;
            this.WorkShift.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.WorkShift.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.WorkShift.Width = 70;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            this.Unit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Unit.Width = 80;
            // 
            // TDY
            // 
            this.TDY.DataPropertyName = "TDY";
            this.TDY.FalseValue = "False";
            this.TDY.HeaderText = "TDY";
            this.TDY.Name = "TDY";
            this.TDY.ReadOnly = true;
            this.TDY.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TDY.TrueValue = "True";
            this.TDY.Width = 50;
            // 
            // AircraftType
            // 
            this.AircraftType.DataPropertyName = "AircraftType";
            this.AircraftType.HeaderText = "Aircraft Type";
            this.AircraftType.Name = "AircraftType";
            this.AircraftType.ReadOnly = true;
            this.AircraftType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AircraftType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AircraftType.Width = 80;
            // 
            // TailNO
            // 
            this.TailNO.DataPropertyName = "TailNO";
            this.TailNO.HeaderText = "Tail No";
            this.TailNO.Name = "TailNO";
            this.TailNO.ReadOnly = true;
            this.TailNO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TailNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TailNO.Width = 65;
            // 
            // AircraftStatus
            // 
            this.AircraftStatus.DataPropertyName = "AircraftStatus";
            this.AircraftStatus.HeaderText = "Aircraft Status";
            this.AircraftStatus.Name = "AircraftStatus";
            this.AircraftStatus.ReadOnly = true;
            this.AircraftStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AircraftStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AircraftStatus.Width = 70;
            // 
            // PodNO
            // 
            this.PodNO.DataPropertyName = "PodNO";
            this.PodNO.HeaderText = "Pod No";
            this.PodNO.Name = "PodNO";
            this.PodNO.ReadOnly = true;
            this.PodNO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PodNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PodNO.Width = 67;
            // 
            // Weighted
            // 
            this.Weighted.DataPropertyName = "Weighted";
            this.Weighted.FalseValue = "False";
            this.Weighted.HeaderText = "WGHT";
            this.Weighted.Name = "Weighted";
            this.Weighted.ReadOnly = true;
            this.Weighted.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Weighted.TrueValue = "True";
            this.Weighted.Width = 65;
            // 
            // DRDNO
            // 
            this.DRDNO.DataPropertyName = "DRDNO";
            this.DRDNO.HeaderText = "DRD No";
            this.DRDNO.Name = "DRDNO";
            this.DRDNO.ReadOnly = true;
            this.DRDNO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DRDNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DRDNO.Width = 75;
            // 
            // TorqueWrench
            // 
            this.TorqueWrench.DataPropertyName = "TorqueWrench";
            this.TorqueWrench.HeaderText = "Torque Wrench";
            this.TorqueWrench.Name = "TorqueWrench";
            this.TorqueWrench.ReadOnly = true;
            this.TorqueWrench.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TorqueWrench.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TorqueWrench.Width = 80;
            // 
            // Station
            // 
            this.Station.DataPropertyName = "Station";
            this.Station.HeaderText = "Station";
            this.Station.Name = "Station";
            this.Station.ReadOnly = true;
            this.Station.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Station.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Station.Width = 68;
            // 
            // Range
            // 
            this.Range.DataPropertyName = "Range";
            this.Range.HeaderText = "Range";
            this.Range.Name = "Range";
            this.Range.ReadOnly = true;
            this.Range.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Range.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Range.Width = 80;
            // 
            // ConditionCode
            // 
            this.ConditionCode.DataPropertyName = "ConditionCode";
            this.ConditionCode.HeaderText = "Code";
            this.ConditionCode.Name = "ConditionCode";
            this.ConditionCode.ReadOnly = true;
            this.ConditionCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ConditionCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ConditionCode.Width = 75;
            // 
            // NotEffective
            // 
            this.NotEffective.DataPropertyName = "NotEffective";
            this.NotEffective.FalseValue = "False";
            this.NotEffective.HeaderText = "Not Effective";
            this.NotEffective.Name = "NotEffective";
            this.NotEffective.ReadOnly = true;
            this.NotEffective.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NotEffective.TrueValue = "True";
            this.NotEffective.Width = 70;
            // 
            // Comments
            // 
            this.Comments.DataPropertyName = "Comments";
            this.Comments.HeaderText = "Comments";
            this.Comments.Name = "Comments";
            this.Comments.ReadOnly = true;
            this.Comments.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Comments.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Comments.Visible = false;
            // 
            // Timestamp
            // 
            this.Timestamp.DataPropertyName = "Timestamp";
            this.Timestamp.HeaderText = "Timestamp";
            this.Timestamp.Name = "Timestamp";
            this.Timestamp.ReadOnly = true;
            this.Timestamp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Timestamp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Timestamp.Visible = false;
            this.Timestamp.Width = 80;
            // 
            // ActionType
            // 
            this.ActionType.DataPropertyName = "ActionType";
            this.ActionType.HeaderText = "Action Type";
            this.ActionType.Name = "ActionType";
            this.ActionType.ReadOnly = true;
            this.ActionType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ActionType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ActionType.Visible = false;
            // 
            // downloadingButton
            // 
            this.downloadingButton.AutoSize = true;
            this.downloadingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.downloadingButton.Location = new System.Drawing.Point(123, 3);
            this.downloadingButton.Name = "downloadingButton";
            this.downloadingButton.Size = new System.Drawing.Size(146, 22);
            this.downloadingButton.TabIndex = 3;
            this.downloadingButton.TabStop = true;
            this.downloadingButton.Text = "DOWNLOADING";
            this.downloadingButton.UseVisualStyleBackColor = true;
            this.downloadingButton.CheckedChanged += new System.EventHandler(this.InputModeChange_Click);
            // 
            // drdnoInput
            // 
            this.drdnoInput.Location = new System.Drawing.Point(175, 358);
            this.drdnoInput.Name = "drdnoInput";
            this.drdnoInput.Size = new System.Drawing.Size(88, 26);
            this.drdnoInput.TabIndex = 17;
            this.drdnoInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckIfInt);
            // 
            // drdnoLabel
            // 
            this.drdnoLabel.AutoSize = true;
            this.drdnoLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drdnoLabel.Location = new System.Drawing.Point(27, 358);
            this.drdnoLabel.Name = "drdnoLabel";
            this.drdnoLabel.Size = new System.Drawing.Size(139, 24);
            this.drdnoLabel.TabIndex = 0;
            this.drdnoLabel.Text = "DRD Number:";
            // 
            // editBox
            // 
            this.editBox.AutoSize = true;
            this.editBox.Location = new System.Drawing.Point(531, 79);
            this.editBox.Name = "editBox";
            this.editBox.Size = new System.Drawing.Size(96, 22);
            this.editBox.TabIndex = 4;
            this.editBox.Text = "Edit Table";
            this.editBox.UseVisualStyleBackColor = true;
            this.editBox.CheckedChanged += new System.EventHandler(this.Datagridview_Edit);
            // 
            // effectiveBox
            // 
            this.effectiveBox.AutoSize = true;
            this.effectiveBox.Enabled = false;
            this.effectiveBox.Location = new System.Drawing.Point(375, 490);
            this.effectiveBox.Name = "effectiveBox";
            this.effectiveBox.Size = new System.Drawing.Size(115, 22);
            this.effectiveBox.TabIndex = 22;
            this.effectiveBox.Text = "Not Effective";
            this.effectiveBox.UseVisualStyleBackColor = true;
            // 
            // modePanel
            // 
            this.modePanel.Controls.Add(this.downloadingButton);
            this.modePanel.Controls.Add(this.uploadingButton);
            this.modePanel.Location = new System.Drawing.Point(810, 73);
            this.modePanel.Name = "modePanel";
            this.modePanel.Size = new System.Drawing.Size(272, 28);
            this.modePanel.TabIndex = 2;
            this.modePanel.TabStop = true;
            // 
            // uploadingButton
            // 
            this.uploadingButton.AutoSize = true;
            this.uploadingButton.Checked = true;
            this.uploadingButton.ForeColor = System.Drawing.Color.Green;
            this.uploadingButton.Location = new System.Drawing.Point(3, 3);
            this.uploadingButton.Name = "uploadingButton";
            this.uploadingButton.Size = new System.Drawing.Size(118, 22);
            this.uploadingButton.TabIndex = 2;
            this.uploadingButton.TabStop = true;
            this.uploadingButton.Text = "UPLOADING";
            this.uploadingButton.UseVisualStyleBackColor = true;
            this.uploadingButton.CheckedChanged += new System.EventHandler(this.InputModeChange_Click);
            // 
            // podnoInput
            // 
            this.podnoInput.Location = new System.Drawing.Point(175, 308);
            this.podnoInput.Name = "podnoInput";
            this.podnoInput.Size = new System.Drawing.Size(121, 26);
            this.podnoInput.TabIndex = 15;
            this.podnoInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckIfInt);
            // 
            // podnoLabel
            // 
            this.podnoLabel.AutoSize = true;
            this.podnoLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.podnoLabel.Location = new System.Drawing.Point(27, 308);
            this.podnoLabel.Name = "podnoLabel";
            this.podnoLabel.Size = new System.Drawing.Size(134, 24);
            this.podnoLabel.TabIndex = 0;
            this.podnoLabel.Text = "Pod Number:";
            // 
            // programTitle
            // 
            this.programTitle.AutoSize = true;
            this.programTitle.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programTitle.Location = new System.Drawing.Point(21, 30);
            this.programTitle.Name = "programTitle";
            this.programTitle.Size = new System.Drawing.Size(504, 55);
            this.programTitle.TabIndex = 0;
            this.programTitle.Text = "Pod Operational Tool";
            // 
            // rangeInput
            // 
            this.rangeInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.rangeInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.rangeInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rangeInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rangeInput.FormattingEnabled = true;
            this.rangeInput.Items.AddRange(new object[] {
            "LOCAL",
            "RF",
            "GF WEST",
            "NTTR/UTTR"});
            this.rangeInput.Location = new System.Drawing.Point(285, 408);
            this.rangeInput.Name = "rangeInput";
            this.rangeInput.Size = new System.Drawing.Size(124, 26);
            this.rangeInput.TabIndex = 20;
            // 
            // rangeLabel
            // 
            this.rangeLabel.AutoSize = true;
            this.rangeLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangeLabel.Location = new System.Drawing.Point(202, 408);
            this.rangeLabel.Name = "rangeLabel";
            this.rangeLabel.Size = new System.Drawing.Size(77, 24);
            this.rangeLabel.TabIndex = 0;
            this.rangeLabel.Text = "Range:";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(518, 578);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(109, 52);
            this.saveButton.TabIndex = 25;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // shift1Button
            // 
            this.shift1Button.AutoSize = true;
            this.shift1Button.Location = new System.Drawing.Point(3, 3);
            this.shift1Button.Name = "shift1Button";
            this.shift1Button.Size = new System.Drawing.Size(70, 22);
            this.shift1Button.TabIndex = 5;
            this.shift1Button.TabStop = true;
            this.shift1Button.Text = "Shift 1";
            this.shift1Button.UseVisualStyleBackColor = true;
            // 
            // shift2Button
            // 
            this.shift2Button.AutoSize = true;
            this.shift2Button.Location = new System.Drawing.Point(79, 3);
            this.shift2Button.Name = "shift2Button";
            this.shift2Button.Size = new System.Drawing.Size(70, 22);
            this.shift2Button.TabIndex = 6;
            this.shift2Button.TabStop = true;
            this.shift2Button.Text = "Shift 2";
            this.shift2Button.UseVisualStyleBackColor = true;
            // 
            // shift3Button
            // 
            this.shift3Button.AutoSize = true;
            this.shift3Button.Location = new System.Drawing.Point(155, 3);
            this.shift3Button.Name = "shift3Button";
            this.shift3Button.Size = new System.Drawing.Size(70, 22);
            this.shift3Button.TabIndex = 7;
            this.shift3Button.TabStop = true;
            this.shift3Button.Text = "Shift 3";
            this.shift3Button.UseVisualStyleBackColor = true;
            // 
            // shift4Button
            // 
            this.shift4Button.AutoSize = true;
            this.shift4Button.Location = new System.Drawing.Point(231, 3);
            this.shift4Button.Name = "shift4Button";
            this.shift4Button.Size = new System.Drawing.Size(75, 22);
            this.shift4Button.TabIndex = 8;
            this.shift4Button.TabStop = true;
            this.shift4Button.Text = "WKND";
            this.shift4Button.UseVisualStyleBackColor = true;
            // 
            // shiftLabel
            // 
            this.shiftLabel.AutoSize = true;
            this.shiftLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftLabel.Location = new System.Drawing.Point(27, 108);
            this.shiftLabel.Name = "shiftLabel";
            this.shiftLabel.Size = new System.Drawing.Size(117, 24);
            this.shiftLabel.TabIndex = 0;
            this.shiftLabel.Text = "Work Shift:";
            // 
            // shiftPanel
            // 
            this.shiftPanel.Controls.Add(this.shift1Button);
            this.shiftPanel.Controls.Add(this.shift2Button);
            this.shiftPanel.Controls.Add(this.shift3Button);
            this.shiftPanel.Controls.Add(this.shift4Button);
            this.shiftPanel.Location = new System.Drawing.Point(149, 107);
            this.shiftPanel.Name = "shiftPanel";
            this.shiftPanel.Size = new System.Drawing.Size(310, 30);
            this.shiftPanel.TabIndex = 5;
            this.shiftPanel.TabStop = true;
            // 
            // stationInput
            // 
            this.stationInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.stationInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.stationInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stationInput.FormattingEnabled = true;
            this.stationInput.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.stationInput.Location = new System.Drawing.Point(117, 408);
            this.stationInput.Name = "stationInput";
            this.stationInput.Size = new System.Drawing.Size(61, 26);
            this.stationInput.TabIndex = 19;
            // 
            // stationLabel
            // 
            this.stationLabel.AutoSize = true;
            this.stationLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stationLabel.Location = new System.Drawing.Point(27, 408);
            this.stationLabel.Name = "stationLabel";
            this.stationLabel.Size = new System.Drawing.Size(84, 24);
            this.stationLabel.TabIndex = 0;
            this.stationLabel.Text = "Station:";
            // 
            // statusmreqButton
            // 
            this.statusmreqButton.AutoSize = true;
            this.statusmreqButton.Checked = true;
            this.statusmreqButton.Location = new System.Drawing.Point(3, 3);
            this.statusmreqButton.Name = "statusmreqButton";
            this.statusmreqButton.Size = new System.Drawing.Size(50, 22);
            this.statusmreqButton.TabIndex = 13;
            this.statusmreqButton.TabStop = true;
            this.statusmreqButton.Text = "MR";
            this.statusmreqButton.UseVisualStyleBackColor = true;
            // 
            // statusPanel
            // 
            this.statusPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.statusPanel.Controls.Add(this.statussprButton);
            this.statusPanel.Controls.Add(this.statusmreqButton);
            this.statusPanel.Location = new System.Drawing.Point(325, 258);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(128, 26);
            this.statusPanel.TabIndex = 13;
            this.statusPanel.TabStop = true;
            // 
            // statussprButton
            // 
            this.statussprButton.AutoSize = true;
            this.statussprButton.Location = new System.Drawing.Point(77, 3);
            this.statussprButton.Name = "statussprButton";
            this.statussprButton.Size = new System.Drawing.Size(48, 22);
            this.statussprButton.TabIndex = 14;
            this.statussprButton.TabStop = true;
            this.statussprButton.Text = "SP";
            this.statussprButton.UseVisualStyleBackColor = true;
            // 
            // syncBar
            // 
            this.syncBar.Location = new System.Drawing.Point(1357, 592);
            this.syncBar.Name = "syncBar";
            this.syncBar.Size = new System.Drawing.Size(100, 23);
            this.syncBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.syncBar.TabIndex = 0;
            this.syncBar.Visible = false;
            // 
            // syncButton
            // 
            this.syncButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.syncButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.syncButton.Location = new System.Drawing.Point(1463, 578);
            this.syncButton.Name = "syncButton";
            this.syncButton.Size = new System.Drawing.Size(109, 52);
            this.syncButton.TabIndex = 26;
            this.syncButton.Text = "SYNC";
            this.syncButton.UseVisualStyleBackColor = false;
            this.syncButton.Click += new System.EventHandler(this.SyncButton_Click);
            // 
            // tailnoInput
            // 
            this.tailnoInput.Location = new System.Drawing.Point(175, 258);
            this.tailnoInput.Name = "tailnoInput";
            this.tailnoInput.Size = new System.Drawing.Size(121, 26);
            this.tailnoInput.TabIndex = 12;
            this.tailnoInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckIfInt);
            // 
            // tailnoLabel
            // 
            this.tailnoLabel.AutoSize = true;
            this.tailnoLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tailnoLabel.Location = new System.Drawing.Point(27, 258);
            this.tailnoLabel.Name = "tailnoLabel";
            this.tailnoLabel.Size = new System.Drawing.Size(130, 24);
            this.tailnoLabel.TabIndex = 0;
            this.tailnoLabel.Text = "Tail Number:";
            // 
            // tdyBox
            // 
            this.tdyBox.AutoSize = true;
            this.tdyBox.Location = new System.Drawing.Point(380, 161);
            this.tdyBox.Name = "tdyBox";
            this.tdyBox.Size = new System.Drawing.Size(57, 22);
            this.tdyBox.TabIndex = 10;
            this.tdyBox.Text = "TDY";
            this.tdyBox.UseVisualStyleBackColor = true;
            // 
            // torqueInput
            // 
            this.torqueInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.torqueInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.torqueInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.torqueInput.FormattingEnabled = true;
            this.torqueInput.Items.AddRange(new object[] {
            "N29057",
            "N09074",
            "N31081",
            "N08858",
            "N29107",
            "N29146",
            "N09039"});
            this.torqueInput.Location = new System.Drawing.Point(382, 358);
            this.torqueInput.Name = "torqueInput";
            this.torqueInput.Size = new System.Drawing.Size(100, 26);
            this.torqueInput.TabIndex = 18;
            // 
            // torqueLabel
            // 
            this.torqueLabel.AutoSize = true;
            this.torqueLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.torqueLabel.Location = new System.Drawing.Point(271, 358);
            this.torqueLabel.Name = "torqueLabel";
            this.torqueLabel.Size = new System.Drawing.Size(109, 24);
            this.torqueLabel.TabIndex = 0;
            this.torqueLabel.Text = "T-Wrench:";
            // 
            // unitInput
            // 
            this.unitInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.unitInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.unitInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unitInput.FormattingEnabled = true;
            this.unitInput.Items.AddRange(new object[] {
            "16 WPS",
            "17 WPS",
            "24 TASS",
            "335 FS",
            "361 FS",
            "391 FS",
            "433 WPS",
            "64 AGRS",
            "66 WPS",
            "DRAKEN",
            "VAQ 135",
            "VIPER",
            "EAGLE",
            "STRIKE"});
            this.unitInput.Location = new System.Drawing.Point(175, 158);
            this.unitInput.Name = "unitInput";
            this.unitInput.Size = new System.Drawing.Size(180, 26);
            this.unitInput.TabIndex = 9;
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitLabel.Location = new System.Drawing.Point(27, 158);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(55, 24);
            this.unitLabel.TabIndex = 0;
            this.unitLabel.Text = "Unit:";
            // 
            // weightedBox
            // 
            this.weightedBox.AutoSize = true;
            this.weightedBox.Location = new System.Drawing.Point(328, 311);
            this.weightedBox.Name = "weightedBox";
            this.weightedBox.Size = new System.Drawing.Size(94, 22);
            this.weightedBox.TabIndex = 16;
            this.weightedBox.Text = "Weighted";
            this.weightedBox.UseVisualStyleBackColor = true;
            // 
            // PodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1599, 656);
            this.Controls.Add(this.aircraftInput);
            this.Controls.Add(this.aircraftLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.codeInput);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.commentBox);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.displayedTable);
            this.Controls.Add(this.drdnoInput);
            this.Controls.Add(this.drdnoLabel);
            this.Controls.Add(this.editBox);
            this.Controls.Add(this.effectiveBox);
            this.Controls.Add(this.modePanel);
            this.Controls.Add(this.podnoInput);
            this.Controls.Add(this.podnoLabel);
            this.Controls.Add(this.programTitle);
            this.Controls.Add(this.rangeInput);
            this.Controls.Add(this.rangeLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.shiftLabel);
            this.Controls.Add(this.shiftPanel);
            this.Controls.Add(this.stationInput);
            this.Controls.Add(this.stationLabel);
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.syncBar);
            this.Controls.Add(this.syncButton);
            this.Controls.Add(this.tailnoInput);
            this.Controls.Add(this.tailnoLabel);
            this.Controls.Add(this.tdyBox);
            this.Controls.Add(this.torqueInput);
            this.Controls.Add(this.torqueLabel);
            this.Controls.Add(this.unitInput);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.weightedBox);
            this.Controls.Add(this.bannerPicture);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PodForm";
            this.Text = "Pod Operational Tool";
            ((System.ComponentModel.ISupportInitialize)(this.bannerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayedTable)).EndInit();
            this.modePanel.ResumeLayout(false);
            this.modePanel.PerformLayout();
            this.shiftPanel.ResumeLayout(false);
            this.shiftPanel.PerformLayout();
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button syncButton;
        private System.Windows.Forms.CheckBox editBox;
        private System.Windows.Forms.CheckBox effectiveBox;
        private System.Windows.Forms.CheckBox tdyBox;
        private System.Windows.Forms.CheckBox weightedBox;
        private System.Windows.Forms.ComboBox aircraftInput;
        private System.Windows.Forms.ComboBox codeInput;
        private System.Windows.Forms.ComboBox rangeInput;
        private System.Windows.Forms.ComboBox stationInput;
        private System.Windows.Forms.ComboBox torqueInput;
        private System.Windows.Forms.ComboBox unitInput;
        private System.Windows.Forms.DataGridView displayedTable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Done;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NotEffective;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TDY;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Weighted;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AircraftStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn AircraftType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConditionCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DRDNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PodNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Range;
        private System.Windows.Forms.DataGridViewTextBoxColumn Station;
        private System.Windows.Forms.DataGridViewTextBoxColumn TailNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn TorqueWrench;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkShift;
        private System.Windows.Forms.Label aircraftLabel;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label drdnoLabel;
        private System.Windows.Forms.Label podnoLabel;
        private System.Windows.Forms.Label programTitle;
        private System.Windows.Forms.Label rangeLabel;
        private System.Windows.Forms.Label shiftLabel;
        private System.Windows.Forms.Label stationLabel;
        private System.Windows.Forms.Label tailnoLabel;
        private System.Windows.Forms.Label torqueLabel;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.Panel modePanel;
        private System.Windows.Forms.Panel shiftPanel;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.PictureBox bannerPicture;
        private System.Windows.Forms.ProgressBar syncBar;
        private System.Windows.Forms.RadioButton downloadingButton;
        private System.Windows.Forms.RadioButton shift1Button;
        private System.Windows.Forms.RadioButton shift2Button;
        private System.Windows.Forms.RadioButton shift3Button;
        private System.Windows.Forms.RadioButton shift4Button;
        private System.Windows.Forms.RadioButton statusmreqButton;
        private System.Windows.Forms.RadioButton statussprButton;
        private System.Windows.Forms.RadioButton uploadingButton;
        private System.Windows.Forms.TextBox commentBox;
        private System.Windows.Forms.TextBox drdnoInput;
        private System.Windows.Forms.TextBox podnoInput;
        private System.Windows.Forms.TextBox tailnoInput;
    }
}

