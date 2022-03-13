namespace TemperatureConversion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.CelsiusButton = new System.Windows.Forms.RadioButton();
            this.FarenheitButton = new System.Windows.Forms.RadioButton();
            this.InputLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.InputNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.InfoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ErrorToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.97059F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.02941F));
            this.tableLayoutPanel1.Controls.Add(this.ClearButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ConvertButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.CelsiusButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.FarenheitButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.InputLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.OutputLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.InputNumericUpDown, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ResultTextBox, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(329, 183);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // ClearButton
            // 
            this.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearButton.Location = new System.Drawing.Point(3, 137);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(122, 43);
            this.ClearButton.TabIndex = 0;
            this.ClearButton.Text = "Clear";
            this.InfoToolTip.SetToolTip(this.ClearButton, "Click this to reset result and input");
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ConvertButton
            // 
            this.ConvertButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConvertButton.Location = new System.Drawing.Point(131, 137);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(195, 43);
            this.ConvertButton.TabIndex = 1;
            this.ConvertButton.Text = "Convert";
            this.InfoToolTip.SetToolTip(this.ConvertButton, "Click this to start converting");
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // CelsiusButton
            // 
            this.CelsiusButton.AutoSize = true;
            this.CelsiusButton.Checked = true;
            this.CelsiusButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.CelsiusButton.Location = new System.Drawing.Point(131, 48);
            this.CelsiusButton.Name = "CelsiusButton";
            this.CelsiusButton.Size = new System.Drawing.Size(58, 16);
            this.CelsiusButton.TabIndex = 2;
            this.CelsiusButton.TabStop = true;
            this.CelsiusButton.Text = "Celsius";
            this.InfoToolTip.SetToolTip(this.CelsiusButton, "Choose this if you want to convert to Celsius");
            this.CelsiusButton.UseVisualStyleBackColor = true;
            this.CelsiusButton.CheckedChanged += new System.EventHandler(this.CelsiusButton_CheckedChanged);
            // 
            // FarenheitButton
            // 
            this.FarenheitButton.AutoSize = true;
            this.FarenheitButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.FarenheitButton.Location = new System.Drawing.Point(131, 70);
            this.FarenheitButton.Name = "FarenheitButton";
            this.FarenheitButton.Size = new System.Drawing.Size(69, 16);
            this.FarenheitButton.TabIndex = 3;
            this.FarenheitButton.Text = "Farenheit";
            this.InfoToolTip.SetToolTip(this.FarenheitButton, "Choose this if you want to convert to Farenheit");
            this.FarenheitButton.UseVisualStyleBackColor = true;
            this.FarenheitButton.CheckedChanged += new System.EventHandler(this.FarenheitButton_CheckedChanged);
            // 
            // InputLabel
            // 
            this.InputLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(71, 16);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(54, 13);
            this.InputLabel.TabIndex = 4;
            this.InputLabel.Text = "Farenheit:";
            this.InputLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Convert to:";
            // 
            // OutputLabel
            // 
            this.OutputLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(82, 105);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(43, 13);
            this.OutputLabel.TabIndex = 6;
            this.OutputLabel.Text = "Celsius:";
            // 
            // InputNumericUpDown
            // 
            this.InputNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InputNumericUpDown.DecimalPlaces = 2;
            this.InputNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.InputNumericUpDown.Location = new System.Drawing.Point(131, 12);
            this.InputNumericUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.InputNumericUpDown.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
            this.InputNumericUpDown.Name = "InputNumericUpDown";
            this.InputNumericUpDown.Size = new System.Drawing.Size(195, 20);
            this.InputNumericUpDown.TabIndex = 7;
            this.InfoToolTip.SetToolTip(this.InputNumericUpDown, "Enter the temperature here");
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.ResultTextBox.Location = new System.Drawing.Point(131, 101);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(195, 20);
            this.ResultTextBox.TabIndex = 8;
            this.InfoToolTip.SetToolTip(this.ResultTextBox, "This is the result");
            // 
            // ErrorToolTip
            // 
            this.ErrorToolTip.ForeColor = System.Drawing.Color.DarkRed;
            this.ErrorToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.ErrorToolTip.ToolTipTitle = "Error";
            // 
            // Form1
            // 
            this.AcceptButton = this.ConvertButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ClearButton;
            this.ClientSize = new System.Drawing.Size(329, 183);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Temperature Converter - Domenic Catalano";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.RadioButton CelsiusButton;
        private System.Windows.Forms.RadioButton FarenheitButton;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.NumericUpDown InputNumericUpDown;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.ToolTip InfoToolTip;
        private System.Windows.Forms.ToolTip ErrorToolTip;
    }
}

