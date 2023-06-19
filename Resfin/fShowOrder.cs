using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Resfin
{
    public partial class fShowOrder : Form
    {
        public int IDOrder;
        public fShowOrder()
        {
            InitializeComponent();
        }

        private void fShowOrder_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbBook1DataSet.OrderProduct". При необходимости она может быть перемещена или удалена.
            this.orderProductTableAdapter.Fill(this.dbBook1DataSet.OrderProduct);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbBook1DataSet.ProductInOrder". При необходимости она может быть перемещена или удалена.
            this.productInOrderTableAdapter.Fill(this.dbBook1DataSet.ProductInOrder);

            productInOrderBindingSource.Filter = $"IDOrder={IDOrder}";
            groupOpTableAdapter.Fill(dbBook1DataSet.GroupOp, IDOrder);
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            int Count = int.Parse(tbCount.Text);
            DataRowView drPO = (DataRowView)productInOrderBindingSource.Current;
            int iDProductOrder = Convert.ToInt32(drPO.Row["IDOrderProduct"]);
            string prname = drPO["NameProduct"].ToString();

            orderProductBindingSource.Position = orderProductBindingSource.Find("IDOrderProduct",iDProductOrder);

            if(Count==0)
            {
                if(MessageBox.Show($"Вы действительно хотите удалить {prname} из заказа?","Внимание",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    orderProductBindingSource.RemoveCurrent();
                }
            }
            else
            {
                DataRowView drOP=(DataRowView)orderProductBindingSource.Current;
                drOP["Count"] = Count;
                orderProductBindingSource.EndEdit();
            }
            orderProductTableAdapter.Update(dbBook1DataSet.OrderProduct);
            this.productInOrderTableAdapter.Fill(this.dbBook1DataSet.ProductInOrder);
            productInOrderBindingSource.Filter = $"IDOrder={IDOrder}";
            groupOpTableAdapter.Fill(dbBook1DataSet.GroupOp, IDOrder);

            if(productInOrderBindingSource.Count==0)
                this.Close();
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            tbCount.Text = "0";
            bOK_Click(null, null);
        }

        private void bPDF_Click(object sender, EventArgs e)
        {
            Excel.Application exapp = new Excel.Application();
            // exapp.Visible = false;

            string path = System.Windows.Forms.Application.StartupPath + "\\Шаблон.xlsx";
            Excel.Workbook exbook = exapp.Workbooks.Open(path);
            Excel.Worksheet exSheet = exbook.Worksheets[1];

            exSheet.Cells[1, 3] = lNumZak.Text;
            exSheet.Cells[3, 3] = lPup.Text;
            exSheet.Cells[4, 3] = lCode.Text;
            exSheet.Cells[5, 3] = Convert.ToDouble(lSummD.Text).ToString("0.00");
            exSheet.Cells[6, 3] = Convert.ToDouble(lDiscD.Text).ToString("0.00");


            productInOrderBindingSource.MoveFirst();
            for (int i = 0; i < productInOrderBindingSource.Count; i++)
            {
                exSheet.Columns.AutoFit();
                //exSheet.Cells.Borders.LineStyle =i+11;
                exSheet.Cells[i + 11, 1] = i + 1;
                exSheet.Cells[i + 11, 2] = lNP.Text;
                exSheet.Cells[i + 11, 3] = lDeC.Text;
                exSheet.Cells[i + 11, 4] = Convert.ToDouble(lSumm.Text).ToString("0.00");
                exSheet.Cells[i + 11, 5] = Convert.ToDouble(lDisc.Text).ToString("0.00");
                exSheet.Cells[i + 11, 6] = lF.Text;
                exSheet.Cells[i + 11, 7] = tbCount.Text;
                productInOrderBindingSource.MoveNext();
                //эксель не должен спрашивать сохнанения
                //не показывался эксель
                //добавить границы
            }

            exapp.DisplayAlerts = false;

            Excel.Range range = exSheet.Range[exSheet.Cells[11, 1], exSheet.Cells[10 + 1 * productInOrderBindingSource.Count, 7]];
            range.Borders.LineStyle = XlLineStyle.xlContinuous;
            string fnPDF = System.Windows.Forms.Application.StartupPath + "\\Шаблон " + lNumZak.Text + ".pdf";
            exSheet.ExportAsFixedFormat(Excel.XlFixedFormatType.xlTypePDF, fnPDF);

            exbook.Close(false);
            exapp.Quit();
            Process.Start(fnPDF);
        }
    }
}
