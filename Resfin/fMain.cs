using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resfin
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        double summa = 0, discount = 0;
        struct Product
        {
            public int ID;
            public int Count;
        }
        Random rnd= new Random();

        List<Product> LstOP = new List<Product>();

        private void TSMAddT_Click(object sender, EventArgs e)
        {
            if(productAllDataBindingSource.Count==0)
            {
                MessageBox.Show("Нет товаров");
                return;
            }
            if(productAllDataBindingSource.Current==null)
            {
                MessageBox.Show("Не выбран товар");
                return;
            }
            DataRowView dr = (DataRowView)productAllDataBindingSource.Current;
            int IDProduct = int.Parse(dr["IDProduct"].ToString());
            bool productInLst = false;
            for (int i = 0; i < LstOP.Count; i++)
            {
                if (LstOP[i].ID==IDProduct)
                {
                    Product p = LstOP[i];
                    p.Count++;
                    LstOP[i] = p;
                    productInLst = true;
                }
            }
            if(!productInLst)
            {
                Product p;
                p.ID = IDProduct;
                p.Count = 1;
                LstOP.Add(p);
            }
            summa += double.Parse(dr["Price"].ToString());
            discount += double.Parse(dr["Discount"].ToString());
            lSumZ.Text=summa.ToString();
            lDiscZ.Text=discount.ToString();
            pT.Visible = true;
        }

        private void bShowT_Click(object sender, EventArgs e)
        {
            if(pickUpPointBindingSource.Count==0)
            {
                MessageBox.Show("Добавьте пункт выдачи заказа");
                return;
            }
            if (pickUpPointBindingSource.Current==null)
            {
                MessageBox.Show("Выберите пункт выдачи заказа");
                return;
            }
            if(LstOP.Count==0)
            {
                MessageBox.Show("В заказе отсутствуют товары");
                return;
            }
            DataRowView drPickP = (DataRowView)pickUpPointBindingSource.Current;
            int IDPP = int.Parse(drPickP["IDPickUpPoint"].ToString());
            orderBindingSource.AddNew();

            DataRowView drOrder = (DataRowView)orderBindingSource.Current;

            drOrder["DateOrder"]=DateTime.Now;
            drOrder["IDUser"] = 1;
            drOrder["IDPickUpPoint"] = IDPP;
            int code=rnd.Next(100,999);
            drOrder["Code"]=code;
            drOrder["IDStatus"] = 1;
            orderBindingSource.EndEdit();
            orderTableAdapter.Update(dbBook1DataSet.Order);
            orderTableAdapter.Fill(dbBook1DataSet.Order);
            orderBindingSource.MoveLast();
            drOrder=(DataRowView)orderBindingSource.Current;
            int IDOrder = int.Parse(drOrder["IDOrder"].ToString());

            foreach (Product p in LstOP)
            {
                orderProductBindingSource.AddNew();
                DataRowView drOP= (DataRowView)orderProductBindingSource.Current;
                drOP["IDOrder"] = IDOrder;
                drOP["IDProduct"] = p.ID;
                drOP["Count"] = p.Count;
                orderProductBindingSource.EndEdit();
            }
            orderProductTableAdapter.Update(dbBook1DataSet.OrderProduct);
            orderTableAdapter.Fill(dbBook1DataSet.Order);

            fShowOrder f=new fShowOrder();
            f.IDOrder = IDOrder;
            f.lNumZak.Text=IDOrder.ToString();
            f.lPup.Text=CbPUP.Text;
            f.lCode.Text=code.ToString();
            f.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbBook1DataSet.OrderProduct". При необходимости она может быть перемещена или удалена.
            this.orderProductTableAdapter.Fill(this.dbBook1DataSet.OrderProduct);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbBook1DataSet.ProductAllData". При необходимости она может быть перемещена или удалена.
            this.productAllDataTableAdapter.Fill(this.dbBook1DataSet.ProductAllData);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbBook1DataSet.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.dbBook1DataSet.Order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbBook1DataSet.PickUpPoint". При необходимости она может быть перемещена или удалена.
            this.pickUpPointTableAdapter.Fill(this.dbBook1DataSet.PickUpPoint);

        }
    }
}
