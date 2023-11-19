using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Formulario
{
    public partial class Form1 : Form
    {
        private BdComun mySQL;
        private bool isNewRecord = false;
        private int currentClientId;
        private System.Data.DataTable originalDataTable;

        public Form1()
        {
            InitializeComponent();
            mySQL = new BdComun();
            ClearForm();
            LoadUserData();
            originalDataTable = (System.Data.DataTable)dataGridViewUsuarios.DataSource;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ClearForm()
        {
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            dateTimePickerFechaNacimiento.Value = DateTime.Now;
            textBoxDireccion.Text = "";
        }

        private void EnableControls(bool enable)
        {
            textBoxNombre.Enabled = enable;
            textBoxApellido.Enabled = enable;
            dateTimePickerFechaNacimiento.Enabled = enable;
            textBoxDireccion.Enabled = enable;

            buttonNuevo.Enabled = !enable;
            buttonGuardar.Enabled = enable;
            buttonActualizar.Enabled = !enable;
            buttonEliminar.Enabled = !enable;
            buttonBuscar.Enabled = !enable;
            buttonCancelar.Enabled = enable;
        }

        private void LoadUserData()
        {
            // Cargar datos de usuarios en el DataGridView
            using (MySqlConnection conexion = mySQL.GetConexion())
            {
                string selectQuery = "SELECT IdCliente, Nombre, Apellido, Fecha_Nacimiento, Direccion FROM clientes";
                using (MySqlCommand cmd = new MySqlCommand(selectQuery, conexion))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        originalDataTable = new System.Data.DataTable();
                        adapter.Fill(originalDataTable);
                        dataGridViewUsuarios.DataSource = originalDataTable;
                    }
                }
            }
        }

        private void dataGridViewUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            // Manejar la selección en el DataGridView
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewUsuarios.SelectedRows[0];
                currentClientId = Convert.ToInt32(selectedRow.Cells["IdCliente"].Value);
                textBoxNombre.Text = Convert.ToString(selectedRow.Cells["Nombre"].Value);
                textBoxApellido.Text = Convert.ToString(selectedRow.Cells["Apellido"].Value);
                dateTimePickerFechaNacimiento.Value = Convert.ToDateTime(selectedRow.Cells["Fecha_Nacimiento"].Value);
                textBoxDireccion.Text = Convert.ToString(selectedRow.Cells["Direccion"].Value);
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            isNewRecord = true;
            ClearForm();
            EnableControls(true);
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            // Guardar o actualizar el registro según sea necesario
            using (MySqlConnection conexion = mySQL.GetConexion())
            {
                if (isNewRecord)
                {
                    // Insertar nuevo cliente
                    string insertQuery = "INSERT INTO clientes (Nombre, Apellido, Fecha_Nacimiento, Direccion) " +
                                         "VALUES (@Nombre, @Apellido, @Fecha_Nacimiento, @Direccion)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", textBoxNombre.Text);
                        cmd.Parameters.AddWithValue("@Apellido", textBoxApellido.Text);
                        cmd.Parameters.AddWithValue("@Fecha_Nacimiento", dateTimePickerFechaNacimiento.Value);
                        cmd.Parameters.AddWithValue("@Direccion", textBoxDireccion.Text);

                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    // Actualizar cliente existente
                    string updateQuery = "UPDATE clientes SET Nombre=@Nombre, Apellido=@Apellido, " +
                                         "Fecha_Nacimiento=@Fecha_Nacimiento, Direccion=@Direccion " +
                                         "WHERE IdCliente=@IdCliente";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", textBoxNombre.Text);
                        cmd.Parameters.AddWithValue("@Apellido", textBoxApellido.Text);
                        cmd.Parameters.AddWithValue("@Fecha_Nacimiento", dateTimePickerFechaNacimiento.Value);
                        cmd.Parameters.AddWithValue("@Direccion", textBoxDireccion.Text);
                        cmd.Parameters.AddWithValue("@IdCliente", currentClientId);

                        cmd.ExecuteNonQuery();
                    }
                }

                ClearForm();
                EnableControls(false);
                LoadUserData(); // Actualizar la lista de usuarios después de guardar
            } // La conexión se cerrará automáticamente al salir del bloque using
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (currentClientId > 0)
            {
                isNewRecord = false;
                EnableControls(true);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente para actualizar.", "Actualizar Cliente");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (currentClientId > 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?", "Eliminar Cliente", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Eliminar cliente
                    string deleteQuery = "DELETE FROM clientes WHERE IdCliente=@IdCliente";

                    using (MySqlConnection conexion = mySQL.GetConexion())
                    {
                        using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conexion))
                        {
                            cmd.Parameters.AddWithValue("@IdCliente", currentClientId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    ClearForm();
                    EnableControls(false);
                    LoadUserData(); // Actualizar la lista de usuarios después de eliminar
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente para eliminar.", "Eliminar Cliente");
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            // Realizar la búsqueda filtrada por nombre
            using (MySqlConnection conexion = mySQL.GetConexion())
            {
                string searchQuery = "SELECT IdCliente, Nombre, Apellido, Fecha_Nacimiento, Direccion " +
                                     "FROM clientes WHERE Nombre LIKE @Nombre";

                using (MySqlCommand cmd = new MySqlCommand(searchQuery, conexion))
                {
                    cmd.Parameters.AddWithValue("@Nombre", "%" + textBoxBuscarNombre.Text + "%");

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        System.Data.DataTable table = new System.Data.DataTable();
                        adapter.Fill(table);
                        dataGridViewUsuarios.DataSource = table;
                    }
                }
            }
        }

        private void buttonCancelarBusqueda_Click(object sender, EventArgs e)
        {
            // Cancelar la búsqueda y restaurar los datos originales
            dataGridViewUsuarios.DataSource = originalDataTable;
            textBoxBuscarNombre.Text = "";
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            ClearForm();
            EnableControls(false);
            textBoxNombre.Text = "";
            dataGridViewUsuarios.DataSource = originalDataTable;
        }
    }
}