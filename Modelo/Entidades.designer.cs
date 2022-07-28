﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelo
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="GoalBus")]
	public partial class EntidadesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertCODIGO_TIPO_EVENTO(CODIGO_TIPO_EVENTO instance);
    partial void UpdateCODIGO_TIPO_EVENTO(CODIGO_TIPO_EVENTO instance);
    partial void DeleteCODIGO_TIPO_EVENTO(CODIGO_TIPO_EVENTO instance);
    partial void InsertCUADROS_SOLUCIONES_DET(CUADROS_SOLUCIONES_DET instance);
    partial void UpdateCUADROS_SOLUCIONES_DET(CUADROS_SOLUCIONES_DET instance);
    partial void DeleteCUADROS_SOLUCIONES_DET(CUADROS_SOLUCIONES_DET instance);
    #endregion
		
		public EntidadesDataContext() : 
				base(global::Modelo.Properties.Settings.Default.GoalBusConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public EntidadesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EntidadesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EntidadesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EntidadesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CODIGO_TIPO_EVENTO> CODIGO_TIPO_EVENTO
		{
			get
			{
				return this.GetTable<CODIGO_TIPO_EVENTO>();
			}
		}
		
		public System.Data.Linq.Table<CUADROS_SOLUCIONES_DET> CUADROS_SOLUCIONES_DET
		{
			get
			{
				return this.GetTable<CUADROS_SOLUCIONES_DET>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CODIGO_TIPO_EVENTO")]
	public partial class CODIGO_TIPO_EVENTO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CODIGO_TIPO_EVENTO1;
		
		private string _DESCRIPCION;
		
		private string _DESCRIP_CORTA;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCODIGO_TIPO_EVENTO1Changing(int value);
    partial void OnCODIGO_TIPO_EVENTO1Changed();
    partial void OnDESCRIPCIONChanging(string value);
    partial void OnDESCRIPCIONChanged();
    partial void OnDESCRIP_CORTAChanging(string value);
    partial void OnDESCRIP_CORTAChanged();
    #endregion
		
		public CODIGO_TIPO_EVENTO()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="CODIGO_TIPO_EVENTO", Storage="_CODIGO_TIPO_EVENTO1", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CODIGO_TIPO_EVENTO1
		{
			get
			{
				return this._CODIGO_TIPO_EVENTO1;
			}
			set
			{
				if ((this._CODIGO_TIPO_EVENTO1 != value))
				{
					this.OnCODIGO_TIPO_EVENTO1Changing(value);
					this.SendPropertyChanging();
					this._CODIGO_TIPO_EVENTO1 = value;
					this.SendPropertyChanged("CODIGO_TIPO_EVENTO1");
					this.OnCODIGO_TIPO_EVENTO1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DESCRIPCION", DbType="VarChar(60)")]
		public string DESCRIPCION
		{
			get
			{
				return this._DESCRIPCION;
			}
			set
			{
				if ((this._DESCRIPCION != value))
				{
					this.OnDESCRIPCIONChanging(value);
					this.SendPropertyChanging();
					this._DESCRIPCION = value;
					this.SendPropertyChanged("DESCRIPCION");
					this.OnDESCRIPCIONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DESCRIP_CORTA", DbType="VarChar(4)")]
		public string DESCRIP_CORTA
		{
			get
			{
				return this._DESCRIP_CORTA;
			}
			set
			{
				if ((this._DESCRIP_CORTA != value))
				{
					this.OnDESCRIP_CORTAChanging(value);
					this.SendPropertyChanging();
					this._DESCRIP_CORTA = value;
					this.SendPropertyChanged("DESCRIP_CORTA");
					this.OnDESCRIP_CORTAChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CUADROS_SOLUCIONES_DET")]
	public partial class CUADROS_SOLUCIONES_DET : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CODIGO_CUADRO;
		
		private string _CODIGO_TRAYECTO;
		
		private int _NUMERO_SOLUCION;
		
		private int _CODIGO_TIPO_EVENTO;
		
		private int _EVENTO;
		
		private System.Nullable<int> _PARADA_ORIGEN;
		
		private System.Nullable<int> _PARADA_DESTINO;
		
		private System.Nullable<int> _COCHE_LOGICO;
		
		private System.Nullable<int> _TURNO_SERVICIO;
		
		private string _HORA_INICIO;
		
		private string _HORA_FIN;
		
		private System.Nullable<short> _SENTIDO;
		
		private System.Nullable<int> _KMS;
		
		private System.Nullable<int> _CODIGO_TIPO_BUS;
		
		private System.Nullable<int> _COCHE_INFORMES;
		
		private string _DESCRIP_CAMINO;
		
		private System.Nullable<int> _BUS_EMT;
		
		private string _DURACION;
		
		private string _FRECUENCIA;
		
		private System.Nullable<int> _VIAJE_ACUM;
		
		private System.Nullable<int> _TRAMO;
		
		private System.Nullable<int> _CODIGO_TIPO_TURNO;
		
		private string _DESCRIPCION_EVENTO;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCODIGO_CUADROChanging(int value);
    partial void OnCODIGO_CUADROChanged();
    partial void OnCODIGO_TRAYECTOChanging(string value);
    partial void OnCODIGO_TRAYECTOChanged();
    partial void OnNUMERO_SOLUCIONChanging(int value);
    partial void OnNUMERO_SOLUCIONChanged();
    partial void OnCODIGO_TIPO_EVENTOChanging(int value);
    partial void OnCODIGO_TIPO_EVENTOChanged();
    partial void OnEVENTOChanging(int value);
    partial void OnEVENTOChanged();
    partial void OnPARADA_ORIGENChanging(System.Nullable<int> value);
    partial void OnPARADA_ORIGENChanged();
    partial void OnPARADA_DESTINOChanging(System.Nullable<int> value);
    partial void OnPARADA_DESTINOChanged();
    partial void OnCOCHE_LOGICOChanging(System.Nullable<int> value);
    partial void OnCOCHE_LOGICOChanged();
    partial void OnTURNO_SERVICIOChanging(System.Nullable<int> value);
    partial void OnTURNO_SERVICIOChanged();
    partial void OnHORA_INICIOChanging(string value);
    partial void OnHORA_INICIOChanged();
    partial void OnHORA_FINChanging(string value);
    partial void OnHORA_FINChanged();
    partial void OnSENTIDOChanging(System.Nullable<short> value);
    partial void OnSENTIDOChanged();
    partial void OnKMSChanging(System.Nullable<int> value);
    partial void OnKMSChanged();
    partial void OnCODIGO_TIPO_BUSChanging(System.Nullable<int> value);
    partial void OnCODIGO_TIPO_BUSChanged();
    partial void OnCOCHE_INFORMESChanging(System.Nullable<int> value);
    partial void OnCOCHE_INFORMESChanged();
    partial void OnDESCRIP_CAMINOChanging(string value);
    partial void OnDESCRIP_CAMINOChanged();
    partial void OnBUS_EMTChanging(System.Nullable<int> value);
    partial void OnBUS_EMTChanged();
    partial void OnDURACIONChanging(string value);
    partial void OnDURACIONChanged();
    partial void OnFRECUENCIAChanging(string value);
    partial void OnFRECUENCIAChanged();
    partial void OnVIAJE_ACUMChanging(System.Nullable<int> value);
    partial void OnVIAJE_ACUMChanged();
    partial void OnTRAMOChanging(System.Nullable<int> value);
    partial void OnTRAMOChanged();
    partial void OnCODIGO_TIPO_TURNOChanging(System.Nullable<int> value);
    partial void OnCODIGO_TIPO_TURNOChanged();
    partial void OnDESCRIPCION_EVENTOChanging(string value);
    partial void OnDESCRIPCION_EVENTOChanged();
    #endregion
		
		public CUADROS_SOLUCIONES_DET()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODIGO_CUADRO", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CODIGO_CUADRO
		{
			get
			{
				return this._CODIGO_CUADRO;
			}
			set
			{
				if ((this._CODIGO_CUADRO != value))
				{
					this.OnCODIGO_CUADROChanging(value);
					this.SendPropertyChanging();
					this._CODIGO_CUADRO = value;
					this.SendPropertyChanged("CODIGO_CUADRO");
					this.OnCODIGO_CUADROChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODIGO_TRAYECTO", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CODIGO_TRAYECTO
		{
			get
			{
				return this._CODIGO_TRAYECTO;
			}
			set
			{
				if ((this._CODIGO_TRAYECTO != value))
				{
					this.OnCODIGO_TRAYECTOChanging(value);
					this.SendPropertyChanging();
					this._CODIGO_TRAYECTO = value;
					this.SendPropertyChanged("CODIGO_TRAYECTO");
					this.OnCODIGO_TRAYECTOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NUMERO_SOLUCION", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int NUMERO_SOLUCION
		{
			get
			{
				return this._NUMERO_SOLUCION;
			}
			set
			{
				if ((this._NUMERO_SOLUCION != value))
				{
					this.OnNUMERO_SOLUCIONChanging(value);
					this.SendPropertyChanging();
					this._NUMERO_SOLUCION = value;
					this.SendPropertyChanged("NUMERO_SOLUCION");
					this.OnNUMERO_SOLUCIONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODIGO_TIPO_EVENTO", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CODIGO_TIPO_EVENTO
		{
			get
			{
				return this._CODIGO_TIPO_EVENTO;
			}
			set
			{
				if ((this._CODIGO_TIPO_EVENTO != value))
				{
					this.OnCODIGO_TIPO_EVENTOChanging(value);
					this.SendPropertyChanging();
					this._CODIGO_TIPO_EVENTO = value;
					this.SendPropertyChanged("CODIGO_TIPO_EVENTO");
					this.OnCODIGO_TIPO_EVENTOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EVENTO", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int EVENTO
		{
			get
			{
				return this._EVENTO;
			}
			set
			{
				if ((this._EVENTO != value))
				{
					this.OnEVENTOChanging(value);
					this.SendPropertyChanging();
					this._EVENTO = value;
					this.SendPropertyChanged("EVENTO");
					this.OnEVENTOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PARADA_ORIGEN", DbType="Int")]
		public System.Nullable<int> PARADA_ORIGEN
		{
			get
			{
				return this._PARADA_ORIGEN;
			}
			set
			{
				if ((this._PARADA_ORIGEN != value))
				{
					this.OnPARADA_ORIGENChanging(value);
					this.SendPropertyChanging();
					this._PARADA_ORIGEN = value;
					this.SendPropertyChanged("PARADA_ORIGEN");
					this.OnPARADA_ORIGENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PARADA_DESTINO", DbType="Int")]
		public System.Nullable<int> PARADA_DESTINO
		{
			get
			{
				return this._PARADA_DESTINO;
			}
			set
			{
				if ((this._PARADA_DESTINO != value))
				{
					this.OnPARADA_DESTINOChanging(value);
					this.SendPropertyChanging();
					this._PARADA_DESTINO = value;
					this.SendPropertyChanged("PARADA_DESTINO");
					this.OnPARADA_DESTINOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COCHE_LOGICO", DbType="Int")]
		public System.Nullable<int> COCHE_LOGICO
		{
			get
			{
				return this._COCHE_LOGICO;
			}
			set
			{
				if ((this._COCHE_LOGICO != value))
				{
					this.OnCOCHE_LOGICOChanging(value);
					this.SendPropertyChanging();
					this._COCHE_LOGICO = value;
					this.SendPropertyChanged("COCHE_LOGICO");
					this.OnCOCHE_LOGICOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TURNO_SERVICIO", DbType="Int")]
		public System.Nullable<int> TURNO_SERVICIO
		{
			get
			{
				return this._TURNO_SERVICIO;
			}
			set
			{
				if ((this._TURNO_SERVICIO != value))
				{
					this.OnTURNO_SERVICIOChanging(value);
					this.SendPropertyChanging();
					this._TURNO_SERVICIO = value;
					this.SendPropertyChanged("TURNO_SERVICIO");
					this.OnTURNO_SERVICIOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HORA_INICIO", DbType="VarChar(9)")]
		public string HORA_INICIO
		{
			get
			{
				return this._HORA_INICIO;
			}
			set
			{
				if ((this._HORA_INICIO != value))
				{
					this.OnHORA_INICIOChanging(value);
					this.SendPropertyChanging();
					this._HORA_INICIO = value;
					this.SendPropertyChanged("HORA_INICIO");
					this.OnHORA_INICIOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HORA_FIN", DbType="VarChar(9)")]
		public string HORA_FIN
		{
			get
			{
				return this._HORA_FIN;
			}
			set
			{
				if ((this._HORA_FIN != value))
				{
					this.OnHORA_FINChanging(value);
					this.SendPropertyChanging();
					this._HORA_FIN = value;
					this.SendPropertyChanged("HORA_FIN");
					this.OnHORA_FINChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SENTIDO", DbType="SmallInt")]
		public System.Nullable<short> SENTIDO
		{
			get
			{
				return this._SENTIDO;
			}
			set
			{
				if ((this._SENTIDO != value))
				{
					this.OnSENTIDOChanging(value);
					this.SendPropertyChanging();
					this._SENTIDO = value;
					this.SendPropertyChanged("SENTIDO");
					this.OnSENTIDOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KMS", DbType="Int")]
		public System.Nullable<int> KMS
		{
			get
			{
				return this._KMS;
			}
			set
			{
				if ((this._KMS != value))
				{
					this.OnKMSChanging(value);
					this.SendPropertyChanging();
					this._KMS = value;
					this.SendPropertyChanged("KMS");
					this.OnKMSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODIGO_TIPO_BUS", DbType="Int")]
		public System.Nullable<int> CODIGO_TIPO_BUS
		{
			get
			{
				return this._CODIGO_TIPO_BUS;
			}
			set
			{
				if ((this._CODIGO_TIPO_BUS != value))
				{
					this.OnCODIGO_TIPO_BUSChanging(value);
					this.SendPropertyChanging();
					this._CODIGO_TIPO_BUS = value;
					this.SendPropertyChanged("CODIGO_TIPO_BUS");
					this.OnCODIGO_TIPO_BUSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COCHE_INFORMES", DbType="Int")]
		public System.Nullable<int> COCHE_INFORMES
		{
			get
			{
				return this._COCHE_INFORMES;
			}
			set
			{
				if ((this._COCHE_INFORMES != value))
				{
					this.OnCOCHE_INFORMESChanging(value);
					this.SendPropertyChanging();
					this._COCHE_INFORMES = value;
					this.SendPropertyChanged("COCHE_INFORMES");
					this.OnCOCHE_INFORMESChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DESCRIP_CAMINO", DbType="VarChar(200)")]
		public string DESCRIP_CAMINO
		{
			get
			{
				return this._DESCRIP_CAMINO;
			}
			set
			{
				if ((this._DESCRIP_CAMINO != value))
				{
					this.OnDESCRIP_CAMINOChanging(value);
					this.SendPropertyChanging();
					this._DESCRIP_CAMINO = value;
					this.SendPropertyChanged("DESCRIP_CAMINO");
					this.OnDESCRIP_CAMINOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BUS_EMT", DbType="Int")]
		public System.Nullable<int> BUS_EMT
		{
			get
			{
				return this._BUS_EMT;
			}
			set
			{
				if ((this._BUS_EMT != value))
				{
					this.OnBUS_EMTChanging(value);
					this.SendPropertyChanging();
					this._BUS_EMT = value;
					this.SendPropertyChanged("BUS_EMT");
					this.OnBUS_EMTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DURACION", DbType="VarChar(9)")]
		public string DURACION
		{
			get
			{
				return this._DURACION;
			}
			set
			{
				if ((this._DURACION != value))
				{
					this.OnDURACIONChanging(value);
					this.SendPropertyChanging();
					this._DURACION = value;
					this.SendPropertyChanged("DURACION");
					this.OnDURACIONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FRECUENCIA", DbType="VarChar(9)")]
		public string FRECUENCIA
		{
			get
			{
				return this._FRECUENCIA;
			}
			set
			{
				if ((this._FRECUENCIA != value))
				{
					this.OnFRECUENCIAChanging(value);
					this.SendPropertyChanging();
					this._FRECUENCIA = value;
					this.SendPropertyChanged("FRECUENCIA");
					this.OnFRECUENCIAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VIAJE_ACUM", DbType="Int")]
		public System.Nullable<int> VIAJE_ACUM
		{
			get
			{
				return this._VIAJE_ACUM;
			}
			set
			{
				if ((this._VIAJE_ACUM != value))
				{
					this.OnVIAJE_ACUMChanging(value);
					this.SendPropertyChanging();
					this._VIAJE_ACUM = value;
					this.SendPropertyChanged("VIAJE_ACUM");
					this.OnVIAJE_ACUMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TRAMO", DbType="Int")]
		public System.Nullable<int> TRAMO
		{
			get
			{
				return this._TRAMO;
			}
			set
			{
				if ((this._TRAMO != value))
				{
					this.OnTRAMOChanging(value);
					this.SendPropertyChanging();
					this._TRAMO = value;
					this.SendPropertyChanged("TRAMO");
					this.OnTRAMOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CODIGO_TIPO_TURNO", DbType="Int")]
		public System.Nullable<int> CODIGO_TIPO_TURNO
		{
			get
			{
				return this._CODIGO_TIPO_TURNO;
			}
			set
			{
				if ((this._CODIGO_TIPO_TURNO != value))
				{
					this.OnCODIGO_TIPO_TURNOChanging(value);
					this.SendPropertyChanging();
					this._CODIGO_TIPO_TURNO = value;
					this.SendPropertyChanged("CODIGO_TIPO_TURNO");
					this.OnCODIGO_TIPO_TURNOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DESCRIPCION_EVENTO", DbType="VarChar(50)")]
		public string DESCRIPCION_EVENTO
		{
			get
			{
				return this._DESCRIPCION_EVENTO;
			}
			set
			{
				if ((this._DESCRIPCION_EVENTO != value))
				{
					this.OnDESCRIPCION_EVENTOChanging(value);
					this.SendPropertyChanging();
					this._DESCRIPCION_EVENTO = value;
					this.SendPropertyChanged("DESCRIPCION_EVENTO");
					this.OnDESCRIPCION_EVENTOChanged();
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