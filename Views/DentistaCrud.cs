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
public class FormDentistaCrud : Form //Dentista
    {
        private System.ComponentModel.IContainer components = null;

        Label lblDentista;

        Button btnCancel;
        Button btnInsert;
        Button btnDeletar;
        Button btnUpdate;

        ListView listView;
        public FormDentistaCrud()
        {
            this.lblDentista = new Label();
            this.lblDentista.Text = "Dentista";
            this.lblDentista.Location = new Point(220, 10);

            this.Controls.Add(this.lblDentista);

            listView = new ListView();
            listView.Location = new Point(45, 70);
            listView.Size = new Size(410, 100);
            listView.View = View.Details;

            listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            listView.Columns.Add("CPF", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Telefone", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Email", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Registro", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Salário", -2, HorizontalAlignment.Left);
            listView.Columns.Add("ID da Especialidade", -2, HorizontalAlignment.Left);
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

            /*this.btnDeletar = new Button();
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Location = new Point(160, 220);
            this.btnDeletar.Size = new Size(80, 30);
            this.btnDeletar.Click += new EventHandler(this.handleConfirmClickDentistaDeletar);

            this.btnUpdate = new Button();
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.Location = new Point(260, 220);
            this.btnUpdate.Size = new Size(80, 30);
            this.btnUpdate.Click += new EventHandler(this.handleConfirmClickDentistaAtualizar);*/

            this.Controls.Add(listView);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnUpdate);

            this.ClientSize = new System.Drawing.Size(500, 300);
        }

        /*private void handleConfirmClickDentistaAtualizar(object sender, EventArgs e)
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
        }*/
        private void handleConfirmClickDentistaInserir(object sender, EventArgs e)
        {
            FormDentistaInsert menu = new FormDentistaInsert();
            menu.Size = new Size(430, 595);
            menu.ShowDialog();
        }
        private void handleCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}