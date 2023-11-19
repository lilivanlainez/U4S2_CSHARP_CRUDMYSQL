using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Formulario
{
    partial class Form1
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
            buttonNuevo = new Button();
            buttonGuardar = new Button();
            buttonActualizar = new Button();
            buttonEliminar = new Button();
            buttonBuscar = new Button();
            buttonCancelar = new Button();
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            dateTimePickerFechaNacimiento = new DateTimePicker();
            textBoxDireccion = new TextBox();
            dataGridViewUsuarios = new DataGridView();
            labelNombre = new Label();
            labelApellido = new Label();
            labelFechaNacimiento = new Label();
            labelDireccion = new Label();
            labelBuscarNombre = new Label();
            textBoxBuscarNombre = new TextBox();
            buttonRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            SuspendLayout();
            // 
            // buttonNuevo
            // 
            buttonNuevo.Location = new Point(16, 12);
            buttonNuevo.Margin = new Padding(4, 5, 4, 5);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(100, 35);
            buttonNuevo.TabIndex = 0;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(157, 12);
            buttonGuardar.Margin = new Padding(4, 5, 4, 5);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(100, 35);
            buttonGuardar.TabIndex = 1;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonActualizar
            // 
            buttonActualizar.Location = new Point(299, 12);
            buttonActualizar.Margin = new Padding(4, 5, 4, 5);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(100, 35);
            buttonActualizar.TabIndex = 2;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = true;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(448, 12);
            buttonEliminar.Margin = new Padding(4, 5, 4, 5);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(100, 35);
            buttonEliminar.TabIndex = 3;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(262, 381);
            buttonBuscar.Margin = new Padding(4, 5, 4, 5);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(100, 35);
            buttonBuscar.TabIndex = 19;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(589, 12);
            buttonCancelar.Margin = new Padding(4, 5, 4, 5);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(100, 35);
            buttonCancelar.TabIndex = 5;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(16, 89);
            textBoxNombre.Margin = new Padding(4, 5, 4, 5);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(132, 27);
            textBoxNombre.TabIndex = 6;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(157, 89);
            textBoxApellido.Margin = new Padding(4, 5, 4, 5);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(132, 27);
            textBoxApellido.TabIndex = 7;
            // 
            // dateTimePickerFechaNacimiento
            // 
            dateTimePickerFechaNacimiento.Location = new Point(299, 89);
            dateTimePickerFechaNacimiento.Margin = new Padding(4, 5, 4, 5);
            dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            dateTimePickerFechaNacimiento.Size = new Size(265, 27);
            dateTimePickerFechaNacimiento.TabIndex = 8;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(573, 89);
            textBoxDireccion.Margin = new Padding(4, 5, 4, 5);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(132, 27);
            textBoxDireccion.TabIndex = 9;
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Location = new Point(16, 138);
            dataGridViewUsuarios.Margin = new Padding(4, 5, 4, 5);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.RowHeadersWidth = 51;
            dataGridViewUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsuarios.Size = new Size(673, 231);
            dataGridViewUsuarios.TabIndex = 10;
            dataGridViewUsuarios.SelectionChanged += dataGridViewUsuarios_SelectionChanged;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(16, 64);
            labelNombre.Margin = new Padding(4, 0, 4, 0);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(67, 20);
            labelNombre.TabIndex = 11;
            labelNombre.Text = "Nombre:";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(157, 64);
            labelApellido.Margin = new Padding(4, 0, 4, 0);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(69, 20);
            labelApellido.TabIndex = 12;
            labelApellido.Text = "Apellido:";
            // 
            // labelFechaNacimiento
            // 
            labelFechaNacimiento.AutoSize = true;
            labelFechaNacimiento.Location = new Point(299, 64);
            labelFechaNacimiento.Margin = new Padding(4, 0, 4, 0);
            labelFechaNacimiento.Name = "labelFechaNacimiento";
            labelFechaNacimiento.Size = new Size(152, 20);
            labelFechaNacimiento.TabIndex = 13;
            labelFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Location = new Point(573, 64);
            labelDireccion.Margin = new Padding(4, 0, 4, 0);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(75, 20);
            labelDireccion.TabIndex = 14;
            labelDireccion.Text = "Dirección:";
            // 
            // labelBuscarNombre
            // 
            labelBuscarNombre.AutoSize = true;
            labelBuscarNombre.Location = new Point(16, 385);
            labelBuscarNombre.Margin = new Padding(4, 0, 4, 0);
            labelBuscarNombre.Name = "labelBuscarNombre";
            labelBuscarNombre.Size = new Size(67, 20);
            labelBuscarNombre.TabIndex = 15;
            labelBuscarNombre.Text = "Nombre:";
            // 
            // textBoxBuscarNombre
            // 
            textBoxBuscarNombre.Location = new Point(91, 385);
            textBoxBuscarNombre.Margin = new Padding(4, 5, 4, 5);
            textBoxBuscarNombre.Name = "textBoxBuscarNombre";
            textBoxBuscarNombre.Size = new Size(132, 27);
            textBoxBuscarNombre.TabIndex = 17;
            // 
            // buttonRegresar
            // 
            buttonRegresar.Location = new Point(369, 381);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(100, 37);
            buttonRegresar.TabIndex = 20;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonCancelarBusqueda_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 428);
            Controls.Add(buttonRegresar);
            Controls.Add(textBoxBuscarNombre);
            Controls.Add(labelBuscarNombre);
            Controls.Add(labelDireccion);
            Controls.Add(labelFechaNacimiento);
            Controls.Add(labelApellido);
            Controls.Add(labelNombre);
            Controls.Add(dataGridViewUsuarios);
            Controls.Add(textBoxDireccion);
            Controls.Add(dateTimePickerFechaNacimiento);
            Controls.Add(textBoxApellido);
            Controls.Add(textBoxNombre);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonActualizar);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonNuevo);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Formulario de Clientes";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaNacimiento;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelFechaNacimiento;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelBuscarNombre;
        private System.Windows.Forms.TextBox textBoxBuscarNombre;
        private System.Windows.Forms.Button buttonRegresar;
    }
}