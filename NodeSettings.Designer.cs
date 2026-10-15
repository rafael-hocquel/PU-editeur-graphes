namespace GraphDrawing
{
    partial class NodeSettings
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
            nodeSettingsWidthLabel = new Label();
            nodeSettingsColorLabel = new Label();
            nodeSettingsWidthNumericUpDown = new NumericUpDown();
            nodeSettingsColorVisualizationLabel = new Label();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            nodeSettingsTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nodeSettingsWidthNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // nodeSettingsWidthLabel
            // 
            nodeSettingsWidthLabel.AutoSize = true;
            nodeSettingsWidthLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nodeSettingsWidthLabel.Location = new Point(55, 85);
            nodeSettingsWidthLabel.Name = "nodeSettingsWidthLabel";
            nodeSettingsWidthLabel.Size = new Size(71, 25);
            nodeSettingsWidthLabel.TabIndex = 0;
            nodeSettingsWidthLabel.Text = "Width:";
            // 
            // nodeSettingsColorLabel
            // 
            nodeSettingsColorLabel.AutoSize = true;
            nodeSettingsColorLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nodeSettingsColorLabel.Location = new Point(55, 196);
            nodeSettingsColorLabel.Name = "nodeSettingsColorLabel";
            nodeSettingsColorLabel.Size = new Size(67, 25);
            nodeSettingsColorLabel.TabIndex = 1;
            nodeSettingsColorLabel.Text = "Color:";
            // 
            // nodeSettingsWidthNumericUpDown
            // 
            nodeSettingsWidthNumericUpDown.Location = new Point(156, 85);
            nodeSettingsWidthNumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nodeSettingsWidthNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nodeSettingsWidthNumericUpDown.Name = "nodeSettingsWidthNumericUpDown";
            nodeSettingsWidthNumericUpDown.Size = new Size(120, 23);
            nodeSettingsWidthNumericUpDown.TabIndex = 2;
            nodeSettingsWidthNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nodeSettingsColorVisualizationLabel
            // 
            nodeSettingsColorVisualizationLabel.AutoSize = true;
            nodeSettingsColorVisualizationLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nodeSettingsColorVisualizationLabel.Location = new Point(145, 196);
            nodeSettingsColorVisualizationLabel.Name = "nodeSettingsColorVisualizationLabel";
            nodeSettingsColorVisualizationLabel.Size = new Size(55, 25);
            nodeSettingsColorVisualizationLabel.TabIndex = 3;
            nodeSettingsColorVisualizationLabel.Text = "color";
            nodeSettingsColorVisualizationLabel.TextAlign = ContentAlignment.MiddleRight;
            nodeSettingsColorVisualizationLabel.Click += nodeSettingsColorVisualizationLabel_Click;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(376, 101);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(376, 196);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 305);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 6;
            label1.Text = "Text:";
            // 
            // nodeSettingsTextBox
            // 
            nodeSettingsTextBox.Location = new Point(145, 305);
            nodeSettingsTextBox.Name = "nodeSettingsTextBox";
            nodeSettingsTextBox.Size = new Size(205, 23);
            nodeSettingsTextBox.TabIndex = 7;
            // 
            // NodeSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nodeSettingsTextBox);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(nodeSettingsColorVisualizationLabel);
            Controls.Add(nodeSettingsWidthNumericUpDown);
            Controls.Add(nodeSettingsColorLabel);
            Controls.Add(nodeSettingsWidthLabel);
            Name = "NodeSettings";
            ((System.ComponentModel.ISupportInitialize)nodeSettingsWidthNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nodeSettingsWidthLabel;
        private Label nodeSettingsColorLabel;
        private NumericUpDown nodeSettingsWidthNumericUpDown;
        private Label nodeSettingsColorVisualizationLabel;
        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox nodeSettingsTextBox;
    }
}