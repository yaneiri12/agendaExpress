using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaElectronicaWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {      
    }
        private List<Contacto> agenda = new List<Contacto>();
        private object txtCorreoElectronico;
        private object txtFechaNacimiento;

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            {
                
            }

            var contacto = new Contacto
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Direccion = txtDireccion.Text,
                Genero = cmbGenero.Text,
                EstadoCivil = cmbEstadoCivil.Text,
                Movil = txtMovil.Text,
                Telefono = txtTelefono.Text,
                CorreoElectronico = txtCorreo.Text
            };

            agenda.Add(contacto);
            ActualizarDataGridView();
            LimpiarCampos();
            MessageBox.Show("Contacto agregado correctamente.");
        }

        private void ActualizarDataGridView()
        {
           
        }

        private void LimpiarCampos()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = agenda;
        }

        private void ActualizarDataGridView1()
        {
            throw new NotImplementedException();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            
            txtDireccion.Clear();
            cmbGenero.SelectedIndex = -1;
            cmbEstadoCivil.SelectedIndex = -1;
            txtMovil.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            var contacto = agenda.FirstOrDefault(c => c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));

            if (contacto != null)
            {
                
                {
                   
                }

                contacto.Apellido = txtApellido.Text;
                contacto.Direccion = txtDireccion.Text;
                contacto.Genero = cmbGenero.Text;
                contacto.EstadoCivil = cmbEstadoCivil.Text;
                contacto.Movil = txtMovil.Text;
                contacto.Telefono = txtTelefono.Text;
                contacto.CorreoElectronico = txtCorreo.Text;

                ActualizarDataGridView();
                LimpiarCampos();
                MessageBox.Show("Contacto modificado correctamente.");
            }
            else
            {
                MessageBox.Show("Contacto no encontrado.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            var contacto = agenda.FirstOrDefault(c => c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));

            if (contacto != null)
            {
                txtApellido.Text = contacto.Apellido;
                txtDireccion.Text = contacto.Direccion;
                cmbGenero.Text = contacto.Genero;
                cmbEstadoCivil.Text = contacto.EstadoCivil;
                txtMovil.Text = contacto.Movil;
                txtTelefono.Text = contacto.Telefono;
                txtCorreo.Text = contacto.CorreoElectronico;
            }
        
            {
                
            }

        }
    }
    }

