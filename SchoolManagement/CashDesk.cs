using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolManagement
{
    public partial class CashDesk : Form
    {
        public CashDesk()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // 用双缓冲绘制窗口的所有子控件
                return cp;
            }
        }

        SupermarketInfoEntities9 db = new SupermarketInfoEntities9();
        int num;

       
        decimal much = 0;
        DataTable dt = new DataTable();

        void getNum(int num)
        {
            this.num = num;
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //DataGridView dataGridView1 = new DataGridView();
            //this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            //this.dataGridView1.Name = "dataGridView1";
            //this.dataGridView1.RowTemplate.Height = 30;
            //this.dataGridView1.Size = new System.Drawing.Size(588, 484);
            //this.dataGridView1.TabIndex = 0;
            //dataGridView1.Show();
        }

        private void CashDesk_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            var query = from p in db.Product
                        select new { 商品编号 = p.Product_ID, 商品名称 = p.Product_Name, 商品价格 = p.Selling_Price, 供应商 = p.Supplier.Supplier_Name, 折扣 = p.Discount_Info, 库存编号 = p.stock_ID };
            dataGridView1.DataSource = query.ToList();
            dt.Columns.Add("商品编号", typeof(string));
            dt.Columns.Add("商品名称", typeof(string));
            dt.Columns.Add("数量", typeof(string));
            dt.Columns.Add("价格", typeof(string));
            dt.Columns.Add("折扣", typeof(string));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string productID = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Product entry = new Product();
            entry = db.Product.FirstOrDefault(a => a.Product_ID == productID); //查询
            txtName.Text  = entry.Product_Name;
            txtID.Text = entry.Product_ID;
            txtPrice.Text = Convert.ToString(entry.Selling_Price);
            txtDiscount.Text = Convert.ToString(entry.Discount);
           // txtCount.Text = Convert.ToString(entry.Inventory.Quantity);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.AsEnumerable().FirstOrDefault(r => r.Field<string>("商品编号") == txtID.Text);
            if (dr != null)
            {
                int count = Convert.ToInt32(txtCount.Text);
                int oldcount = Convert.ToInt32(dr["数量"]);
                dr["数量"] = oldcount + count;
            }
            else
            {
                DataRow row = dt.NewRow();
                row["商品编号"] = txtID.Text;
                row["商品名称"] = txtName.Text;
                row["数量"] = txtCount.Text;
                row["折扣"] = txtDiscount.Text;
                row["价格"] = txtPrice.Text;
                dt.Rows.Add(row);
               
            }
                dataGridView2.DataSource = dt;
                decimal a = Convert.ToDecimal(txtPrice.Text);
                decimal b = Convert.ToDecimal(txtCount.Text);
                much +=  a* b;
                lbMoney.Text = Convert.ToString(much);
            //错误的方法，但是很意思
            #region
            // var query=from p in db.Product where p.Product_ID==txtID.Text
           //              select new {商品编号=p.Product_ID,商品名称=p.Product_Name,数量=txtCount.Text,折扣=p.Discount};
            
           // txtCount.Text = "";
           // // dataGridView2.DataSource = query.ToList();
           // // 获取之前的数据
           // var oldRows = dataGridView2.Rows.Cast<DataGridViewRow>().ToList();

           // // 清除数据源
           //// dataGridView2.DataSource = null;

           // // 创建一个新的容器
           // var newRows = new List<object>();

           // // 添加之前的数据
           // newRows.AddRange(oldRows.Select(r => r.DataBoundItem));

           // // 添加新的查询结果
           // newRows.AddRange(query.ToList());

           // // 将新的数据源赋值给 DataGridView
           // dataGridView2.DataSource = newRows;

           // this.dataGridView2.Rows[num].Cells[2].Value = txtCount.Text;

            // num++;
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt.Rows[num].Delete();
            decimal a = Convert.ToDecimal(txtPrice.Text);
            decimal b = Convert.ToDecimal(txtCount.Text);
            much -= a * b;
            lbMoney.Text = Convert.ToString(much);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getNum(e.RowIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rand = new Random(); //创建一个Random对象

            int id = rand.Next(10000, 99999); //生成一个5到50之间的随机整数

            Payment entry = new Payment();
            entry.Payment_ID = "PA" + Convert.ToString(id);
            entry.Payment_Method = "微信";
            entry.Payment_Money = much;
            entry.Payment_Time = DateTime.Now;
            entry.Customer_ID = "CI00001";
            id++;
            db.Payment.Add(entry);
            db.SaveChanges();


            foreach (DataRow row in dt.Rows)
            {
                //1.准备参数 
                SqlParameter p1 = new SqlParameter("@produtcID", SqlDbType.VarChar, 20);
                p1.Value = row["商品编号"];
                p1.Direction = ParameterDirection.Input;

                SqlParameter p2 = new SqlParameter("@productCount", SqlDbType.Char, 10);
                p2.Value =  Convert.ToInt32(txtCount.Text)* -1;
                p2.Direction = ParameterDirection.Input;


                //2.执行存储过程
                List<SqlParameter> paraList = new List<SqlParameter>();
                paraList.Add(p1);
                paraList.Add(p2);


                DBHelper.ExecuteNonQuery("prcQuantity", paraList, CommandType.StoredProcedure);
                //3.使用返回值或输出参数

            }
        
         
            //导出

            //判断导出的表非空
            if (dataGridView1.Rows.Count <= 0)
            {
                MessageBox.Show("无数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            string filePath = "";
            SaveFileDialog s = new SaveFileDialog   //保存文件对话框
            {
                FileName = ExcelHelper.GetFileName("Inventory"),//生成文件名(每个组根据要求修改名称！！！)
                Title = "保存Excel文件",
                Filter = "Excel文件(*.xls)|*.xls",
                FilterIndex = 1
            };
            if (s.ShowDialog() == DialogResult.OK)    //保存
            {
                filePath = s.FileName; //文件路径+名称
                DataTable tb = ExcelHelper.GetDgvToTable(dataGridView1);
                ExcelHelper.DataTableToExcel(filePath, "Sheet1", tb);
            }
            else
                return;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
           // this.Close();
        }
    }
}
