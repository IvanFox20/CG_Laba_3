namespace CG_Laba_3
{
    partial class Main_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.segment_button = new System.Windows.Forms.Button();
            this.circle_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // segment_button
            // 
            this.segment_button.Location = new System.Drawing.Point(116, 254);
            this.segment_button.Name = "segment_button";
            this.segment_button.Size = new System.Drawing.Size(308, 114);
            this.segment_button.TabIndex = 9;
            this.segment_button.Text = "Отрезок";
            this.segment_button.UseVisualStyleBackColor = true;
            this.segment_button.Click += new System.EventHandler(this.segment_button_Click);
            // 
            // circle_Button
            // 
            this.circle_Button.Location = new System.Drawing.Point(498, 254);
            this.circle_Button.Name = "circle_Button";
            this.circle_Button.Size = new System.Drawing.Size(308, 114);
            this.circle_Button.TabIndex = 10;
            this.circle_Button.Text = "Окружность";
            this.circle_Button.UseVisualStyleBackColor = true;
            this.circle_Button.Click += new System.EventHandler(this.circle_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 634);
            this.Controls.Add(this.circle_Button);
            this.Controls.Add(this.segment_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button segment_button;
        private Button circle_Button;
    }
}