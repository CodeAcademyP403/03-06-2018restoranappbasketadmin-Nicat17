using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        ArrayList products = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            //Dont Understand 
            products.AddRange(new Product[] {
                new Product
                {
                    name="Kabab",
                    id=1,
                    count=10,
                    category=Category.MainEats,
                    price=4
                },
                new Product
                {
                    name="Dolma",
                    id=2,
                    count=15,
                    category=Category.MainEats,
                    price=3
                },
                new Product
                {
                    name="Cola",
                    id=3,
                    count=20,
                    category=Category.Drinks,
                    price=1
                },
                new Product
                {
                    name="Fanta",
                    id=4,
                    count=20,
                    category=Category.Drinks,
                    price=1
                },
                new Product
                {
                    name="Duses",
                    id=5,
                    count=20,
                    category=Category.Drinks,
                    price=1
                },
                new Product
                {
                    name="Coban Salati",
                    id=6,
                    count=10,
                    category=Category.Salat,
                    price=2
                },
                new Product
                {
                    name="Merci",
                    id=7,
                    count=12,
                    category=Category.Soup,
                    price=2
                },
                new Product
                {
                    name="Lobya",
                    id=8,
                    count=8,
                    category=Category.Soup,
                    price=2
                }
            });
            comboBox_category.DataSource = Enum.GetNames(typeof(Category));
        }

        Form _form = new Form();
        //First apply empty constroctor with ':this()' function
        public Form1(Form form):this()
        {
            _form = form;
        }

        private void comboBox_category_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedValue = (sender as ComboBox).SelectedValue.ToString();

            Category SelectedChangedValue = (Category)Enum.Parse(typeof(Category), selectedValue);

            ArrayList showList = new ArrayList();

            foreach (Product pro in products)
            {
                if (pro.category == SelectedChangedValue)
                {
                    showList.Add(pro);
                }
            }

            comboBox_name.DataSource = showList;
            comboBox_name.DisplayMember = "name";
        }

        Product prod = new Product();

        private void comboBox_name_SelectedValueChanged(object sender, EventArgs e)
        {
            prod = (Product)(sender as ComboBox).SelectedValue;

            textBox_price.Text = prod.price.ToString();
        }

        Basket basket = new Basket();

        private void btn_order_Click(object sender, EventArgs e)
        {
            byte count=1;

            if (textBox_count.Text!="")
            {
                count= Convert.ToByte(textBox_count.Text);
            }

            ProductsAtBasket productOfBasket = new ProductsAtBasket
            {
                Name=prod.name,
                Count = count,
                id = prod.id,
                TotalPrice=count*prod.price
            };

            basket.productsItems.Add(productOfBasket);

            dataGridView_Order.DataSource = null;
            dataGridView_Order.DataSource = basket.productsItems;
            dataGridView_Order.Columns[0].Visible = false;

            lbl_allPrice.Text = SumAllPrice(basket.productsItems).ToString();
        }

        private decimal SumAllPrice(ArrayList arrayList)
        {
            decimal Sum = 0;
            foreach (ProductsAtBasket arr in arrayList)
            {
                Sum += arr.TotalPrice;
            }
            return Sum;
        }

        private void textBox_count_Enter(object sender, EventArgs e)
        {
            textBox_count.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _form.Close();
        }

        
    }
}
