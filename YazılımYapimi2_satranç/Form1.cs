using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazılımYapimi2_satranç
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int size = 0, count = 0;

        private void btnYeni_Click(object sender, EventArgs e)
        {
            count = 0;
            if (rd5.Checked)
                size = 5;
            else if (rd6.Checked)
                size = 6;
            else if (rd7.Checked)
                size = 7;
            else if (rd8.Checked)
                size = 8;
            else if (rd9.Checked)
                size = 9;
            else
                MessageBox.Show("Tekrar Seçiniz..");

            dgView.Enabled = true;
            dgView.Rows.Clear();
            dgView.Columns.Clear();
            dgView.Size = new Size(size * 41, size * 41);

            for (int i = 0; i < size; i++)
            {
                dgView.Columns.Add(null, null);
                DataGridViewColumn column = dgView.Columns[i];
                column.Width = 40;

                dgView.Rows.Add(null, null);
                DataGridViewRow row = dgView.Rows[i];
                row.Height = 40;
            }
         
        }

        private void dgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int SelectedRow = dgView.CurrentCell.RowIndex;
            int SelectedColumn = dgView.CurrentCell.ColumnIndex;

            if (dgView.Rows[SelectedRow].Cells[SelectedColumn].Style.BackColor == Color.YellowGreen || count == 0)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (dgView.Rows[i].Cells[j].Style.BackColor != Color.Brown)
                            dgView.Rows[i].Cells[j].Style.BackColor = Color.White;      //eski yeşiller kapanır
                    }
                }
                count++;
                dgView.Rows[dgView.CurrentCell.RowIndex].Cells[dgView.CurrentCell.ColumnIndex].Value = count;
                dgView.Rows[dgView.CurrentCell.RowIndex].Cells[dgView.CurrentCell.ColumnIndex].Style.BackColor = Color.Brown;

                int hamle = 0;
                if (SelectedRow + 2 < size && SelectedColumn + 1 < size && dgView.Rows[SelectedRow + 2].Cells[SelectedColumn + 1].Style.BackColor != Color.Brown)
                {
                    dgView.Rows[SelectedRow + 2].Cells[SelectedColumn + 1].Style.BackColor = Color.YellowGreen;
                    hamle++;
                }
                    
                if (SelectedRow + 2 < size && SelectedColumn - 1 >= 0 && dgView.Rows[SelectedRow + 2].Cells[SelectedColumn - 1].Style.BackColor != Color.Brown)
                {
                    dgView.Rows[SelectedRow + 2].Cells[SelectedColumn - 1].Style.BackColor = Color.YellowGreen;
                    hamle++;
                }
                if (SelectedRow - 2 >= 0 && SelectedColumn + 1 < size && dgView.Rows[SelectedRow - 2].Cells[SelectedColumn + 1].Style.BackColor != Color.Brown)
                {
                    dgView.Rows[SelectedRow - 2].Cells[SelectedColumn + 1].Style.BackColor = Color.YellowGreen;
                    hamle++;
                }
                if (SelectedRow - 2 >= 0 && SelectedColumn - 1 >= 0 && dgView.Rows[SelectedRow - 2].Cells[SelectedColumn - 1].Style.BackColor != Color.Brown)
                {
                    dgView.Rows[SelectedRow - 2].Cells[SelectedColumn - 1].Style.BackColor = Color.YellowGreen;
                    hamle++;
                }
                if (SelectedRow + 1 < size && SelectedColumn + 2 < size && dgView.Rows[SelectedRow + 1].Cells[SelectedColumn + 2].Style.BackColor != Color.Brown)
                {
                    dgView.Rows[SelectedRow + 1].Cells[SelectedColumn + 2].Style.BackColor = Color.YellowGreen;
                    hamle++;
                }
                if (SelectedRow + 1 < size && SelectedColumn - 2 >= 0 && dgView.Rows[SelectedRow + 1].Cells[SelectedColumn - 2].Style.BackColor != Color.Brown)
                {
                    dgView.Rows[SelectedRow + 1].Cells[SelectedColumn - 2].Style.BackColor = Color.YellowGreen;
                    hamle++;
                }
                if (SelectedRow - 1 >= 0 && SelectedColumn + 2 < size && dgView.Rows[SelectedRow - 1].Cells[SelectedColumn + 2].Style.BackColor != Color.Brown)
                {
                    dgView.Rows[SelectedRow - 1].Cells[SelectedColumn + 2].Style.BackColor = Color.YellowGreen;
                    hamle++;
                }
                if (SelectedRow - 1 >= 0 && SelectedColumn - 2 >= 0 && dgView.Rows[SelectedRow - 1].Cells[SelectedColumn - 2].Style.BackColor != Color.Brown)
                {
                    dgView.Rows[SelectedRow - 1].Cells[SelectedColumn - 2].Style.BackColor = Color.YellowGreen;
                    hamle++;
                }

                if (hamle != 0)
                    lblDurum.Text =hamle.ToString();
                else
                    lblwinlose.Text = "GAME OVER!";

                if (count == size * size)
                    lblwinlose.Text = "Kazandınız!!";

                lblHamle.Text = count.ToString();


            }
            if (dgView.Rows[SelectedRow].Cells[SelectedRow].Style.BackColor == Color.YellowGreen)
            {
                dgView.Rows[SelectedRow].Cells[SelectedColumn].Value = count;
                dgView.Rows[SelectedRow].Cells[SelectedColumn].Style.BackColor = Color.Brown;


            }
        }





    }
}
