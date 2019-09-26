namespace _14._7
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
            this.colorGroupBox = new System.Windows.Forms.GroupBox();
            this.blackButton = new System.Windows.Forms.RadioButton();
            this.greenButton = new System.Windows.Forms.RadioButton();
            this.blueButton = new System.Windows.Forms.RadioButton();
            this.redButton = new System.Windows.Forms.RadioButton();
            this.sizeGroupBox = new System.Windows.Forms.GroupBox();
            this.largeButton = new System.Windows.Forms.RadioButton();
            this.mediumButton = new System.Windows.Forms.RadioButton();
            this.smallButton = new System.Windows.Forms.RadioButton();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.colorGroupBox.SuspendLayout();
            this.sizeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.Controls.Add(this.blackButton);
            this.colorGroupBox.Controls.Add(this.greenButton);
            this.colorGroupBox.Controls.Add(this.blueButton);
            this.colorGroupBox.Controls.Add(this.redButton);
            this.colorGroupBox.Location = new System.Drawing.Point(51, 27);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Size = new System.Drawing.Size(137, 167);
            this.colorGroupBox.TabIndex = 0;
            this.colorGroupBox.TabStop = false;
            this.colorGroupBox.Text = "Color";
            // 
            // blackButton
            // 
            this.blackButton.AutoSize = true;
            this.blackButton.Checked = true;
            this.blackButton.Location = new System.Drawing.Point(19, 122);
            this.blackButton.Name = "blackButton";
            this.blackButton.Size = new System.Drawing.Size(52, 17);
            this.blackButton.TabIndex = 3;
            this.blackButton.TabStop = true;
            this.blackButton.Text = "Black";
            this.blackButton.UseVisualStyleBackColor = true;
            this.blackButton.CheckedChanged += new System.EventHandler(this.ColorCheckChanged);
            // 
            // greenButton
            // 
            this.greenButton.AutoSize = true;
            this.greenButton.Location = new System.Drawing.Point(19, 89);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(54, 17);
            this.greenButton.TabIndex = 2;
            this.greenButton.Text = "Green";
            this.greenButton.UseVisualStyleBackColor = true;
            this.greenButton.CheckedChanged += new System.EventHandler(this.ColorCheckChanged);
            // 
            // blueButton
            // 
            this.blueButton.AutoSize = true;
            this.blueButton.Location = new System.Drawing.Point(19, 54);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(46, 17);
            this.blueButton.TabIndex = 1;
            this.blueButton.TabStop = true;
            this.blueButton.Text = "Blue";
            this.blueButton.UseVisualStyleBackColor = true;
            this.blueButton.CheckedChanged += new System.EventHandler(this.ColorCheckChanged);
            // 
            // redButton
            // 
            this.redButton.AutoSize = true;
            this.redButton.Location = new System.Drawing.Point(19, 19);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(45, 17);
            this.redButton.TabIndex = 0;
            this.redButton.TabStop = true;
            this.redButton.Text = "Red";
            this.redButton.UseVisualStyleBackColor = true;
            this.redButton.CheckedChanged += new System.EventHandler(this.ColorCheckChanged);
            // 
            // sizeGroupBox
            // 
            this.sizeGroupBox.Controls.Add(this.largeButton);
            this.sizeGroupBox.Controls.Add(this.mediumButton);
            this.sizeGroupBox.Controls.Add(this.smallButton);
            this.sizeGroupBox.Location = new System.Drawing.Point(51, 212);
            this.sizeGroupBox.Name = "sizeGroupBox";
            this.sizeGroupBox.Size = new System.Drawing.Size(137, 159);
            this.sizeGroupBox.TabIndex = 1;
            this.sizeGroupBox.TabStop = false;
            this.sizeGroupBox.Text = "Size";
            // 
            // largeButton
            // 
            this.largeButton.AutoSize = true;
            this.largeButton.Location = new System.Drawing.Point(19, 114);
            this.largeButton.Name = "largeButton";
            this.largeButton.Size = new System.Drawing.Size(52, 17);
            this.largeButton.TabIndex = 6;
            this.largeButton.Text = "Large";
            this.largeButton.UseVisualStyleBackColor = true;
            this.largeButton.CheckedChanged += new System.EventHandler(this.SizeCheckChanged);
            // 
            // mediumButton
            // 
            this.mediumButton.AutoSize = true;
            this.mediumButton.Location = new System.Drawing.Point(19, 75);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(62, 17);
            this.mediumButton.TabIndex = 5;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.CheckedChanged += new System.EventHandler(this.SizeCheckChanged);
            // 
            // smallButton
            // 
            this.smallButton.AutoSize = true;
            this.smallButton.Checked = true;
            this.smallButton.Location = new System.Drawing.Point(19, 36);
            this.smallButton.Name = "smallButton";
            this.smallButton.Size = new System.Drawing.Size(50, 17);
            this.smallButton.TabIndex = 4;
            this.smallButton.TabStop = true;
            this.smallButton.Text = "Small";
            this.smallButton.UseVisualStyleBackColor = true;
            this.smallButton.CheckedChanged += new System.EventHandler(this.SizeCheckChanged);
            // 
            // drawingPanel
            // 
            this.drawingPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.drawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.drawingPanel.Location = new System.Drawing.Point(256, 27);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(515, 372);
            this.drawingPanel.TabIndex = 2;
            this.drawingPanel.SizeChanged += new System.EventHandler(this.Resize_Form);
            this.drawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownDraw);
            this.drawingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draw);
            this.drawingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpNoDraw);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.drawingPanel);
            this.Controls.Add(this.sizeGroupBox);
            this.Controls.Add(this.colorGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Resize_Form);
            this.SizeChanged += new System.EventHandler(this.Resize_Form);
            this.colorGroupBox.ResumeLayout(false);
            this.colorGroupBox.PerformLayout();
            this.sizeGroupBox.ResumeLayout(false);
            this.sizeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox colorGroupBox;
        private System.Windows.Forms.GroupBox sizeGroupBox;
        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.RadioButton blackButton;
        private System.Windows.Forms.RadioButton greenButton;
        private System.Windows.Forms.RadioButton blueButton;
        private System.Windows.Forms.RadioButton redButton;
        private System.Windows.Forms.RadioButton largeButton;
        private System.Windows.Forms.RadioButton mediumButton;
        private System.Windows.Forms.RadioButton smallButton;
    }
}

