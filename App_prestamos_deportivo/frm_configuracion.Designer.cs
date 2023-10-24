namespace App_prestamos_deportivo
{
    partial class frm_configuracion
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_agregar = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancelar = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.dbs_pretamos_deportivosDataSet = new App_prestamos_deportivo.dbs_pretamos_deportivosDataSet();
            this.tblsexoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_sexoTableAdapter = new App_prestamos_deportivo.dbs_pretamos_deportivosDataSetTableAdapters.tbl_sexoTableAdapter();
            this.pKIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomenclaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbs_pretamos_deportivosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsexoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(-3, 0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(698, 461);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SeaShell;
            this.tabPage1.Controls.Add(this.materialTextBox2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.materialButton1);
            this.tabPage1.Controls.Add(this.btn_cancelar);
            this.tabPage1.Controls.Add(this.btn_agregar);
            this.tabPage1.Controls.Add(this.materialTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(690, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sexo";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(690, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.Hint = "Sexo";
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(115, 60);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(309, 50);
            this.materialTextBox1.TabIndex = 0;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            this.materialTextBox1.TextChanged += new System.EventHandler(this.materialTextBox1_TextChanged);
            // 
            // btn_agregar
            // 
            this.btn_agregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_agregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_agregar.Depth = 0;
            this.btn_agregar.HighEmphasis = true;
            this.btn_agregar.Icon = null;
            this.btn_agregar.Location = new System.Drawing.Point(127, 186);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_agregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_agregar.Size = new System.Drawing.Size(88, 36);
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_agregar.UseAccentColor = false;
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancelar.Depth = 0;
            this.btn_cancelar.HighEmphasis = true;
            this.btn_cancelar.Icon = null;
            this.btn_cancelar.Location = new System.Drawing.Point(340, 186);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancelar.Size = new System.Drawing.Size(96, 36);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancelar.UseAccentColor = false;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(223, 186);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(109, 36);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Text = "Actualizar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pKIdDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.nomenclaturaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblsexoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(493, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.Hint = "Nomenclatura ";
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(115, 116);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(309, 50);
            this.materialTextBox2.TabIndex = 6;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            // 
            // dbs_pretamos_deportivosDataSet
            // 
            this.dbs_pretamos_deportivosDataSet.DataSetName = "dbs_pretamos_deportivosDataSet";
            this.dbs_pretamos_deportivosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblsexoBindingSource
            // 
            this.tblsexoBindingSource.DataMember = "tbl_sexo";
            this.tblsexoBindingSource.DataSource = this.dbs_pretamos_deportivosDataSet;
            // 
            // tbl_sexoTableAdapter
            // 
            this.tbl_sexoTableAdapter.ClearBeforeFill = true;
            // 
            // pKIdDataGridViewTextBoxColumn
            // 
            this.pKIdDataGridViewTextBoxColumn.DataPropertyName = "PKId";
            this.pKIdDataGridViewTextBoxColumn.HeaderText = "PKId";
            this.pKIdDataGridViewTextBoxColumn.Name = "pKIdDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // nomenclaturaDataGridViewTextBoxColumn
            // 
            this.nomenclaturaDataGridViewTextBoxColumn.DataPropertyName = "nomenclatura";
            this.nomenclaturaDataGridViewTextBoxColumn.HeaderText = "nomenclatura";
            this.nomenclaturaDataGridViewTextBoxColumn.Name = "nomenclaturaDataGridViewTextBoxColumn";
            // 
            // frm_configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 461);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "frm_configuracion";
            this.Text = "frm_configuracion";
            this.Load += new System.EventHandler(this.frm_configuracion_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbs_pretamos_deportivosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsexoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialButton btn_agregar;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton btn_cancelar;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dbs_pretamos_deportivosDataSet dbs_pretamos_deportivosDataSet;
        private System.Windows.Forms.BindingSource tblsexoBindingSource;
        private dbs_pretamos_deportivosDataSetTableAdapters.tbl_sexoTableAdapter tbl_sexoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomenclaturaDataGridViewTextBoxColumn;
    }
}