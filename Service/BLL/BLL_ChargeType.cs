using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Common.Data;

namespace Service.BLL
{
    public class BLL_ChargeType
    {
        public DataSet GetChargeInfo()
        {
            string[] ParaName = { };
            string[] ParaValue = { };
            DataSet ds = ExecuteSql.ExeParaSqlForDataSet("SELECT ChargeType.ID AS CID,VehicleType.ID AS VID,TypeName,DayCost,NightCost,Monthly,FreeTime FROM VehicleType LEFT OUTER JOIN ChargeType ON VehicleType.TypeCode = ChargeType.VehicleType", ParaName, ParaValue);
            return ds;
        }
    }
}