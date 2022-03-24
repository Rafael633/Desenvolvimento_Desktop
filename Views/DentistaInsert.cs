using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using Models;
using Controllers;

namespace Views
{
    public class FormDentistaInsert : Form //Inserir Dentista
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

        public FormDentistaInsert()
        {
            lblNome = new Label();
            lblNome.Text = "Nome";
            lblNome.Location = new Point(20,20);

            lblCpf = new Label();
            lblCpf.Text = "CPF";
            lblCpf.Location = new Point(20,85);

            lblTelefone = new Label();
            lblTelefone.Text = "Fone";
            lblTelefone.Location = new Point(210,85);

            lblEmail = new Label();
            lblEmail.Text = "Email";
            lblEmail.Location = new Point(20,150);

            lblSenha = new Label();
            lblSenha.Text = "Senha";
            lblSenha.Location = new Point(20,215);

            lblRegistro = new Label();
            lblRegistro.Text = "Registro";
            lblRegistro.Location = new Point(20,280);

            lblSalario = new Label();
            lblSalario.Text = "Salário";
            lblSalario.Location = new Point(143,280);

            lblEspecialidade = new Label();
            lblEspecialidade.Text = "ID Especialidade";
            lblEspecialidade.Location = new Point(266,280);

            txtNome = new TextBox();
            txtNome.Location = new Point(20,45);
            txtNome.Size = new Size(360,20);

            txtCpf = new TextBox();
            txtCpf.Location = new Point(20,110);
            txtCpf.Size = new Size(175,20);

            txtTelefone = new TextBox();
            txtTelefone.Location = new Point(205,110);
            txtTelefone.Size = new Size(175,20);

            txtEmail = new TextBox();
            txtEmail.Location = new Point(20,175);
            txtEmail.Size = new Size(360,20);

            txtSenha = new TextBox();
            txtSenha.Location = new Point(20,240);
            txtSenha.Size = new Size(360,20);
            txtSenha.PasswordChar = '*';

            txtRegistro = new TextBox();
            txtRegistro.Location = new Point(20,305);
            txtRegistro.Size = new Size(114,20);

            txtSalario = new TextBox();
            txtSalario.Location = new Point(143,305);
            txtSalario.Size = new Size(114,20);

            txtEspecialidade = new TextBox();
            txtEspecialidade.Location = new Point(266,305);
            txtEspecialidade.Size = new Size(114,20);

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(120, 520);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(220, 520);
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

            double salario = Convert.ToDouble(txtSalario.Text);
            int id = int.Parse(txtEspecialidade.Text);
            try
            {
                DentistaController.InserirDentista(
                txtNome.Text,
                txtCpf.Text,
                txtEmail.Text,
                txtSenha.Text,
                txtSenha.Text,
                txtRegistro.Text,
                salario,
                id
                );

                MessageBox.Show("Dados inseridos com sucesso.");
                this.Close();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Não foi possível inserir os dados.");
            }
        }

        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}