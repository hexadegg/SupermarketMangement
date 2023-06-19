using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel; // 用于处理 Excel 2003 格式的 .xls 文件
using System.IO;
using System.Data.OleDb;
using System.Windows.Forms;


namespace SchoolManagement
{
    class ExcelHelper
    {
        //引入动态链接库 NPOI.dll



        /// <summary>
        ///  将dataTable内的数据导入的Excel 97-2003 文件中，并提供下载功能
        /// </summary>
        /// <param name="filePath">Excel文件路径</param>
        /// <param name="sheetName">Excel文件中的表，如Sheet1</param>
        /// <param name="table">要导出的数据表</param>
        /// <returns></returns>
        public static void DataTableToExcel(string filePath, string sheetName, DataTable table)
        {
            IWorkbook workbook = new NPOI.HSSF.UserModel.HSSFWorkbook();
            ISheet sheet = workbook.CreateSheet(sheetName);

            //将DataTable内的数据写入到sheet中
            //写标题
            IRow header = sheet.CreateRow(0);
            for (int i = 0; i < table.Columns.Count; i++)
            {
                header.CreateCell(i).SetCellValue(table.Columns[i].ColumnName);
            }

            //写数据
            for (int i = 0; i < table.Rows.Count; i++)
            {
                IRow row = sheet.CreateRow(i + 1);
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    row.CreateCell(j).SetCellValue(table.Rows[i][j].ToString());
                }
            }

            // 写入到文件 
            System.IO.FileStream ms = new FileStream(filePath, FileMode.Create);
            workbook.Write(ms);
            ms.Close();

            workbook = null;
            ms.Close();
            ms.Dispose();
        }



        /// <summary>
        /// 把数据从Excel装载到DataTable(可以导入不同版本的Excel，.xlsx需安装AccessDatabaseEngine)
        /// </summary>
        /// <param name="pathName">带路径的Excel文件名</param>
        /// <param name="sheetName">工作表名</param>
        /// <returns>将数据存入的DataTable</returns>
        public static DataTable ExcelToDataTable(string pathName, string sheetName)
        {
            DataTable tbContainer = new DataTable();
            string strConn = string.Empty;
            if (string.IsNullOrEmpty(sheetName)) { sheetName = "Sheet1"; }
            FileInfo file = new FileInfo(pathName);
            if (!file.Exists) { throw new Exception("文件不存在"); }
            string extension = file.Extension;
            switch (extension)
            {
                case ".xls":// 另存为Excel 97-2003
                    strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                    break;
                case ".xlsx": //显示缩小
                    strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathName + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'";
                    break;
                default:
                    strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                    break;
            }
            #region 关于不同版本Excel的提供程序字符串
            /*
             参数HDR的值：
                HDR=Yes，这代表第一行是标题，不做为数据使用 ，如果用HDR=NO，则表示第一行不是标题，做为数据来使用。系统默认的是YES
                参数Excel 8.0
                对于Excel 97以上版本都用Excel 8.0
                IMEX ( IMport EXport mode )设置
　　                IMEX 有三种模式：
　　                0 is Export mode
　　                1 is Import mode
　　                2 is Linked mode (full update capabilities)
　　                我这里特别要说明的就是 IMEX 参数了，因为不同的模式代表著不同的读写行为：
　　                当 IMEX=0 时为“汇出模式”，这个模式开启的 Excel 档案只能用来做“写入”用途。
　　                当 IMEX=1 时为“汇入模式”，这个模式开启的 Excel 档案只能用来做“读取”用途。
　　                当 IMEX=2 时为“连結模式”，这个模式开启的 Excel 档案可同时支援“读取”与“写入”用途。
                意义如下:
                0 ---输出模式;
                1---输入模式;
                2----链接模式(完全更新能力)
             */
            #endregion
            //链接Excel
            OleDbConnection cnnxls = new OleDbConnection(strConn);
            //读取Excel里面有 表Sheet1
            OleDbDataAdapter oda = new OleDbDataAdapter(string.Format("select * from [{0}$]", sheetName), cnnxls);
            DataSet ds = new DataSet();
            //将Excel里面有表内容装载到内存表中！
            oda.Fill(tbContainer);
            return tbContainer;

        }

        /// <summary>
        /// 把数据从DataGridView装载到DataTable(与数据源无关)
        /// </summary>
        public static DataTable GetDgvToTable(DataGridView dgv)
        {
            DataTable dt = new DataTable();

            // 列强制转换
            for (int count = 0; count < dgv.Columns.Count; count++)
            {
                DataColumn dc = new DataColumn(dgv.Columns[count].Name.ToString());//列名
                dt.Columns.Add(dc);
            }

            // 循环行
            for (int count = 0; count < dgv.Rows.Count; count++)
            {
                DataRow dr = dt.NewRow();
                for (int countsub = 0; countsub < dgv.Columns.Count; countsub++)//每个字段
                {
                    dr[countsub] = Convert.ToString(dgv.Rows[count].Cells[countsub].Value);
                }
                dt.Rows.Add(dr);//添加一行
            }
            return dt;

        }

        /// <summary>
        /// 获取随机文本，格式：GuGuGu-B-202305301234
        /// </summary>
        /// <param name="category">中间字符串</param>
        /// <returns>返回随机文本</returns>
        public static string GetFileName(string category)
        {
            string head = "GuGuGu-"; //固定开头 (你们组的店名）
            string middle = category + "-";  //中间字符串，可变字符（你们班的班号，如B、C）
            string time = DateTime.Now.ToString("yyyyMMdd"); //年月日
            string rear = (new Random()).Next(0, 9999).ToString("0000"); //4位随机数
            return head + middle + time + rear;
        }



    }


}

