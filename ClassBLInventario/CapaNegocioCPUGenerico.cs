﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;
using System.Data.SqlClient;
using ClassAccesoDatosSQL22;
using ClassCapaEntidad;

namespace ClassBLInventario
{
    public class CapaNegocioCPUGenerico
    {
        private AccesoSQL operacion = null;

        public CapaNegocioCPUGenerico(string cadConx)
        {
            operacion = new AccesoSQL(cadConx);
        }

        public Boolean InsertarCPUGenerico(EntidadCPUGenerico nuevo, ref string m)
        {
            string sentencia = "insert into CPU_Generico(f_Tcpu, f_MarcaCpu, Modelo, Descripcion," +
                "f_tipoRam, id_Gabinete, fkimg) values (@f_Cp, @f_maCp, @mod, @des, @f_tipR, @id_G, @fim);";
            SqlParameter[] coleccion = new SqlParameter[]
            {
                new SqlParameter("f_Cp",SqlDbType.Int),
                new SqlParameter("f_maCp",SqlDbType.Int),
                new SqlParameter("mod",SqlDbType.VarChar,20),
                new SqlParameter("des",SqlDbType.VarChar,40),
                new SqlParameter("f_tipR",SqlDbType.Int),
                new SqlParameter("id_G",SqlDbType.Int),
                new SqlParameter("fim",SqlDbType.Int)
            };

            coleccion[0].Value = nuevo.f_Tcpu;
            coleccion[1].Value = nuevo.f_MarcaCpu;
            coleccion[2].Value = nuevo.Modelo;
            coleccion[3].Value = nuevo.Descripcion;
            coleccion[4].Value = nuevo.f_tipoRam;
            coleccion[5].Value = nuevo.id_Gabinete;
            coleccion[6].Value = nuevo.fkimg;
            Boolean salida = false;
            salida = operacion.ModificarBDMasSeguro(sentencia, operacion.AbrirConexion(ref m), ref m, coleccion);
            return salida;
        }

        public Boolean ModificarCPUGenerico(EntidadCPUGenerico nuevo, ref string m)
        {
            string sentencia = "UPDATE CPU_Generico set f_Tcpu = @f_Cp, f_MarcaCpu = @f_maCp," +
                "Modelo = @mod,Descripcion = @des,f_tipoRam = @f_tipR, id_Gabinete = @id_G, fkimg = @fim WHERE id_CPU =@id";
            SqlParameter[] coleccion = new SqlParameter[]
            {
                new SqlParameter("id",SqlDbType.Int),
                new SqlParameter("f_Cp",SqlDbType.Int),
                new SqlParameter("f_maCp",SqlDbType.Int),
                new SqlParameter("mod",SqlDbType.VarChar,20),
                new SqlParameter("des",SqlDbType.VarChar,40),
                new SqlParameter("f_tipR",SqlDbType.Int),
                new SqlParameter("id_G",SqlDbType.Int),
                new SqlParameter("fim",SqlDbType.Int)
            };
            coleccion[0].Value = nuevo.id_CPU;
            coleccion[1].Value = nuevo.f_Tcpu;
            coleccion[2].Value = nuevo.f_MarcaCpu;
            coleccion[3].Value = nuevo.Modelo;
            coleccion[4].Value = nuevo.Descripcion;
            coleccion[5].Value = nuevo.f_tipoRam;
            coleccion[6].Value = nuevo.id_Gabinete;
            coleccion[6].Value = nuevo.fkimg;
            Boolean salida = false;
            salida = operacion.ModificarBDMasSeguro(sentencia, operacion.AbrirConexion(ref m), ref m, coleccion);
            return salida;
        }

        public List<EntidadCPUGenerico> DevuelveInfoCPUGenerico(ref string mensaje)
        {
            List<EntidadCPUGenerico> lista = new List<EntidadCPUGenerico>();
            SqlDataReader atrapa = null;
            SqlConnection cn = null;
            cn = operacion.AbrirConexion(ref mensaje);
            string consulta = "select * from CPU_Generico";
            atrapa = operacion.ConsultaDR(consulta, cn, ref mensaje);
            if (atrapa != null)
            {
                while (atrapa.Read())
                {
                    lista.Add(new EntidadCPUGenerico()
                    {

                        f_Tcpu = Convert.ToInt16(atrapa[1]),
                        f_MarcaCpu = Convert.ToInt16(atrapa[2]),
                        Modelo = atrapa[3].ToString(),
                        Descripcion = atrapa[4].ToString(),
                        f_tipoRam = Convert.ToInt16(atrapa[5]),
                        id_Gabinete = Convert.ToInt16(atrapa[6]),
                        fkimg = Convert.ToInt16(atrapa[7])
                    }
                    ); 

                }
            }
            cn.Close();
            cn.Dispose();
            return lista;
        }

        public DataTable ObtenTodCPUGenerico(ref string mensaje)
        {
            string consulta = "Select * from CPU_Generico";
            DataSet obtener = null;
            DataTable salida = null;
            obtener = operacion.ConsultaDataSet(consulta, operacion.AbrirConexion(ref mensaje), ref mensaje);
            if (obtener != null)
            {
                salida = obtener.Tables[0];
            }
            return salida;
        }

        public Boolean EliminarCPUGenerico(EntidadCPUGenerico nuevo, ref string m)
        {
            string sentencia = "DELETE FROM CPU_Generico WHERE Modelo = @mod";
            SqlParameter[] coleccion = new SqlParameter[]
            {
                new SqlParameter("mod",SqlDbType.VarChar,20),
            };
            coleccion[0].Value = nuevo.Modelo;
            Boolean salida = false;
            salida = operacion.ModificarBDMasSeguro(sentencia, operacion.AbrirConexion(ref m), ref m, coleccion);
            return salida;
        }
    }
}