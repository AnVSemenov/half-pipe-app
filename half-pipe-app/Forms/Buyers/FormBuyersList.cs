﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using half_pipe_app.Forms;

namespace half_pipe_app.Forms.Buyers
{
    public partial class FormBuyersList : Form
    {
        public FormBuyersList()
        {
            InitializeComponent();
        }

        private void FormBuyersList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Buyers". При необходимости она может быть перемещена или удалена.
            this.buyersTableAdapter.Fill(this.database1DataSet.Buyers);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form formEdit = new half_pipe_app.Forms.Buyers.FormBuyer();

            formEdit.Owner = this;
            formEdit.Show();
        }
    }
}
