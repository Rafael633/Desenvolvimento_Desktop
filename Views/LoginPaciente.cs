using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using Models;

namespace Views
{
    public class FormTelaPaciente : Form //Tela Inicial - Usuário Paciente
    {
        private System.ComponentModel.IContainer components = null;

        Label lblLogin;
        ListView listView;
        Button btnConfirmar;
        Button btnCancel;

        public FormTelaPaciente()
        {
            this.lblLogin = new Label();
            this.lblLogin.Text = $"Olá, {Auth.Paciente.Nome}";
            this.lblLogin.Location = new Point(200, 20);
            this.lblLogin.Size = new Size(150, 30);

            this.btnConfirmar = new Button();
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.Size = new Size(100, 30);
            this.btnConfirmar.Location = new Point(140, 290);
            this.btnConfirmar.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Sair";
            this.btnCancel.Size = new Size(100, 30);
            this.btnCancel.Location = new Point(250, 290);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            listView = new ListView();
            listView.Location = new Point(45, 70);
            listView.Size = new Size(410, 180);
            listView.View = View.Details;

            listView.Columns.Add("Dentista", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Data", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Sala", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Check", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.Sorting = SortOrder.Ascending;

            this.Controls.Add(this.lblLogin);
            this.Controls.Add(listView);

            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancel);
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja confirmar o agendamento selecionado?" +
                $"",
                "Confirmar Agendamento",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Agendamento confirmado com sucesso! " +
                    $"",
                    "",
                    MessageBoxButtons.OK
                );
            }
            else
            {
                Console.WriteLine("Clicou não");
            }
        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}