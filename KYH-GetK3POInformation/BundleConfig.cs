using System;
using System.Web.Optimization;

namespace KYH_GetK3POInformation
{
	// Token: 0x02000003 RID: 3
	public class BundleConfig
	{
		// Token: 0x06000008 RID: 8 RVA: 0x000021D8 File Offset: 0x000003D8
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js", new IItemTransform[0]));
			bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/Scripts/jquery.validate*", new IItemTransform[0]));
			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*", new IItemTransform[0]));
			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js", new IItemTransform[0]));
			bundles.Add(new StyleBundle("~/Content/css").Include(new string[]
			{
				"~/Content/bootstrap.css",
				"~/Content/site.css"
			}));
		}
	}
}
