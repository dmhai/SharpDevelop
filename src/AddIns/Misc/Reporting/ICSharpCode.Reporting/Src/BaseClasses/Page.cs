﻿/*
 * Created by SharpDevelop.
 * User: Peter Forstmeier
 * Date: 03.04.2013
 * Time: 20:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;

using ICSharpCode.Reporting.Interfaces;
using ICSharpCode.Reporting.Interfaces.Export;

namespace ICSharpCode.Reporting.BaseClasses
{
	/// <summary>
	/// Description of Page.
	/// </summary>
	///
	

	public class Page:IPage
	{
		public Page(IPageInfo pageInfo,Size pageSize)
		{
			if (pageInfo == null) {
				throw new ArgumentNullException("pageInfo");
			}
			PageInfo = pageInfo;
			Name = "Page";
			Size = pageSize;
			ExportedItems = new List<IExportColumn>();
		}
		
		public bool IsFirstPage {get;set;}
		
		
		public IPageInfo PageInfo {get;private set;}
		

		public string Name {get;set;}
		
		
		public System.Drawing.Size Size {get;set;}

		
		public System.Drawing.Point Location {get;set;}
			
		
		public List<IExportColumn> ExportedItems {get;set;}
		
		
		public IExportContainer CreateExportColumn()
		{
			throw new NotImplementedException();
		}
	}
}