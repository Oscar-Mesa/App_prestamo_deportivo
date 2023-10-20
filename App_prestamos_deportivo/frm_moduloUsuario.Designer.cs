namespace App_prestamos_deportivo
{
    partial class frm_moduloUsuario
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
            this.txt_identificacion = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_primer_nombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_segundo_nombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_primer_apellido = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_segundo_apellido = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_contacto = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_correo = new MaterialSkin.Controls.MaterialTextBox();
            this.cbx_genero = new MaterialSkin.Controls.MaterialComboBox();
            this.txt_direccion = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_cancelar = new MaterialSkin.Controls.MaterialButton();
            this.btn_guardar = new MaterialSkin.Controls.MaterialButton();
            this.btn_actualizar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // txt_identificacion
            // 
            this.txt_identificacion.AnimateReadOnly = false;
            this.txt_identificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_identificacion.Depth = 0;
            this.txt_identificacion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_identificacion.Hint = "Identificación";
            this.txt_identificacion.LeadingIcon = null;
            this.txt_identificacion.Location = new System.Drawing.Point(27, 12);
            this.txt_identificacion.MaxLength = 50;
            this.txt_identificacion.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_identificacion.Multiline = false;
            this.txt_identificacion.Name = "txt_identificacion";
            this.txt_identificacion.Size = new System.Drawing.Size(191, 50);
            this.txt_identificacion.TabIndex = 0;
            this.txt_identificacion.Text = "";
            this.txt_identificacion.TrailingIcon = null;
            this.txt_identificacion.TextChanged += new System.EventHandler(this.materialTextBox1_TextChanged);
            // 
            // txt_primer_nombre
            // 
            this.txt_primer_nombre.AnimateReadOnly = false;
            this.txt_primer_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_primer_nombre.Depth = 0;
            this.txt_primer_nombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_primer_nombre.Hint = "Primer Nombre";
            this.txt_primer_nombre.LeadingIcon = null;
            this.txt_primer_nombre.Location = new System.Drawing.Point(224, 12);
            this.txt_primer_nombre.MaxLength = 50;
            this.txt_primer_nombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_primer_nombre.Multiline = false;
            this.txt_primer_nombre.Name = "txt_primer_nombre";
            this.txt_primer_nombre.Size = new System.Drawing.Size(215, 50);
            this.txt_primer_nombre.TabIndex = 1;
            this.txt_primer_nombre.Text = "";
            this.txt_primer_nombre.TrailingIcon = null;
            // 
            // txt_segundo_nombre
            // 
            this.txt_segundo_nombre.AnimateReadOnly = false;
            this.txt_segundo_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_segundo_nombre.Depth = 0;
            this.txt_segundo_nombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_segundo_nombre.Hint = "Segundo Nombre";
            this.txt_segundo_nombre.LeadingIcon = null;
            this.txt_segundo_nombre.Location = new System.Drawing.Point(445, 12);
            this.txt_segundo_nombre.MaxLength = 50;
            this.txt_segundo_nombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_segundo_nombre.Multiline = false;
            this.txt_segundo_nombre.Name = "txt_segundo_nombre";
            this.txt_segundo_nombre.Size = new System.Drawing.Size(202, 50);
            this.txt_segundo_nombre.TabIndex = 2;
            this.txt_segundo_nombre.Text = "";
            this.txt_segundo_nombre.TrailingIcon = null;
            // 
            // txt_primer_apellido
            // 
            this.txt_primer_apellido.AnimateReadOnly = false;
            this.txt_primer_apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_primer_apellido.Depth = 0;
            this.txt_primer_apellido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_primer_apellido.Hint = "Primer Apellido";
            this.txt_primer_apellido.LeadingIcon = null;
            this.txt_primer_apellido.Location = new System.Drawing.Point(27, 78);
            this.txt_primer_apellido.MaxLength = 50;
            this.txt_primer_apellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_primer_apellido.Multiline = false;
            this.txt_primer_apellido.Name = "txt_primer_apellido";
            this.txt_primer_apellido.Size = new System.Drawing.Size(191, 50);
            this.txt_primer_apellido.TabIndex = 3;
            this.txt_primer_apellido.Text = "";
            this.txt_primer_apellido.TrailingIcon = null;
            // 
            // txt_segundo_apellido
            // 
            this.txt_segundo_apellido.AnimateReadOnly = false;
            this.txt_segundo_apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_segundo_apellido.Depth = 0;
            this.txt_segundo_apellido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_segundo_apellido.Hint = "Segundo Apellido";
            this.txt_segundo_apellido.LeadingIcon = null;
            this.txt_segundo_apellido.Location = new System.Drawing.Point(224, 78);
            this.txt_segundo_apellido.MaxLength = 50;
            this.txt_segundo_apellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_segundo_apellido.Multiline = false;
            this.txt_segundo_apellido.Name = "txt_segundo_apellido";
            this.txt_segundo_apellido.Size = new System.Drawing.Size(215, 50);
            this.txt_segundo_apellido.TabIndex = 4;
            this.txt_segundo_apellido.Text = "";
            this.txt_segundo_apellido.TrailingIcon = null;
            // 
            // txt_contacto
            // 
            this.txt_contacto.AnimateReadOnly = false;
            this.txt_contacto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contacto.Depth = 0;
            this.txt_contacto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_contacto.Hint = "Contacto";
            this.txt_contacto.LeadingIcon = null;
            this.txt_contacto.Location = new System.Drawing.Point(445, 78);
            this.txt_contacto.MaxLength = 50;
            this.txt_contacto.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_contacto.Multiline = false;
            this.txt_contacto.Name = "txt_contacto";
            this.txt_contacto.Size = new System.Drawing.Size(202, 50);
            this.txt_contacto.TabIndex = 5;
            this.txt_contacto.Text = "";
            this.txt_contacto.TrailingIcon = null;
            // 
            // txt_correo
            // 
            this.txt_correo.AnimateReadOnly = false;
            this.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_correo.Depth = 0;
            this.txt_correo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_correo.Hint = "Correo";
            this.txt_correo.LeadingIcon = null;
            this.txt_correo.Location = new System.Drawing.Point(27, 134);
            this.txt_correo.MaxLength = 50;
            this.txt_correo.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_correo.Multiline = false;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(412, 50);
            this.txt_correo.TabIndex = 6;
            this.txt_correo.Text = "";
            this.txt_correo.TrailingIcon = null;
            // 
            // cbx_genero
            // 
            this.cbx_genero.AutoResize = false;
            this.cbx_genero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbx_genero.Depth = 0;
            this.cbx_genero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbx_genero.DropDownHeight = 174;
            this.cbx_genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_genero.DropDownWidth = 121;
            this.cbx_genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbx_genero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbx_genero.FormattingEnabled = true;
            this.cbx_genero.IntegralHeight = false;
            this.cbx_genero.ItemHeight = 43;
            this.cbx_genero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Transformer"});
            this.cbx_genero.Location = new System.Drawing.Point(445, 134);
            this.cbx_genero.MaxDropDownItems = 4;
            this.cbx_genero.MouseState = MaterialSkin.MouseState.OUT;
            this.cbx_genero.Name = "cbx_genero";
            this.cbx_genero.Size = new System.Drawing.Size(202, 49);
            this.cbx_genero.StartIndex = 0;
            this.cbx_genero.TabIndex = 7;
            // 
            // txt_direccion
            // 
            this.txt_direccion.AnimateReadOnly = false;
            this.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_direccion.Depth = 0;
            this.txt_direccion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_direccion.Hint = "Dirección";
            this.txt_direccion.LeadingIcon = null;
            this.txt_direccion.Location = new System.Drawing.Point(27, 190);
            this.txt_direccion.MaxLength = 50;
            this.txt_direccion.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_direccion.Multiline = false;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(620, 50);
            this.txt_direccion.TabIndex = 8;
            this.txt_direccion.Text = "";
            this.txt_direccion.TrailingIcon = null;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancelar.Depth = 0;
            this.btn_cancelar.HighEmphasis = true;
            this.btn_cancelar.Icon = null;
            this.btn_cancelar.Location = new System.Drawing.Point(553, 249);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancelar.Size = new System.Drawing.Size(96, 36);
            this.btn_cancelar.TabIndex = 11;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancelar.UseAccentColor = false;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_guardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_guardar.Depth = 0;
            this.btn_guardar.HighEmphasis = true;
            this.btn_guardar.Icon = null;
            this.btn_guardar.Location = new System.Drawing.Point(461, 249);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_guardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_guardar.Size = new System.Drawing.Size(88, 36);
            this.btn_guardar.TabIndex = 10;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_guardar.UseAccentColor = false;
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_actualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_actualizar.Depth = 0;
            this.btn_actualizar.HighEmphasis = true;
            this.btn_actualizar.Icon = null;
            this.btn_actualizar.Location = new System.Drawing.Point(344, 249);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_actualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_actualizar.Size = new System.Drawing.Size(109, 36);
            this.btn_actualizar.TabIndex = 9;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_actualizar.UseAccentColor = false;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // frm_moduloUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 303);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.cbx_genero);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.txt_contacto);
            this.Controls.Add(this.txt_segundo_apellido);
            this.Controls.Add(this.txt_primer_apellido);
            this.Controls.Add(this.txt_segundo_nombre);
            this.Controls.Add(this.txt_primer_nombre);
            this.Controls.Add(this.txt_identificacion);
            this.Name = "frm_moduloUsuario";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txt_identificacion;
        private MaterialSkin.Controls.MaterialTextBox txt_primer_nombre;
        private MaterialSkin.Controls.MaterialTextBox txt_segundo_nombre;
        private MaterialSkin.Controls.MaterialTextBox txt_primer_apellido;
        private MaterialSkin.Controls.MaterialTextBox txt_segundo_apellido;
        private MaterialSkin.Controls.MaterialTextBox txt_contacto;
        private MaterialSkin.Controls.MaterialTextBox txt_correo;
        private MaterialSkin.Controls.MaterialComboBox cbx_genero;
        private MaterialSkin.Controls.MaterialTextBox txt_direccion;
        private MaterialSkin.Controls.MaterialButton btn_cancelar;
        private MaterialSkin.Controls.MaterialButton btn_guardar;
        private MaterialSkin.Controls.MaterialButton btn_actualizar;
    }
}

