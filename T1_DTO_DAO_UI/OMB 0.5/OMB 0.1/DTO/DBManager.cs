using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace OMB
{
    class DBManager
    {
        private static MySqlConnection Con { get; set; }

        public DBManager()
        {
            Con = new MySqlConnection("server=localhost;" +
                "database=gym;" +
                "Uid=root;" +
                "pwd=Cristian123;SslMode=none;");
        }
        public DBManager(string database,string pwd)
        {
            Con = new MySqlConnection($"server=localhost;" +
                $"database={database};" +
                $"Uid=root;pwd={pwd};" +
                $"SslMode=none;");
        }

        #region DEFAULT_CONECTION_FUNCTIONS
        //private static MySqlConnection Conectar()
        //{

        //    MySqlConnection Conectar = new MySqlConnection
        //    ("server=localhost;database=gym;Uid=root;pwd=Cristian123;SslMode=none;");
        //    Conectar.Open();
        //    return Conectar;
        //}
        private static MySqlCommand Command(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, Con);
            cmd.Connection = Con;
            cmd.CommandText = query;
            return cmd;
        }
        #endregion

        public DataSet Table(string query)
        {
            Con.Open();
            MySqlDataAdapter adp = new MySqlDataAdapter(Command(query));
            DataSet Dset = new DataSet();
            adp.Fill(Dset, "Data");
            Con.Close();
            return Dset;
        }

        public void QueryAction(string query)
        {
            Con.Open();
            MySqlCommand cmd = Command(query);
            cmd.ExecuteNonQuery();
            Con.Close();
        }

        public string AddClietnQuery(string nombre, string apPat, string apMat, string naci, double peso,
            string blood, string alerg, string email, string nomEmer, string numEmerg, string tipo, int status,
            string sexo, string telEmer, string idenCon, string calle_Num, string colonia, string cod_postal, string city, 
            string estado,
            string tel, string celular, string telEmerg)
        {
            string msg = $"INSERT INTO cliente(Nombre, apPat, apMat, FechaNac,Peso, TipoSangre, " +
                $"Alergias,Correo, NombreEmer,celularEmer,Tipo,Status,Sexo,IdentificadoCon," +
                $"Calle_Num,Colonia,CodigoPostal,Ciudad, Estado, Telefono,Celular,TelefonoEmer) " +
                $"VALUES('{nombre}', '{apPat}', '{apMat}', '{naci}', '{peso}', '{blood}', '{alerg}'" +
                $", '{email}', '{nomEmer}', '{numEmerg}', '{status}', {tipo}, '{sexo}', '{telEmer}', '{idenCon}', '{calle_Num}', '{colonia}'" +
                $", '{cod_postal}', '{city}', '{estado}', '{tel}', '{celular}'); ";
            return msg;
        }

        public static void SelectClintQuery()
        {
            //
        }




    }
}


