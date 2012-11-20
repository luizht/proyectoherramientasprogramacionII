﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.225
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nomina.movil
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
	
	
	public partial class BaseDatosDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertPersona(Persona instance);
    partial void UpdatePersona(Persona instance);
    partial void DeletePersona(Persona instance);
    partial void InsertTotalEmpleado(TotalEmpleado instance);
    partial void UpdateTotalEmpleado(TotalEmpleado instance);
    partial void DeleteTotalEmpleado(TotalEmpleado instance);
    #endregion
		
		public BaseDatosDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BaseDatosDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Persona> Persona
		{
			get
			{
				return this.GetTable<Persona>();
			}
		}
		
		public System.Data.Linq.Table<TotalEmpleado> TotalEmpleado
		{
			get
			{
				return this.GetTable<TotalEmpleado>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class Persona : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Cedula;
		
		private string _Nombre;
		
		private int _Salario;
		
		private int _VlrDia;
		
		private int _VlrHora;
		
		private string _IdTipoTrabajador;
		
		private EntitySet<TotalEmpleado> _TotalEmpleado;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCedulaChanging(string value);
    partial void OnCedulaChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnSalarioChanging(int value);
    partial void OnSalarioChanged();
    partial void OnVlrDiaChanging(int value);
    partial void OnVlrDiaChanged();
    partial void OnVlrHoraChanging(int value);
    partial void OnVlrHoraChanged();
    partial void OnIdTipoTrabajadorChanging(string value);
    partial void OnIdTipoTrabajadorChanged();
    #endregion
		
		public Persona()
		{
			this._TotalEmpleado = new EntitySet<TotalEmpleado>(new Action<TotalEmpleado>(this.attach_TotalEmpleado), new Action<TotalEmpleado>(this.detach_TotalEmpleado));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cedula", CanBeNull=false, IsPrimaryKey=true)]
		public string Cedula
		{
			get
			{
				return this._Cedula;
			}
			set
			{
				if ((this._Cedula != value))
				{
					this.OnCedulaChanging(value);
					this.SendPropertyChanging();
					this._Cedula = value;
					this.SendPropertyChanged("Cedula");
					this.OnCedulaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salario")]
		public int Salario
		{
			get
			{
				return this._Salario;
			}
			set
			{
				if ((this._Salario != value))
				{
					this.OnSalarioChanging(value);
					this.SendPropertyChanging();
					this._Salario = value;
					this.SendPropertyChanged("Salario");
					this.OnSalarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VlrDia")]
		public int VlrDia
		{
			get
			{
				return this._VlrDia;
			}
			set
			{
				if ((this._VlrDia != value))
				{
					this.OnVlrDiaChanging(value);
					this.SendPropertyChanging();
					this._VlrDia = value;
					this.SendPropertyChanged("VlrDia");
					this.OnVlrDiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VlrHora")]
		public int VlrHora
		{
			get
			{
				return this._VlrHora;
			}
			set
			{
				if ((this._VlrHora != value))
				{
					this.OnVlrHoraChanging(value);
					this.SendPropertyChanging();
					this._VlrHora = value;
					this.SendPropertyChanged("VlrHora");
					this.OnVlrHoraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTipoTrabajador", CanBeNull=false)]
		public string IdTipoTrabajador
		{
			get
			{
				return this._IdTipoTrabajador;
			}
			set
			{
				if ((this._IdTipoTrabajador != value))
				{
					this.OnIdTipoTrabajadorChanging(value);
					this.SendPropertyChanging();
					this._IdTipoTrabajador = value;
					this.SendPropertyChanged("IdTipoTrabajador");
					this.OnIdTipoTrabajadorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Persona_TotalEmpleado", Storage="_TotalEmpleado", ThisKey="Cedula", OtherKey="Cedula")]
		public EntitySet<TotalEmpleado> TotalEmpleado
		{
			get
			{
				return this._TotalEmpleado;
			}
			set
			{
				this._TotalEmpleado.Assign(value);
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
		
		private void attach_TotalEmpleado(TotalEmpleado entity)
		{
			this.SendPropertyChanging();
			entity.Persona = this;
		}
		
		private void detach_TotalEmpleado(TotalEmpleado entity)
		{
			this.SendPropertyChanging();
			entity.Persona = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class TotalEmpleado : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Vlrempleado;
		
		private string _TipodeHora;
		
		private int _Total;
		
		private int _Cantidad;
		
		private string _Cedula;
		
		private EntityRef<Persona> _Persona;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnVlrempleadoChanging(string value);
    partial void OnVlrempleadoChanged();
    partial void OnTipodeHoraChanging(string value);
    partial void OnTipodeHoraChanged();
    partial void OnTotalChanging(int value);
    partial void OnTotalChanged();
    partial void OnCantidadChanging(int value);
    partial void OnCantidadChanged();
    partial void OnCedulaChanging(string value);
    partial void OnCedulaChanged();
    #endregion
		
		public TotalEmpleado()
		{
			this._Persona = default(EntityRef<Persona>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vlrempleado", CanBeNull=false, IsPrimaryKey=true)]
		public string Vlrempleado
		{
			get
			{
				return this._Vlrempleado;
			}
			set
			{
				if ((this._Vlrempleado != value))
				{
					this.OnVlrempleadoChanging(value);
					this.SendPropertyChanging();
					this._Vlrempleado = value;
					this.SendPropertyChanged("Vlrempleado");
					this.OnVlrempleadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TipodeHora", CanBeNull=false)]
		public string TipodeHora
		{
			get
			{
				return this._TipodeHora;
			}
			set
			{
				if ((this._TipodeHora != value))
				{
					this.OnTipodeHoraChanging(value);
					this.SendPropertyChanging();
					this._TipodeHora = value;
					this.SendPropertyChanged("TipodeHora");
					this.OnTipodeHoraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total")]
		public int Total
		{
			get
			{
				return this._Total;
			}
			set
			{
				if ((this._Total != value))
				{
					this.OnTotalChanging(value);
					this.SendPropertyChanging();
					this._Total = value;
					this.SendPropertyChanged("Total");
					this.OnTotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cantidad")]
		public int Cantidad
		{
			get
			{
				return this._Cantidad;
			}
			set
			{
				if ((this._Cantidad != value))
				{
					this.OnCantidadChanging(value);
					this.SendPropertyChanging();
					this._Cantidad = value;
					this.SendPropertyChanged("Cantidad");
					this.OnCantidadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cedula", CanBeNull=false)]
		public string Cedula
		{
			get
			{
				return this._Cedula;
			}
			set
			{
				if ((this._Cedula != value))
				{
					if (this._Persona.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCedulaChanging(value);
					this.SendPropertyChanging();
					this._Cedula = value;
					this.SendPropertyChanged("Cedula");
					this.OnCedulaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Persona_TotalEmpleado", Storage="_Persona", ThisKey="Cedula", OtherKey="Cedula", IsForeignKey=true)]
		public Persona Persona
		{
			get
			{
				return this._Persona.Entity;
			}
			set
			{
				Persona previousValue = this._Persona.Entity;
				if (((previousValue != value) 
							|| (this._Persona.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Persona.Entity = null;
						previousValue.TotalEmpleado.Remove(this);
					}
					this._Persona.Entity = value;
					if ((value != null))
					{
						value.TotalEmpleado.Add(this);
						this._Cedula = value.Cedula;
					}
					else
					{
						this._Cedula = default(string);
					}
					this.SendPropertyChanged("Persona");
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