namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdb_estagio = new System.Windows.Forms.RadioButton();
            this.rdb_efetivo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_registros = new System.Windows.Forms.TextBox();
            this.txt_registro = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_java = new System.Windows.Forms.CheckBox();
            this.chk_typescript = new System.Windows.Forms.CheckBox();
            this.chk_php = new System.Windows.Forms.CheckBox();
            this.chk_python = new System.Windows.Forms.CheckBox();
            this.chk_cs = new System.Windows.Forms.CheckBox();
            this.chk_sql = new System.Windows.Forms.CheckBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(107, 53);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(213, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // rdb_estagio
            // 
            this.rdb_estagio.AutoSize = true;
            this.rdb_estagio.Location = new System.Drawing.Point(11, 30);
            this.rdb_estagio.Name = "rdb_estagio";
            this.rdb_estagio.Size = new System.Drawing.Size(60, 17);
            this.rdb_estagio.TabIndex = 4;
            this.rdb_estagio.TabStop = true;
            this.rdb_estagio.Text = "Estágio";
            this.rdb_estagio.UseVisualStyleBackColor = true;
            // 
            // rdb_efetivo
            // 
            this.rdb_efetivo.AutoSize = true;
            this.rdb_efetivo.Location = new System.Drawing.Point(145, 30);
            this.rdb_efetivo.Name = "rdb_efetivo";
            this.rdb_efetivo.Size = new System.Drawing.Size(58, 17);
            this.rdb_efetivo.TabIndex = 5;
            this.rdb_efetivo.TabStop = true;
            this.rdb_efetivo.Text = "Efetivo";
            this.rdb_efetivo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_efetivo);
            this.groupBox1.Controls.Add(this.rdb_estagio);
            this.groupBox1.Location = new System.Drawing.Point(111, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 84);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipos de Contrato";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(163, 252);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(151, 50);
            this.btn_cadastrar.TabIndex = 6;
            this.btn_cadastrar.Text = "CADRASTAR";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Senha";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_registros
            // 
            this.txt_registros.Location = new System.Drawing.Point(66, 332);
            this.txt_registros.Multiline = true;
            this.txt_registros.Name = "txt_registros";
            this.txt_registros.Size = new System.Drawing.Size(300, 191);
            this.txt_registros.TabIndex = 8;
            // 
            // txt_registro
            // 
            this.txt_registro.AutoSize = true;
            this.txt_registro.Location = new System.Drawing.Point(63, 316);
            this.txt_registro.Name = "txt_registro";
            this.txt_registro.Size = new System.Drawing.Size(51, 13);
            this.txt_registro.TabIndex = 9;
            this.txt_registro.Text = "Registros";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk_sql);
            this.groupBox2.Controls.Add(this.chk_cs);
            this.groupBox2.Controls.Add(this.chk_python);
            this.groupBox2.Controls.Add(this.chk_php);
            this.groupBox2.Controls.Add(this.chk_typescript);
            this.groupBox2.Controls.Add(this.chk_java);
            this.groupBox2.Location = new System.Drawing.Point(452, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 170);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Experiências";
            this.groupBox2.Enter += new System.EventHandler(this.chk_php_Enter);
            // 
            // chk_java
            // 
            this.chk_java.AutoSize = true;
            this.chk_java.Location = new System.Drawing.Point(13, 34);
            this.chk_java.Name = "chk_java";
            this.chk_java.Size = new System.Drawing.Size(49, 17);
            this.chk_java.TabIndex = 0;
            this.chk_java.Text = "Java";
            this.chk_java.UseVisualStyleBackColor = true;
            // 
            // chk_typescript
            // 
            this.chk_typescript.AutoSize = true;
            this.chk_typescript.Location = new System.Drawing.Point(13, 72);
            this.chk_typescript.Name = "chk_typescript";
            this.chk_typescript.Size = new System.Drawing.Size(77, 17);
            this.chk_typescript.TabIndex = 1;
            this.chk_typescript.Text = "TypeScript";
            this.chk_typescript.UseVisualStyleBackColor = true;
            // 
            // chk_php
            // 
            this.chk_php.AutoSize = true;
            this.chk_php.Location = new System.Drawing.Point(13, 107);
            this.chk_php.Name = "chk_php";
            this.chk_php.Size = new System.Drawing.Size(48, 17);
            this.chk_php.TabIndex = 2;
            this.chk_php.Text = "PHP";
            this.chk_php.UseVisualStyleBackColor = true;
            this.chk_php.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chk_python
            // 
            this.chk_python.AutoSize = true;
            this.chk_python.Location = new System.Drawing.Point(204, 34);
            this.chk_python.Name = "chk_python";
            this.chk_python.Size = new System.Drawing.Size(59, 17);
            this.chk_python.TabIndex = 3;
            this.chk_python.Text = "Python";
            this.chk_python.UseVisualStyleBackColor = true;
            // 
            // chk_cs
            // 
            this.chk_cs.AutoSize = true;
            this.chk_cs.Location = new System.Drawing.Point(204, 72);
            this.chk_cs.Name = "chk_cs";
            this.chk_cs.Size = new System.Drawing.Size(40, 17);
            this.chk_cs.TabIndex = 4;
            this.chk_cs.Text = "C#";
            this.chk_cs.UseVisualStyleBackColor = true;
            // 
            // chk_sql
            // 
            this.chk_sql.AutoSize = true;
            this.chk_sql.Location = new System.Drawing.Point(204, 107);
            this.chk_sql.Name = "chk_sql";
            this.chk_sql.Size = new System.Drawing.Size(47, 17);
            this.chk_sql.TabIndex = 5;
            this.chk_sql.Text = "SQL";
            this.chk_sql.UseVisualStyleBackColor = true;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(539, 230);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(105, 28);
            this.btn_limpar.TabIndex = 11;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 678);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_registro);
            this.Controls.Add(this.txt_registros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Aula 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdb_estagio;
        private System.Windows.Forms.RadioButton rdb_efetivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_registros;
        private System.Windows.Forms.Label txt_registro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk_php;
        private System.Windows.Forms.CheckBox chk_typescript;
        private System.Windows.Forms.CheckBox chk_java;
        private System.Windows.Forms.CheckBox chk_sql;
        private System.Windows.Forms.CheckBox chk_cs;
        private System.Windows.Forms.CheckBox chk_python;
        private System.Windows.Forms.Button btn_limpar;
    }
}

