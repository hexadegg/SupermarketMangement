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
    public partial class SaleQuery : Form
    {
        public SaleQuery()
        {
            InitializeComponent();
        }
        SupermarketInfoEntities9 db = new SupermarketInfoEntities9();
        private void SaleQuery_Load(object sender, EventArgs e)
        {
            var query = from p in db.Indent
                        select new { 订单号 = p.Order_ID, 客户号 = p.Payment.Customer.Customer_ID, 员工号 = p.Employee_ID, 订单日期 = p.Order_Date, 总金额 = p.TotalOrder_Money };
            dataGridView1.DataSource = query.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label5.Text = txtID.Text;
            var result = from a in db.OrderDetail select a;
            //商品编号
            if (this.txtID.Text != "")
            {
                result = from a in result
                         where a.Order_ID.Contains(txtID.Text)
                         select a;
            }

            var query = from a in result
                        select new { 订单号 = a.Order_ID, 明细编号 = a.Detail_ID, 商品编号 = a.Product_ID, 商品单价 = a.Unit_Price, 购买数量 = a.Amount };
            dataGridView2.DataSource = query.ToList();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //var result = from a in db.Indent select a;
            ////商品编号
            //if (this.txtCusID.Text != "")
            //{
            //    result = from a in result
            //             where a.Payment.Customer.Customer_ID.Contains(txtCusID.Text)
            //             select a;
            //}

            //var query = from a in result
            //            select new { 订单号 = a.Order_ID, 客户号 = a.Payment.Customer.Customer_ID, 员工号 = a.Employee_ID, 订单日期 = a.Order_Date, 总金额 = a.TotalOrder_Money };
            //dataGridView1.DataSource = query.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string indentID = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Indent entry = new Indent();
            entry = db.Indent.FirstOrDefault(a => a.Order_ID == indentID); //查询
            txtID.Text = entry.Order_ID;
            txtCusID.Text = entry.Payment.Customer_ID;
        }
    }
}
