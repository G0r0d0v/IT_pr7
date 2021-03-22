using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Двумерные_массивы
{
    public partial class Form1 : Form
    {
        int[,] a = new int[5, 5];
        int x;
        int y;
        int x1;
        int y1;
        int i, j;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 5;
            dataGridView1.ColumnCount = 5;
            
            Random rand = new Random();
            for (i = 0; i < 5; i++)
                for (j = 0; j < 5; j++)
                {
                    a[i, j] = rand.Next(-100, 100);
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
                }
            
            int m = int.MinValue;
            int l = int.MaxValue;

            for (i = 0; i < 5; i++)
                for (j = 0; j < 5; j++)
                    if (a[i, j] > m)
                    {
                        m = a[i, j];
                        x = i;
                        y = j;
                    }
            for (i = 0; i < 5; i++)
                for (j = 0; j < 5; j++)
                    if (a[i, j] > l)
                    {
                        l = a[i, j];
                        x1 = i;
                        y1 = j;
                    }
            for (i = 0; i < 5; i++)
                for (j = 0; j < 5; j++)
                    if (a[i, j] > l)
                    {
                        l = a[i, j];
                        x1 = i;
                        y1 = j;
                    }
           var tmp = a[x1, y1];
            a[x1, y1] = a[x, y];
            a[x, y] = tmp;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            for (i = 0; i < 5; i++)
                for (j = 0; j < 5; j++)
                {

                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
                }
        }

    }
}
