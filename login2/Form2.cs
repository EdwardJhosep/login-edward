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
            //conectamos la base de datos 
        {
            string connectionString = "Data Source=DESKTOP-7LDGQBD;Initial Catalog=login;Integrated Security=True";

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
                        command.Parameters.AddWithValue("@Usuario", textBox1.Text);
                        command.Parameters.AddWithValue("@Contraseña", textBox2.Text);
                        command.Parameters.AddWithValue("@Correo", textBox3.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Crear una instancia de Form4 y mostrarla.
                            Form4 form4 = new Form4();
                            form4.Show();

                            //  ocultar el formulario actual (Form1) si lo deseas.
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("El registro ha fallado.");
                        }
                    }
                }
                // indicación de que algo salió mal 
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }

}


