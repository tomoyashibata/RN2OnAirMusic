﻿using System.Web;
using System.Web.Mvc;

namespace Rn2OnAirMucicList {
	public class FilterConfig {
		public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
			filters.Add(new HandleErrorAttribute());
		}
	}
}