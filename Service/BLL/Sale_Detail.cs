using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Service.Common.Data;
namespace Service.BLL
{
    /// <summary>
    /// 数据访问类:Sale_Detail
    /// </summary>
    public partial class BLL_Sale_Detail
    {
        public BLL_Sale_Detail()
        { }
        #region  Method

        /// <summary>
        /// 销售单明细
        /// </summary>
        /// <param name="Sale_ID"></param>
        /// <returns></returns>
        public DataSet GetDetailAll(Int32 Sale_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT Product_ID AS ProId,Name AS ProName,SupplierName,SpecName,UnitName,Quantity,Price AS UnitPrice,SaleOrder_ID,Discount,0 AS PaidInAmount,0 AS PaidIn1 FROM v_saledetail ");
            strSql.Append("WHERE Sale_ID = " + Sale_ID);
            return ExecuteSql.ExeComSqlForDataSet(strSql.ToString());
        }

        /// <summary>
        /// 销售明细表
        /// </summary>
        /// <param name="BeginDate"></param>
        /// <param name="EndDate"></param>
        /// <returns></returns>
        public DataSet GetSaleDefinite(string BeginDate, string EndDate)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from SaleDefinite where saledate between '" + BeginDate + "' and '" + Convert.ToDateTime(EndDate).AddDays(1) +"'");
            return ExecuteSql.ExeComSqlForDataSet(strSql.ToString());
        }

        /// <summary>
        /// 生成销售汇总（按单品汇总）
        /// </summary>
        /// <param name="BeginDate">统计开始时间</param>
        /// <param name="EndDate">统计终止时间</param>
        /// <returns>DataSet</returns>
        public DataSet GetSaleGather(string BeginDate, string EndDate)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Product_ID,ProductName,SpecName,UnitName,shortname,Name,sum(Quantity) as totalQty from SaleDefinite where saledate between '" + BeginDate + "' and '" + Convert.ToDateTime(EndDate).AddDays(1) + "' group by Product_ID,ProductName,SpecName,UnitName,shortname,Name");
            return ExecuteSql.ExeComSqlForDataSet(strSql.ToString());
        }

        /// <summary>
        /// 生成销售汇总（按单号汇总）
        /// </summary>
        /// <param name="BeginDate"></param>
        /// <param name="EndDate"></param>
        /// <returns></returns>
        public DataSet GetGatherByList(string BeginDate, string EndDate)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Sale_ID, TradeNo,StoreAdd,count(TradeNo) as TrCount, sum(Price*Quantity) as totalPrice,GatheringWay,Account,Address,SaleDate ");
            strSql.Append("from dbo.SaleDefinite where SaleDate between '" + BeginDate + "' and '" + Convert.ToDateTime(EndDate).AddDays(1) + "' group by Sale_ID, TradeNo,StoreAdd,Address,SaleDate,GatheringWay,Account");
            return ExecuteSql.ExeComSqlForDataSet(strSql.ToString());
        }

        public bool DeleteSaleDtl(Int32 Sale_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Sale_Detail ");
            strSql.Append(" where Sale_ID =" + Sale_ID);
            int rows = ExecuteSql.ExeComSqlForNonQuery(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion  Method
    }
}

