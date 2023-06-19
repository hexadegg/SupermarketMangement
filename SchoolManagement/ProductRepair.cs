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
    public partial class ProductRepair : Form
    {
        public ProductRepair()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        SupermarketInfoEntities9 db = new SupermarketInfoEntities9();
        string mode;
        void setMode(string mode)
        {
            this.mode = mode;
            button6.Text = mode;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            setMode("查询");
          
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           

            if (button6.Text == "查询")
            {
                var result = from a in db.Product select a;
                //商品编号
                if (this.txtID.Text != "")
                {
                    result = from a in result
                             where a.Product_ID == txtID.Text
                             select a;
                }
                //商品名称
                if (this.txtName.Text != "")
                {
                    result = from a in result
                             where a.Product_Name.Contains(txtName.Text)
                             select a;
                }

                //是否有折扣
                if (this.radioButton1.Checked)  //折扣
                {
                    result = from a in result
                             where a.Discount_Info == true
                             select a;
                }
                //供应商
                if (this.comboBox1.Text != "")
                {
                    result = from a in result
                             where a.Supplier.Supplier_Name.Contains(comboBox1.Text)
                             select a;
                }

                var query = from a in result
                            select new { 商品编号 = a.Product_ID, 商品名称 = a.Product_Name, 商品价格 = a.Selling_Price, 供应商 = a.Supplier.Supplier_Name, 折扣 = a.Discount_Info };
                dataGridView1.DataSource = query.ToList();
            }

            if (button6.Text == "刷新")
            {

                {//绑定类别
                    List<Supplier> list = db.Supplier.ToList<Supplier>();
                    list.Insert(0, new Supplier() { Supplier_ID = "SP00000", Supplier_Name = "=请选择=" });
                    this.comboBox1.DataSource = list;
                    this.comboBox1.DisplayMember = "Supplier_Name";
                    this.comboBox1.ValueMember = "Supplier_ID";
                }

                var query = from p in db.Product
                            select new { 商品编号 = p.Product_ID, 商品名称 = p.Product_Name, 商品价格 = p.Selling_Price, 供应商 = p.Supplier.Supplier_Name, 折扣 = p.Discount_Info, 库存编号 = p.stock_ID };
                dataGridView1.DataSource = query.ToList();
            }

            if (button6.Text == "删除")
            {
                //判断是否已选中行
                if (this.dataGridView1.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("确认删除选中的行?", "", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        //获取主键
                        string stockID = txtstockID.Text;

                        if (db.Inventory.Any(a => a.stock_ID == stockID && a.Quantity > 0))
                        {
                            MessageBox.Show("库存不为空，不允许删除");
                            return;
                        }
                        //删除
                        {
                            Product entry = db.Product.SingleOrDefault(a => a.stock_ID == stockID);
                            db.Product.Remove(entry);
                            db.SaveChanges();
                        }
                    }
                }
                
            }
            btnSearch.PerformClick();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {//绑定类别
                List<Supplier> list = db.Supplier.ToList<Supplier>();
                list.Insert(0, new Supplier() { Supplier_ID = "SP00000", Supplier_Name = "=请选择=" });
                this.comboBox1.DataSource = list;
                this.comboBox1.DisplayMember = "Supplier_Name";
                this.comboBox1.ValueMember = "Supplier_ID";
            }

            var query = from p in db.Product
                        select new { 商品编号 = p.Product_ID, 商品名称 = p.Product_Name, 商品价格 = p.Selling_Price, 供应商 = p.Supplier.Supplier_Name, 折扣 = p.Discount_Info, 库存编号 = p.stock_ID };
            dataGridView1.DataSource = query.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //打开从界面
            SMProduct smp = new SMProduct();
            smp.setValue("PT00000", "INSERT");
            if (smp.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //执行查询，刷新数据
                this.btnSearch.PerformClick();
                this.button6.PerformClick();
            }
            //SchoolInfoEntities db = new SchoolInfoEntities();
            //Student stu = getStu();
            //if (stu != null && db.Student.Where(p => p.StuID == stu.StuID).Count() == 0)
            //{
            //    studentMethod.insert(stu);
            //    MessageBox.Show("添加成功");
            //}
            //else
            //    MessageBox.Show("学号不能重复");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Product entry;
            //try
            //{
            //    if (opMode == "INSERT")  //新增
            //    {
            //        entry = new Products(); //产品ID数据库自动添加
            //        entry.ProductName = tbx产品名称.Text;
            //        entry.SupplierID = Convert.ToInt32(cbx供应商.SelectedValue);
            //        entry.CategoryID = Convert.ToInt32(cbx类别.SelectedValue);
            //        entry.UnitPrice = Convert.ToDecimal(tbx单价.Text);
            //        entry.Discontinued = cbx折扣.Checked;
            //        db.Products.Add(entry);//添加
            //    }
            //    if (opMode == "Update")
            //    {
            //        int n = Convert.ToInt32(lbl产品编码.Text);
            //        entry = db.Products.FirstOrDefault(a => a.ProductID == n); //查询
            //        entry.ProductName = tbx产品名称.Text;
            //        entry.SupplierID = Convert.ToInt32(cbx供应商.SelectedValue);
            //        entry.CategoryID = Convert.ToInt32(cbx类别.SelectedValue);
            //        entry.UnitPrice = Convert.ToDecimal(tbx单价.Text);
            //        entry.Discontinued = cbx折扣.Checked;
            //    }
            //    db.SaveChanges();//保存修改
            //    this.DialogResult = DialogResult.OK;
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("异常");
            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            setMode("刷新");
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                string productID = this.dataGridView1
                            .Rows[e.RowIndex].Cells[0].Value.ToString();
                SMProduct smp = new SMProduct();
                smp.setValue(productID, "Update");
                if (smp.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //执行查询，刷新数据
                    this.btnSearch.PerformClick();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setMode("删除");
           

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "清除")
            {
                txtID.Text = "";
                txtName.Text = "";
                txtThrehold.Text = "";
                txtPrice.Text = "";
                txtstockID.Text = "";
                txtStockCount.Text = "";
                txtxDiscount.Text = "";
                {//绑定类别
                    List<Supplier> list = db.Supplier.ToList<Supplier>();
                    list.Insert(0, new Supplier() { Supplier_ID = "SP00000", Supplier_Name = "=请选择=" });
                    this.comboBox1.DataSource = list;
                    this.comboBox1.DisplayMember = "Supplier_Name";
                    this.comboBox1.ValueMember = "Supplier_ID";
                }
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string productID = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            Product entry = db.Product.SingleOrDefault(a => a.Product_ID == productID);
            this.txtID.Text = entry.Product_ID.ToString();
            this.txtName.Text = entry.Product_Name.ToString();
            this.txtPrice.Text = entry.Selling_Price.ToString();
            this.txtxDiscount.Text = entry.Discount.ToString();
            if (Convert.ToDecimal(txtxDiscount.Text) < 1)
                radioButton1.Checked = true;
            else radioButton2.Checked = true;
            this.txtstockID.Text = entry.stock_ID.ToString();
            this.comboBox1.Text = entry.Supplier_ID;
            this.txtStockCount.Text = Convert.ToString(entry.Inventory.Quantity);
            txtThrehold.Text = Convert.ToString(entry.Inventory.Threshold);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // 根据行的索引值设置不同的背景色
            if (e.RowIndex % 2 == 0) // 这里是设置每隔一行为一个颜色，也可以根据其他条件来设置不同颜色
            {
                e.CellStyle.BackColor = Color.LightGray; // 奇数行的背景颜色为浅灰色
            }
            else
            {
                e.CellStyle.BackColor = Color.Honeydew; // 偶数行的背景颜色为白色
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
