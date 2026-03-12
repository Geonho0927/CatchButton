namespace CatchButton
{
    partial class Form1
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
            targetButton = new Button();
            SuspendLayout();
            // 
            // targetButton
            // 
            targetButton.BackColor = SystemColors.ActiveCaption;
            targetButton.Font = new Font("휴먼옛체", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            targetButton.Location = new Point(299, 185);
            targetButton.Name = "targetButton";
            targetButton.Size = new Size(250, 120);
            targetButton.TabIndex = 0;
            targetButton.Text = "나를 잡아봐";
            targetButton.UseVisualStyleBackColor = false;
            targetButton.Click += targetButton_Click;
            targetButton.MouseEnter += targetButton_MouseEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(targetButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button targetButton;
    }
}
