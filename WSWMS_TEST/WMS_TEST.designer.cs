﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSWMS_TEST
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TEST")]
	public partial class WMS_TESTDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public WMS_TESTDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["TESTConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public WMS_TESTDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WMS_TESTDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WMS_TESTDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WMS_TESTDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertUser")]
		public int InsertUser([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> userid, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string namalengkap, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string password, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Char(10)")] string status)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userid, namalengkap, username, password, status);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetUser")]
		public ISingleResult<GetUserResult> GetUser([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(5)")] string userid)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userid);
			return ((ISingleResult<GetUserResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DeleteUser")]
		public int DeleteUser([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> userid)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userid);
			return ((int)(result.ReturnValue));
		}
	}
	
	public partial class GetUserResult
	{
		
		private int _userid;
		
		private string _namalengkap;
		
		private string _username;
		
		private string _password;
		
		private string _status;
		
		public GetUserResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userid", DbType="Int NOT NULL")]
		public int userid
		{
			get
			{
				return this._userid;
			}
			set
			{
				if ((this._userid != value))
				{
					this._userid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_namalengkap", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string namalengkap
		{
			get
			{
				return this._namalengkap;
			}
			set
			{
				if ((this._namalengkap != value))
				{
					this._namalengkap = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this._username = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this._password = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this._status = value;
				}
			}
		}
	}
}
#pragma warning restore 1591