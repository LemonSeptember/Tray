using System.Data.OleDb;

namespace Tray
{
    internal class Access
    {
        private OleDbConnection oleDb;

        /// <summary>
        /// 构造函数
        /// </summary>
        public Access()
        {
            oleDb = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\KETIZU2\Desktop\database\login.mdb");
            //oleDb.Open();
        }

        #region 属性

        public string Pwd { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        #endregion 属性

        #region 公共方法

        //public void AddData(Access data)
        //{
        //}

        #endregion 公共方法
    }
}