namespace Pokemon_RNG_Time_Calculator
{
    public partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.oldGenRadioButton = new System.Windows.Forms.RadioButton();
            this.gen7RadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.gen6RadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timeOutputBox = new System.Windows.Forms.TextBox();
            this.numberofnpcsLabel = new System.Windows.Forms.Label();
            this.npcCountLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fidgetCheckBox = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.targetFrameBox = new System.Windows.Forms.NumericUpDown();
            this.startingFrameBox = new System.Windows.Forms.NumericUpDown();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.oldGenLabel = new System.Windows.Forms.Label();
            this.npcCount = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetFrameBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingFrameBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gen 6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gen 7";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.oldGenRadioButton);
            this.groupBox1.Controls.Add(this.gen7RadioButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.gen6RadioButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 111);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generation";
            // 
            // oldGenRadioButton
            // 
            this.oldGenRadioButton.AutoSize = true;
            this.oldGenRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oldGenRadioButton.Location = new System.Drawing.Point(117, 86);
            this.oldGenRadioButton.Name = "oldGenRadioButton";
            this.oldGenRadioButton.Size = new System.Drawing.Size(17, 16);
            this.oldGenRadioButton.TabIndex = 6;
            this.oldGenRadioButton.UseVisualStyleBackColor = true;
            this.oldGenRadioButton.CheckedChanged += new System.EventHandler(this.oldGenRadioButton_CheckedChanged);
            // 
            // gen7RadioButton
            // 
            this.gen7RadioButton.AutoSize = true;
            this.gen7RadioButton.Checked = true;
            this.gen7RadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gen7RadioButton.Location = new System.Drawing.Point(117, 26);
            this.gen7RadioButton.Name = "gen7RadioButton";
            this.gen7RadioButton.Size = new System.Drawing.Size(17, 16);
            this.gen7RadioButton.TabIndex = 4;
            this.gen7RadioButton.TabStop = true;
            this.gen7RadioButton.UseVisualStyleBackColor = true;
            this.gen7RadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Older Gens";
            // 
            // gen6RadioButton
            // 
            this.gen6RadioButton.AutoSize = true;
            this.gen6RadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gen6RadioButton.Location = new System.Drawing.Point(117, 57);
            this.gen6RadioButton.Name = "gen6RadioButton";
            this.gen6RadioButton.Size = new System.Drawing.Size(17, 16);
            this.gen6RadioButton.TabIndex = 5;
            this.gen6RadioButton.UseVisualStyleBackColor = true;
            this.gen6RadioButton.CheckedChanged += new System.EventHandler(this.gen6RadioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.timeOutputBox);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 206);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // timeOutputBox
            // 
            this.timeOutputBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.timeOutputBox.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeOutputBox.Location = new System.Drawing.Point(6, 22);
            this.timeOutputBox.Multiline = true;
            this.timeOutputBox.Name = "timeOutputBox";
            this.timeOutputBox.ReadOnly = true;
            this.timeOutputBox.Size = new System.Drawing.Size(356, 178);
            this.timeOutputBox.TabIndex = 3;
            // 
            // numberofnpcsLabel
            // 
            this.numberofnpcsLabel.AutoSize = true;
            this.numberofnpcsLabel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberofnpcsLabel.Location = new System.Drawing.Point(18, 154);
            this.numberofnpcsLabel.Name = "numberofnpcsLabel";
            this.numberofnpcsLabel.Size = new System.Drawing.Size(84, 40);
            this.numberofnpcsLabel.TabIndex = 4;
            this.numberofnpcsLabel.Text = "Number \r\nof NPCs";
            // 
            // npcCountLabel
            // 
            this.npcCountLabel.AutoSize = true;
            this.npcCountLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npcCountLabel.Location = new System.Drawing.Point(168, 12);
            this.npcCountLabel.Name = "npcCountLabel";
            this.npcCountLabel.Size = new System.Drawing.Size(231, 153);
            this.npcCountLabel.TabIndex = 5;
            this.npcCountLabel.Text = resources.GetString("npcCountLabel.Text");
            this.npcCountLabel.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Help;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fidget?";
            this.toolTip1.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // fidgetCheckBox
            // 
            this.fidgetCheckBox.AutoSize = true;
            this.fidgetCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fidgetCheckBox.Location = new System.Drawing.Point(128, 131);
            this.fidgetCheckBox.Name = "fidgetCheckBox";
            this.fidgetCheckBox.Size = new System.Drawing.Size(18, 17);
            this.fidgetCheckBox.TabIndex = 7;
            this.fidgetCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.targetFrameBox);
            this.groupBox3.Controls.Add(this.startingFrameBox);
            this.groupBox3.Controls.Add(this.calculateButton);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 94);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parameters";
            // 
            // targetFrameBox
            // 
            this.targetFrameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.targetFrameBox.Location = new System.Drawing.Point(3, 50);
            this.targetFrameBox.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.targetFrameBox.Name = "targetFrameBox";
            this.targetFrameBox.Size = new System.Drawing.Size(147, 22);
            this.targetFrameBox.TabIndex = 14;
            this.targetFrameBox.ValueChanged += new System.EventHandler(this.targetFrameBox_ValueChanged);
            // 
            // startingFrameBox
            // 
            this.startingFrameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.startingFrameBox.Location = new System.Drawing.Point(3, 18);
            this.startingFrameBox.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.startingFrameBox.Name = "startingFrameBox";
            this.startingFrameBox.Size = new System.Drawing.Size(147, 22);
            this.startingFrameBox.TabIndex = 13;
            this.startingFrameBox.Value = new decimal(new int[] {
            478,
            0,
            0,
            0});
            this.startingFrameBox.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(275, 21);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(87, 56);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Calculate!";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(156, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Target Frame";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(156, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Starting Frame";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // oldGenLabel
            // 
            this.oldGenLabel.AutoSize = true;
            this.oldGenLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldGenLabel.Location = new System.Drawing.Point(168, 12);
            this.oldGenLabel.Name = "oldGenLabel";
            this.oldGenLabel.Size = new System.Drawing.Size(209, 187);
            this.oldGenLabel.TabIndex = 9;
            this.oldGenLabel.Text = resources.GetString("oldGenLabel.Text");
            this.oldGenLabel.Visible = false;
            this.oldGenLabel.Click += new System.EventHandler(this.label5_Click_2);
            // 
            // npcCount
            // 
            this.npcCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.npcCount.Location = new System.Drawing.Point(100, 172);
            this.npcCount.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.npcCount.Name = "npcCount";
            this.npcCount.Size = new System.Drawing.Size(46, 22);
            this.npcCount.TabIndex = 10;
            this.npcCount.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(392, 518);
            this.Controls.Add(this.npcCount);
            this.Controls.Add(this.oldGenLabel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.fidgetCheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.npcCountLabel);
            this.Controls.Add(this.numberofnpcsLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pokemon RNG Time Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetFrameBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingFrameBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton oldGenRadioButton;
        private System.Windows.Forms.RadioButton gen6RadioButton;
        private System.Windows.Forms.RadioButton gen7RadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox timeOutputBox;
        private System.Windows.Forms.Label numberofnpcsLabel;
        private System.Windows.Forms.Label npcCountLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox fidgetCheckBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label oldGenLabel;
        public System.Windows.Forms.NumericUpDown targetFrameBox;
        public System.Windows.Forms.NumericUpDown startingFrameBox;
        private System.Windows.Forms.NumericUpDown npcCount;
    }
}

