﻿using System;
using System.Collections.Generic;
using System.Web.Mvc;
using KYH_GetK3POInformation.Models;
using KYH_GetK3POInformation.Models.PublicSqlMethods;
using KYH_GetK3POInformation.Models.SqlMethods;
using Newtonsoft.Json;

namespace KYH_GetK3POInformation.Controllers
{
	// Token: 0x0200000F RID: 15
	public class AddLoadingListAddPOdata_TempController : Controller
	{
		// Token: 0x0600008F RID: 143 RVA: 0x00002E09 File Offset: 0x00001009
		public ActionResult Index()
		{
			return base.View();
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002E14 File Offset: 0x00001014
		public int AddFunction(string ArrayList)
		{
			int result = 0;
			try
			{
				int a = 0;
				if (new GetIndex().CheckTable(base.Session["username"].ToString()) == 0)
				{
					if (!new GetIndex().CREATETable(base.Session["username"].ToString()))
					{
						return 0;
					}
				}
				else if (!new GetIndex().TRUNCATETABLE(base.Session["username"].ToString()))
				{
					return 0;
				}
				ArrayList = ArrayList.Replace("GIP-PO", "GIP_PO");
				ArrayList = ArrayList.Replace("Part-No", "Part_No");
				List<Others> List = JsonConvert.DeserializeObject<List<Others>>(ArrayList);
				foreach (Others Con in List)
				{
					List[a].Unit = List[a].Unit.ToUpper();
					if (!new GetIndex().InsertData(base.Session["username"].ToString(), List[a]))
					{
						result = 0;
					}
					a++;
					result = 1;
				}
			}
			catch (Exception ex)
			{
				LogHelper.Write(ex.ToString());
				return 0;
			}
			return result;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002F88 File Offset: 0x00001188
		public int UpdFunction(string username, LoadingListAddPOdata_Temp ArrayList)
		{
			int result;
			try
			{
				if (!new GetIndex().UpdateData(username, ArrayList))
				{
					result = 0;
				}
				else
				{
					result = 1;
				}
			}
			catch (Exception ex)
			{
				LogHelper.Write(ex.ToString());
				return 0;
			}
			return result;
		}

		// Token: 0x0400003A RID: 58
		private WebStationEntities db = new WebStationEntities();
	}
}
