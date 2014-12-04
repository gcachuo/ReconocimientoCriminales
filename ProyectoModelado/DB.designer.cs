﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.33440
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoModelado
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Criminales")]
	public partial class DBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCRIMINALE(CRIMINALE instance);
    partial void UpdateCRIMINALE(CRIMINALE instance);
    partial void DeleteCRIMINALE(CRIMINALE instance);
    partial void InsertEFECTO(EFECTO instance);
    partial void UpdateEFECTO(EFECTO instance);
    partial void DeleteEFECTO(EFECTO instance);
    partial void InsertPRISIONE(PRISIONE instance);
    partial void UpdatePRISIONE(PRISIONE instance);
    partial void DeletePRISIONE(PRISIONE instance);
    partial void InsertUSUARIO(USUARIO instance);
    partial void UpdateUSUARIO(USUARIO instance);
    partial void DeleteUSUARIO(USUARIO instance);
    #endregion
		
		public DBDataContext() : 
				base(global::ProyectoModelado.Properties.Settings.Default.CriminalesConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CRIMINALE> CRIMINALEs
		{
			get
			{
				return this.GetTable<CRIMINALE>();
			}
		}
		
		public System.Data.Linq.Table<EFECTO> EFECTOs
		{
			get
			{
				return this.GetTable<EFECTO>();
			}
		}
		
		public System.Data.Linq.Table<PRISIONE> PRISIONEs
		{
			get
			{
				return this.GetTable<PRISIONE>();
			}
		}
		
		public System.Data.Linq.Table<USUARIO> USUARIOs
		{
			get
			{
				return this.GetTable<USUARIO>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CRIMINALES")]
	public partial class CRIMINALE : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nombre;
		
		private string _Apellido;
		
		private string _Alias;
		
		private int _Edad;
		
		private int _Estatura;
		
		private string _Relacion;
		
		private string _Nacionalidad;
		
		private string _Origen;
		
		private string _Carcel;
		
		private System.Data.Linq.Binary _Estatus;
		
		private string _Condena;
		
		private decimal _Fianza;
		
		private string _Descripcion;
		
		private System.Data.Linq.Binary _Imagen;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnApellidoChanging(string value);
    partial void OnApellidoChanged();
    partial void OnAliasChanging(string value);
    partial void OnAliasChanged();
    partial void OnEdadChanging(int value);
    partial void OnEdadChanged();
    partial void OnEstaturaChanging(int value);
    partial void OnEstaturaChanged();
    partial void OnRelacionChanging(string value);
    partial void OnRelacionChanged();
    partial void OnNacionalidadChanging(string value);
    partial void OnNacionalidadChanged();
    partial void OnOrigenChanging(string value);
    partial void OnOrigenChanged();
    partial void OnCarcelChanging(string value);
    partial void OnCarcelChanged();
    partial void OnEstatusChanging(System.Data.Linq.Binary value);
    partial void OnEstatusChanged();
    partial void OnCondenaChanging(string value);
    partial void OnCondenaChanged();
    partial void OnFianzaChanging(decimal value);
    partial void OnFianzaChanged();
    partial void OnDescripcionChanging(string value);
    partial void OnDescripcionChanged();
    partial void OnImagenChanging(System.Data.Linq.Binary value);
    partial void OnImagenChanged();
    #endregion
		
		public CRIMINALE()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(45) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellido", DbType="NVarChar(45) NOT NULL", CanBeNull=false)]
		public string Apellido
		{
			get
			{
				return this._Apellido;
			}
			set
			{
				if ((this._Apellido != value))
				{
					this.OnApellidoChanging(value);
					this.SendPropertyChanging();
					this._Apellido = value;
					this.SendPropertyChanged("Apellido");
					this.OnApellidoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Alias", DbType="NVarChar(45) NOT NULL", CanBeNull=false)]
		public string Alias
		{
			get
			{
				return this._Alias;
			}
			set
			{
				if ((this._Alias != value))
				{
					this.OnAliasChanging(value);
					this.SendPropertyChanging();
					this._Alias = value;
					this.SendPropertyChanged("Alias");
					this.OnAliasChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Edad", DbType="Int NOT NULL")]
		public int Edad
		{
			get
			{
				return this._Edad;
			}
			set
			{
				if ((this._Edad != value))
				{
					this.OnEdadChanging(value);
					this.SendPropertyChanging();
					this._Edad = value;
					this.SendPropertyChanged("Edad");
					this.OnEdadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Estatura", DbType="Int NOT NULL")]
		public int Estatura
		{
			get
			{
				return this._Estatura;
			}
			set
			{
				if ((this._Estatura != value))
				{
					this.OnEstaturaChanging(value);
					this.SendPropertyChanging();
					this._Estatura = value;
					this.SendPropertyChanged("Estatura");
					this.OnEstaturaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Relacion", DbType="NVarChar(45) NOT NULL", CanBeNull=false)]
		public string Relacion
		{
			get
			{
				return this._Relacion;
			}
			set
			{
				if ((this._Relacion != value))
				{
					this.OnRelacionChanging(value);
					this.SendPropertyChanging();
					this._Relacion = value;
					this.SendPropertyChanged("Relacion");
					this.OnRelacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nacionalidad", DbType="NVarChar(45) NOT NULL", CanBeNull=false)]
		public string Nacionalidad
		{
			get
			{
				return this._Nacionalidad;
			}
			set
			{
				if ((this._Nacionalidad != value))
				{
					this.OnNacionalidadChanging(value);
					this.SendPropertyChanging();
					this._Nacionalidad = value;
					this.SendPropertyChanged("Nacionalidad");
					this.OnNacionalidadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Origen", DbType="NVarChar(45) NOT NULL", CanBeNull=false)]
		public string Origen
		{
			get
			{
				return this._Origen;
			}
			set
			{
				if ((this._Origen != value))
				{
					this.OnOrigenChanging(value);
					this.SendPropertyChanging();
					this._Origen = value;
					this.SendPropertyChanged("Origen");
					this.OnOrigenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Carcel", DbType="NVarChar(45) NOT NULL", CanBeNull=false)]
		public string Carcel
		{
			get
			{
				return this._Carcel;
			}
			set
			{
				if ((this._Carcel != value))
				{
					this.OnCarcelChanging(value);
					this.SendPropertyChanging();
					this._Carcel = value;
					this.SendPropertyChanged("Carcel");
					this.OnCarcelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Estatus", DbType="Binary(1) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Estatus
		{
			get
			{
				return this._Estatus;
			}
			set
			{
				if ((this._Estatus != value))
				{
					this.OnEstatusChanging(value);
					this.SendPropertyChanging();
					this._Estatus = value;
					this.SendPropertyChanged("Estatus");
					this.OnEstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Condena", DbType="NVarChar(45) NOT NULL", CanBeNull=false)]
		public string Condena
		{
			get
			{
				return this._Condena;
			}
			set
			{
				if ((this._Condena != value))
				{
					this.OnCondenaChanging(value);
					this.SendPropertyChanging();
					this._Condena = value;
					this.SendPropertyChanged("Condena");
					this.OnCondenaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fianza", DbType="Money NOT NULL")]
		public decimal Fianza
		{
			get
			{
				return this._Fianza;
			}
			set
			{
				if ((this._Fianza != value))
				{
					this.OnFianzaChanging(value);
					this.SendPropertyChanging();
					this._Fianza = value;
					this.SendPropertyChanged("Fianza");
					this.OnFianzaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this.OnDescripcionChanging(value);
					this.SendPropertyChanging();
					this._Descripcion = value;
					this.SendPropertyChanged("Descripcion");
					this.OnDescripcionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Imagen", DbType="Image NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Imagen
		{
			get
			{
				return this._Imagen;
			}
			set
			{
				if ((this._Imagen != value))
				{
					this.OnImagenChanging(value);
					this.SendPropertyChanging();
					this._Imagen = value;
					this.SendPropertyChanged("Imagen");
					this.OnImagenChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EFECTOS")]
	public partial class EFECTO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Id_Criminal;
		
		private System.Data.Linq.Binary _imagenModificada;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnId_CriminalChanging(string value);
    partial void OnId_CriminalChanged();
    partial void OnimagenModificadaChanging(System.Data.Linq.Binary value);
    partial void OnimagenModificadaChanged();
    #endregion
		
		public EFECTO()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Criminal", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string Id_Criminal
		{
			get
			{
				return this._Id_Criminal;
			}
			set
			{
				if ((this._Id_Criminal != value))
				{
					this.OnId_CriminalChanging(value);
					this.SendPropertyChanging();
					this._Id_Criminal = value;
					this.SendPropertyChanged("Id_Criminal");
					this.OnId_CriminalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imagenModificada", DbType="VarBinary(MAX) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary imagenModificada
		{
			get
			{
				return this._imagenModificada;
			}
			set
			{
				if ((this._imagenModificada != value))
				{
					this.OnimagenModificadaChanging(value);
					this.SendPropertyChanging();
					this._imagenModificada = value;
					this.SendPropertyChanged("imagenModificada");
					this.OnimagenModificadaChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PRISIONES")]
	public partial class PRISIONE : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nombre;
		
		private string _Ciudad;
		
		private string _Estado;
		
		private string _Pais;
		
		private string _Coordenadas;
		
		private System.Data.Linq.Binary _Division;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnCiudadChanging(string value);
    partial void OnCiudadChanged();
    partial void OnEstadoChanging(string value);
    partial void OnEstadoChanged();
    partial void OnPaisChanging(string value);
    partial void OnPaisChanged();
    partial void OnCoordenadasChanging(string value);
    partial void OnCoordenadasChanged();
    partial void OnDivisionChanging(System.Data.Linq.Binary value);
    partial void OnDivisionChanged();
    #endregion
		
		public PRISIONE()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ciudad", DbType="NVarChar(40) NOT NULL", CanBeNull=false)]
		public string Ciudad
		{
			get
			{
				return this._Ciudad;
			}
			set
			{
				if ((this._Ciudad != value))
				{
					this.OnCiudadChanging(value);
					this.SendPropertyChanging();
					this._Ciudad = value;
					this.SendPropertyChanged("Ciudad");
					this.OnCiudadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Estado", DbType="NVarChar(40) NOT NULL", CanBeNull=false)]
		public string Estado
		{
			get
			{
				return this._Estado;
			}
			set
			{
				if ((this._Estado != value))
				{
					this.OnEstadoChanging(value);
					this.SendPropertyChanging();
					this._Estado = value;
					this.SendPropertyChanged("Estado");
					this.OnEstadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pais", DbType="NVarChar(35) NOT NULL", CanBeNull=false)]
		public string Pais
		{
			get
			{
				return this._Pais;
			}
			set
			{
				if ((this._Pais != value))
				{
					this.OnPaisChanging(value);
					this.SendPropertyChanging();
					this._Pais = value;
					this.SendPropertyChanged("Pais");
					this.OnPaisChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Coordenadas", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Coordenadas
		{
			get
			{
				return this._Coordenadas;
			}
			set
			{
				if ((this._Coordenadas != value))
				{
					this.OnCoordenadasChanging(value);
					this.SendPropertyChanging();
					this._Coordenadas = value;
					this.SendPropertyChanged("Coordenadas");
					this.OnCoordenadasChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Division", DbType="Binary(2) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Division
		{
			get
			{
				return this._Division;
			}
			set
			{
				if ((this._Division != value))
				{
					this.OnDivisionChanging(value);
					this.SendPropertyChanging();
					this._Division = value;
					this.SendPropertyChanged("Division");
					this.OnDivisionChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.USUARIOS")]
	public partial class USUARIO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nombre;
		
		private string _Apellido;
		
		private string _Usuario1;
		
		private int _Edad;
		
		private string _Puesto;
		
		private string _Correo;
		
		private int _Telefono;
		
		private System.Data.Linq.Binary _Estatus;
		
		private int _idPrision;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnApellidoChanging(string value);
    partial void OnApellidoChanged();
    partial void OnUsuario1Changing(string value);
    partial void OnUsuario1Changed();
    partial void OnEdadChanging(int value);
    partial void OnEdadChanged();
    partial void OnPuestoChanging(string value);
    partial void OnPuestoChanged();
    partial void OnCorreoChanging(string value);
    partial void OnCorreoChanged();
    partial void OnTelefonoChanging(int value);
    partial void OnTelefonoChanged();
    partial void OnEstatusChanging(System.Data.Linq.Binary value);
    partial void OnEstatusChanged();
    partial void OnidPrisionChanging(int value);
    partial void OnidPrisionChanged();
    #endregion
		
		public USUARIO()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(45) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellido", DbType="NVarChar(45) NOT NULL", CanBeNull=false)]
		public string Apellido
		{
			get
			{
				return this._Apellido;
			}
			set
			{
				if ((this._Apellido != value))
				{
					this.OnApellidoChanging(value);
					this.SendPropertyChanging();
					this._Apellido = value;
					this.SendPropertyChanged("Apellido");
					this.OnApellidoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Usuario", Storage="_Usuario1", DbType="NVarChar(45) NOT NULL", CanBeNull=false)]
		public string Usuario1
		{
			get
			{
				return this._Usuario1;
			}
			set
			{
				if ((this._Usuario1 != value))
				{
					this.OnUsuario1Changing(value);
					this.SendPropertyChanging();
					this._Usuario1 = value;
					this.SendPropertyChanged("Usuario1");
					this.OnUsuario1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Edad", DbType="Int NOT NULL")]
		public int Edad
		{
			get
			{
				return this._Edad;
			}
			set
			{
				if ((this._Edad != value))
				{
					this.OnEdadChanging(value);
					this.SendPropertyChanging();
					this._Edad = value;
					this.SendPropertyChanged("Edad");
					this.OnEdadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Puesto", DbType="NVarChar(35) NOT NULL", CanBeNull=false)]
		public string Puesto
		{
			get
			{
				return this._Puesto;
			}
			set
			{
				if ((this._Puesto != value))
				{
					this.OnPuestoChanging(value);
					this.SendPropertyChanging();
					this._Puesto = value;
					this.SendPropertyChanged("Puesto");
					this.OnPuestoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Correo", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Correo
		{
			get
			{
				return this._Correo;
			}
			set
			{
				if ((this._Correo != value))
				{
					this.OnCorreoChanging(value);
					this.SendPropertyChanging();
					this._Correo = value;
					this.SendPropertyChanged("Correo");
					this.OnCorreoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefono", DbType="Int NOT NULL")]
		public int Telefono
		{
			get
			{
				return this._Telefono;
			}
			set
			{
				if ((this._Telefono != value))
				{
					this.OnTelefonoChanging(value);
					this.SendPropertyChanging();
					this._Telefono = value;
					this.SendPropertyChanged("Telefono");
					this.OnTelefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Estatus", DbType="Binary(1) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Estatus
		{
			get
			{
				return this._Estatus;
			}
			set
			{
				if ((this._Estatus != value))
				{
					this.OnEstatusChanging(value);
					this.SendPropertyChanging();
					this._Estatus = value;
					this.SendPropertyChanged("Estatus");
					this.OnEstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idPrision", DbType="Int NOT NULL")]
		public int idPrision
		{
			get
			{
				return this._idPrision;
			}
			set
			{
				if ((this._idPrision != value))
				{
					this.OnidPrisionChanging(value);
					this.SendPropertyChanging();
					this._idPrision = value;
					this.SendPropertyChanged("idPrision");
					this.OnidPrisionChanged();
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
