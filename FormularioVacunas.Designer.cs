namespace ProgramaMascotas
{
    partial class FormularioVacunas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioVacunas));
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.tabControlConsultas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewInfoMascota = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewCantidadRazaEspecie = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewCantidadVacunaEspecie = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMascotas = new System.Windows.Forms.ComboBox();
            this.comboBoxVacunas = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRegistrarVacuna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.tabControlConsultas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfoMascota)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCantidadRazaEspecie)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCantidadVacunaEspecie)).BeginInit();
            this.SuspendLayout();
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // tabControlConsultas
            // 
            resources.ApplyResources(this.tabControlConsultas, "tabControlConsultas");
            this.tabControlConsultas.Controls.Add(this.tabPage1);
            this.tabControlConsultas.Controls.Add(this.tabPage2);
            this.tabControlConsultas.Controls.Add(this.tabPage3);
            this.tabControlConsultas.Multiline = true;
            this.tabControlConsultas.Name = "tabControlConsultas";
            this.tabControlConsultas.SelectedIndex = 0;
            this.tabControlConsultas.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlConsultas.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewInfoMascota);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInfoMascota
            // 
            resources.ApplyResources(this.dataGridViewInfoMascota, "dataGridViewInfoMascota");
            this.dataGridViewInfoMascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfoMascota.Name = "dataGridViewInfoMascota";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewCantidadRazaEspecie);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCantidadRazaEspecie
            // 
            resources.ApplyResources(this.dataGridViewCantidadRazaEspecie, "dataGridViewCantidadRazaEspecie");
            this.dataGridViewCantidadRazaEspecie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCantidadRazaEspecie.Name = "dataGridViewCantidadRazaEspecie";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewCantidadVacunaEspecie);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCantidadVacunaEspecie
            // 
            resources.ApplyResources(this.dataGridViewCantidadVacunaEspecie, "dataGridViewCantidadVacunaEspecie");
            this.dataGridViewCantidadVacunaEspecie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCantidadVacunaEspecie.Name = "dataGridViewCantidadVacunaEspecie";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // comboBoxMascotas
            // 
            this.comboBoxMascotas.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxMascotas, "comboBoxMascotas");
            this.comboBoxMascotas.Name = "comboBoxMascotas";
            this.comboBoxMascotas.SelectedIndexChanged += new System.EventHandler(this.comboBoxMascotas_SelectedIndexChanged);
            // 
            // comboBoxVacunas
            // 
            this.comboBoxVacunas.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxVacunas, "comboBoxVacunas");
            this.comboBoxVacunas.Name = "comboBoxVacunas";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // buttonRegistrarVacuna
            // 
            resources.ApplyResources(this.buttonRegistrarVacuna, "buttonRegistrarVacuna");
            this.buttonRegistrarVacuna.Name = "buttonRegistrarVacuna";
            this.buttonRegistrarVacuna.UseVisualStyleBackColor = true;
            this.buttonRegistrarVacuna.Click += new System.EventHandler(this.buttonRegistrarVacuna_Click);
            // 
            // FormularioVacunas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.buttonRegistrarVacuna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxVacunas);
            this.Controls.Add(this.comboBoxMascotas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControlConsultas);
            this.Name = "FormularioVacunas";
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormVacunas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.tabControlConsultas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfoMascota)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCantidadRazaEspecie)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCantidadVacunaEspecie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControlConsultas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxVacunas;
        private System.Windows.Forms.ComboBox comboBoxMascotas;
        private System.Windows.Forms.Button buttonRegistrarVacuna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewInfoMascota;
        private System.Windows.Forms.DataGridView dataGridViewCantidadRazaEspecie;
        private System.Windows.Forms.DataGridView dataGridViewCantidadVacunaEspecie;
    }
}

