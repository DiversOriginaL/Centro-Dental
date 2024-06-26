﻿using Domain.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.FormsButton.Usuario;

namespace Presentacion.FormsButton.Usuario.FormHijos
{
    public partial class CrudUsuario : Form
    {
        public CrudUsuario()
        {
            InitializeComponent();
        }


        public Usuario usuarioForm;
        public CrudUsuario(Usuario usuarioForm) : this()
        {
            this.usuarioForm = usuarioForm;
        }

        #region Efecto PlaceHolder
        private void txtNombres_Enter(object sender, EventArgs e)
        {
            if(txtNombres.Text == "NOMBRES:")
            {
                txtNombres.Text = "";
                txtNombres.ForeColor = Color.Black;
            }
        }

        private void txtNombres_Leave(object sender, EventArgs e)
        {
            if(txtNombres.Text == "")
            {
                txtNombres.Text = "NOMBRES:";
                txtNombres.ForeColor = Color.Silver;
            }
        }

        private void txtApellidos_Enter(object sender, EventArgs e)
        {
            if (txtApellidos.Text == "APELLIDOS:")
            {
                txtApellidos.Text = "";
                txtApellidos.ForeColor = Color.Black;

            }
        }

        private void txtApellidos_Leave(object sender, EventArgs e)
        {
            if (txtApellidos.Text == "")
            {
                txtApellidos.Text = "APELLIDOS:";
                txtApellidos.ForeColor = Color.Silver;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "EMAIL:")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "EMAIL:";
                txtEmail.ForeColor = Color.Silver;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO:")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO:";
                txtUsuario.ForeColor = Color.Silver;

            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA:")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA:";
                txtContraseña.ForeColor = Color.Silver;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }
        private void cbPuesto_Enter(object sender, EventArgs e)
        {
            if(cbPuesto.Text == "PUESTO:")
            {
                cbPuesto.Text = "";
                cbPuesto.ForeColor = Color.Black;

            }

        }
        private void cbPuesto_Leave(object sender, EventArgs e)
        {
            if( cbPuesto.Text == "")
            {
                cbPuesto.Text = "PUESTO:";
                cbPuesto.ForeColor = Color.Silver;
            }
        }

        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            this.Close();
        }
        private void LimpiarCampos()
        {
            txtNombres.Text = "NOMBRES:";
            txtApellidos.Text = "APELLIDOS:";
            txtEmail.Text = "EMAIL:";
            txtUsuario.Text = "USUARIO:";
            txtContraseña.Text = "CONTRASEÑA:";
            cbPuesto.SelectedIndex = -1; // Deseleccionar el elemento seleccionado en el ComboBox
        }

        private void CrudUsuario_Load(object sender, EventArgs e)
        {
            cargarRoles();
            cbPuesto.Text = "PUESTO:";
        }

        CnUsuario cnUsuario = new CnUsuario();
        private void cargarRoles()
        {
            cbPuesto.DataSource = cnUsuario.cargarRol();
            cbPuesto.DisplayMember = "Rol";
            cbPuesto.ValueMember = "RolID";
            cbPuesto.SelectedIndex = -1;
        }

        //GUARDAR.
        private string idUsuario;
        public string operacion = "Insertar";
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(!rellenarCampo(txtNombres, "NOMBRES:") || !rellenarCampo(txtApellidos, "APELLIDOS:") ||
               !rellenarCampo(txtEmail, "EMAIL:") || !rellenarCampo(txtUsuario, "USUARIO:") || !rellenarCampo(cbPuesto, "PUESTO:")
            ){
                return;
            }

            string nombre = txtNombres.Text;
            string apellido = txtApellidos.Text;
            string email = txtEmail.Text;
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            object rolId = cbPuesto.SelectedValue;

            try
            {
                if (operacion == "Insertar")
                {
                    // Llamar al método InsertarUsuario con los valores obtenidos.
                    cnUsuario.InsertarUsuario(nombre, apellido, email, usuario, contraseña, rolId);
                    MessageBox.Show(" Usuario Insertado Correctamente.");


                }
                else if (operacion == "Editar")
                {
                    if (string.IsNullOrEmpty(idUsuario))
                    {
                        MessageBox.Show("No se ha seleccionado ningun usuario para editar.");
                        return;
                    }

                    //Llamar al metodo editarUsuario con los valores obtenidos.
                    cnUsuario.EditarUsuario(nombre, apellido, email, usuario, contraseña, rolId, idUsuario);
                    operacion = "Insertar";
                }

                if (usuarioForm != null)
                {
                    usuarioForm.Actualizardtgv();
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }
        private bool rellenarCampo(TextBox txtBox, string texto)
        {
            if (string.IsNullOrWhiteSpace(txtBox.Text) || txtBox.Text == texto)
            {
                MessageBox.Show($"POR FAVOR, RELLENE EL CAMPO {texto} CON LA INFORMACION CORRECTA!");
                txtBox.Focus();
                return false;
            }
            return true;
        }

        private bool rellenarCampo(ComboBox cbBox, string texto)
        {
            if (string.IsNullOrWhiteSpace(cbBox.Text) || cbBox.Text == texto)
            {
                MessageBox.Show($"POR FAVOR, RELLENE EL CAMPO {texto} CON LA INFORMACION CORRECTA!");
                return false;
            }
            return true;
        }

        public void CargarValores(string nombre, string apellido, string email, string usuario, string contraseña, string rolId, string idUsuario)
        {
            txtNombres.Text = nombre;
            txtApellidos.Text = apellido;
            txtEmail.Text = email;
            txtUsuario.Text = usuario;
            txtContraseña.Text = contraseña;
            cbPuesto.SelectedValue = rolId;
            this.idUsuario = idUsuario;

            lblInsertar.Text = "EDITANDO";
            txtNombres.ForeColor = Color.Black;
            txtApellidos.ForeColor = Color.Black;
            txtEmail.ForeColor = Color.Black;
            txtUsuario.ForeColor = Color.Black;
            txtContraseña.ForeColor = Color.Black;
            txtContraseña.UseSystemPasswordChar = false;
            cbPuesto.ForeColor = Color.Black;
        }

        private void pbVerContraseña_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = false;
            pbVerContraseña.Visible = false;
            pbOcultarContraseña.Visible = true;
        }

        private void pbOcultarContraseña_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
            pbVerContraseña.Visible = true;
            pbOcultarContraseña.Visible = false;
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloTexto(sender, e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloTexto(sender, e);
        }

        private void SoloTexto(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
