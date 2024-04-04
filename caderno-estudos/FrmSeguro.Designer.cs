namespace caderno_estudos
{
    partial class FrmSeguro
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
            this.btt = new System.Windows.Forms.Button();
            this.txtValorV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdButNaoinf = new System.Windows.Forms.RadioButton();
            this.rdButProf = new System.Windows.Forms.RadioButton();
            this.rdButPessoal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdButUni = new System.Windows.Forms.RadioButton();
            this.rdButVar = new System.Windows.Forms.RadioButton();
            this.chkBoxSim = new System.Windows.Forms.CheckBox();
            this.chkBoxNao = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btt
            // 
            this.btt.Location = new System.Drawing.Point(15, 161);
            this.btt.Name = "btt";
            this.btt.Size = new System.Drawing.Size(97, 37);
            this.btt.TabIndex = 0;
            this.btt.Text = "Calcular";
            this.btt.UseVisualStyleBackColor = true;
            this.btt.Click += new System.EventHandler(this.btt_Click);
            // 
            // txtValorV
            // 
            this.txtValorV.Location = new System.Drawing.Point(12, 25);
            this.txtValorV.Name = "txtValorV";
            this.txtValorV.Size = new System.Drawing.Size(100, 20);
            this.txtValorV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor do Veiculo:";
            // 
            // rdButNaoinf
            // 
            this.rdButNaoinf.AutoSize = true;
            this.rdButNaoinf.Location = new System.Drawing.Point(6, 65);
            this.rdButNaoinf.Name = "rdButNaoinf";
            this.rdButNaoinf.Size = new System.Drawing.Size(94, 17);
            this.rdButNaoinf.TabIndex = 3;
            this.rdButNaoinf.TabStop = true;
            this.rdButNaoinf.Text = "Não informado";
            this.rdButNaoinf.UseVisualStyleBackColor = true;
            // 
            // rdButProf
            // 
            this.rdButProf.AutoSize = true;
            this.rdButProf.Location = new System.Drawing.Point(6, 42);
            this.rdButProf.Name = "rdButProf";
            this.rdButProf.Size = new System.Drawing.Size(78, 17);
            this.rdButProf.TabIndex = 4;
            this.rdButProf.TabStop = true;
            this.rdButProf.Text = "Profissional";
            this.rdButProf.UseVisualStyleBackColor = true;
            // 
            // rdButPessoal
            // 
            this.rdButPessoal.AutoSize = true;
            this.rdButPessoal.Location = new System.Drawing.Point(6, 19);
            this.rdButPessoal.Name = "rdButPessoal";
            this.rdButPessoal.Size = new System.Drawing.Size(62, 17);
            this.rdButPessoal.TabIndex = 5;
            this.rdButPessoal.TabStop = true;
            this.rdButPessoal.Text = "Pessoal";
            this.rdButPessoal.UseVisualStyleBackColor = true;
            this.rdButPessoal.CheckedChanged += new System.EventHandler(this.rdButUnic_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdButPessoal);
            this.groupBox1.Controls.Add(this.rdButNaoinf);
            this.groupBox1.Controls.Add(this.rdButProf);
            this.groupBox1.Location = new System.Drawing.Point(118, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Utilização";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdButVar);
            this.groupBox2.Controls.Add(this.rdButUni);
            this.groupBox2.Location = new System.Drawing.Point(365, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // rdButUni
            // 
            this.rdButUni.AutoSize = true;
            this.rdButUni.Location = new System.Drawing.Point(6, 19);
            this.rdButUni.Name = "rdButUni";
            this.rdButUni.Size = new System.Drawing.Size(82, 17);
            this.rdButUni.TabIndex = 8;
            this.rdButUni.TabStop = true;
            this.rdButUni.Text = "Único Dono";
            this.rdButUni.UseVisualStyleBackColor = true;
            // 
            // rdButVar
            // 
            this.rdButVar.AutoSize = true;
            this.rdButVar.Location = new System.Drawing.Point(6, 42);
            this.rdButVar.Name = "rdButVar";
            this.rdButVar.Size = new System.Drawing.Size(111, 17);
            this.rdButVar.TabIndex = 9;
            this.rdButVar.TabStop = true;
            this.rdButVar.Text = "Vários Condutores";
            this.rdButVar.UseVisualStyleBackColor = true;
            // 
            // chkBoxSim
            // 
            this.chkBoxSim.AutoSize = true;
            this.chkBoxSim.Location = new System.Drawing.Point(617, 52);
            this.chkBoxSim.Name = "chkBoxSim";
            this.chkBoxSim.Size = new System.Drawing.Size(43, 17);
            this.chkBoxSim.TabIndex = 8;
            this.chkBoxSim.Text = "Sim";
            this.chkBoxSim.UseVisualStyleBackColor = true;
            // 
            // chkBoxNao
            // 
            this.chkBoxNao.AutoSize = true;
            this.chkBoxNao.Checked = true;
            this.chkBoxNao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxNao.Location = new System.Drawing.Point(687, 52);
            this.chkBoxNao.Name = "chkBoxNao";
            this.chkBoxNao.Size = new System.Drawing.Size(46, 17);
            this.chkBoxNao.TabIndex = 9;
            this.chkBoxNao.Text = "Não";
            this.chkBoxNao.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Algum dos condutores é recem habilitado";
            // 
            // txtValorF
            // 
            this.txtValorF.Location = new System.Drawing.Point(12, 295);
            this.txtValorF.Name = "txtValorF";
            this.txtValorF.Size = new System.Drawing.Size(100, 20);
            this.txtValorF.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Valor do Seguro:";
            // 
            // FrmSeguro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkBoxNao);
            this.Controls.Add(this.chkBoxSim);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorV);
            this.Controls.Add(this.btt);
            this.Name = "FrmSeguro";
            this.Text = "FrmSeguro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btt;
        private System.Windows.Forms.TextBox txtValorV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdButNaoinf;
        private System.Windows.Forms.RadioButton rdButProf;
        private System.Windows.Forms.RadioButton rdButPessoal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdButVar;
        private System.Windows.Forms.RadioButton rdButUni;
        private System.Windows.Forms.CheckBox chkBoxSim;
        private System.Windows.Forms.CheckBox chkBoxNao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorF;
        private System.Windows.Forms.Label label3;
    }
}