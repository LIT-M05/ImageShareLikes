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

namespace ImageLikesLinqToSql.Data
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ImageLikesLinqToSql")]
	public partial class ImagesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertImage(Image instance);
    partial void UpdateImage(Image instance);
    partial void DeleteImage(Image instance);
    #endregion
		
		public ImagesDataContext() : 
				base(global::ImageLikesLinqToSql.Data.Properties.Settings.Default.ImageLikesLinqToSqlConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ImagesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ImagesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ImagesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ImagesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Image> Images
		{
			get
			{
				return this.GetTable<Image>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Images")]
	public partial class Image : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Title;
		
		private string _FileName;
		
		private int _Likes;
		
		private System.DateTime _DateUploaded;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnFileNameChanging(string value);
    partial void OnFileNameChanged();
    partial void OnLikesChanging(int value);
    partial void OnLikesChanged();
    partial void OnDateUploadedChanging(System.DateTime value);
    partial void OnDateUploadedChanged();
    #endregion
		
		public Image()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FileName", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string FileName
		{
			get
			{
				return this._FileName;
			}
			set
			{
				if ((this._FileName != value))
				{
					this.OnFileNameChanging(value);
					this.SendPropertyChanging();
					this._FileName = value;
					this.SendPropertyChanged("FileName");
					this.OnFileNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Likes", DbType="Int NOT NULL")]
		public int Likes
		{
			get
			{
				return this._Likes;
			}
			set
			{
				if ((this._Likes != value))
				{
					this.OnLikesChanging(value);
					this.SendPropertyChanging();
					this._Likes = value;
					this.SendPropertyChanged("Likes");
					this.OnLikesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateUploaded", DbType="DateTime NOT NULL")]
		public System.DateTime DateUploaded
		{
			get
			{
				return this._DateUploaded;
			}
			set
			{
				if ((this._DateUploaded != value))
				{
					this.OnDateUploadedChanging(value);
					this.SendPropertyChanging();
					this._DateUploaded = value;
					this.SendPropertyChanged("DateUploaded");
					this.OnDateUploadedChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
