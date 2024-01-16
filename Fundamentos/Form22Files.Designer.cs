namespace Fundamentos
{
    partial class Form22Files
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
            label1 = new Label();
            txtContenidoFile = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            btnNuevoNombre = new Button();
            lstNombres = new ListBox();
            label3 = new Label();
            btnReadFile = new Button();
            btnWriteFile = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 25);
            label1.Name = "label1";
            label1.Size = new Size(161, 31);
            label1.TabIndex = 0;
            label1.Text = "Contenido File";
            // 
            // txtContenidoFile
            // 
            txtContenidoFile.Location = new Point(54, 71);
            txtContenidoFile.Multiline = true;
            txtContenidoFile.Name = "txtContenidoFile";
            txtContenidoFile.Size = new Size(293, 413);
            txtContenidoFile.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(395, 27);
            label2.Name = "label2";
            label2.Size = new Size(98, 31);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(395, 61);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(224, 38);
            txtNombre.TabIndex = 3;
            // 
            // btnNuevoNombre
            // 
            btnNuevoNombre.Location = new Point(414, 128);
            btnNuevoNombre.Name = "btnNuevoNombre";
            btnNuevoNombre.Size = new Size(189, 57);
            btnNuevoNombre.TabIndex = 4;
            btnNuevoNombre.Text = "Nuevo nombre";
            btnNuevoNombre.UseVisualStyleBackColor = true;
            btnNuevoNombre.Click += btnNuevoNombre_Click;
            // 
            // lstNombres
            // 
            lstNombres.FormattingEnabled = true;
            lstNombres.ItemHeight = 31;
            lstNombres.Location = new Point(655, 71);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(304, 407);
            lstNombres.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(655, 24);
            label3.Name = "label3";
            label3.Size = new Size(108, 31);
            label3.TabIndex = 6;
            label3.Text = "Nombres";
            // 
            // btnReadFile
            // 
            btnReadFile.Location = new Point(414, 202);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(189, 62);
            btnReadFile.TabIndex = 7;
            btnReadFile.Text = "Read File";
            btnReadFile.UseVisualStyleBackColor = true;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // btnWriteFile
            // 
            btnWriteFile.Location = new Point(414, 284);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(189, 62);
            btnWriteFile.TabIndex = 8;
            btnWriteFile.Text = "Write File";
            btnWriteFile.UseVisualStyleBackColor = true;
            btnWriteFile.Click += btnWriteFile_Click;
            // 
            // Form22Files
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 513);
            Controls.Add(btnWriteFile);
            Controls.Add(btnReadFile);
            Controls.Add(label3);
            Controls.Add(lstNombres);
            Controls.Add(btnNuevoNombre);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtContenidoFile);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form22Files";
            Text = "Form22Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtContenidoFile;
        private Label label2;
        private TextBox txtNombre;
        private Button btnNuevoNombre;
        private ListBox lstNombres;
        private Label label3;
        private Button btnReadFile;
        private Button btnWriteFile;
    }
}