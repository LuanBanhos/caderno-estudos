
namespace caderno_estudos
{
    partial class Bonus
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorBonus = new System.Windows.Forms.TextBox();
            this.bttCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDependente = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.gpInstituicao = new System.Windows.Forms.GroupBox();
            this.rdParticular = new System.Windows.Forms.RadioButton();
            this.rdPublico = new System.Windows.Forms.RadioButton();
            this.gpTurno = new System.Windows.Forms.GroupBox();
            this.rdManha = new System.Windows.Forms.RadioButton();
            this.rdNoite = new System.Windows.Forms.RadioButton();
            this.rdTarde = new System.Windows.Forms.RadioButton();
            this.gpEstudos = new System.Windows.Forms.GroupBox();
            this.rdfundamental = new System.Windows.Forms.RadioButton();
            this.rdPos = new System.Windows.Forms.RadioButton();
            this.rdMedio = new System.Windows.Forms.RadioButton();
            this.rdSuperior = new System.Windows.Forms.RadioButton();
            this.chkBoxEstuda = new System.Windows.Forms.CheckBox();
            this.chkboxTrabalha = new System.Windows.Forms.CheckBox();
            this.gpInstituicao.SuspendLayout();
            this.gpTurno.SuspendLayout();
            this.gpEstudos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Salario:";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Valor do Bonus:";
            // 
            // txtValorBonus
            // 
            this.txtValorBonus.Location = new System.Drawing.Point(97, 278);
            this.txtValorBonus.Name = "txtValorBonus";
            this.txtValorBonus.Size = new System.Drawing.Size(100, 20);
            this.txtValorBonus.TabIndex = 30;
            // 
            // bttCalcular
            // 
            this.bttCalcular.Location = new System.Drawing.Point(237, 265);
            this.bttCalcular.Name = "bttCalcular";
            this.bttCalcular.Size = new System.Drawing.Size(92, 45);
            this.bttCalcular.TabIndex = 29;
            this.bttCalcular.Text = "Calcular";
            this.bttCalcular.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Quantidade de Dependentes:";
            // 
            // txtDependente
            // 
            this.txtDependente.Location = new System.Drawing.Point(162, 227);
            this.txtDependente.Name = "txtDependente";
            this.txtDependente.Size = new System.Drawing.Size(100, 20);
            this.txtDependente.TabIndex = 27;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(79, 28);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 26;
            this.txtSalario.Visible = false;
            // 
            // gpInstituicao
            // 
            this.gpInstituicao.Controls.Add(this.rdParticular);
            this.gpInstituicao.Controls.Add(this.rdPublico);
            this.gpInstituicao.Location = new System.Drawing.Point(464, 173);
            this.gpInstituicao.Name = "gpInstituicao";
            this.gpInstituicao.Size = new System.Drawing.Size(101, 67);
            this.gpInstituicao.TabIndex = 25;
            this.gpInstituicao.TabStop = false;
            this.gpInstituicao.Text = "Instituição";
            this.gpInstituicao.Visible = false;
            // 
            // rdParticular
            // 
            this.rdParticular.AutoSize = true;
            this.rdParticular.Location = new System.Drawing.Point(6, 19);
            this.rdParticular.Name = "rdParticular";
            this.rdParticular.Size = new System.Drawing.Size(69, 17);
            this.rdParticular.TabIndex = 11;
            this.rdParticular.TabStop = true;
            this.rdParticular.Text = "Particular";
            this.rdParticular.UseVisualStyleBackColor = true;
            // 
            // rdPublico
            // 
            this.rdPublico.AutoSize = true;
            this.rdPublico.Location = new System.Drawing.Point(6, 42);
            this.rdPublico.Name = "rdPublico";
            this.rdPublico.Size = new System.Drawing.Size(60, 17);
            this.rdPublico.TabIndex = 12;
            this.rdPublico.TabStop = true;
            this.rdPublico.Text = "Pública";
            this.rdPublico.UseVisualStyleBackColor = true;
            // 
            // gpTurno
            // 
            this.gpTurno.Controls.Add(this.rdManha);
            this.gpTurno.Controls.Add(this.rdNoite);
            this.gpTurno.Controls.Add(this.rdTarde);
            this.gpTurno.Location = new System.Drawing.Point(306, 131);
            this.gpTurno.Name = "gpTurno";
            this.gpTurno.Size = new System.Drawing.Size(152, 86);
            this.gpTurno.TabIndex = 24;
            this.gpTurno.TabStop = false;
            this.gpTurno.Text = "Periodo";
            this.gpTurno.Visible = false;
            // 
            // rdManha
            // 
            this.rdManha.AutoSize = true;
            this.rdManha.Location = new System.Drawing.Point(6, 19);
            this.rdManha.Name = "rdManha";
            this.rdManha.Size = new System.Drawing.Size(58, 17);
            this.rdManha.TabIndex = 7;
            this.rdManha.TabStop = true;
            this.rdManha.Text = "Manhã";
            this.rdManha.UseVisualStyleBackColor = true;
            // 
            // rdNoite
            // 
            this.rdNoite.AutoSize = true;
            this.rdNoite.Location = new System.Drawing.Point(6, 65);
            this.rdNoite.Name = "rdNoite";
            this.rdNoite.Size = new System.Drawing.Size(50, 17);
            this.rdNoite.TabIndex = 9;
            this.rdNoite.TabStop = true;
            this.rdNoite.Text = "Noite";
            this.rdNoite.UseVisualStyleBackColor = true;
            // 
            // rdTarde
            // 
            this.rdTarde.AutoSize = true;
            this.rdTarde.Location = new System.Drawing.Point(6, 42);
            this.rdTarde.Name = "rdTarde";
            this.rdTarde.Size = new System.Drawing.Size(53, 17);
            this.rdTarde.TabIndex = 8;
            this.rdTarde.TabStop = true;
            this.rdTarde.Text = "Tarde";
            this.rdTarde.UseVisualStyleBackColor = true;
            // 
            // gpEstudos
            // 
            this.gpEstudos.Controls.Add(this.rdfundamental);
            this.gpEstudos.Controls.Add(this.rdPos);
            this.gpEstudos.Controls.Add(this.rdMedio);
            this.gpEstudos.Controls.Add(this.rdSuperior);
            this.gpEstudos.Location = new System.Drawing.Point(79, 68);
            this.gpEstudos.Name = "gpEstudos";
            this.gpEstudos.Size = new System.Drawing.Size(221, 132);
            this.gpEstudos.TabIndex = 23;
            this.gpEstudos.TabStop = false;
            this.gpEstudos.Text = "Cruso";
            this.gpEstudos.Visible = false;
            // 
            // rdfundamental
            // 
            this.rdfundamental.AutoSize = true;
            this.rdfundamental.Location = new System.Drawing.Point(6, 19);
            this.rdfundamental.Name = "rdfundamental";
            this.rdfundamental.Size = new System.Drawing.Size(115, 17);
            this.rdfundamental.TabIndex = 2;
            this.rdfundamental.TabStop = true;
            this.rdfundamental.Text = "Ensino Fudamental";
            this.rdfundamental.UseVisualStyleBackColor = true;
            // 
            // rdPos
            // 
            this.rdPos.AutoSize = true;
            this.rdPos.Location = new System.Drawing.Point(6, 88);
            this.rdPos.Name = "rdPos";
            this.rdPos.Size = new System.Drawing.Size(99, 17);
            this.rdPos.TabIndex = 5;
            this.rdPos.TabStop = true;
            this.rdPos.Text = "Pós Graduação";
            this.rdPos.UseVisualStyleBackColor = true;
            // 
            // rdMedio
            // 
            this.rdMedio.AutoSize = true;
            this.rdMedio.Location = new System.Drawing.Point(6, 42);
            this.rdMedio.Name = "rdMedio";
            this.rdMedio.Size = new System.Drawing.Size(89, 17);
            this.rdMedio.TabIndex = 3;
            this.rdMedio.TabStop = true;
            this.rdMedio.Text = "Ensino Médio";
            this.rdMedio.UseVisualStyleBackColor = true;
            // 
            // rdSuperior
            // 
            this.rdSuperior.AutoSize = true;
            this.rdSuperior.Location = new System.Drawing.Point(6, 65);
            this.rdSuperior.Name = "rdSuperior";
            this.rdSuperior.Size = new System.Drawing.Size(99, 17);
            this.rdSuperior.TabIndex = 4;
            this.rdSuperior.TabStop = true;
            this.rdSuperior.Text = "Ensino Superior";
            this.rdSuperior.UseVisualStyleBackColor = true;
            // 
            // chkBoxEstuda
            // 
            this.chkBoxEstuda.AutoSize = true;
            this.chkBoxEstuda.Location = new System.Drawing.Point(12, 68);
            this.chkBoxEstuda.Name = "chkBoxEstuda";
            this.chkBoxEstuda.Size = new System.Drawing.Size(59, 17);
            this.chkBoxEstuda.TabIndex = 22;
            this.chkBoxEstuda.Text = "Estuda";
            this.chkBoxEstuda.UseVisualStyleBackColor = true;
            // 
            // chkboxTrabalha
            // 
            this.chkboxTrabalha.AutoSize = true;
            this.chkboxTrabalha.Location = new System.Drawing.Point(12, 12);
            this.chkboxTrabalha.Name = "chkboxTrabalha";
            this.chkboxTrabalha.Size = new System.Drawing.Size(68, 17);
            this.chkboxTrabalha.TabIndex = 21;
            this.chkboxTrabalha.Text = "Trabalha";
            this.chkboxTrabalha.UseVisualStyleBackColor = true;
            // 
            // Bonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorBonus);
            this.Controls.Add(this.bttCalcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDependente);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.gpInstituicao);
            this.Controls.Add(this.gpTurno);
            this.Controls.Add(this.gpEstudos);
            this.Controls.Add(this.chkBoxEstuda);
            this.Controls.Add(this.chkboxTrabalha);
            this.Name = "Bonus";
            this.Text = "Bonus";
            this.gpInstituicao.ResumeLayout(false);
            this.gpInstituicao.PerformLayout();
            this.gpTurno.ResumeLayout(false);
            this.gpTurno.PerformLayout();
            this.gpEstudos.ResumeLayout(false);
            this.gpEstudos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorBonus;
        private System.Windows.Forms.Button bttCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDependente;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.GroupBox gpInstituicao;
        private System.Windows.Forms.RadioButton rdParticular;
        private System.Windows.Forms.RadioButton rdPublico;
        private System.Windows.Forms.GroupBox gpTurno;
        private System.Windows.Forms.RadioButton rdManha;
        private System.Windows.Forms.RadioButton rdNoite;
        private System.Windows.Forms.RadioButton rdTarde;
        private System.Windows.Forms.GroupBox gpEstudos;
        private System.Windows.Forms.RadioButton rdfundamental;
        private System.Windows.Forms.RadioButton rdPos;
        private System.Windows.Forms.RadioButton rdMedio;
        private System.Windows.Forms.RadioButton rdSuperior;
        private System.Windows.Forms.CheckBox chkBoxEstuda;
        private System.Windows.Forms.CheckBox chkboxTrabalha;
    }
}