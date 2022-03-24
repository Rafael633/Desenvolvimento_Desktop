using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace ExemploTela
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Form1 : Form //Tela de Login
    {
        private System.ComponentModel.IContainer components = null;

        Label lblUser;
        Label lblPass;

        TextBox txtUser;
        TextBox txtPass;

        Button btnConfirm;
        Button btnCancel;

        public Form1()
        {
            this.lblUser = new Label();
            this.lblUser.Text = "Usuário";
            this.lblUser.Location = new Point(120, 20);

            this.lblPass = new Label();
            this.lblPass.Text = "Senha";
            this.lblPass.Location = new Point(120, 80);

            this.txtUser = new TextBox();
            this.txtUser.Location = new Point(10, 50);
            this.txtUser.Size = new Size(280, 30);

            this.txtPass = new TextBox();
            this.txtPass.Location = new Point(10, 110);
            this.txtPass.Size = new Size(280, 30);
            this.txtPass.PasswordChar = '*';

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(100, 180);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(100, 220);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPass);

            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPass);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Login";
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void handleConfirmClick(object sender, EventArgs e)
        {

            if (this.txtUser.Text == "dentista" && this.txtPass.Text == "123")
            {
                Form2 form = new Form2();
                form.Size = new Size(320, 300);
                form.Show();
            }
            else
            {
                //Form3 form = new Form3();
                Form27 form = new Form27();
                form.Size = new Size(515, 390);
                form.Show();

            }
        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Form2 : Form //Tela Inicial - Usuário Dentista
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

        public Form2()
        {
            this.lblLogin = new Label();
            this.lblLogin.Text = "Olá Fulano";
            this.lblLogin.Location = new Point(117, 20);

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
            Form3 menu = new Form3();
            menu.ShowDialog();
        }
        private void handleDentistaClick(object sender, EventArgs e)
        {
            Form4 menu = new Form4();
            menu.ShowDialog();
        }
        private void handleProcedimentoClick(object sender, EventArgs e)
        {
            Form11 menu = new Form11();
            menu.ShowDialog();
        }
        private void handleEspecialidadeClick(object sender, EventArgs e)
        {
            Form15 menu = new Form15();
            menu.ShowDialog();
        }
        private void handleSalaClick(object sender, EventArgs e)
        {
            Form19 menu = new Form19();
            menu.ShowDialog();
        }
        private void handleAgendamentoClick(object sender, EventArgs e)
        {
            Form23 menu = new Form23();
            menu.ShowDialog();
        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Form27 : Form //Tela Inicial - Usuário Paciente
    {
        private System.ComponentModel.IContainer components = null;

        Label lblLogin;
        ListView listView;
        Button btnConfirmar;
        Button btnCancel;

        public Form27()
        {
            this.lblLogin = new Label();
            this.lblLogin.Text = "Olá Fulano";
            this.lblLogin.Location = new Point(220, 20);

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
            ListViewItem lista1 = new ListViewItem("0");
            lista1.SubItems.Add("Rafael");
            lista1.SubItems.Add("000.000.000-00");
            lista1.SubItems.Add("4002-8922");
            lista1.SubItems.Add("teste@gmail.com");
            lista1.SubItems.Add("2002-01-31");

            listView.Items.AddRange(new ListViewItem[] { lista1 });
            listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            listView.Columns.Add("CPF", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Telefone", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Email", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Data de Nascimento", -2, HorizontalAlignment.Left);
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

    public class Form3 : Form //Paciente
    {
        private System.ComponentModel.IContainer components = null;

        Label lblPaciente;

        Button btnCancel;
        Button btnInsert;
        Button btnDeletar;
        Button btnUpdate;

        ListView listView;
        public Form3()
        {
            this.lblPaciente = new Label();
            this.lblPaciente.Text = "Paciente";
            this.lblPaciente.Location = new Point(220, 10);

            this.Controls.Add(this.lblPaciente);

            listView = new ListView();
            listView.Location = new Point(45, 70);
            listView.Size = new Size(410, 100);
            listView.View = View.Details;

            listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            listView.Columns.Add("CPF", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Telefone", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Email", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Data de Nascimento", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Status", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.Sorting = SortOrder.Ascending;

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(360, 220);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.btnInsert = new Button();
            this.btnInsert.Text = "Inserir";
            this.btnInsert.Location = new Point(60, 220);
            this.btnInsert.Size = new Size(80, 30);
            this.btnInsert.Click += new EventHandler(this.handleConfirmPacienteInserir);

            this.btnDeletar = new Button();
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Location = new Point(160, 220);
            this.btnDeletar.Size = new Size(80, 30);
            this.btnDeletar.Click += new EventHandler(this.handleConfirmPacienteDeletar);

            this.btnUpdate = new Button();
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.Location = new Point(260, 220);
            this.btnUpdate.Size = new Size(80, 30);
            this.btnUpdate.Click += new EventHandler(this.handleConfirmPacienteAtualizar);

            this.Controls.Add(listView);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnUpdate);

            this.ClientSize = new System.Drawing.Size(500, 300);
        }

        private void handleConfirmPacienteAtualizar(object sender, EventArgs e)
        {
            Form7 menu = new Form7();
            menu.Size = new Size(325, 550);
            menu.ShowDialog();
        }
        private void handleConfirmPacienteDeletar(object sender, EventArgs e)
        {
            Form6 menu = new Form6();
            menu.Size = new Size(320, 228);
            menu.ShowDialog();
        }
        private void handleConfirmPacienteInserir(object sender, EventArgs e)
        {
            Form5 menu = new Form5();
            menu.Size = new Size(325, 510);
            menu.ShowDialog();
        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Form4 : Form //Dentista
    {
        private System.ComponentModel.IContainer components = null;

        Label lblDentista;

        Button btnCancel;
        Button btnInsert;
        Button btnDeletar;
        Button btnUpdate;

        ListView listView;
        public Form4()
        {
            this.lblDentista = new Label();
            this.lblDentista.Text = "Dentista";
            this.lblDentista.Location = new Point(220, 10);

            this.Controls.Add(this.lblDentista);

            listView = new ListView();
            listView.Location = new Point(45, 70);
            listView.Size = new Size(410, 100);
            listView.View = View.Details;
            ListViewItem lista1 = new ListViewItem("0");
            lista1.SubItems.Add("Rafael");
            lista1.SubItems.Add("000.000.000-00");
            lista1.SubItems.Add("4002-8922");
            lista1.SubItems.Add("teste@gmail.com");
            lista1.SubItems.Add("ABC-01");
            lista1.SubItems.Add("R$900,00");
            lista1.SubItems.Add("1");
            lista1.SubItems.Add("Endodontia");
            lista1.SubItems.Add("Estrutura dos dentes");

            listView.Items.AddRange(new ListViewItem[] { lista1 });
            listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            listView.Columns.Add("CPF", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Telefone", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Email", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Registro", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Salário", -2, HorizontalAlignment.Left);
            listView.Columns.Add("ID da Especialidade", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Descrição", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Tarefas", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.Sorting = SortOrder.Ascending;

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(360, 220);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.btnInsert = new Button();
            this.btnInsert.Text = "Inserir";
            this.btnInsert.Location = new Point(60, 220);
            this.btnInsert.Size = new Size(80, 30);
            this.btnInsert.Click += new EventHandler(this.handleConfirmClickDentistaInserir);

            this.btnDeletar = new Button();
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Location = new Point(160, 220);
            this.btnDeletar.Size = new Size(80, 30);
            this.btnDeletar.Click += new EventHandler(this.handleConfirmClickDentistaDeletar);

            this.btnUpdate = new Button();
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.Location = new Point(260, 220);
            this.btnUpdate.Size = new Size(80, 30);
            this.btnUpdate.Click += new EventHandler(this.handleConfirmClickDentistaAtualizar);

            this.Controls.Add(listView);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnUpdate);

            this.ClientSize = new System.Drawing.Size(500, 300);
        }

        private void handleConfirmClickDentistaAtualizar(object sender, EventArgs e)
        {
            Form10 menu = new Form10();
            menu.Size = new Size(325, 595);
            menu.ShowDialog();
        }
        private void handleConfirmClickDentistaDeletar(object sender, EventArgs e)
        {
            Form9 menu = new Form9();
            menu.Size = new Size(320, 228);
            menu.ShowDialog();
        }
        private void handleConfirmClickDentistaInserir(object sender, EventArgs e)
        {
            Form8 menu = new Form8();
            menu.Size = new Size(325, 595);
            menu.ShowDialog();
        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Form5 : Form //Inserir Paciente
    {
        private System.ComponentModel.IContainer components = null;

        Label lblNome;
        Label lblCpf;
        Label lblNascimento;
        Label lblTelefone;
        Label lblEmail;
        Label lblSenha;

        TextBox txtNome;
        TextBox txtCpf;
        DateTimePicker dtpNascimento;
        TextBox txtTelefone;
        TextBox txtEmail;
        TextBox txtSenha;

        Button btnConfirm;
        Button btnCancel;

        public Form5()
        {
            this.lblNome = new Label();
            this.lblNome.Text = "Nome";
            this.lblNome.Location = new Point(132, 20);

            this.lblCpf = new Label();
            this.lblCpf.Text = "CPF";
            this.lblCpf.Location = new Point(135, 80);
            this.lblCpf.Size = new Size(300, 30);

            this.lblTelefone = new Label();
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.Location = new Point(132, 140);
            this.lblTelefone.Size = new Size(300, 30);

            this.lblEmail = new Label();
            this.lblEmail.Text = "Email";
            this.lblEmail.Location = new Point(130, 200);
            this.lblEmail.Size = new Size(300, 30);

            this.lblSenha = new Label();
            this.lblSenha.Text = "Senha";
            this.lblSenha.Location = new Point(130, 260);
            this.lblSenha.Size = new Size(300, 30);

            this.lblNascimento = new Label();
            this.lblNascimento.Text = "Data de Nascimento";
            this.lblNascimento.Location = new Point(95, 320);
            this.lblNascimento.Size = new Size(300, 30);

            this.txtNome = new TextBox();
            this.txtNome.Location = new Point(10, 50);
            this.txtNome.Size = new Size(280, 30);

            this.txtCpf = new TextBox();
            this.txtCpf.Location = new Point(10, 110);
            this.txtCpf.Size = new Size(280, 30);

            this.txtTelefone = new TextBox();
            this.txtTelefone.Location = new Point(10, 170);
            this.txtTelefone.Size = new Size(280, 30);

            this.txtEmail = new TextBox();
            this.txtEmail.Location = new Point(10, 230);
            this.txtEmail.Size = new Size(280, 30);

            this.txtSenha = new TextBox();
            this.txtSenha.Location = new Point(10, 290);
            this.txtSenha.Size = new Size(280, 30);

            this.dtpNascimento = new DateTimePicker();
            this.dtpNascimento.Location = new Point(10, 350);
            this.dtpNascimento.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(70, 430);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(160, 430);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSenha);

            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSenha);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Inserir Paciente ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja inserir este paciente?" +
                $"",
                "Inserir Paciente",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Paciente cadastrado com sucesso! " +
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
    public class Form6 : Form //Deletar Paciente
    {
        Label lblId;

        TextBox TxtId;

        Button btnConfirm;
        Button btnCancel;

        public Form6()
        {
            this.lblId = new Label();
            this.lblId.Text = "Digite o ID:";
            this.lblId.Location = new Point(110, 20);

            this.TxtId = new TextBox();
            this.TxtId.Location = new Point(10, 50);
            this.TxtId.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(55, 150);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(145, 150);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblId);
            this.Controls.Add(this.TxtId);

            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);

            //this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Deletar Paciente ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja excluir este paciente?" +
                $"",
                "Excluir Paciente",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Paciente deletado com sucesso! " +
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

    public class Form7 : Form //Atualizar Paciente
    {
        private System.ComponentModel.IContainer components = null;

        Label lblNome;
        Label lblCpf;
        Label lblNascimento;
        Label lblTelefone;
        Label lblEmail;
        Label lblSenha;
        Label lblId;

        TextBox txtNome;
        TextBox txtCpf;
        DateTimePicker dtpNascimento;
        TextBox txtTelefone;
        TextBox txtEmail;
        TextBox txtSenha;
        TextBox txtId;

        Button btnConfirm;
        Button btnCancel;

        public Form7()
        {
            this.lblNome = new Label();
            this.lblNome.Text = "Nome";
            this.lblNome.Location = new Point(132, 20);

            this.lblCpf = new Label();
            this.lblCpf.Text = "CPF";
            this.lblCpf.Location = new Point(135, 80);
            this.lblCpf.Size = new Size(300, 30);

            this.lblTelefone = new Label();
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.Location = new Point(132, 140);
            this.lblTelefone.Size = new Size(300, 30);

            this.lblEmail = new Label();
            this.lblEmail.Text = "Email";
            this.lblEmail.Location = new Point(130, 200);
            this.lblEmail.Size = new Size(300, 30);

            this.lblSenha = new Label();
            this.lblSenha.Text = "Senha";
            this.lblSenha.Location = new Point(130, 260);
            this.lblSenha.Size = new Size(300, 30);

            this.lblNascimento = new Label();
            this.lblNascimento.Text = "Data de Nascimento";
            this.lblNascimento.Location = new Point(95, 320);
            this.lblNascimento.Size = new Size(300, 30);

            this.lblId = new Label();
            this.lblId.Text = "ID de Alteração";
            this.lblId.Location = new Point(110, 380);
            this.lblId.Size = new Size(300, 30);

            this.txtNome = new TextBox();
            this.txtNome.Location = new Point(10, 50);
            this.txtNome.Size = new Size(280, 30);

            this.txtCpf = new TextBox();
            this.txtCpf.Location = new Point(10, 110);
            this.txtCpf.Size = new Size(280, 30);

            this.txtTelefone = new TextBox();
            this.txtTelefone.Location = new Point(10, 170);
            this.txtTelefone.Size = new Size(280, 30);

            this.txtEmail = new TextBox();
            this.txtEmail.Location = new Point(10, 230);
            this.txtEmail.Size = new Size(280, 30);

            this.txtSenha = new TextBox();
            this.txtSenha.Location = new Point(10, 290);
            this.txtSenha.Size = new Size(280, 30);

            this.dtpNascimento = new DateTimePicker();
            this.dtpNascimento.Location = new Point(10, 350);
            this.dtpNascimento.Size = new Size(280, 30);

            this.txtId = new TextBox();
            this.txtId.Location = new Point(10, 410);
            this.txtId.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(70, 460);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(160, 460);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblId);

            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtId);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Atualizar Paciente ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja atualizar os dados deste paciente?" +
                $"",
                "Atualizar Paciente",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Paciente alterado com sucesso! " +
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

    public class Form8 : Form //Inserir Dentista
    {
        private System.ComponentModel.IContainer components = null;

        Label lblNome;
        Label lblCpf;
        Label lblTelefone;
        Label lblEmail;
        Label lblSenha;
        Label lblRegistro;
        Label lblSalario;
        Label lblEspecialidade;

        TextBox txtNome;
        TextBox txtCpf;
        TextBox txtTelefone;
        TextBox txtEmail;
        TextBox txtSenha;
        TextBox txtRegistro;
        TextBox txtSalario;
        TextBox txtEspecialidade;

        Button btnConfirm;
        Button btnCancel;

        public Form8()
        {
            this.lblNome = new Label();
            this.lblNome.Text = "Nome";
            this.lblNome.Location = new Point(132, 20);

            this.lblCpf = new Label();
            this.lblCpf.Text = "CPF";
            this.lblCpf.Location = new Point(135, 80);

            this.lblTelefone = new Label();
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.Location = new Point(132, 140);

            this.lblEmail = new Label();
            this.lblEmail.Text = "Email";
            this.lblEmail.Location = new Point(130, 200);

            this.lblSenha = new Label();
            this.lblSenha.Text = "Senha";
            this.lblSenha.Location = new Point(130, 260);

            this.lblRegistro = new Label();
            this.lblRegistro.Text = "Registro";
            this.lblRegistro.Location = new Point(128, 320);

            this.lblSalario = new Label();
            this.lblSalario.Text = "Salario";
            this.lblSalario.Location = new Point(128, 380);

            this.lblEspecialidade = new Label();
            this.lblEspecialidade.Text = "Especialidade";
            this.lblEspecialidade.Location = new Point(120, 440);

            this.txtNome = new TextBox();
            this.txtNome.Location = new Point(10, 50);
            this.txtNome.Size = new Size(280, 30);

            this.txtCpf = new TextBox();
            this.txtCpf.Location = new Point(10, 110);
            this.txtCpf.Size = new Size(280, 30);

            this.txtTelefone = new TextBox();
            this.txtTelefone.Location = new Point(10, 170);
            this.txtTelefone.Size = new Size(280, 30);

            this.txtEmail = new TextBox();
            this.txtEmail.Location = new Point(10, 230);
            this.txtEmail.Size = new Size(280, 30);

            this.txtSenha = new TextBox();
            this.txtSenha.Location = new Point(10, 290);
            this.txtSenha.Size = new Size(280, 30);

            this.txtRegistro = new TextBox();
            this.txtRegistro.Location = new Point(10, 350);
            this.txtRegistro.Size = new Size(280, 30);

            this.txtSalario = new TextBox();
            this.txtSalario.Location = new Point(10, 410);
            this.txtSalario.Size = new Size(280, 30);

            this.txtEspecialidade = new TextBox();
            this.txtEspecialidade.Location = new Point(10, 470);
            this.txtEspecialidade.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(70, 520);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(160, 520);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblEspecialidade);

            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtEspecialidade);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Inserir Dentista ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja inserir esse dentista?" +
                $"",
                "Inserir Dentista",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Dentista cadastrado com sucesso! " +
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

    public class Form9 : Form //Deletar Dentista
    {
        Label lblId;

        TextBox TxtId;

        Button btnConfirm;
        Button btnCancel;

        public Form9()
        {
            this.lblId = new Label();
            this.lblId.Text = "Digite o ID:";
            this.lblId.Location = new Point(110, 20);

            this.TxtId = new TextBox();
            this.TxtId.Location = new Point(10, 50);
            this.TxtId.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(50, 150);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(140, 150);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblId);
            this.Controls.Add(this.TxtId);

            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);

            //this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Deletar Dentista ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja excluir esse dentista?" +
                $"",
                "Excluir Dentista",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Dentista deletado com sucesso! " +
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

    public class Form10 : Form //Atualizar Dentista
    {
        Label lblNome;
        Label lblCpf;
        Label lblTelefone;
        Label lblEmail;
        Label lblSenha;
        Label lblRegistro;
        Label lblSalario;
        Label lblEspecialidade;

        TextBox txtNome;
        TextBox txtCpf;
        TextBox txtTelefone;
        TextBox txtEmail;
        TextBox txtSenha;
        TextBox txtRegistro;
        TextBox txtSalario;
        TextBox txtEspecialidade;

        Button btnConfirm;
        Button btnCancel;

        public Form10()
        {

            this.lblNome = new Label();
            this.lblNome.Text = "Nome";
            this.lblNome.Location = new Point(132, 20);

            this.lblCpf = new Label();
            this.lblCpf.Text = "CPF";
            this.lblCpf.Location = new Point(135, 80);

            this.lblTelefone = new Label();
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.Location = new Point(132, 140);

            this.lblEmail = new Label();
            this.lblEmail.Text = "Email";
            this.lblEmail.Location = new Point(130, 200);

            this.lblSenha = new Label();
            this.lblSenha.Text = "Senha";
            this.lblSenha.Location = new Point(130, 260);

            this.lblRegistro = new Label();
            this.lblRegistro.Text = "Registro";
            this.lblRegistro.Location = new Point(128, 320);

            this.lblSalario = new Label();
            this.lblSalario.Text = "Salario";
            this.lblSalario.Location = new Point(128, 380);

            this.lblEspecialidade = new Label();
            this.lblEspecialidade.Text = "Especialidade";
            this.lblEspecialidade.Location = new Point(120, 440);

            this.txtNome = new TextBox();
            this.txtNome.Location = new Point(10, 50);
            this.txtNome.Size = new Size(280, 30);

            this.txtCpf = new TextBox();
            this.txtCpf.Location = new Point(10, 110);
            this.txtCpf.Size = new Size(280, 30);

            this.txtTelefone = new TextBox();
            this.txtTelefone.Location = new Point(10, 170);
            this.txtTelefone.Size = new Size(280, 30);

            this.txtEmail = new TextBox();
            this.txtEmail.Location = new Point(10, 230);
            this.txtEmail.Size = new Size(280, 30);

            this.txtSenha = new TextBox();
            this.txtSenha.Location = new Point(10, 290);
            this.txtSenha.Size = new Size(280, 30);

            this.txtRegistro = new TextBox();
            this.txtRegistro.Location = new Point(10, 350);
            this.txtRegistro.Size = new Size(280, 30);

            this.txtSalario = new TextBox();
            this.txtSalario.Location = new Point(10, 410);
            this.txtSalario.Size = new Size(280, 30);

            this.txtEspecialidade = new TextBox();
            this.txtEspecialidade.Location = new Point(10, 470);
            this.txtEspecialidade.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(70, 520);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(160, 520);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblEspecialidade);

            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtEspecialidade);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            //this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Atualizar Dentista ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja alterar os dados deste dentista?" +
                $"",
                "Atualizar Dentista",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Dentista alterado com sucesso! " +
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

    public class Form11 : Form //Procedimento
    {
        private System.ComponentModel.IContainer components = null;

        Label lblProcedimento;

        Button btnCancel;
        Button btnInsert;
        Button btnDeletar;
        Button btnUpdate;

        ListView listView;
        public Form11()
        {
            this.lblProcedimento = new Label();
            this.lblProcedimento.Text = "Procedimento";
            this.lblProcedimento.Location = new Point(220, 10);

            this.Controls.Add(this.lblProcedimento);

            listView = new ListView();
            listView.Location = new Point(45, 70);
            listView.Size = new Size(410, 100);
            listView.View = View.Details;
            ListViewItem lista1 = new ListViewItem("0");
            lista1.SubItems.Add("Arrancar dente");
            lista1.SubItems.Add("R$ 50,00");

            listView.Items.AddRange(new ListViewItem[] { lista1 });
            listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Descrição", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Preço", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.Sorting = SortOrder.Ascending;

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(360, 220);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.btnInsert = new Button();
            this.btnInsert.Text = "Inserir";
            this.btnInsert.Location = new Point(60, 220);
            this.btnInsert.Size = new Size(80, 30);
            this.btnInsert.Click += new EventHandler(this.handleConfirmClickProcedimentoInserir);

            this.btnDeletar = new Button();
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Location = new Point(160, 220);
            this.btnDeletar.Size = new Size(80, 30);
            this.btnDeletar.Click += new EventHandler(this.handleConfirmClickProcedimentoDeletar);

            this.btnUpdate = new Button();
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.Location = new Point(260, 220);
            this.btnUpdate.Size = new Size(80, 30);
            this.btnUpdate.Click += new EventHandler(this.handleConfirmClickProcedimentoAtualizar);

            this.Controls.Add(listView);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnUpdate);

            this.ClientSize = new System.Drawing.Size(500, 300);
        }

        private void handleConfirmClickProcedimentoAtualizar(object sender, EventArgs e)
        {
            Form14 menu = new Form14();
            menu.ShowDialog();
        }
        private void handleConfirmClickProcedimentoDeletar(object sender, EventArgs e)
        {
            Form13 menu = new Form13();
            menu.Size = new Size(320, 228);
            menu.ShowDialog();
        }
        private void handleConfirmClickProcedimentoInserir(object sender, EventArgs e)
        {
            Form12 menu = new Form12();
            menu.ShowDialog();
        }
        private void handleCancelClick(object sender, EventArgs e)
        {

            this.Close();
        }
    }

    public class Form12 : Form //Inserir Procedimento
    {
        private System.ComponentModel.IContainer components = null;

        Label lblDescricao;
        Label lblPreco;

        TextBox txtDescricao;
        TextBox txtPreco;

        Button btnConfirm;
        Button btnCancel;

        public Form12()
        {
            this.lblDescricao = new Label();
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.Location = new Point(120, 20);

            this.lblPreco = new Label();
            this.lblPreco.Text = "Preço";
            this.lblPreco.Location = new Point(130, 80);
            this.lblPreco.Size = new Size(300, 30);

            this.txtDescricao = new TextBox();
            this.txtDescricao.Location = new Point(10, 50);
            this.txtDescricao.Size = new Size(280, 30);

            this.txtPreco = new TextBox();
            this.txtPreco.Location = new Point(10, 110);
            this.txtPreco.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(100, 220);
            this.btnConfirm.Size = new Size(90, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(100, 260);
            this.btnCancel.Size = new Size(90, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblPreco);

            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtPreco);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Inserir Procedimento ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja inserir um novo procedimento?" +
                $"",
                "Inserir Procedimento",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Procedimento cadastrado com sucesso! " +
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

    public class Form13 : Form //Deletar Procedimento
    {
        Label lblId;

        TextBox TxtId;

        Button btnConfirm;
        Button btnCancel;

        public Form13()
        {
            this.lblId = new Label();
            this.lblId.Text = "Digite o ID:";
            this.lblId.Location = new Point(110, 20);

            this.TxtId = new TextBox();
            this.TxtId.Location = new Point(10, 50);
            this.TxtId.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(50, 150);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(140, 150);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblId);
            this.Controls.Add(this.TxtId);

            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);

            //this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Deletar Procedimento";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja excluir este procedimento?" +
                $"",
                "Deletar Procedimento",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Procedimento deletado com sucesso! " +
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

    public class Form14 : Form //Atualizar Procedimento
    {
        private System.ComponentModel.IContainer components = null;

        Label lblDescricao;
        Label lblPreco;

        TextBox txtDescricao;
        TextBox txtPreco;

        Button btnConfirm;
        Button btnCancel;

        public Form14()
        {
            this.lblDescricao = new Label();
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.Location = new Point(120, 20);

            this.lblPreco = new Label();
            this.lblPreco.Text = "Preço";
            this.lblPreco.Location = new Point(130, 80);
            this.lblPreco.Size = new Size(300, 30);

            this.txtDescricao = new TextBox();
            this.txtDescricao.Location = new Point(10, 50);
            this.txtDescricao.Size = new Size(280, 30);

            this.txtPreco = new TextBox();
            this.txtPreco.Location = new Point(10, 110);
            this.txtPreco.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(100, 220);
            this.btnConfirm.Size = new Size(90, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(100, 260);
            this.btnCancel.Size = new Size(90, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblPreco);

            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtPreco);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Atualizar Procedimento ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja alterar este procedimento?" +
                $"",
                "Atualizar Procedimento",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Procedimento alterado com sucesso! " +
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

    public class Form15 : Form //Especialidade
    {
        private System.ComponentModel.IContainer components = null;

        Label lblEspecialidade;

        Button btnCancel;
        Button btnInsert;
        Button btnDeletar;
        Button btnUpdate;

        ListView listView;
        public Form15()
        {
            this.lblEspecialidade = new Label();
            this.lblEspecialidade.Text = "Especialidade";
            this.lblEspecialidade.Location = new Point(220, 10);

            this.Controls.Add(this.lblEspecialidade);

            listView = new ListView();
            listView.Location = new Point(45, 70);
            listView.Size = new Size(410, 100);
            listView.View = View.Details;

            listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Descrição", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Tarefas", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.Sorting = SortOrder.Ascending;

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(360, 220);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.btnInsert = new Button();
            this.btnInsert.Text = "Inserir";
            this.btnInsert.Location = new Point(60, 220);
            this.btnInsert.Size = new Size(80, 30);
            this.btnInsert.Click += new EventHandler(this.handleConfirmClickEspecialidadeInserir);

            this.btnDeletar = new Button();
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Location = new Point(160, 220);
            this.btnDeletar.Size = new Size(80, 30);
            this.btnDeletar.Click += new EventHandler(this.handleConfirmClickEspecialidadeDeletar);

            this.btnUpdate = new Button();
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.Location = new Point(260, 220);
            this.btnUpdate.Size = new Size(80, 30);
            this.btnUpdate.Click += new EventHandler(this.handleConfirmClickEspecialidadeAtualizar);

            this.Controls.Add(listView);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnUpdate);

            this.ClientSize = new System.Drawing.Size(500, 300);
        }

        private void handleConfirmClickEspecialidadeAtualizar(object sender, EventArgs e)
        {
            Form18 menu = new Form18();
            menu.ShowDialog();
        }
        private void handleConfirmClickEspecialidadeDeletar(object sender, EventArgs e)
        {
            Form17 menu = new Form17();
            menu.Size = new Size(320, 228);
            menu.ShowDialog();
        }
        private void handleConfirmClickEspecialidadeInserir(object sender, EventArgs e)
        {
            Form16 menu = new Form16();
            menu.ShowDialog();
        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Form16 : Form //Inserir Especialidade
    {
        private System.ComponentModel.IContainer components = null;

        Label lblDescricao;
        Label lblTarefas;

        TextBox txtDescricao;
        TextBox txtTarefas;

        Button btnConfirm;
        Button btnCancel;

        public Form16()
        {
            this.lblDescricao = new Label();
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.Location = new Point(120, 20);

            this.lblTarefas = new Label();
            this.lblTarefas.Text = "Tarefas";
            this.lblTarefas.Location = new Point(125, 80);
            this.lblTarefas.Size = new Size(300, 30);

            this.txtDescricao = new TextBox();
            this.txtDescricao.Location = new Point(10, 50);
            this.txtDescricao.Size = new Size(280, 30);

            this.txtTarefas = new TextBox();
            this.txtTarefas.Location = new Point(10, 110);
            this.txtTarefas.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(110, 220);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(110, 260);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblTarefas);

            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtTarefas);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Inserir Especialidade ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja inserir essa nova especialidade?" +
                $"",
                "Inserir Especialidade",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Especialidade cadastrada com sucesso! " +
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

    public class Form17 : Form //Deletar Especialidade
    {
        Label lblId;

        TextBox TxtId;

        Button btnConfirm;
        Button btnCancel;

        public Form17()
        {
            this.lblId = new Label();
            this.lblId.Text = "Digite o ID:";
            this.lblId.Location = new Point(110, 20);

            this.TxtId = new TextBox();
            this.TxtId.Location = new Point(10, 50);
            this.TxtId.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(50, 150);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(140, 150);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblId);
            this.Controls.Add(this.TxtId);

            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);

            //this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Deletar Especialidade";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja excluir essa especialidade?" +
                $"",
                "Deletar Especialidade",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Especialidade deletada com sucesso! " +
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

    public class Form18 : Form // Atualizar Especialidade
    {
        private System.ComponentModel.IContainer components = null;

        Label lblDescricao;
        Label lblTarefas;

        TextBox txtDescricao;
        TextBox txtTarefas;

        Button btnConfirm;
        Button btnCancel;

        public Form18()
        {
            this.lblDescricao = new Label();
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.Location = new Point(120, 20);

            this.lblTarefas = new Label();
            this.lblTarefas.Text = "Tarefas";
            this.lblTarefas.Location = new Point(125, 80);
            this.lblTarefas.Size = new Size(300, 30);

            this.txtDescricao = new TextBox();
            this.txtDescricao.Location = new Point(10, 50);
            this.txtDescricao.Size = new Size(280, 30);

            this.txtTarefas = new TextBox();
            this.txtTarefas.Location = new Point(10, 110);
            this.txtTarefas.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(110, 220);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(110, 260);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblTarefas);

            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtTarefas);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Atualizar Especialidade ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja alterar essa especialidade?" +
                $"",
                "Atualizar Especialidade",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Especialidade alterada com sucesso! " +
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

    public class Form19 : Form //Sala
    {
        private System.ComponentModel.IContainer components = null;

        Label lblSala;

        Button btnCancel;
        Button btnInsert;
        Button btnDeletar;
        Button btnUpdate;

        ListView listView;
        public Form19()
        {
            this.lblSala = new Label();
            this.lblSala.Text = "Sala";
            this.lblSala.Location = new Point(220, 10);

            this.Controls.Add(this.lblSala);

            listView = new ListView();
            listView.Location = new Point(45, 70);
            listView.Size = new Size(410, 100);
            listView.View = View.Details;
            ListViewItem lista1 = new ListViewItem("1");
            lista1.SubItems.Add("RA12");
            lista1.SubItems.Add("Raio-X");

            listView.Items.AddRange(new ListViewItem[] { lista1 });
            listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Número", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Equipamentos", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.Sorting = SortOrder.Ascending;

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(360, 220);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.btnInsert = new Button();
            this.btnInsert.Text = "Inserir";
            this.btnInsert.Location = new Point(60, 220);
            this.btnInsert.Size = new Size(80, 30);
            this.btnInsert.Click += new EventHandler(this.handleConfirmClickSalaInserir);

            this.btnDeletar = new Button();
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Location = new Point(160, 220);
            this.btnDeletar.Size = new Size(80, 30);
            this.btnDeletar.Click += new EventHandler(this.handleConfirmClickSalaDeletar);

            this.btnUpdate = new Button();
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.Location = new Point(260, 220);
            this.btnUpdate.Size = new Size(80, 30);
            this.btnUpdate.Click += new EventHandler(this.handleConfirmClickSalaAtualizar);

            this.Controls.Add(listView);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnUpdate);

            this.ClientSize = new System.Drawing.Size(500, 300);
        }

        private void handleConfirmClickSalaAtualizar(object sender, EventArgs e)
        {
            Form22 menu = new Form22();
            menu.ShowDialog();
        }
        private void handleConfirmClickSalaDeletar(object sender, EventArgs e)
        {
            Form21 menu = new Form21();
            menu.Size = new Size(320, 228);
            menu.ShowDialog();
        }
        private void handleConfirmClickSalaInserir(object sender, EventArgs e)
        {
            Form20 menu = new Form20();
            menu.ShowDialog();
        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Form20 : Form //Inserir Sala
    {
        private System.ComponentModel.IContainer components = null;

        Label lblNumero;
        Label lblEquipamentos;

        TextBox txtNumero;
        TextBox txtEquipamentos;

        Button btnConfirm;
        Button btnCancel;

        public Form20()
        {
            this.lblNumero = new Label();
            this.lblNumero.Text = "Número";
            this.lblNumero.Location = new Point(120, 20);

            this.lblEquipamentos = new Label();
            this.lblEquipamentos.Text = "Equipamentos";
            this.lblEquipamentos.Location = new Point(110, 80);
            this.lblEquipamentos.Size = new Size(300, 30);

            this.txtNumero = new TextBox();
            this.txtNumero.Location = new Point(10, 50);
            this.txtNumero.Size = new Size(280, 30);

            this.txtEquipamentos = new TextBox();
            this.txtEquipamentos.Location = new Point(10, 110);
            this.txtEquipamentos.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(110, 220);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(110, 260);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblEquipamentos);

            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtEquipamentos);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Inserir Sala ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja inserir esta nova sala?" +
                $"",
                "Inserir Sala",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Sala cadastrada com sucesso! " +
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

    public class Form21 : Form //Deletar Sala
    {
        Label lblId;

        TextBox TxtId;

        Button btnConfirm;
        Button btnCancel;

        public Form21()
        {
            this.lblId = new Label();
            this.lblId.Text = "Digite o ID:";
            this.lblId.Location = new Point(110, 20);

            this.TxtId = new TextBox();
            this.TxtId.Location = new Point(10, 50);
            this.TxtId.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(50, 150);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(140, 150);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblId);
            this.Controls.Add(this.TxtId);

            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);

            //this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Deletar Sala";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja excluir essa sala?" +
                $"",
                "Deletar Sala",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Sala deletada com sucesso! " +
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

    public class Form22 : Form //Atualizar Sala
    {
        private System.ComponentModel.IContainer components = null;

        Label lblNumero;
        Label lblEquipamentos;

        TextBox txtNumero;
        TextBox txtEquipamentos;

        Button btnConfirm;
        Button btnCancel;

        public Form22()
        {
            this.lblNumero = new Label();
            this.lblNumero.Text = "Número";
            this.lblNumero.Location = new Point(120, 20);

            this.lblEquipamentos = new Label();
            this.lblEquipamentos.Text = "Equipamentos";
            this.lblEquipamentos.Location = new Point(110, 80);
            this.lblEquipamentos.Size = new Size(300, 30);

            this.txtNumero = new TextBox();
            this.txtNumero.Location = new Point(10, 50);
            this.txtNumero.Size = new Size(280, 30);

            this.txtEquipamentos = new TextBox();
            this.txtEquipamentos.Location = new Point(10, 110);
            this.txtEquipamentos.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(110, 220);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(110, 260);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblEquipamentos);

            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtEquipamentos);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Atualizar Sala ";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja alterar os dados desta sala?" +
                $"",
                "Atualizar Sala",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Sala alterada com sucesso! " +
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

    public class Form23 : Form //Agendamento
    {
        private System.ComponentModel.IContainer components = null;

        Label lblAgendamento;

        Button btnCancel;
        Button btnInsert;
        Button btnDeletar;
        Button btnUpdate;

        ListView listView;
        public Form23()
        {
            this.lblAgendamento = new Label();
            this.lblAgendamento.Text = "Agendamento";
            this.lblAgendamento.Location = new Point(200, 10);

            this.Controls.Add(this.lblAgendamento);

            listView = new ListView();
            listView.Location = new Point(100, 70);
            listView.Size = new Size(280, 100);
            listView.View = View.Details;
            ListViewItem lista1 = new ListViewItem("1");
            lista1.SubItems.Add("1");
            lista1.SubItems.Add("1");
            lista1.SubItems.Add("1");
            lista1.SubItems.Add("2022/03/21");

            listView.Items.AddRange(new ListViewItem[] { lista1 });
            listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listView.Columns.Add("PacienteId", -2, HorizontalAlignment.Left);
            listView.Columns.Add("DentistaId", -2, HorizontalAlignment.Left);
            listView.Columns.Add("SalaId", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Data", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.Sorting = SortOrder.Ascending;

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(360, 220);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.btnInsert = new Button();
            this.btnInsert.Text = "Inserir";
            this.btnInsert.Location = new Point(60, 220);
            this.btnInsert.Size = new Size(80, 30);
            this.btnInsert.Click += new EventHandler(this.handleConfirmAgendamentoInserir);

            this.btnDeletar = new Button();
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Location = new Point(160, 220);
            this.btnDeletar.Size = new Size(80, 30);
            this.btnDeletar.Click += new EventHandler(this.handleConfirmAgendamentoDeletar);

            this.btnUpdate = new Button();
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.Location = new Point(260, 220);
            this.btnUpdate.Size = new Size(80, 30);
            this.btnUpdate.Click += new EventHandler(this.handleConfirmAgendamentoAtualizar);

            this.Controls.Add(listView);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnUpdate);

            this.ClientSize = new System.Drawing.Size(480, 300);
        }

        private void handleConfirmAgendamentoAtualizar(object sender, EventArgs e)
        {
            Form24 menu = new Form24();
            menu.Size = new Size(325, 400);
            menu.ShowDialog();
        }
        private void handleConfirmAgendamentoDeletar(object sender, EventArgs e)
        {
            Form25 menu = new Form25();
            menu.Size = new Size(320, 228);
            menu.ShowDialog();
        }
        private void handleConfirmAgendamentoInserir(object sender, EventArgs e)
        {
            Form26 menu = new Form26();
            menu.Size = new Size(325, 400);
            menu.ShowDialog();
        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Form24 : Form //Atualizar Agendamento
    {
        private System.ComponentModel.IContainer components = null;

        Label lblPacienteId;
        Label lblDentistaId;
        Label lblSalaId;
        Label lblData;

        TextBox txtPacienteId;
        TextBox txtDentistaId;
        TextBox txtSalaId;
        TextBox txtData;

        Button btnConfirm;
        Button btnCancel;

        public Form24()
        {
            this.lblPacienteId = new Label();
            this.lblPacienteId.Text = "PacienteId";
            this.lblPacienteId.Location = new Point(120, 20);

            this.lblDentistaId = new Label();
            this.lblDentistaId.Text = "DentistaId";
            this.lblDentistaId.Location = new Point(120, 80);
            this.lblDentistaId.Size = new Size(300, 30);

            this.lblSalaId = new Label();
            this.lblSalaId.Text = "SalaId";
            this.lblSalaId.Location = new Point(125, 140);
            this.lblSalaId.Size = new Size(300, 30);

            this.lblData = new Label();
            this.lblData.Text = "Data";
            this.lblData.Location = new Point(130, 200);
            this.lblData.Size = new Size(300, 30);

            this.txtPacienteId = new TextBox();
            this.txtPacienteId.Location = new Point(10, 50);
            this.txtPacienteId.Size = new Size(280, 30);

            this.txtDentistaId = new TextBox();
            this.txtDentistaId.Location = new Point(10, 110);
            this.txtDentistaId.Size = new Size(280, 30);

            this.txtSalaId = new TextBox();
            this.txtSalaId.Location = new Point(10, 170);
            this.txtSalaId.Size = new Size(280, 30);

            this.txtData = new TextBox();
            this.txtData.Location = new Point(10, 230);
            this.txtData.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(65, 280);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(155, 280);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblPacienteId);
            this.Controls.Add(this.lblDentistaId);
            this.Controls.Add(this.lblSalaId);
            this.Controls.Add(this.lblData);

            this.Controls.Add(this.txtPacienteId);
            this.Controls.Add(this.txtDentistaId);
            this.Controls.Add(this.txtSalaId);
            this.Controls.Add(this.txtData);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.ClientSize = new System.Drawing.Size(300, 400);

        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja inserir um novo agendamento?" +
                $"",
                "Inserir Agendamento",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Agendamento inserido com sucesso! " +
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

    public class Form25 : Form //Deletar Agendamento
    {
        Label lblId;

        TextBox TxtId;

        Button btnConfirm;
        Button btnCancel;

        public Form25()
        {
            this.lblId = new Label();
            this.lblId.Text = "Digite o ID:";
            this.lblId.Location = new Point(110, 20);

            this.TxtId = new TextBox();
            this.TxtId.Location = new Point(10, 50);
            this.TxtId.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(50, 150);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(140, 150);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblId);
            this.Controls.Add(this.TxtId);

            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);

            //this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Deletar Agendamento";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja excluir este agendamento?" +
                $"",
                "Deletar Agendamento",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Agendamento deletado com sucesso! " +
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

    public class Form26 : Form //Inserir Agendamento
    {
        private System.ComponentModel.IContainer components = null;

        Label lblPacienteId;
        Label lblDentistaId;
        Label lblSalaId;
        Label lblData;

        TextBox txtPacienteId;
        TextBox txtDentistaId;
        TextBox txtSalaId;
        TextBox txtData;

        Button btnConfirm;
        Button btnCancel;

        public Form26()
        {
            this.lblPacienteId = new Label();
            this.lblPacienteId.Text = "PacienteId";
            this.lblPacienteId.Location = new Point(120, 20);

            this.lblDentistaId = new Label();
            this.lblDentistaId.Text = "DentistaId";
            this.lblDentistaId.Location = new Point(120, 80);
            this.lblDentistaId.Size = new Size(300, 30);

            this.lblSalaId = new Label();
            this.lblSalaId.Text = "SalaId";
            this.lblSalaId.Location = new Point(125, 140);
            this.lblSalaId.Size = new Size(300, 30);

            this.lblData = new Label();
            this.lblData.Text = "Data";
            this.lblData.Location = new Point(130, 200);
            this.lblData.Size = new Size(300, 30);

            this.txtPacienteId = new TextBox();
            this.txtPacienteId.Location = new Point(10, 50);
            this.txtPacienteId.Size = new Size(280, 30);

            this.txtDentistaId = new TextBox();
            this.txtDentistaId.Location = new Point(10, 110);
            this.txtDentistaId.Size = new Size(280, 30);

            this.txtSalaId = new TextBox();
            this.txtSalaId.Location = new Point(10, 170);
            this.txtSalaId.Size = new Size(280, 30);

            this.txtData = new TextBox();
            this.txtData.Location = new Point(10, 230);
            this.txtData.Size = new Size(280, 30);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(65, 280);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(155, 280);
            this.btnCancel.Size = new Size(80, 30);
            this.btnCancel.Click += new EventHandler(this.handleCancelClick);

            this.Controls.Add(this.lblPacienteId);
            this.Controls.Add(this.lblDentistaId);
            this.Controls.Add(this.lblSalaId);
            this.Controls.Add(this.lblData);

            this.Controls.Add(this.txtPacienteId);
            this.Controls.Add(this.txtDentistaId);
            this.Controls.Add(this.txtSalaId);
            this.Controls.Add(this.txtData);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.ClientSize = new System.Drawing.Size(300, 400);

        }
        private void handleConfirmClick(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(
                $"Deseja alterar as informações deste agendamento?" +
                $"",
                "Atualizar Agendamento",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Agendamento alterado com sucesso! " +
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