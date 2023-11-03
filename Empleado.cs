using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace pryReportesEmpresita
{
    public class Empleado
    {
        public DataTable GetData() 
        {
            string consulta = @"SELECT E.EmpleadoID, E.Nombre, S.Nombre as Sector FROM Empleados E
                                INNER JOIN Sectores S ON E.SectorID = S.SectorID";
            string cadena = "Data Source = ./Empresita.db";
            DataTable tabla = new DataTable();
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter(consulta, cadena);
            adaptador.Fill(tabla);

            return tabla;
        }
    }
}
