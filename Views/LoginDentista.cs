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
    public class FormTelaDentista : Form //Tela Inicial - Usuário Dentista
    {
        private System.ComponentModel.IContainer components = null;

        Label lblLogin;

        Button btnDentista;
        Button btnPaciente;
        Button btnProcedi;
        Button btnEspeciali;
        Button btnSala;
        Button btnAgendamento;
        Button btnCancel;

        public FormTelaDentista()
        {
            this.lblLogin = new Label();
            this.lblLogin.Text = $"Olá, {Auth.Dentista.Nome}";
            this.lblLogin.Location = new Point(100, 20);
            this.lblLogin.Size = new Size(150, 30);

            this.btnDentista = new Button();
            this.btnDentista.Text = "Dentista";
            this.btnDentista.Location = new Point(40, 60);
            this.btnDentista.Size = new Size(100, 30);
            this.btnDentista.Click += new EventHandler(this.handleDentistaClick);

            this.btnPaciente = new Button();
            this.btnPaciente.Text = "Paciente";
            this.btnPaciente.Location = new Point(160, 60);
            this.btnPaciente.Size = new Size(100, 30);
            this.btnPaciente.Click += new EventHandler(this.handlePacienteClick);

            this.btnProcedi = new Button();
            this.btnProcedi.Text = "Procedimento";
            this.btnProcedi.Location = new Point(40, 100);
            this.btnProcedi.Size = new Size(100, 30);
            this.btnProcedi.Click += new EventHandler(this.handleProcedimentoClick);

            this.btnEspeciali = new Button();
            this.btnEspeciali.Text = "Especialidade";
            this.btnEspeciali.Location = new Point(160, 100);
            this.btnEspeciali.Size = new Size(100, 30);
            this.btnEspeciali.Click += new EventHandler(this.handleEspecialidadeClick);

            this.btnSala = new Button();
            this.btnSala.Text = "Sala";
            this.btnSala.Location = new Point(40, 140);
            this.btnSala.Size = new Size(100, 30);
            this.btnSala.Click += new EventHandler(this.handleSalaClick);

            this.btnAgendamento = new Button();
            this.btnAgendamento.Text = "Agendamento";
            this.btnAgendamento.Location = new Point(160, 140);
            this.btnAgendamento.Size = new Size(100, 30);
            this.btnAgendamento.Click += new EventHandler(this.handleAgendamentoClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Sair";
            this.btnCancel.Location = new Point(110, 200);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblLogin);

            this.Controls.Add(this.btnDentista);
            this.Controls.Add(this.btnPaciente);
            this.Controls.Add(this.btnProcedi);
            this.Controls.Add(this.btnEspeciali);
            this.Controls.Add(this.btnSala);
            this.Controls.Add(this.btnAgendamento);
            this.Controls.Add(this.btnCancel);

        }
        private void handlePacienteClick(object sender, EventArgs e)
        {
            /*Form3 menu = new Form3();
            menu.ShowDialog();*/
            this.Close();
        }
        private void handleDentistaClick(object sender, EventArgs e)
        {
            FormDentistaCrud menu = new FormDentistaCrud();
            menu.ShowDialog();
            this.Close();
        }
        private void handleProcedimentoClick(object sender, EventArgs e)
        {
            /*Form11 menu = new Form11();
            menu.ShowDialog();*/
            this.Close();
        }
        private void handleEspecialidadeClick(object sender, EventArgs e)
        {
            /*Form15 menu = new Form15();
            menu.ShowDialog();*/
            this.Close();
        }
        private void handleSalaClick(object sender, EventArgs e)
        {
            /*Form19 menu = new Form19();
            menu.ShowDialog();*/
            this.Close();
        }
        private void handleAgendamentoClick(object sender, EventArgs e)
        {
            /*Form23 menu = new Form23();
            menu.ShowDialog();*/
            this.Close();
        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}