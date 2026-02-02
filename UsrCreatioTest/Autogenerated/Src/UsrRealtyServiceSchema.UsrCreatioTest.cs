namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyServiceSchema

	/// <exclude/>
	public class UsrRealtyServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyServiceSchema(UsrRealtyServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("436ae764-9a79-41dc-968c-f9ce389ee9cd");
			Name = "UsrRealtyService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f753c22a-95d4-41ba-ba19-b4792dd0a066");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,83,77,107,227,48,16,61,187,208,255,32,146,139,3,65,190,55,105,161,205,166,75,11,105,66,93,218,67,232,65,177,39,169,88,235,99,71,178,23,179,244,191,175,100,203,177,27,74,214,96,99,189,121,243,230,73,51,34,146,9,48,154,101,64,94,0,145,25,181,183,116,161,228,158,31,74,100,150,43,121,121,241,247,242,34,42,13,151,7,146,214,198,130,160,41,96,197,51,88,169,28,138,217,185,32,125,131,221,121,194,109,102,121,213,212,233,121,189,17,151,238,204,8,241,125,116,161,16,232,82,102,88,235,32,224,72,219,32,239,246,96,145,101,246,221,99,183,70,63,129,117,74,218,149,218,241,130,219,250,25,126,151,28,65,128,180,38,30,46,188,47,114,77,254,147,226,89,52,0,249,196,23,209,229,174,224,25,201,10,102,12,89,120,79,234,128,76,127,240,44,56,34,87,228,142,25,232,86,254,84,163,237,90,67,123,204,67,191,209,214,109,252,65,86,234,23,196,43,176,31,42,119,134,70,155,117,250,50,154,146,59,149,215,169,173,11,111,210,209,86,96,12,59,192,17,165,111,174,168,134,124,234,117,34,239,16,140,189,87,40,152,253,146,208,66,244,209,40,57,37,207,110,4,148,52,112,158,231,183,233,85,147,36,33,115,83,10,193,176,190,233,128,241,240,33,39,63,100,0,141,201,143,101,74,143,58,201,169,208,92,51,100,130,248,185,188,30,105,119,152,127,20,230,163,155,94,111,80,138,206,147,134,221,39,35,216,18,165,9,244,233,87,91,227,147,101,183,118,50,93,158,23,10,157,52,22,253,188,253,244,83,32,43,64,11,249,38,216,121,101,69,9,113,32,116,30,39,109,75,35,190,39,33,68,31,204,83,89,20,107,92,10,109,235,248,72,236,152,81,91,53,84,162,13,107,214,68,62,155,111,197,144,104,84,21,207,1,93,83,218,161,218,4,224,222,13,139,194,154,58,127,225,14,116,145,120,50,59,166,35,152,178,240,29,237,116,186,11,211,187,105,201,193,74,203,111,32,239,193,189,159,190,233,255,0,16,85,146,15,39,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("436ae764-9a79-41dc-968c-f9ce389ee9cd"));
		}

		#endregion

	}

	#endregion

}

