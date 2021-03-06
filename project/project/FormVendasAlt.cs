﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace project
{
    public partial class FormVendasAlt : Form
    {
        public FormVendasAlt()
        {
            InitializeComponent();
        }

        private void ButtonSendVd2_Click(object sender, EventArgs e)
        {
            try
            {
                string StringCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\GeekSmart\base.mdb";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();

                string SQL;

                SQL = "Update Vendas set DataVenda ='" + dateTimePickerDvVd2.Text + "',";
                SQL += "Cliente = '" + textBoxClienteVd2.Text + "',";
                SQL += "Vendedor = '" + textBoxVendedorVd2.Text + "',";
                SQL += "Produto = '" + textBoxProdVd2.Text + "',";
                SQL += "Quantidade = '" + textBoxQuantVd2.Text + "',";
                SQL += "Valor = '" + textBoxValorVd2.Text + "' ";
                SQL += "Where ID = " + labelIdVd2.Text;

                OleDbCommand cmd = new OleDbCommand(SQL, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados Alterados com Sucesso!");
                this.Close();

                conn.Close();

            }//Conexão com arquivo de base de dados e registro dos dados na base
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }//Mensagem de erro
        }
    }
}
