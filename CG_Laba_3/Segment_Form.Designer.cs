namespace CG_Laba_3
{
    partial class Segment_Form
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
            this.segment_pictureBox = new System.Windows.Forms.PictureBox();
            this.point1_label = new System.Windows.Forms.Label();
            this.point2_label = new System.Windows.Forms.Label();
            this.x1_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.x2_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.y1_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.y2_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.x_label = new System.Windows.Forms.Label();
            this.y_label = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.nextStep_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.segment_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y2_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // segment_pictureBox
            // 
            this.segment_pictureBox.Location = new System.Drawing.Point(12, 12);
            this.segment_pictureBox.Name = "segment_pictureBox";
            this.segment_pictureBox.Size = new System.Drawing.Size(630, 630);
            this.segment_pictureBox.TabIndex = 0;
            this.segment_pictureBox.TabStop = false;
            // 
            // point1_label
            // 
            this.point1_label.AutoSize = true;
            this.point1_label.Location = new System.Drawing.Point(748, 117);
            this.point1_label.Name = "point1_label";
            this.point1_label.Size = new System.Drawing.Size(48, 15);
            this.point1_label.TabIndex = 5;
            this.point1_label.Text = "Точка 1";
            // 
            // point2_label
            // 
            this.point2_label.AutoSize = true;
            this.point2_label.Location = new System.Drawing.Point(748, 150);
            this.point2_label.Name = "point2_label";
            this.point2_label.Size = new System.Drawing.Size(48, 15);
            this.point2_label.TabIndex = 6;
            this.point2_label.Text = "Точка 2";
            // 
            // x1_numericUpDown
            // 
            this.x1_numericUpDown.Location = new System.Drawing.Point(823, 115);
            this.x1_numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.x1_numericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.x1_numericUpDown.Name = "x1_numericUpDown";
            this.x1_numericUpDown.Size = new System.Drawing.Size(52, 23);
            this.x1_numericUpDown.TabIndex = 7;
            // 
            // x2_numericUpDown
            // 
            this.x2_numericUpDown.Location = new System.Drawing.Point(823, 148);
            this.x2_numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.x2_numericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.x2_numericUpDown.Name = "x2_numericUpDown";
            this.x2_numericUpDown.Size = new System.Drawing.Size(52, 23);
            this.x2_numericUpDown.TabIndex = 8;
            // 
            // y1_numericUpDown
            // 
            this.y1_numericUpDown.Location = new System.Drawing.Point(896, 115);
            this.y1_numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.y1_numericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.y1_numericUpDown.Name = "y1_numericUpDown";
            this.y1_numericUpDown.Size = new System.Drawing.Size(52, 23);
            this.y1_numericUpDown.TabIndex = 9;
            // 
            // y2_numericUpDown
            // 
            this.y2_numericUpDown.Location = new System.Drawing.Point(896, 148);
            this.y2_numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.y2_numericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.y2_numericUpDown.Name = "y2_numericUpDown";
            this.y2_numericUpDown.Size = new System.Drawing.Size(52, 23);
            this.y2_numericUpDown.TabIndex = 10;
            // 
            // x_label
            // 
            this.x_label.AutoSize = true;
            this.x_label.Location = new System.Drawing.Point(839, 97);
            this.x_label.Name = "x_label";
            this.x_label.Size = new System.Drawing.Size(14, 15);
            this.x_label.TabIndex = 11;
            this.x_label.Text = "X";
            // 
            // y_label
            // 
            this.y_label.AutoSize = true;
            this.y_label.Location = new System.Drawing.Point(910, 97);
            this.y_label.Name = "y_label";
            this.y_label.Size = new System.Drawing.Size(14, 15);
            this.y_label.TabIndex = 12;
            this.y_label.Text = "Y";
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(787, 546);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(152, 78);
            this.start_button.TabIndex = 13;
            this.start_button.Text = "Начать";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // nextStep_Button
            // 
            this.nextStep_Button.Location = new System.Drawing.Point(787, 546);
            this.nextStep_Button.Name = "nextStep_Button";
            this.nextStep_Button.Size = new System.Drawing.Size(152, 78);
            this.nextStep_Button.TabIndex = 14;
            this.nextStep_Button.Text = "Следующий шаг";
            this.nextStep_Button.UseVisualStyleBackColor = true;
            this.nextStep_Button.Visible = false;
            this.nextStep_Button.Click += new System.EventHandler(this.nextStep_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Location = new System.Drawing.Point(787, 396);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(152, 71);
            this.exit_Button.TabIndex = 15;
            this.exit_Button.Text = "Завершить";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Visible = false;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // Segment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 676);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.nextStep_Button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.y_label);
            this.Controls.Add(this.x_label);
            this.Controls.Add(this.y2_numericUpDown);
            this.Controls.Add(this.y1_numericUpDown);
            this.Controls.Add(this.x2_numericUpDown);
            this.Controls.Add(this.x1_numericUpDown);
            this.Controls.Add(this.point2_label);
            this.Controls.Add(this.point1_label);
            this.Controls.Add(this.segment_pictureBox);
            this.Name = "Segment_Form";
            this.Text = "Segment_Form";
            ((System.ComponentModel.ISupportInitialize)(this.segment_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y2_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox segment_pictureBox;
        private Label point1_label;
        private Label point2_label;
        private NumericUpDown x1_numericUpDown;
        private NumericUpDown x2_numericUpDown;
        private NumericUpDown y1_numericUpDown;
        private NumericUpDown y2_numericUpDown;
        private Label x_label;
        private Label y_label;
        private Button start_button;
        private Button nextStep_Button;
        private Button exit_Button;
    }
}