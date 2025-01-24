namespace Presentacion
{
    partial class form_Empleados
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Empleados));
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.cbx_BuscarX = new System.Windows.Forms.ComboBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.dgv_Empleados = new System.Windows.Forms.DataGridView();
            this.aBM_EFDataSet = new Presentacion.ABM_EFDataSet();
            this.empleadoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoesTableAdapter = new Presentacion.ABM_EFDataSetTableAdapters.EmpleadoesTableAdapter();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBM_EFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Location = new System.Drawing.Point(13, 13);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(134, 20);
            this.txt_Buscar.TabIndex = 0;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(280, 12);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(82, 23);
            this.btn_Buscar.TabIndex = 2;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // cbx_BuscarX
            // 
            this.cbx_BuscarX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_BuscarX.FormattingEnabled = true;
            this.cbx_BuscarX.Items.AddRange(new object[] {
            "Nombre",
            "Departamento"});
            this.cbx_BuscarX.Location = new System.Drawing.Point(153, 13);
            this.cbx_BuscarX.Name = "cbx_BuscarX";
            this.cbx_BuscarX.Size = new System.Drawing.Size(121, 21);
            this.cbx_BuscarX.TabIndex = 1;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(13, 215);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(134, 23);
            this.btn_Agregar.TabIndex = 4;
            this.btn_Agregar.Text = "Agregar Empleado";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(206, 215);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 5;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(287, 215);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 6;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // dgv_Empleados
            // 
            this.dgv_Empleados.AllowUserToAddRows = false;
            this.dgv_Empleados.AllowUserToDeleteRows = false;
            this.dgv_Empleados.AllowUserToResizeColumns = false;
            this.dgv_Empleados.AllowUserToResizeRows = false;
            this.dgv_Empleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Empleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellido,
            this.Departamento});
            this.dgv_Empleados.Location = new System.Drawing.Point(13, 53);
            this.dgv_Empleados.MultiSelect = false;
            this.dgv_Empleados.Name = "dgv_Empleados";
            this.dgv_Empleados.ReadOnly = true;
            this.dgv_Empleados.RowHeadersVisible = false;
            this.dgv_Empleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Empleados.Size = new System.Drawing.Size(349, 150);
            this.dgv_Empleados.TabIndex = 3;
            this.dgv_Empleados.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_Empleados_RowsRemoved);
            // 
            // aBM_EFDataSet
            // 
            this.aBM_EFDataSet.DataSetName = "ABM_EFDataSet";
            this.aBM_EFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadoesBindingSource
            // 
            this.empleadoesBindingSource.DataMember = "Empleadoes";
            this.empleadoesBindingSource.DataSource = this.aBM_EFDataSet;
            // 
            // empleadoesTableAdapter
            // 
            this.empleadoesTableAdapter.ClearBeforeFill = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Departamento
            // 
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            // 
            // form_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(377, 248);
            this.Controls.Add(this.dgv_Empleados);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.cbx_BuscarX);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txt_Buscar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Empleados";
            this.Load += new System.EventHandler(this.form_Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBM_EFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.ComboBox cbx_BuscarX;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.DataGridView dgv_Empleados;
        private ABM_EFDataSet aBM_EFDataSet;
        private System.Windows.Forms.BindingSource empleadoesBindingSource;
        private ABM_EFDataSetTableAdapters.EmpleadoesTableAdapter empleadoesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
    }
}

