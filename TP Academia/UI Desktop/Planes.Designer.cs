namespace UI_Desktop
{
    partial class Planes
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
            this.dataGridViewPlanes = new System.Windows.Forms.DataGridView();
            this.idplanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descplanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idespecialidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.academiaDataSet = new UI_Desktop.AcademiaDataSet();
            this.lbl_planes = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.planesTableAdapter = new UI_Desktop.AcademiaDataSetTableAdapters.planesTableAdapter();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtDescPlan = new System.Windows.Forms.TextBox();
            this.txtIdPlan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_especialidad = new System.Windows.Forms.Label();
            this.txtIdEspecialidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPlanes
            // 
            this.dataGridViewPlanes.AutoGenerateColumns = false;
            this.dataGridViewPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlanes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idplanDataGridViewTextBoxColumn,
            this.descplanDataGridViewTextBoxColumn,
            this.idespecialidadDataGridViewTextBoxColumn});
            this.dataGridViewPlanes.DataSource = this.planesBindingSource;
            this.dataGridViewPlanes.Location = new System.Drawing.Point(313, 88);
            this.dataGridViewPlanes.Name = "dataGridViewPlanes";
            this.dataGridViewPlanes.RowHeadersWidth = 51;
            this.dataGridViewPlanes.Size = new System.Drawing.Size(475, 350);
            this.dataGridViewPlanes.TabIndex = 0;
            // 
            // idplanDataGridViewTextBoxColumn
            // 
            this.idplanDataGridViewTextBoxColumn.DataPropertyName = "id_plan";
            this.idplanDataGridViewTextBoxColumn.HeaderText = "id_plan";
            this.idplanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idplanDataGridViewTextBoxColumn.Name = "idplanDataGridViewTextBoxColumn";
            this.idplanDataGridViewTextBoxColumn.ReadOnly = true;
            this.idplanDataGridViewTextBoxColumn.Width = 125;
            // 
            // descplanDataGridViewTextBoxColumn
            // 
            this.descplanDataGridViewTextBoxColumn.DataPropertyName = "desc_plan";
            this.descplanDataGridViewTextBoxColumn.HeaderText = "desc_plan";
            this.descplanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descplanDataGridViewTextBoxColumn.Name = "descplanDataGridViewTextBoxColumn";
            this.descplanDataGridViewTextBoxColumn.Width = 125;
            // 
            // idespecialidadDataGridViewTextBoxColumn
            // 
            this.idespecialidadDataGridViewTextBoxColumn.DataPropertyName = "id_especialidad";
            this.idespecialidadDataGridViewTextBoxColumn.HeaderText = "id_especialidad";
            this.idespecialidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idespecialidadDataGridViewTextBoxColumn.Name = "idespecialidadDataGridViewTextBoxColumn";
            this.idespecialidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // planesBindingSource
            // 
            this.planesBindingSource.DataMember = "planes";
            this.planesBindingSource.DataSource = this.academiaDataSet;
            // 
            // academiaDataSet
            // 
            this.academiaDataSet.DataSetName = "AcademiaDataSet";
            this.academiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_planes
            // 
            this.lbl_planes.AutoSize = true;
            this.lbl_planes.Location = new System.Drawing.Point(365, 13);
            this.lbl_planes.Name = "lbl_planes";
            this.lbl_planes.Size = new System.Drawing.Size(60, 16);
            this.lbl_planes.TabIndex = 1;
            this.lbl_planes.Text = "PLANES";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(12, 42);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(160, 40);
            this.btnCrear.TabIndex = 15;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(222, 42);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(160, 40);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(424, 42);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(160, 40);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(628, 42);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(160, 40);
            this.btnConsultar.TabIndex = 16;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // planesTableAdapter
            // 
            this.planesTableAdapter.ClearBeforeFill = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(232, 214);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 24;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // txtDescPlan
            // 
            this.txtDescPlan.Enabled = false;
            this.txtDescPlan.Location = new System.Drawing.Point(108, 148);
            this.txtDescPlan.Name = "txtDescPlan";
            this.txtDescPlan.Size = new System.Drawing.Size(199, 22);
            this.txtDescPlan.TabIndex = 23;
            // 
            // txtIdPlan
            // 
            this.txtIdPlan.Enabled = false;
            this.txtIdPlan.Location = new System.Drawing.Point(108, 107);
            this.txtIdPlan.Name = "txtIdPlan";
            this.txtIdPlan.Size = new System.Drawing.Size(199, 22);
            this.txtIdPlan.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Id Plan:";
            // 
            // lbl_especialidad
            // 
            this.lbl_especialidad.AutoSize = true;
            this.lbl_especialidad.Location = new System.Drawing.Point(12, 189);
            this.lbl_especialidad.Name = "lbl_especialidad";
            this.lbl_especialidad.Size = new System.Drawing.Size(90, 16);
            this.lbl_especialidad.TabIndex = 25;
            this.lbl_especialidad.Text = "Especialidad:";
            // 
            // txtIdEspecialidad
            // 
            this.txtIdEspecialidad.Enabled = false;
            this.txtIdEspecialidad.Location = new System.Drawing.Point(108, 186);
            this.txtIdEspecialidad.Name = "txtIdEspecialidad";
            this.txtIdEspecialidad.Size = new System.Drawing.Size(199, 22);
            this.txtIdEspecialidad.TabIndex = 26;
            // 
            // Planes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIdEspecialidad);
            this.Controls.Add(this.lbl_especialidad);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtDescPlan);
            this.Controls.Add(this.txtIdPlan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lbl_planes);
            this.Controls.Add(this.dataGridViewPlanes);
            this.Name = "Planes";
            this.Text = "Planes";
            this.Load += new System.EventHandler(this.Planes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPlanes;
        private System.Windows.Forms.Label lbl_planes;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnConsultar;
        private AcademiaDataSet academiaDataSet;
        private System.Windows.Forms.BindingSource planesBindingSource;
        private AcademiaDataSetTableAdapters.planesTableAdapter planesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idplanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descplanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idespecialidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtDescPlan;
        private System.Windows.Forms.TextBox txtIdPlan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_especialidad;
        private System.Windows.Forms.TextBox txtIdEspecialidad;
    }
}