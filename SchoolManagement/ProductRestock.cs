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
    public partial class ProductRestock : Form
    {
        public ProductRestock()
        {
            InitializeComponent();
        }
        SupermarketInfoEntities9 db = new SupermarketInfoEntities9();
        DataTable dt = new DataTable();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            //table.Columns.Add("productID", typeof(string));
            //table.Columns.Add("productCount", typeof(int));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("需提供：商品编号、入库数量");
            //导入
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel文件(*.xls)|*.xls";
            ofd.RestoreDirectory = true;
            string filePath = null;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName.ToString();
                dt = ExcelHelper.ExcelToDataTable(filePath, "customers");
                dataGridView1.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            foreach (DataRow row in dt.Rows)
            {
                //1.准备参数 
                SqlParameter p1 = new SqlParameter("@produtcID", SqlDbType.VarChar, 20);
                p1.Value = row["商品编号"];
                p1.Direction = ParameterDirection.Input;

                SqlParameter p2 = new SqlParameter("@productCount", SqlDbType.Char, 10);
                p2.Value = row["入库数量"];
                p2.Direction = ParameterDirection.Input;

            
                //2.执行存储过程
                List<SqlParameter> paraList = new List<SqlParameter>();
                paraList.Add(p1);
                paraList.Add(p2);
        

                DBHelper.ExecuteNonQuery("prcQuantity", paraList, CommandType.StoredProcedure);
                //3.使用返回值或输出参数
              
            }
            MessageBox.Show("导入成功！");
            button3.PerformClick();
        }

        private void ProductRestock_Load(object sender, EventArgs e)
        {
            var query = from p in db.Product
                        select new { 商品编号 = p.Product_ID, 商品名称 = p.Product_Name, 供应商 = p.Supplier.Supplier_Name, 库存 = p.Inventory.Quantity };
            dataGridView2.DataSource = query.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var query = from p in db.Product
                        select new { 商品编号 = p.Product_ID, 商品名称 = p.Product_Name, 供应商 = p.Supplier.Supplier_Name, 库存 = p.Inventory.Quantity };
            dataGridView2.DataSource = query.ToList();
        }
    }
}
