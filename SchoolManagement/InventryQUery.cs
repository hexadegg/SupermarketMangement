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
    public partial class InventryQUery : Form
    {
        public InventryQUery()
        {
            InitializeComponent();
        }
        SupermarketInfoEntities9 db = new SupermarketInfoEntities9();
        string mode;
        void setMode(string mode)
        {
            this.mode = mode;
            button6.Text = mode;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            txtThrehold.Enabled = true;
            setMode("修改");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtProductID.Enabled = true;
            txtProductName.Enabled = true;
            txtSuplierID.Enabled = true;
            setMode("查找");
        }

        private void button2_Click(object sender, EventArgs e)
        {

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var query = from p in db.Product
                        select new { 商品编号 = p.Product_ID, 商品名称 = p.Product_Name, 供应商 = p.Supplier.Supplier_Name, 库存 = p.Inventory.Quantity, 阈值 = p.Inventory.Threshold };
            dataGridView1.DataSource = query.ToList();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int a = Convert.ToInt32(row.Cells["库存"].Value);
                int b = Convert.ToInt32(row.Cells["阈值"].Value);
                if (a < b)
                    row.DefaultCellStyle.ForeColor = Color.Red;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = null; // 先取消当前单元格
            dataGridView1.Rows.Cast<DataGridViewRow>()
                .Where(row => (int)row.Cells["库存"].Value > (int)row.Cells["阈值"].Value)
                .ToList()
                .ForEach(row => { row.Visible = false; });
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string productID = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Product entry = new Product();
            entry = db.Product.FirstOrDefault(a => a.Product_ID == productID); //查询
            txtProductID.Text = entry.Product_ID;
            txtProductName.Text = entry.Product_Name;
            txtSuplierID.Text = entry.Supplier.Supplier_ID;
            txtCount.Text = Convert.ToString(entry.Inventory.Quantity);
            txtThrehold.Text = Convert.ToString(entry.Inventory.Threshold);
            txtstockID.Text = Convert.ToString(entry.Inventory.stock_ID);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (mode == "修改")
            {
                Inventory entry = db.Inventory.FirstOrDefault(a => a.stock_ID == txtstockID.Text); //查询
                entry.Threshold = Convert.ToInt32(txtThrehold.Text);
                db.SaveChanges();
                btnSearch.PerformClick();
            }
            if (mode == "查找")
            {
                var result = from a in db.Product select a;
                //商品编号
                if (this.txtProductID.Text != "")
                {
                    result = from a in result
                             where a.Product_ID == txtProductID.Text
                             select a;
                }
                //顾客名称
                if (this.txtProductName.Text != "")
                {
                    result = from a in result
                             where a.Product_Name.Contains(txtProductName.Text)
                             select a;
                }
                if (this.txtSuplierID.Text != "")
                {
                    result = from a in result
                             where a.Supplier_ID == txtSuplierID.Text
                             select a;
                }
                var query = from p in result
                            select new { 商品编号 = p.Product_ID, 商品名称 = p.Product_Name, 供应商 = p.Supplier.Supplier_Name, 库存 = p.Inventory.Quantity, 阈值 = p.Inventory.Threshold };
                dataGridView1.DataSource = query.ToList();
            }
        }

        private void InventryQUery_Load(object sender, EventArgs e)
        {
            var query = from p in db.Product
                        select new { 商品编号 = p.Product_ID, 商品名称 = p.Product_Name, 供应商 = p.Supplier.Supplier_Name, 库存 = p.Inventory.Quantity, 阈值 = p.Inventory.Threshold };
         
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int a = Convert.ToInt32(row.Cells["库存"].Value);
                int b = Convert.ToInt32(row.Cells["阈值"].Value);
                if (a < b)
                    row.DefaultCellStyle.ForeColor = Color.Red;
            }
            btnSearch.PerformClick();
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            txtProductID.Enabled = false;
            txtProductName.Enabled = false;
            txtSuplierID.Enabled = false;
        }
    }
}
