﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Conexion;

namespace Entidades
{
    public class clsDirecciones
    {
        private clsManejador M = new clsManejador();
        int Mid;
        int Mid2;
        int Mvalor;
        string Mdescripcion;
        string Mdireccion;
        Boolean Mestado;
        string Mcampo;
        string Mtabla;

        public int Id
        {
            get { return Mid; }
            set { Mid = value; }
        }
        public int Id2
        {
            get { return Mid2; }
            set { Mid2 = value; }
        }
        public int Valor
        {
            get { return Mvalor; }
            set { Mvalor = value; }
        }
        //public int Idregion
        //{
        //    get { return Midregion; }
        //    set { Midregion = value; }
        //}
        //public int Idciudad
        //{
        //    get { return Midciudad; }
        //    set { Midciudad = value; }
        //}
        //public int Idbarrio
        //{
        //    get { return Midbarrio; }
        //    set { Midbarrio = value; }
        //}
        public string Descripcion
        {
            get { return Mdescripcion; }
            set { Mdescripcion = value; }
        }
        public string Campo
        {
            get { return Mcampo; }
            set { Mcampo = value; }
        }
        public string Tabla
        {
            get { return Mtabla; }
            set { Mtabla = value; }
        }
        public Boolean Estado
        {
            get { return Mestado; }
            set { Mestado = value; }
        }
        //Registrar

        public string Registrar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@descripcion", Mdescripcion));
            lst.Add(new clsParametros("@id", Mid));
            lst.Add(new clsParametros("@id2", Mid2));
            lst.Add(new clsParametros("@valor", Mvalor));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_prcb", ref lst);
            mensaje = lst[4].Valor.ToString();
            return mensaje;
        }

        public DataTable Listar(Boolean objEstado)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@valor", Mvalor));
            lst.Add(new clsParametros("@estado", objEstado));
            lst.Add(new clsParametros("@id", Mid));
            return dt = M.Listado("listado_prcb", lst);

        }
        public string Activar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@id", Mid));
            lst.Add(new clsParametros("@valor", Mestado));
            lst.Add(new clsParametros("@table", Mtabla));
            lst.Add(new clsParametros("@campo", Mcampo));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actdes_entidades", ref lst);
            mensaje = lst[4].Valor.ToString();
            return mensaje;
        }


        //public string ActualizarAlmacen()
        //{
        //    string mensaje = "";
        //    List<clsParametros> lst = new List<clsParametros>();
        //    lst.Add(new clsParametros("@idalmacen", Midalmacen));
        //    lst.Add(new clsParametros("@descripcion", Mdescripcion));
        //    lst.Add(new clsParametros("@encargado", Mencargado));
        //    lst.Add(new clsParametros("@direccion", Mdireccion));
        //    lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
        //    M.EjecutarSP("actualizar_almacen", ref lst);
        //    mensaje = lst[4].Valor.ToString();
        //    return mensaje;
        //}
    }
}
