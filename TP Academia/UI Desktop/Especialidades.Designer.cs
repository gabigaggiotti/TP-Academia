﻿namespace UI_Desktop
{
    partial class Especialidades
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_crear = new System.Windows.Forms.Button();
            this.dataGridViewEsp = new System.Windows.Forms.DataGridView();
            this.idEspecialidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descEspecialidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.academiaDataSet = new UI_Desktop.AcademiaDataSet();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.especialidadesTableAdapter = new UI_Desktop.AcademiaDataSetTableAdapters.especialidadesTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdEspecialidad = new System.Windows.Forms.TextBox();
            this.txtDescEspecialidad = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "ESPECIALIDADES";
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(12, 49);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(160, 40);
            this.btn_crear.TabIndex = 12;
            this.btn_crear.Text = "CREAR";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // dataGridViewEsp
            // 
            this.dataGridViewEsp.AutoGenerateColumns = false;
            this.dataGridViewEsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEsp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEspecialidadDataGridViewTextBoxColumn,
            this.descEspecialidadDataGridViewTextBoxColumn});
            this.dataGridViewEsp.DataSource = this.especialidadesBindingSource;
            this.dataGridViewEsp.Location = new System.Drawing.Point(385, 95);
            this.dataGridViewEsp.Name = "dataGridViewEsp";
            this.dataGridViewEsp.RowHeadersWidth = 51;
            this.dataGridViewEsp.RowTemplate.Height = 24;
            this.dataGridViewEsp.Size = new System.Drawing.Size(403, 343);
            this.dataGridViewEsp.TabIndex = 13;
            this.dataGridViewEsp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idEspecialidadDataGridViewTextBoxColumn
            // 
            this.idEspecialidadDataGridViewTextBoxColumn.DataPropertyName = "idEspecialidad";
            this.idEspecialidadDataGridViewTextBoxColumn.HeaderText = "idEspecialidad";
            this.idEspecialidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idEspecialidadDataGridViewTextBoxColumn.Name = "idEspecialidadDataGridViewTextBoxColumn";
            this.idEspecialidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEspecialidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // descEspecialidadDataGridViewTextBoxColumn
            // 
            this.descEspecialidadDataGridViewTextBoxColumn.DataPropertyName = "descEspecialidad";
            this.descEspecialidadDataGridViewTextBoxColumn.HeaderText = "descEspecialidad";
            this.descEspecialidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descEspecialidadDataGridViewTextBoxColumn.Name = "descEspecialidadDataGridViewTextBoxColumn";
            this.descEspecialidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // especialidadesBindingSource
            // 
            this.especialidadesBindingSource.DataMember = "especialidades";
            this.especialidadesBindingSource.DataSource = this.academiaDataSet;
            // 
            // academiaDataSet
            // 
            this.academiaDataSet.DataSetName = "AcademiaDataSet";
            this.academiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(431, 49);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(160, 40);
            this.btn_eliminar.TabIndex = 9;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(225, 49);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(160, 40);
            this.btn_modificar.TabIndex = 10;
            this.btn_modificar.Text = "MODIFICAR";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // especialidadesTableAdapter
            // 
            this.especialidadesTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "ID Especialidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Descripcion:";
            // 
            // txtIdEspecialidad
            // 
            this.txtIdEspecialidad.Location = new System.Drawing.Point(121, 120);
            this.txtIdEspecialidad.Name = "txtIdEspecialidad";
            this.txtIdEspecialidad.Size = new System.Drawing.Size(199, 22);
            this.txtIdEspecialidad.TabIndex = 16;
            // 
            // txtDescEspecialidad
            // 
            this.txtDescEspecialidad.Location = new System.Drawing.Point(121, 155);
            this.txtDescEspecialidad.Name = "txtDescEspecialidad";
            this.txtDescEspecialidad.Size = new System.Drawing.Size(199, 22);
            this.txtDescEspecialidad.TabIndex = 17;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(628, 49);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(160, 40);
            this.btnConsultar.TabIndex = 18;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // Especialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtDescEspecialidad);
            this.Controls.Add(this.txtIdEspecialidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewEsp);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.label1);
            this.Name = "Especialidades";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Especialidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.DataGridView dataGridViewEsp;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private AcademiaDataSet academiaDataSet;
        private System.Windows.Forms.BindingSource especialidadesBindingSource;
        private AcademiaDataSetTableAdapters.especialidadesTableAdapter especialidadesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEspecialidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descEspecialidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdEspecialidad;
        private System.Windows.Forms.TextBox txtDescEspecialidad;
        private System.Windows.Forms.Button btnConsultar;
    }
}