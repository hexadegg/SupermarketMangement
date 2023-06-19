using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class SMProduct : Form
    {
        public SMProduct()
        {
            InitializeComponent();
        }
        private string productID;
        private string opMode;
       
        SupermarketInfoEntities9 db = new SupermarketInfoEntities9();
        public void setValue(string productID, string opMode)
        {
            this.opMode = opMode;
            this.productID = productID;
        } 
        private void SMProduct_Load(object sender, EventArgs e)
        {
            
            {//绑定类别
                List<Supplier> list = db.Supplier.ToList<Supplier>();
                this.comboBox1.DataSource = list;
                this.comboBox1.DisplayMember = "Supplier_ID";
                this.comboBox1.ValueMember = "Supplier_Name";
            }
            if (this.opMode == "Update")
            {
                Product entry = db.Product.SingleOrDefault(a => a.Product_ID == productID);
                this.txtID.Text = entry.Product_ID.ToString();
                this.txtName.Text = entry.Product_Name.ToString();
                this.txtPrice.Text = entry.Selling_Price.ToString();
                this.txtDiscount.Text = entry.Discount.ToString();
                this.txtDepict.Text = entry.Depict.ToString();
                this.txtStockID.Text = entry.stock_ID.ToString();
                this.comboBox1.Text = entry.Supplier_ID;
                this.txtQuanity.Text = Convert.ToString(entry.Inventory.Quantity);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product entry;
            //try
            //{
                if (opMode == "INSERT")  //新增
                {
                    Inventory first = new Inventory();
                    first.stock_ID = txtStockID.Text;
                    first.Product_Name = txtName.Text;
                    first.Quantity = Convert.ToInt32(txtQuanity.Text);
                    first.Inventory_Date = DateTime.Now;
                    db.Inventory.Add(first);
                    db.SaveChanges();
                    entry = new Product(); 
                    entry.Product_Name = txtName.Text;
                    entry.Product_ID = txtID.Text;
                    if (radioButton1.Checked)
                        entry.Discount_Info = true;
                    else if (radioButton2.Checked)
                        entry.Discount_Info = false;
                 
                    entry.Selling_Price = Convert.ToDecimal(txtPrice.Text);
                    entry.Depict = txtDepict.Text;
                    entry.Discount = Convert.ToDecimal(txtDiscount.Text);
                    entry.stock_ID = txtStockID.Text;
                    //entry.Supplier_ID = comboBox1.Text;
                  //  entry.Inventory.Quantity = Convert.ToInt32(txtQuanity.Text);
                    db.Product.Add(entry);//添加
                    db.SaveChanges();
                }
                if (opMode == "Update")
                {
                    entry = db.Product.FirstOrDefault(a => a.Product_ID == productID); //查询
                    entry.Product_Name = txtName.Text;
                    entry.Product_ID = txtID.Text;
                    if (radioButton1.Checked){
                        entry.Discount_Info = true;
                        entry.Discount = Convert.ToDecimal(txtDiscount.Text);
                    }  
                    else if (radioButton2.Checked)
                    {
                        entry.Discount_Info = false;
                        entry.Discount = 1;
                    }
                    entry.Discount = Convert.ToDecimal(txtDiscount.Text);
                    entry.Selling_Price = Convert.ToDecimal(txtPrice.Text);
                    entry.Depict = txtDepict.Text;
                  //  entry.stock_ID = txtStockID.Text;
                  
                    //entry.Inventory.Quantity = Convert.ToInt32(txtQuanity.Text);
                 //   entry.Supplier_ID = comboBox1.Text;
                }
                db.SaveChanges();//保存修改
                this.DialogResult = DialogResult.OK;
           // }
            //catch (Exception)
            //{
            //    MessageBox.Show("异常");
            //}
        }
 

     
    }
}
