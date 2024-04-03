namespace CG_Laba_3
{
    partial class Circle_Form
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
            this.circle_pictureBox = new System.Windows.Forms.PictureBox();
            this.x_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.y_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.x_label = new System.Windows.Forms.Label();
            this.y_label = new System.Windows.Forms.Label();
            this.r_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.r_label = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.nextStep_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.circle_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // circle_pictureBox
            // 
            this.circle_pictureBox.Location = new System.Drawing.Point(-4, 2);
            this.circle_pictureBox.Name = "circle_pictureBox";
            this.circle_pictureBox.Size = new System.Drawing.Size(630, 630);
            this.circle_pictureBox.TabIndex = 1;
            this.circle_pictureBox.TabStop = false;
            // 
            // x_numericUpDown
            // 
            this.x_numericUpDown.Location = new System.Drawing.Point(817, 114);
            this.x_numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.x_numericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.x_numericUpDown.Name = "x_numericUpDown";
            this.x_numericUpDown.Size = new System.Drawing.Size(52, 23);
            this.x_numericUpDown.TabIndex = 8;
            // 
            // y_numericUpDown
            // 
            this.y_numericUpDown.Location = new System.Drawing.Point(875, 114);
            this.y_numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.y_numericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.y_numericUpDown.Name = "y_numericUpDown";
            this.y_numericUpDown.Size = new System.Drawing.Size(52, 23);
            this.y_numericUpDown.TabIndex = 10;
            // 
            // x_label
            // 
            this.x_label.AutoSize = true;
            this.x_label.Location = new System.Drawing.Point(829, 96);
            this.x_label.Name = "x_label";
            this.x_label.Size = new System.Drawing.Size(14, 15);
            this.x_label.TabIndex = 12;
            this.x_label.Text = "X";
            // 
            // y_label
            // 
            this.y_label.AutoSize = true;
            this.y_label.Location = new System.Drawing.Point(890, 96);
            this.y_label.Name = "y_label";
            this.y_label.Size = new System.Drawing.Size(14, 15);
            this.y_label.TabIndex = 13;
            this.y_label.Text = "Y";
            // 
            // r_numericUpDown
            // 
            this.r_numericUpDown.Location = new System.Drawing.Point(933, 114);
            this.r_numericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.r_numericUpDown.Name = "r_numericUpDown";
            this.r_numericUpDown.Size = new System.Drawing.Size(52, 23);
            this.r_numericUpDown.TabIndex = 14;
            // 
            // r_label
            // 
            this.r_label.AutoSize = true;
            this.r_label.Location = new System.Drawing.Point(947, 96);
            this.r_label.Name = "r_label";
            this.r_label.Size = new System.Drawing.Size(14, 15);
            this.r_label.TabIndex = 15;
            this.r_label.Text = "R";
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(775, 520);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(152, 78);
            this.start_button.TabIndex = 16;
            this.start_button.Text = "Начать";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // nextStep_Button
            // 
            this.nextStep_Button.Location = new System.Drawing.Point(775, 436);
            this.nextStep_Button.Name = "nextStep_Button";
            this.nextStep_Button.Size = new System.Drawing.Size(152, 78);
            this.nextStep_Button.TabIndex = 17;
            this.nextStep_Button.Text = "Следующий шаг";
            this.nextStep_Button.UseVisualStyleBackColor = true;
            this.nextStep_Button.Visible = false;
            this.nextStep_Button.Click += new System.EventHandler(this.nextStep_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Location = new System.Drawing.Point(775, 359);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(152, 71);
            this.exit_Button.TabIndex = 18;
            this.exit_Button.Text = "Завершить";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Visible = false;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // Circle_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 668);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.nextStep_Button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.r_label);
            this.Controls.Add(this.r_numericUpDown);
            this.Controls.Add(this.y_label);
            this.Controls.Add(this.x_label);
            this.Controls.Add(this.y_numericUpDown);
            this.Controls.Add(this.x_numericUpDown);
            this.Controls.Add(this.circle_pictureBox);
            this.Name = "Circle_Form";
            this.Text = "Circle_Form";
            ((System.ComponentModel.ISupportInitialize)(this.circle_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox circle_pictureBox;
        private NumericUpDown x_numericUpDown;
        private NumericUpDown y_numericUpDown;
        private Label x_label;
        private Label y_label;
        private NumericUpDown r_numericUpDown;
        private Label r_label;
        private Button start_button;
        private Button nextStep_Button;
        private Button exit_Button;
    }
}