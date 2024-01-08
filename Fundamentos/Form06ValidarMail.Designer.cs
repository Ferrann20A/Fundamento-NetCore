namespace Fundamentos
{
    partial class Form06ValidarMail
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
            btnValidaMail = new Button();
            txtMail = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnValidaMail
            // 
            btnValidaMail.Location = new Point(56, 158);
            btnValidaMail.Name = "btnValidaMail";
            btnValidaMail.Size = new Size(178, 56);
            btnValidaMail.TabIndex = 0;
            btnValidaMail.Text = "Validar Mail";
            btnValidaMail.UseVisualStyleBackColor = true;
            btnValidaMail.Click += btnValidaMail_Click;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(56, 86);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(416, 38);
            txtMail.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 34);
            label1.Name = "label1";
            label1.Size = new Size(162, 31);
            label1.TabIndex = 2;
            label1.Text = "Introduce mail";
            // 
            // Form06ValidarMail
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 370);
            Controls.Add(label1);
            Controls.Add(txtMail);
            Controls.Add(btnValidaMail);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form06ValidarMail";
            Text = "Form06ValidarMail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnValidaMail;
        private TextBox txtMail;
        private Label label1;
    }
}