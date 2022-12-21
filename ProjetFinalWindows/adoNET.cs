using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProjetFinalWindows
{
    public class adoNET
    {
        //Attributs privés
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private string connectionString;
        private DataTable dtEtudiant;
        private DataTable dtEnseignant;
        private DataSet dsScolarite;
        

        public SqlConnection Connection { get => connection; set => connection = value; }
        public SqlCommand Command { get => command; set => command = value; }
        public SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public DataTable DtEtudiant { get => dtEtudiant; set => dtEtudiant = value; }
        public DataSet DsScolarite { get => dsScolarite; set => dsScolarite = value; }
        public DataTable DtEnseignant { get => dtEnseignant; set => dtEnseignant = value; }

        public adoNET()
        {
            connectionString = "Data Source=LAPTOP-I1CVARR4\\MONSQL;Initial Catalog=Scolarité;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            adapter = new SqlDataAdapter();
            dsScolarite = new DataSet();
            dtEtudiant = new DataTable();
            dtEnseignant = new DataTable();
            

        }   
    }
}
