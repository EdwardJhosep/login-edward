using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace login2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario RegisterForm.
            Form1 registerForm = new Form1();

            // Mostrar el formulario RegisterForm.
            registerForm.Show();

            // Opcionalmente, puedes ocultar el formulario actual (Form1) si lo deseas.
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;
            string correo = textBox3.Text;

            // Verifica si los campos obligatorios están vacíos.
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña) || string.IsNullOrWhiteSpace(correo))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return; // No continúes si faltan campos obligatorios.
            }

            // Verifica si el campo "Correo" tiene un formato de correo electrónico válido.
            if (!IsValidEmail(correo))
            {
                MessageBox.Show("Por favor, ingresa una dirección de correo electrónico válida.");
                return; // No continúes si el correo no es válido.
            }

            string connectionString = "Data Source=EDWARDPC\\SQLEXPRESS;Initial Catalog=login;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Aquí puedes construir tu consulta SQL para insertar un nuevo usuario.
                    string query = "INSERT INTO Usuario (Usuario, Contraseña, Correo) VALUES (@Usuario, @Contraseña, @Correo)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Define los parámetros de la consulta.
                        command.Parameters.AddWithValue("@Usuario", usuario);
                        command.Parameters.AddWithValue("@Contraseña", contraseña);
                        command.Parameters.AddWithValue("@Correo", correo);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
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
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }


    }
}

