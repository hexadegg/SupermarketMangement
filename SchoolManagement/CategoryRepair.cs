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
    public partial class CategoryRepair : Form
    {
        public CategoryRepair()
        {
            InitializeComponent();
        }
       
        SupermarketInfoEntities9 db = new SupermarketInfoEntities9();

        string mode;
        void setMode(string mode)
        {
            this.mode = mode;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {


            var query = from p in db.Category
                        select new { 类别编号 = p.Category_ID, 类别名称 = p.Category_Name, 分类标准 = p.Classification_Standard };
            dataGridView1.DataSource = query.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            setMode("查询");
            button2.Text = mode;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setMode("添加");
            button2.Text = mode;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setMode("删除");
            button2.Text = mode;
           
          
        }

        private void CategoryRepair_Load(object sender, EventArgs e)
        {
            var query = from p in db.Category
                        select new { 类别编号 = p.Category_ID, 类别名称 = p.Category_Name, 分类标准 = p.Classification_Standard };
            dataGridView1.DataSource = query.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string categoryID = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Category entry = new Category();
            entry = db.Category.FirstOrDefault(a => a.Category_ID == categoryID); //查询
            txtCategoryName.Text = entry.Category_Name;
            txtCattegoryID.Text = entry.Category_ID;
            rtstandard.Text = entry.Classification_Standard;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mode == "添加")
            {
                button2.Text=mode;
                Category entry = new Category();
                entry.Classification_Standard = rtstandard.Text;
                entry.Category_Name = txtCategoryName.Text;
                entry.Category_ID = txtCattegoryID.Text;
                db.Category.Add(entry);//添加
                db.SaveChanges();
                btnSearch.PerformClick();
            }
            if(mode=="删除")
            {
                button2.Text=mode;
                //获取主键
                string categoryID = txtCattegoryID.Text;
                Category entry = db.Category.SingleOrDefault(a => a.Category_ID == categoryID);
                //1.准备参数 
                SqlParameter p1 = new SqlParameter("@categoryID", SqlDbType.VarChar, 20);
                p1.Value = categoryID;
                p1.Direction = ParameterDirection.Input;

                SqlParameter p3 = new SqlParameter("", SqlDbType.Int);
                p3.Direction = ParameterDirection.ReturnValue;

                //2.执行存储过程
                List<SqlParameter> paraList = new List<SqlParameter>();
                paraList.Add(p1);
                paraList.Add(p3);

                DBHelper.ExecuteNonQuery("prcProductCategory", paraList, CommandType.StoredProcedure);
                int n = (int)p3.Value;
                if (n !=1)
                {
                        db.Category.Remove(entry);
                        db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("有商品存在，不允许删除！");
                }
           
                btnSearch.PerformClick();  
            }
            if (mode == "查询")
            {
               
                var result = from a in db.Category select a;

                if (this.txtCategoryName.Text != "")
                {
                    result = from a in result
                             where a.Category_Name.Contains(txtCategoryName.Text)
                             select a;
                }

                if (this.txtCattegoryID.Text != "")
                {
                    result = from a in result
                             where a.Category_ID == txtCattegoryID.Text
                             select a;
                }
                if (this.rtstandard.Text != "")
                {
                    result = from a in result
                             where a.Classification_Standard.Contains(rtstandard.Text)
                             select a;
                }

                var query = from a in result
                            select new { 类别编号 = a.Category_ID, 类别名称 = a.Category_Name, 分类标准 = a.Classification_Standard };
                dataGridView1.DataSource = query.ToList();
            }
           
        }
    }
}
