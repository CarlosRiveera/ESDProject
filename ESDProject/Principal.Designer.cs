namespace ESDProject
{
    partial class frmPrincipal
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
            this.tbcMenu = new System.Windows.Forms.TabControl();
            this.tpLocal = new System.Windows.Forms.TabPage();
            this.tpAlbe = new System.Windows.Forms.TabPage();
            this.tpRuta = new System.Windows.Forms.TabPage();
            this.btnLongiLocal = new System.Windows.Forms.TextBox();
            this.txtLatiLocal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTablaLocal = new System.Windows.Forms.DataGridView();
            this.btnLimpiarLocal = new System.Windows.Forms.Button();
            this.btnConsultarLocal = new System.Windows.Forms.Button();
            this.btnEliminarLocal = new System.Windows.Forms.Button();
            this.btnAgreModLocal = new System.Windows.Forms.Button();
            this.cmbMunicipioLocal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreLocal = new System.Windows.Forms.TextBox();
            this.txtDescRiesgo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLongiAlbe = new System.Windows.Forms.TextBox();
            this.txtLatAlbe = new System.Windows.Forms.TextBox();
            this.dgvTablaAlbe = new System.Windows.Forms.DataGridView();
            this.btnEliminarAlbe = new System.Windows.Forms.Button();
            this.btnLimpiarAlbe = new System.Windows.Forms.Button();
            this.btnConsultarAlbe = new System.Windows.Forms.Button();
            this.btnAgreModAlbe = new System.Windows.Forms.Button();
            this.txtDescAlbe = new System.Windows.Forms.TextBox();
            this.txtNombreAlbe = new System.Windows.Forms.TextBox();
            this.cmbMunicipioAlbe = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.tbcMenu.SuspendLayout();
            this.tpLocal.SuspendLayout();
            this.tpAlbe.SuspendLayout();
            this.tpRuta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaAlbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcMenu
            // 
            this.tbcMenu.Controls.Add(this.tpLocal);
            this.tbcMenu.Controls.Add(this.tpAlbe);
            this.tbcMenu.Controls.Add(this.tpRuta);
            this.tbcMenu.Location = new System.Drawing.Point(1, 0);
            this.tbcMenu.Name = "tbcMenu";
            this.tbcMenu.SelectedIndex = 0;
            this.tbcMenu.Size = new System.Drawing.Size(767, 500);
            this.tbcMenu.TabIndex = 1;
            // 
            // tpLocal
            // 
            this.tpLocal.Controls.Add(this.btnLongiLocal);
            this.tpLocal.Controls.Add(this.txtLatiLocal);
            this.tpLocal.Controls.Add(this.label5);
            this.tpLocal.Controls.Add(this.label4);
            this.tpLocal.Controls.Add(this.dgvTablaLocal);
            this.tpLocal.Controls.Add(this.btnLimpiarLocal);
            this.tpLocal.Controls.Add(this.btnConsultarLocal);
            this.tpLocal.Controls.Add(this.btnEliminarLocal);
            this.tpLocal.Controls.Add(this.btnAgreModLocal);
            this.tpLocal.Controls.Add(this.cmbMunicipioLocal);
            this.tpLocal.Controls.Add(this.label3);
            this.tpLocal.Controls.Add(this.label2);
            this.tpLocal.Controls.Add(this.label1);
            this.tpLocal.Controls.Add(this.txtNombreLocal);
            this.tpLocal.Controls.Add(this.txtDescRiesgo);
            this.tpLocal.Location = new System.Drawing.Point(4, 22);
            this.tpLocal.Name = "tpLocal";
            this.tpLocal.Padding = new System.Windows.Forms.Padding(3);
            this.tpLocal.Size = new System.Drawing.Size(759, 474);
            this.tpLocal.TabIndex = 0;
            this.tpLocal.Text = "Mantenimiento Localidades de Alto Riesgo";
            this.tpLocal.UseVisualStyleBackColor = true;
            // 
            // tpAlbe
            // 
            this.tpAlbe.Controls.Add(this.label6);
            this.tpAlbe.Controls.Add(this.label7);
            this.tpAlbe.Controls.Add(this.txtLongiAlbe);
            this.tpAlbe.Controls.Add(this.txtLatAlbe);
            this.tpAlbe.Controls.Add(this.dgvTablaAlbe);
            this.tpAlbe.Controls.Add(this.btnEliminarAlbe);
            this.tpAlbe.Controls.Add(this.btnLimpiarAlbe);
            this.tpAlbe.Controls.Add(this.btnConsultarAlbe);
            this.tpAlbe.Controls.Add(this.btnAgreModAlbe);
            this.tpAlbe.Controls.Add(this.txtDescAlbe);
            this.tpAlbe.Controls.Add(this.txtNombreAlbe);
            this.tpAlbe.Controls.Add(this.cmbMunicipioAlbe);
            this.tpAlbe.Controls.Add(this.label8);
            this.tpAlbe.Controls.Add(this.label9);
            this.tpAlbe.Controls.Add(this.label10);
            this.tpAlbe.Location = new System.Drawing.Point(4, 22);
            this.tpAlbe.Name = "tpAlbe";
            this.tpAlbe.Padding = new System.Windows.Forms.Padding(3);
            this.tpAlbe.Size = new System.Drawing.Size(759, 474);
            this.tpAlbe.TabIndex = 1;
            this.tpAlbe.Text = "Mantenimiento Albergues";
            this.tpAlbe.UseVisualStyleBackColor = true;
            // 
            // tpRuta
            // 
            this.tpRuta.Controls.Add(this.label13);
            this.tpRuta.Controls.Add(this.dataGridView1);
            this.tpRuta.Controls.Add(this.button1);
            this.tpRuta.Controls.Add(this.comboBox2);
            this.tpRuta.Controls.Add(this.comboBox1);
            this.tpRuta.Controls.Add(this.label12);
            this.tpRuta.Controls.Add(this.label11);
            this.tpRuta.Location = new System.Drawing.Point(4, 22);
            this.tpRuta.Name = "tpRuta";
            this.tpRuta.Padding = new System.Windows.Forms.Padding(3);
            this.tpRuta.Size = new System.Drawing.Size(759, 474);
            this.tpRuta.TabIndex = 2;
            this.tpRuta.Text = "Calcular Rutas Óptimas";
            this.tpRuta.UseVisualStyleBackColor = true;
            // 
            // btnLongiLocal
            // 
            this.btnLongiLocal.Location = new System.Drawing.Point(628, 194);
            this.btnLongiLocal.Name = "btnLongiLocal";
            this.btnLongiLocal.Size = new System.Drawing.Size(100, 20);
            this.btnLongiLocal.TabIndex = 29;
            // 
            // txtLatiLocal
            // 
            this.txtLatiLocal.Location = new System.Drawing.Point(458, 194);
            this.txtLatiLocal.Name = "txtLatiLocal";
            this.txtLatiLocal.Size = new System.Drawing.Size(100, 20);
            this.txtLatiLocal.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(574, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Longitud";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Latitud";
            // 
            // dgvTablaLocal
            // 
            this.dgvTablaLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaLocal.Location = new System.Drawing.Point(27, 234);
            this.dgvTablaLocal.Name = "dgvTablaLocal";
            this.dgvTablaLocal.Size = new System.Drawing.Size(701, 218);
            this.dgvTablaLocal.TabIndex = 25;
            // 
            // btnLimpiarLocal
            // 
            this.btnLimpiarLocal.Location = new System.Drawing.Point(315, 192);
            this.btnLimpiarLocal.Name = "btnLimpiarLocal";
            this.btnLimpiarLocal.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarLocal.TabIndex = 24;
            this.btnLimpiarLocal.Text = "Limpiar";
            this.btnLimpiarLocal.UseVisualStyleBackColor = true;
            // 
            // btnConsultarLocal
            // 
            this.btnConsultarLocal.Location = new System.Drawing.Point(221, 192);
            this.btnConsultarLocal.Name = "btnConsultarLocal";
            this.btnConsultarLocal.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarLocal.TabIndex = 23;
            this.btnConsultarLocal.Text = "Consultar";
            this.btnConsultarLocal.UseVisualStyleBackColor = true;
            // 
            // btnEliminarLocal
            // 
            this.btnEliminarLocal.Location = new System.Drawing.Point(126, 192);
            this.btnEliminarLocal.Name = "btnEliminarLocal";
            this.btnEliminarLocal.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarLocal.TabIndex = 22;
            this.btnEliminarLocal.Text = "Eliminar";
            this.btnEliminarLocal.UseVisualStyleBackColor = true;
            // 
            // btnAgreModLocal
            // 
            this.btnAgreModLocal.Location = new System.Drawing.Point(27, 192);
            this.btnAgreModLocal.Name = "btnAgreModLocal";
            this.btnAgreModLocal.Size = new System.Drawing.Size(75, 23);
            this.btnAgreModLocal.TabIndex = 21;
            this.btnAgreModLocal.Text = "Agregar";
            this.btnAgreModLocal.UseVisualStyleBackColor = true;
            // 
            // cmbMunicipioLocal
            // 
            this.cmbMunicipioLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMunicipioLocal.FormattingEnabled = true;
            this.cmbMunicipioLocal.Location = new System.Drawing.Point(154, 23);
            this.cmbMunicipioLocal.Name = "cmbMunicipioLocal";
            this.cmbMunicipioLocal.Size = new System.Drawing.Size(236, 21);
            this.cmbMunicipioLocal.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Municipio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Descripción del Riesgo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre";
            // 
            // txtNombreLocal
            // 
            this.txtNombreLocal.Location = new System.Drawing.Point(154, 64);
            this.txtNombreLocal.Name = "txtNombreLocal";
            this.txtNombreLocal.Size = new System.Drawing.Size(236, 20);
            this.txtNombreLocal.TabIndex = 16;
            // 
            // txtDescRiesgo
            // 
            this.txtDescRiesgo.Location = new System.Drawing.Point(154, 105);
            this.txtDescRiesgo.Multiline = true;
            this.txtDescRiesgo.Name = "txtDescRiesgo";
            this.txtDescRiesgo.Size = new System.Drawing.Size(236, 61);
            this.txtDescRiesgo.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(550, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Longitud";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Latitud";
            // 
            // txtLongiAlbe
            // 
            this.txtLongiAlbe.Location = new System.Drawing.Point(604, 215);
            this.txtLongiAlbe.Name = "txtLongiAlbe";
            this.txtLongiAlbe.Size = new System.Drawing.Size(100, 20);
            this.txtLongiAlbe.TabIndex = 27;
            // 
            // txtLatAlbe
            // 
            this.txtLatAlbe.Location = new System.Drawing.Point(428, 215);
            this.txtLatAlbe.Name = "txtLatAlbe";
            this.txtLatAlbe.Size = new System.Drawing.Size(100, 20);
            this.txtLatAlbe.TabIndex = 26;
            // 
            // dgvTablaAlbe
            // 
            this.dgvTablaAlbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaAlbe.Location = new System.Drawing.Point(50, 253);
            this.dgvTablaAlbe.Name = "dgvTablaAlbe";
            this.dgvTablaAlbe.Size = new System.Drawing.Size(656, 188);
            this.dgvTablaAlbe.TabIndex = 25;
            // 
            // btnEliminarAlbe
            // 
            this.btnEliminarAlbe.Location = new System.Drawing.Point(116, 213);
            this.btnEliminarAlbe.Name = "btnEliminarAlbe";
            this.btnEliminarAlbe.Size = new System.Drawing.Size(60, 23);
            this.btnEliminarAlbe.TabIndex = 24;
            this.btnEliminarAlbe.Text = "Eliminar";
            this.btnEliminarAlbe.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarAlbe
            // 
            this.btnLimpiarAlbe.Location = new System.Drawing.Point(252, 213);
            this.btnLimpiarAlbe.Name = "btnLimpiarAlbe";
            this.btnLimpiarAlbe.Size = new System.Drawing.Size(60, 23);
            this.btnLimpiarAlbe.TabIndex = 23;
            this.btnLimpiarAlbe.Text = "Limpiar";
            this.btnLimpiarAlbe.UseVisualStyleBackColor = true;
            // 
            // btnConsultarAlbe
            // 
            this.btnConsultarAlbe.Location = new System.Drawing.Point(182, 213);
            this.btnConsultarAlbe.Name = "btnConsultarAlbe";
            this.btnConsultarAlbe.Size = new System.Drawing.Size(60, 23);
            this.btnConsultarAlbe.TabIndex = 22;
            this.btnConsultarAlbe.Text = "Consultar";
            this.btnConsultarAlbe.UseVisualStyleBackColor = true;
            // 
            // btnAgreModAlbe
            // 
            this.btnAgreModAlbe.Location = new System.Drawing.Point(50, 213);
            this.btnAgreModAlbe.Name = "btnAgreModAlbe";
            this.btnAgreModAlbe.Size = new System.Drawing.Size(60, 23);
            this.btnAgreModAlbe.TabIndex = 21;
            this.btnAgreModAlbe.Text = "Agregar";
            this.btnAgreModAlbe.UseVisualStyleBackColor = true;
            // 
            // txtDescAlbe
            // 
            this.txtDescAlbe.Location = new System.Drawing.Point(118, 120);
            this.txtDescAlbe.Multiline = true;
            this.txtDescAlbe.Name = "txtDescAlbe";
            this.txtDescAlbe.Size = new System.Drawing.Size(194, 68);
            this.txtDescAlbe.TabIndex = 20;
            // 
            // txtNombreAlbe
            // 
            this.txtNombreAlbe.Location = new System.Drawing.Point(118, 72);
            this.txtNombreAlbe.Name = "txtNombreAlbe";
            this.txtNombreAlbe.Size = new System.Drawing.Size(194, 20);
            this.txtNombreAlbe.TabIndex = 19;
            // 
            // cmbMunicipioAlbe
            // 
            this.cmbMunicipioAlbe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMunicipioAlbe.FormattingEnabled = true;
            this.cmbMunicipioAlbe.Location = new System.Drawing.Point(118, 24);
            this.cmbMunicipioAlbe.Name = "cmbMunicipioAlbe";
            this.cmbMunicipioAlbe.Size = new System.Drawing.Size(194, 21);
            this.cmbMunicipioAlbe.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Municipio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Descripción";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Nombre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Municipio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Localidad de Origen";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(159, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(159, 69);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(144, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar Albergues";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(717, 231);
            this.dataGridView1.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(256, 52);
            this.label13.TabIndex = 6;
            this.label13.Text = "En la tabla se muestran las rutas más cortas entre la \r\nlocalidad de origen y los" +
    " albergues. Y se ordenan de \r\nmenor a mayor según la distancia.\r\n\r\n";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 501);
            this.Controls.Add(this.tbcMenu);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.tbcMenu.ResumeLayout(false);
            this.tpLocal.ResumeLayout(false);
            this.tpLocal.PerformLayout();
            this.tpAlbe.ResumeLayout(false);
            this.tpAlbe.PerformLayout();
            this.tpRuta.ResumeLayout(false);
            this.tpRuta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaAlbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tbcMenu;
        private System.Windows.Forms.TabPage tpLocal;
        private System.Windows.Forms.TabPage tpAlbe;
        private System.Windows.Forms.TabPage tpRuta;
        private System.Windows.Forms.TextBox btnLongiLocal;
        private System.Windows.Forms.TextBox txtLatiLocal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvTablaLocal;
        private System.Windows.Forms.Button btnLimpiarLocal;
        private System.Windows.Forms.Button btnConsultarLocal;
        private System.Windows.Forms.Button btnEliminarLocal;
        private System.Windows.Forms.Button btnAgreModLocal;
        private System.Windows.Forms.ComboBox cmbMunicipioLocal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreLocal;
        private System.Windows.Forms.TextBox txtDescRiesgo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLongiAlbe;
        private System.Windows.Forms.TextBox txtLatAlbe;
        private System.Windows.Forms.DataGridView dgvTablaAlbe;
        private System.Windows.Forms.Button btnEliminarAlbe;
        private System.Windows.Forms.Button btnLimpiarAlbe;
        private System.Windows.Forms.Button btnConsultarAlbe;
        private System.Windows.Forms.Button btnAgreModAlbe;
        private System.Windows.Forms.TextBox txtDescAlbe;
        private System.Windows.Forms.TextBox txtNombreAlbe;
        private System.Windows.Forms.ComboBox cmbMunicipioAlbe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}