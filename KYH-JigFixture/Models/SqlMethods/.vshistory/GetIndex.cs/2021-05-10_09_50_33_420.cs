using System.Data.SqlClient;
using System.Linq;
using System.Collections.Generic;
using System;
using KYH_JigFixture.Models;

namespace Customer.Models.SqlMethods
{
    public class GetIndex
    {
        C6Entities c6db = new C6Entities();
        WebStationEntities Webdb = new WebStationEntities();
        /// <summary>
        /// <summary>
        /// </summary>
        /// <param name="OAFlow_Num">OA申请单号</param>
        /// <param name="ApplyDate">申请日期</param>
        /// <param name="Wuliao">物料:物料代码或物料名称</param>
        /// <returns></returns>
        public List<SelectOA_Result> GetIndexPageRow(string OAFlow_Num, DateTime ApplyDate, string Wuliao)
        {
            //默认显示非结案
            //模糊查询
            string queryIndexSql = "exec SelectOA'{0}'";
            queryIndexSql = string.Format(queryIndexSql);
            List<SelectOA_Result> totalCount = c6db.Database.SqlQuery<SelectOA_Result>(queryIndexSql).ToList();
            return totalCount;
        }
    }

}