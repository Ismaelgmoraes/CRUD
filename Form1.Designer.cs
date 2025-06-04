namespace CRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            btnSalvar = new Button();
            lstContatos = new ListView();
            txtLocalizar = new TextBox();
            btnConsultar = new Button();
            label4 = new Label();
            btnLimpar = new Button();
            btnExcluir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Telefone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "E-mail:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 27);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(339, 23);
            txtNome.TabIndex = 3;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(12, 71);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(191, 23);
            txtTelefone.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 115);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(339, 23);
            txtEmail.TabIndex = 5;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(12, 319);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(72, 45);
            btnSalvar.TabIndex = 6;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lstContatos
            // 
            lstContatos.Location = new Point(373, 71);
            lstContatos.Name = "lstContatos";
            lstContatos.Size = new Size(450, 293);
            lstContatos.TabIndex = 7;
            lstContatos.UseCompatibleStateImageBehavior = false;
            lstContatos.SelectedIndexChanged += lstContatos_SelectedIndexChanged_1;
            // 
            // txtLocalizar
            // 
            txtLocalizar.Location = new Point(373, 28);
            txtLocalizar.Name = "txtLocalizar";
            txtLocalizar.Size = new Size(373, 23);
            txtLocalizar.TabIndex = 8;
            // 
            // btnConsultar
            // 
            btnConsultar.Image = (Image)resources.GetObject("btnConsultar.Image");
            btnConsultar.Location = new Point(752, 27);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(71, 41);
            btnConsultar.TabIndex = 9;
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(373, 9);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 10;
            label4.Text = "Localizar:";
            // 
            // btnLimpar
            // 
            btnLimpar.Image = (Image)resources.GetObject("btnLimpar.Image");
            btnLimpar.Location = new Point(141, 319);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(72, 45);
            btnLimpar.TabIndex = 11;
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.Location = new Point(267, 319);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(72, 45);
            btnExcluir.TabIndex = 12;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 376);
            Controls.Add(btnExcluir);
            Controls.Add(btnLimpar);
            Controls.Add(label4);
            Controls.Add(btnConsultar);
            Controls.Add(txtLocalizar);
            Controls.Add(lstContatos);
            Controls.Add(btnSalvar);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Agenda de Contatos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private Button btnSalvar;
        private ListView lstContatos;
        private TextBox txtLocalizar;
        private Button btnConsultar;
        private Label label4;
        private Button btnLimpar;
        private Button btnExcluir;
    }
}
