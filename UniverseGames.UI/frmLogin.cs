using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UniverseGames.UI.Models;
using UniverseGames.UI.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace UniverseGames.UI
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
        private bool EmailValido(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!EmailValido(txtEmail.Text))
            {
                MessageBox.Show("Email inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}