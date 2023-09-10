using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario RegisterForm.
            Form2 registerForm = new Form2();

            // Mostrar el formulario RegisterForm.
            registerForm.Show();

            // Opcionalmente, puedes ocultar el formulario actual (Form1) si lo deseas.
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar si los campos de usuario y contraseña están vacíos
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return; // Salir del método si los campos están vacíos
            }

            // Conectar a la base de datos
            string connectionString = "Data Source=EDWARDPC\\SQLEXPRESS;Initial Catalog=login;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Construir la consulta SQL para verificar el inicio de sesión.
                    string query = "SELECT COUNT(*) FROM Usuario WHERE Usuario = @Usuario AND Contraseña = @Contraseña";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Definir los parámetros de la consulta.
                        command.Parameters.AddWithValue("@Usuario", textBox1.Text);
                        command.Parameters.AddWithValue("@Contraseña", textBox2.Text);

                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            // Crear una instancia del formulario Form3.
                            Form3 form3 = new Form3();

                            // Mostrar el formulario Form3.
                            form3.Show();

                            // Opcionalmente, puedes ocultar el formulario actual (Form1) si lo deseas.
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("El inicio de sesión ha fallado. Verifica tus credenciales.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}


