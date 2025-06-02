namespace BancoDeDados
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnInserir = new Button();
            btnConsultar = new Button();
            btnAlterar = new Button();
            btnExibir = new Button();
            btnExcluir = new Button();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtCurso = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(160, 63);
            label1.Name = "label1";
            label1.Size = new Size(221, 31);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Alunos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 171);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 1;
            label2.Text = "ID: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 212);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "NOME:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 252);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 3;
            label4.Text = "CURSO";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(93, 327);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(94, 29);
            btnInserir.TabIndex = 4;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(260, 327);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(94, 29);
            btnConsultar.TabIndex = 5;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(419, 327);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(94, 29);
            btnAlterar.TabIndex = 6;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExibir
            // 
            btnExibir.Location = new Point(660, 63);
            btnExibir.Name = "btnExibir";
            btnExibir.Size = new Size(94, 29);
            btnExibir.TabIndex = 7;
            btnExibir.Text = "Exibir";
            btnExibir.UseVisualStyleBackColor = true;
            btnExibir.Click += btnExibir_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(584, 327);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(160, 164);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 9;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(160, 212);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(518, 27);
            txtNome.TabIndex = 10;
            // 
            // txtCurso
            // 
            txtCurso.Location = new Point(160, 252);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(518, 27);
            txtCurso.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCurso);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(btnExcluir);
            Controls.Add(btnExibir);
            Controls.Add(btnAlterar);
            Controls.Add(btnConsultar);
            Controls.Add(btnInserir);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnInserir;
        private Button btnConsultar;
        private Button btnAlterar;
        private Button btnExibir;
        private Button btnExcluir;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtCurso;
    }
}
