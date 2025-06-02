namespace BancoDeDados
{
    partial class AlunosCadastrados
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
            txtId = new TextBox();
            txtCurso = new TextBox();
            txtNome = new TextBox();
            btnFechar = new Button();
            lbxDados = new ListBox();
            ID = new Label();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(271, 89);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 0;
            // 
            // txtCurso
            // 
            txtCurso.Location = new Point(271, 188);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(328, 27);
            txtCurso.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(271, 138);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(328, 27);
            txtNome.TabIndex = 2;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = SystemColors.ControlDark;
            btnFechar.ForeColor = SystemColors.ControlText;
            btnFechar.Location = new Point(197, 346);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(94, 29);
            btnFechar.TabIndex = 3;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // lbxDados
            // 
            lbxDados.FormattingEnabled = true;
            lbxDados.Location = new Point(35, 38);
            lbxDados.Name = "lbxDados";
            lbxDados.Size = new Size(179, 284);
            lbxDados.TabIndex = 4;
            lbxDados.SelectedIndexChanged += lbxDados_SelectedIndexChanged;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(35, 15);
            ID.Name = "ID";
            ID.Size = new Size(24, 20);
            ID.TabIndex = 5;
            ID.Text = "ID";
            // 
            // AlunosCadastrados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ID);
            Controls.Add(lbxDados);
            Controls.Add(btnFechar);
            Controls.Add(txtNome);
            Controls.Add(txtCurso);
            Controls.Add(txtId);
            Name = "AlunosCadastrados";
            Text = "AlunosCadastrados";
            Load += AlunosCadastrados_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtCurso;
        private TextBox txtNome;
        private Button btnFechar;
        private ListBox lbxDados;
        private Label ID;
    }
}