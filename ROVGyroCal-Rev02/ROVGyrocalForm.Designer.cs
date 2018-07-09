namespace ROVGyroCal_Rev02
{
    partial class ROVGyrocalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ROVGyrocalForm));
            this.ROVMeasuremetnGroupBox = new System.Windows.Forms.GroupBox();
            this.BaselineMeasurementTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ROVAftMeasurementTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ROVFwdMeasurementTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ReferenceToROVGroupBox = new System.Windows.Forms.GroupBox();
            this.ReferenceToROVStbdRadioButton = new System.Windows.Forms.RadioButton();
            this.ReferenceToROVPortRadioButton = new System.Windows.Forms.RadioButton();
            this.FormLabel = new System.Windows.Forms.Label();
            this.ROVDirectionGroupBox = new System.Windows.Forms.GroupBox();
            this.ROVPortRadioButton = new System.Windows.Forms.RadioButton();
            this.ROVAftRadioButton = new System.Windows.Forms.RadioButton();
            this.ROVStbdRadioButton = new System.Windows.Forms.RadioButton();
            this.ROVFwdRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.useDefaultsButton = new System.Windows.Forms.Button();
            this.rowsToSkipTextBox = new System.Windows.Forms.TextBox();
            this.vesselHDGColumnTextBox = new System.Windows.Forms.TextBox();
            this.ROVHDGColumnTextBox = new System.Windows.Forms.TextBox();
            this.RowsToSkipLabel = new System.Windows.Forms.Label();
            this.AHVHDGColumnLabel = new System.Windows.Forms.Label();
            this.ROVHDGColumnLabel = new System.Windows.Forms.Label();
            this.ChooseCSVButton = new System.Windows.Forms.Button();
            this.FilePreviewTextBox = new System.Windows.Forms.TextBox();
            this.ResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.CopyOutputButton = new System.Windows.Forms.Button();
            this.ComputeButton = new System.Windows.Forms.Button();
            this.AverageComputedROVHDGTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AverageCMinusOTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AverageROVHDGTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ObservationsTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AverageVesselHDGTextBox = new System.Windows.Forms.TextBox();
            this.ROVToVesselLabel = new System.Windows.Forms.Label();
            this.ROVToBaselineResultsTextBox = new System.Windows.Forms.TextBox();
            this.ROVToBaselineLabel = new System.Windows.Forms.Label();
            this.openCSVFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ROVFWDToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ROVAftToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BaselineToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.LoadCSVToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ROVDirectionToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.RefLineToROVToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.RowsToSkipToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ROVHDGColumnToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.VesselHDGColumnToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.UseDefaultsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ComputeButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CopyToClipboardButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ROVMeasuremetnGroupBox.SuspendLayout();
            this.ReferenceToROVGroupBox.SuspendLayout();
            this.ROVDirectionGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ResultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ROVMeasuremetnGroupBox
            // 
            this.ROVMeasuremetnGroupBox.Controls.Add(this.BaselineMeasurementTextBox);
            this.ROVMeasuremetnGroupBox.Controls.Add(this.label4);
            this.ROVMeasuremetnGroupBox.Controls.Add(this.ROVAftMeasurementTextBox);
            this.ROVMeasuremetnGroupBox.Controls.Add(this.label3);
            this.ROVMeasuremetnGroupBox.Controls.Add(this.ROVFwdMeasurementTextBox);
            this.ROVMeasuremetnGroupBox.Controls.Add(this.label2);
            this.ROVMeasuremetnGroupBox.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ROVMeasuremetnGroupBox.Location = new System.Drawing.Point(399, 24);
            this.ROVMeasuremetnGroupBox.Name = "ROVMeasuremetnGroupBox";
            this.ROVMeasuremetnGroupBox.Size = new System.Drawing.Size(203, 154);
            this.ROVMeasuremetnGroupBox.TabIndex = 21;
            this.ROVMeasuremetnGroupBox.TabStop = false;
            this.ROVMeasuremetnGroupBox.Text = "ROV Measurements";
            // 
            // BaselineMeasurementTextBox
            // 
            this.BaselineMeasurementTextBox.Location = new System.Drawing.Point(99, 110);
            this.BaselineMeasurementTextBox.Name = "BaselineMeasurementTextBox";
            this.BaselineMeasurementTextBox.Size = new System.Drawing.Size(98, 33);
            this.BaselineMeasurementTextBox.TabIndex = 3;
            this.BaselineMeasurementTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BaselineMeasurementTextBox.Enter += new System.EventHandler(this.BaselineMeasurementTextBox_Enter);
            this.BaselineMeasurementTextBox.MouseEnter += new System.EventHandler(this.BaselineMeasurementTextBox_MouseEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Baseline";
            // 
            // ROVAftMeasurementTextBox
            // 
            this.ROVAftMeasurementTextBox.Location = new System.Drawing.Point(99, 71);
            this.ROVAftMeasurementTextBox.Name = "ROVAftMeasurementTextBox";
            this.ROVAftMeasurementTextBox.Size = new System.Drawing.Size(98, 33);
            this.ROVAftMeasurementTextBox.TabIndex = 2;
            this.ROVAftMeasurementTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ROVAftMeasurementTextBox.Enter += new System.EventHandler(this.ROVAftMeasurementTextBox_Enter);
            this.ROVAftMeasurementTextBox.MouseEnter += new System.EventHandler(this.ROVAftMeasurementTextBox_MouseEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "ROV Aft";
            // 
            // ROVFwdMeasurementTextBox
            // 
            this.ROVFwdMeasurementTextBox.Location = new System.Drawing.Point(99, 32);
            this.ROVFwdMeasurementTextBox.Name = "ROVFwdMeasurementTextBox";
            this.ROVFwdMeasurementTextBox.Size = new System.Drawing.Size(98, 33);
            this.ROVFwdMeasurementTextBox.TabIndex = 1;
            this.ROVFwdMeasurementTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ROVFwdMeasurementTextBox.Enter += new System.EventHandler(this.ROVFwdMeasurementTextBox_Enter);
            this.ROVFwdMeasurementTextBox.MouseEnter += new System.EventHandler(this.ROVFwdMeasurementTextBox_MouseEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "ROV Fwd";
            // 
            // ReferenceToROVGroupBox
            // 
            this.ReferenceToROVGroupBox.Controls.Add(this.ReferenceToROVStbdRadioButton);
            this.ReferenceToROVGroupBox.Controls.Add(this.ReferenceToROVPortRadioButton);
            this.ReferenceToROVGroupBox.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferenceToROVGroupBox.Location = new System.Drawing.Point(202, 24);
            this.ReferenceToROVGroupBox.Name = "ReferenceToROVGroupBox";
            this.ReferenceToROVGroupBox.Size = new System.Drawing.Size(187, 116);
            this.ReferenceToROVGroupBox.TabIndex = 20;
            this.ReferenceToROVGroupBox.TabStop = false;
            this.ReferenceToROVGroupBox.Text = "Reference Line to ROV";
            this.ReferenceToROVGroupBox.MouseHover += new System.EventHandler(this.ReferenceToROVGroupBox_MouseHover);
            // 
            // ReferenceToROVStbdRadioButton
            // 
            this.ReferenceToROVStbdRadioButton.AutoSize = true;
            this.ReferenceToROVStbdRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferenceToROVStbdRadioButton.Location = new System.Drawing.Point(9, 80);
            this.ReferenceToROVStbdRadioButton.Name = "ReferenceToROVStbdRadioButton";
            this.ReferenceToROVStbdRadioButton.Size = new System.Drawing.Size(87, 23);
            this.ReferenceToROVStbdRadioButton.TabIndex = 3;
            this.ReferenceToROVStbdRadioButton.Text = "Starboard";
            this.ReferenceToROVStbdRadioButton.UseVisualStyleBackColor = true;
            // 
            // ReferenceToROVPortRadioButton
            // 
            this.ReferenceToROVPortRadioButton.AutoSize = true;
            this.ReferenceToROVPortRadioButton.Checked = true;
            this.ReferenceToROVPortRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferenceToROVPortRadioButton.Location = new System.Drawing.Point(9, 51);
            this.ReferenceToROVPortRadioButton.Name = "ReferenceToROVPortRadioButton";
            this.ReferenceToROVPortRadioButton.Size = new System.Drawing.Size(52, 23);
            this.ReferenceToROVPortRadioButton.TabIndex = 2;
            this.ReferenceToROVPortRadioButton.TabStop = true;
            this.ReferenceToROVPortRadioButton.Text = "Port";
            this.ReferenceToROVPortRadioButton.UseVisualStyleBackColor = true;
            // 
            // FormLabel
            // 
            this.FormLabel.AutoSize = true;
            this.FormLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormLabel.Location = new System.Drawing.Point(204, 15);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(215, 32);
            this.FormLabel.TabIndex = 19;
            this.FormLabel.Text = "ROV Gyrocal Tool";
            // 
            // ROVDirectionGroupBox
            // 
            this.ROVDirectionGroupBox.Controls.Add(this.ROVPortRadioButton);
            this.ROVDirectionGroupBox.Controls.Add(this.ROVAftRadioButton);
            this.ROVDirectionGroupBox.Controls.Add(this.ROVStbdRadioButton);
            this.ROVDirectionGroupBox.Controls.Add(this.ROVFwdRadioButton);
            this.ROVDirectionGroupBox.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ROVDirectionGroupBox.Location = new System.Drawing.Point(22, 24);
            this.ROVDirectionGroupBox.Name = "ROVDirectionGroupBox";
            this.ROVDirectionGroupBox.Size = new System.Drawing.Size(174, 154);
            this.ROVDirectionGroupBox.TabIndex = 18;
            this.ROVDirectionGroupBox.TabStop = false;
            this.ROVDirectionGroupBox.Text = "ROV Direction";
            this.ROVDirectionGroupBox.MouseHover += new System.EventHandler(this.ROVDirectionGroupBox_MouseHover);
            // 
            // ROVPortRadioButton
            // 
            this.ROVPortRadioButton.AutoSize = true;
            this.ROVPortRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ROVPortRadioButton.Location = new System.Drawing.Point(7, 119);
            this.ROVPortRadioButton.Name = "ROVPortRadioButton";
            this.ROVPortRadioButton.Size = new System.Drawing.Size(52, 23);
            this.ROVPortRadioButton.TabIndex = 3;
            this.ROVPortRadioButton.Text = "Port";
            this.ROVPortRadioButton.UseVisualStyleBackColor = true;
            // 
            // ROVAftRadioButton
            // 
            this.ROVAftRadioButton.AutoSize = true;
            this.ROVAftRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ROVAftRadioButton.Location = new System.Drawing.Point(7, 90);
            this.ROVAftRadioButton.Name = "ROVAftRadioButton";
            this.ROVAftRadioButton.Size = new System.Drawing.Size(45, 23);
            this.ROVAftRadioButton.TabIndex = 2;
            this.ROVAftRadioButton.Text = "Aft";
            this.ROVAftRadioButton.UseVisualStyleBackColor = true;
            // 
            // ROVStbdRadioButton
            // 
            this.ROVStbdRadioButton.AutoSize = true;
            this.ROVStbdRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ROVStbdRadioButton.Location = new System.Drawing.Point(7, 61);
            this.ROVStbdRadioButton.Name = "ROVStbdRadioButton";
            this.ROVStbdRadioButton.Size = new System.Drawing.Size(87, 23);
            this.ROVStbdRadioButton.TabIndex = 1;
            this.ROVStbdRadioButton.Text = "Starboard";
            this.ROVStbdRadioButton.UseVisualStyleBackColor = true;
            // 
            // ROVFwdRadioButton
            // 
            this.ROVFwdRadioButton.AutoSize = true;
            this.ROVFwdRadioButton.Checked = true;
            this.ROVFwdRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ROVFwdRadioButton.Location = new System.Drawing.Point(7, 32);
            this.ROVFwdRadioButton.Name = "ROVFwdRadioButton";
            this.ROVFwdRadioButton.Size = new System.Drawing.Size(77, 23);
            this.ROVFwdRadioButton.TabIndex = 0;
            this.ROVFwdRadioButton.TabStop = true;
            this.ROVFwdRadioButton.Text = "Forward";
            this.ROVFwdRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ReferenceToROVGroupBox);
            this.groupBox1.Controls.Add(this.ROVDirectionGroupBox);
            this.groupBox1.Controls.Add(this.ROVMeasuremetnGroupBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 187);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vessel Configuration";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.useDefaultsButton);
            this.groupBox2.Controls.Add(this.rowsToSkipTextBox);
            this.groupBox2.Controls.Add(this.vesselHDGColumnTextBox);
            this.groupBox2.Controls.Add(this.ROVHDGColumnTextBox);
            this.groupBox2.Controls.Add(this.RowsToSkipLabel);
            this.groupBox2.Controls.Add(this.AHVHDGColumnLabel);
            this.groupBox2.Controls.Add(this.ROVHDGColumnLabel);
            this.groupBox2.Controls.Add(this.ChooseCSVButton);
            this.groupBox2.Controls.Add(this.FilePreviewTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 215);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Configuration";
            // 
            // useDefaultsButton
            // 
            this.useDefaultsButton.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useDefaultsButton.Location = new System.Drawing.Point(504, 34);
            this.useDefaultsButton.Name = "useDefaultsButton";
            this.useDefaultsButton.Size = new System.Drawing.Size(104, 58);
            this.useDefaultsButton.TabIndex = 7;
            this.useDefaultsButton.Text = "Use Defaults";
            this.useDefaultsButton.UseVisualStyleBackColor = true;
            this.useDefaultsButton.Click += new System.EventHandler(this.useDefaultsButton_Click);
            this.useDefaultsButton.MouseEnter += new System.EventHandler(this.useDefaultsButton_MouseEnter);
            // 
            // rowsToSkipTextBox
            // 
            this.rowsToSkipTextBox.Location = new System.Drawing.Point(135, 60);
            this.rowsToSkipTextBox.Name = "rowsToSkipTextBox";
            this.rowsToSkipTextBox.Size = new System.Drawing.Size(89, 33);
            this.rowsToSkipTextBox.TabIndex = 4;
            this.rowsToSkipTextBox.Text = "1";
            this.rowsToSkipTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rowsToSkipTextBox.Enter += new System.EventHandler(this.rowsToSkipTextBox_Enter);
            this.rowsToSkipTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rowsToSkipTextBox_KeyPress);
            this.rowsToSkipTextBox.MouseEnter += new System.EventHandler(this.rowsToSkipTextBox_MouseEnter);
            // 
            // vesselHDGColumnTextBox
            // 
            this.vesselHDGColumnTextBox.Location = new System.Drawing.Point(369, 60);
            this.vesselHDGColumnTextBox.Name = "vesselHDGColumnTextBox";
            this.vesselHDGColumnTextBox.Size = new System.Drawing.Size(120, 33);
            this.vesselHDGColumnTextBox.TabIndex = 6;
            this.vesselHDGColumnTextBox.Text = "3";
            this.vesselHDGColumnTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.vesselHDGColumnTextBox.Enter += new System.EventHandler(this.vesselHDGColumnTextBox_Enter);
            this.vesselHDGColumnTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vesselHDGColumnTextBox_KeyPress);
            this.vesselHDGColumnTextBox.MouseEnter += new System.EventHandler(this.vesselHDGColumnTextBox_MouseEnter);
            // 
            // ROVHDGColumnTextBox
            // 
            this.ROVHDGColumnTextBox.Location = new System.Drawing.Point(237, 60);
            this.ROVHDGColumnTextBox.Name = "ROVHDGColumnTextBox";
            this.ROVHDGColumnTextBox.Size = new System.Drawing.Size(110, 33);
            this.ROVHDGColumnTextBox.TabIndex = 5;
            this.ROVHDGColumnTextBox.Text = "2";
            this.ROVHDGColumnTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ROVHDGColumnTextBox.Enter += new System.EventHandler(this.ROVHDGColumnTextBox_Enter);
            this.ROVHDGColumnTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ROVHDGColumnTextBox_KeyPress);
            this.ROVHDGColumnTextBox.MouseEnter += new System.EventHandler(this.ROVHDGColumnTextBox_MouseEnter);
            // 
            // RowsToSkipLabel
            // 
            this.RowsToSkipLabel.AutoSize = true;
            this.RowsToSkipLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RowsToSkipLabel.Location = new System.Drawing.Point(136, 34);
            this.RowsToSkipLabel.Name = "RowsToSkipLabel";
            this.RowsToSkipLabel.Size = new System.Drawing.Size(83, 17);
            this.RowsToSkipLabel.TabIndex = 30;
            this.RowsToSkipLabel.Text = "Rows to Skip";
            // 
            // AHVHDGColumnLabel
            // 
            this.AHVHDGColumnLabel.AutoSize = true;
            this.AHVHDGColumnLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AHVHDGColumnLabel.Location = new System.Drawing.Point(368, 34);
            this.AHVHDGColumnLabel.Name = "AHVHDGColumnLabel";
            this.AHVHDGColumnLabel.Size = new System.Drawing.Size(123, 17);
            this.AHVHDGColumnLabel.TabIndex = 28;
            this.AHVHDGColumnLabel.Text = "Vessel HDG Column";
            // 
            // ROVHDGColumnLabel
            // 
            this.ROVHDGColumnLabel.AutoSize = true;
            this.ROVHDGColumnLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ROVHDGColumnLabel.Location = new System.Drawing.Point(236, 34);
            this.ROVHDGColumnLabel.Name = "ROVHDGColumnLabel";
            this.ROVHDGColumnLabel.Size = new System.Drawing.Size(113, 17);
            this.ROVHDGColumnLabel.TabIndex = 26;
            this.ROVHDGColumnLabel.Text = "ROV HDG Column";
            // 
            // ChooseCSVButton
            // 
            this.ChooseCSVButton.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseCSVButton.Location = new System.Drawing.Point(11, 34);
            this.ChooseCSVButton.Name = "ChooseCSVButton";
            this.ChooseCSVButton.Size = new System.Drawing.Size(104, 58);
            this.ChooseCSVButton.TabIndex = 8;
            this.ChooseCSVButton.Text = "Load CSV File";
            this.ChooseCSVButton.UseVisualStyleBackColor = true;
            this.ChooseCSVButton.Click += new System.EventHandler(this.ChooseCSVButton_Click);
            this.ChooseCSVButton.MouseEnter += new System.EventHandler(this.ChooseCSVButton_MouseEnter);
            // 
            // FilePreviewTextBox
            // 
            this.FilePreviewTextBox.BackColor = System.Drawing.Color.Black;
            this.FilePreviewTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilePreviewTextBox.ForeColor = System.Drawing.Color.Lime;
            this.FilePreviewTextBox.Location = new System.Drawing.Point(5, 102);
            this.FilePreviewTextBox.Multiline = true;
            this.FilePreviewTextBox.Name = "FilePreviewTextBox";
            this.FilePreviewTextBox.ReadOnly = true;
            this.FilePreviewTextBox.Size = new System.Drawing.Size(612, 107);
            this.FilePreviewTextBox.TabIndex = 13;
            // 
            // ResultsGroupBox
            // 
            this.ResultsGroupBox.Controls.Add(this.CopyOutputButton);
            this.ResultsGroupBox.Controls.Add(this.ComputeButton);
            this.ResultsGroupBox.Controls.Add(this.AverageComputedROVHDGTextBox);
            this.ResultsGroupBox.Controls.Add(this.label7);
            this.ResultsGroupBox.Controls.Add(this.AverageCMinusOTextBox);
            this.ResultsGroupBox.Controls.Add(this.label8);
            this.ResultsGroupBox.Controls.Add(this.AverageROVHDGTextBox);
            this.ResultsGroupBox.Controls.Add(this.label9);
            this.ResultsGroupBox.Controls.Add(this.ObservationsTextBox);
            this.ResultsGroupBox.Controls.Add(this.label10);
            this.ResultsGroupBox.Controls.Add(this.AverageVesselHDGTextBox);
            this.ResultsGroupBox.Controls.Add(this.ROVToVesselLabel);
            this.ResultsGroupBox.Controls.Add(this.ROVToBaselineResultsTextBox);
            this.ResultsGroupBox.Controls.Add(this.ROVToBaselineLabel);
            this.ResultsGroupBox.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultsGroupBox.Location = new System.Drawing.Point(13, 458);
            this.ResultsGroupBox.Name = "ResultsGroupBox";
            this.ResultsGroupBox.Size = new System.Drawing.Size(623, 228);
            this.ResultsGroupBox.TabIndex = 25;
            this.ResultsGroupBox.TabStop = false;
            this.ResultsGroupBox.Text = "Results";
            // 
            // CopyOutputButton
            // 
            this.CopyOutputButton.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyOutputButton.Location = new System.Drawing.Point(477, 142);
            this.CopyOutputButton.Name = "CopyOutputButton";
            this.CopyOutputButton.Size = new System.Drawing.Size(124, 57);
            this.CopyOutputButton.TabIndex = 10;
            this.CopyOutputButton.Text = "Copy output to Clipboard";
            this.CopyOutputButton.UseVisualStyleBackColor = true;
            this.CopyOutputButton.Click += new System.EventHandler(this.CopyOutputButton_Click);
            this.CopyOutputButton.MouseEnter += new System.EventHandler(this.CopyOutputButton_MouseEnter);
            // 
            // ComputeButton
            // 
            this.ComputeButton.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputeButton.Location = new System.Drawing.Point(477, 71);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(124, 44);
            this.ComputeButton.TabIndex = 9;
            this.ComputeButton.Text = "Compute";
            this.ComputeButton.UseVisualStyleBackColor = true;
            this.ComputeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            this.ComputeButton.MouseEnter += new System.EventHandler(this.ComputeButton_MouseEnter);
            // 
            // AverageComputedROVHDGTextBox
            // 
            this.AverageComputedROVHDGTextBox.Enabled = false;
            this.AverageComputedROVHDGTextBox.Location = new System.Drawing.Point(44, 184);
            this.AverageComputedROVHDGTextBox.Name = "AverageComputedROVHDGTextBox";
            this.AverageComputedROVHDGTextBox.Size = new System.Drawing.Size(134, 33);
            this.AverageComputedROVHDGTextBox.TabIndex = 11;
            this.AverageComputedROVHDGTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Average Computed ROV Heading";
            // 
            // AverageCMinusOTextBox
            // 
            this.AverageCMinusOTextBox.Enabled = false;
            this.AverageCMinusOTextBox.Location = new System.Drawing.Point(287, 51);
            this.AverageCMinusOTextBox.Name = "AverageCMinusOTextBox";
            this.AverageCMinusOTextBox.Size = new System.Drawing.Size(134, 33);
            this.AverageCMinusOTextBox.TabIndex = 9;
            this.AverageCMinusOTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(301, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Average C - O";
            // 
            // AverageROVHDGTextBox
            // 
            this.AverageROVHDGTextBox.Enabled = false;
            this.AverageROVHDGTextBox.Location = new System.Drawing.Point(44, 118);
            this.AverageROVHDGTextBox.Name = "AverageROVHDGTextBox";
            this.AverageROVHDGTextBox.Size = new System.Drawing.Size(134, 33);
            this.AverageROVHDGTextBox.TabIndex = 7;
            this.AverageROVHDGTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 19);
            this.label9.TabIndex = 6;
            this.label9.Text = "Average Observed ROV Heading";
            // 
            // ObservationsTextBox
            // 
            this.ObservationsTextBox.Enabled = false;
            this.ObservationsTextBox.Location = new System.Drawing.Point(44, 51);
            this.ObservationsTextBox.Name = "ObservationsTextBox";
            this.ObservationsTextBox.Size = new System.Drawing.Size(134, 33);
            this.ObservationsTextBox.TabIndex = 5;
            this.ObservationsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(60, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 19);
            this.label10.TabIndex = 4;
            this.label10.Text = "# Observations";
            // 
            // AverageVesselHDGTextBox
            // 
            this.AverageVesselHDGTextBox.Enabled = false;
            this.AverageVesselHDGTextBox.Location = new System.Drawing.Point(287, 184);
            this.AverageVesselHDGTextBox.Name = "AverageVesselHDGTextBox";
            this.AverageVesselHDGTextBox.Size = new System.Drawing.Size(134, 33);
            this.AverageVesselHDGTextBox.TabIndex = 3;
            this.AverageVesselHDGTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ROVToVesselLabel
            // 
            this.ROVToVesselLabel.AutoSize = true;
            this.ROVToVesselLabel.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ROVToVesselLabel.Location = new System.Drawing.Point(245, 162);
            this.ROVToVesselLabel.Name = "ROVToVesselLabel";
            this.ROVToVesselLabel.Size = new System.Drawing.Size(218, 19);
            this.ROVToVesselLabel.TabIndex = 2;
            this.ROVToVesselLabel.Text = "Average Observed Vessel Heading";
            // 
            // ROVToBaselineResultsTextBox
            // 
            this.ROVToBaselineResultsTextBox.Enabled = false;
            this.ROVToBaselineResultsTextBox.Location = new System.Drawing.Point(287, 118);
            this.ROVToBaselineResultsTextBox.Name = "ROVToBaselineResultsTextBox";
            this.ROVToBaselineResultsTextBox.Size = new System.Drawing.Size(134, 33);
            this.ROVToBaselineResultsTextBox.TabIndex = 1;
            this.ROVToBaselineResultsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ROVToBaselineLabel
            // 
            this.ROVToBaselineLabel.AutoSize = true;
            this.ROVToBaselineLabel.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ROVToBaselineLabel.Location = new System.Drawing.Point(301, 96);
            this.ROVToBaselineLabel.Name = "ROVToBaselineLabel";
            this.ROVToBaselineLabel.Size = new System.Drawing.Size(107, 19);
            this.ROVToBaselineLabel.TabIndex = 0;
            this.ROVToBaselineLabel.Text = "ROV to Baseline";
            // 
            // openCSVFileDialog
            // 
            this.openCSVFileDialog.FileName = "openFileDialog1";
            // 
            // ROVGyrocalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 698);
            this.Controls.Add(this.ResultsGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FormLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ROVGyrocalForm";
            this.Text = "ROV Gyrocal Tool - V1.0 ";
            this.ROVMeasuremetnGroupBox.ResumeLayout(false);
            this.ROVMeasuremetnGroupBox.PerformLayout();
            this.ReferenceToROVGroupBox.ResumeLayout(false);
            this.ReferenceToROVGroupBox.PerformLayout();
            this.ROVDirectionGroupBox.ResumeLayout(false);
            this.ROVDirectionGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResultsGroupBox.ResumeLayout(false);
            this.ResultsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ROVMeasuremetnGroupBox;
        private System.Windows.Forms.TextBox BaselineMeasurementTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ROVAftMeasurementTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ROVFwdMeasurementTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox ReferenceToROVGroupBox;
        private System.Windows.Forms.RadioButton ReferenceToROVStbdRadioButton;
        private System.Windows.Forms.RadioButton ReferenceToROVPortRadioButton;
        private System.Windows.Forms.Label FormLabel;
        private System.Windows.Forms.GroupBox ROVDirectionGroupBox;
        private System.Windows.Forms.RadioButton ROVPortRadioButton;
        private System.Windows.Forms.RadioButton ROVAftRadioButton;
        private System.Windows.Forms.RadioButton ROVStbdRadioButton;
        private System.Windows.Forms.RadioButton ROVFwdRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label RowsToSkipLabel;
        private System.Windows.Forms.Label AHVHDGColumnLabel;
        private System.Windows.Forms.Label ROVHDGColumnLabel;
        private System.Windows.Forms.Button ChooseCSVButton;
        private System.Windows.Forms.TextBox FilePreviewTextBox;
        private System.Windows.Forms.GroupBox ResultsGroupBox;
        private System.Windows.Forms.Button CopyOutputButton;
        private System.Windows.Forms.Button ComputeButton;
        private System.Windows.Forms.TextBox AverageComputedROVHDGTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AverageCMinusOTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AverageROVHDGTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ObservationsTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox AverageVesselHDGTextBox;
        private System.Windows.Forms.Label ROVToVesselLabel;
        private System.Windows.Forms.TextBox ROVToBaselineResultsTextBox;
        private System.Windows.Forms.Label ROVToBaselineLabel;
        private System.Windows.Forms.OpenFileDialog openCSVFileDialog;
        private System.Windows.Forms.TextBox rowsToSkipTextBox;
        private System.Windows.Forms.TextBox vesselHDGColumnTextBox;
        private System.Windows.Forms.TextBox ROVHDGColumnTextBox;
        private System.Windows.Forms.Button useDefaultsButton;
        private System.Windows.Forms.ToolTip ROVFWDToolTip;
        private System.Windows.Forms.ToolTip ROVAftToolTip;
        private System.Windows.Forms.ToolTip BaselineToolTip;
        private System.Windows.Forms.ToolTip LoadCSVToolTip;
        private System.Windows.Forms.ToolTip ROVDirectionToolTip;
        private System.Windows.Forms.ToolTip RefLineToROVToolTip;
        private System.Windows.Forms.ToolTip RowsToSkipToolTip;
        private System.Windows.Forms.ToolTip ROVHDGColumnToolTip;
        private System.Windows.Forms.ToolTip VesselHDGColumnToolTip;
        private System.Windows.Forms.ToolTip UseDefaultsToolTip;
        private System.Windows.Forms.ToolTip ComputeButtonToolTip;
        private System.Windows.Forms.ToolTip CopyToClipboardButtonToolTip;
    }
}

