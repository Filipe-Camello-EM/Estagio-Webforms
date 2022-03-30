using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using Domain;
using System.Globalization;
using System.Data;

namespace Repository
{
    public class RepositorioAluno : RepositorioAbstrato<Aluno>
    {
        private static readonly string strConn = @"DataSource=localhost; Database = C:\Users\Escolar Manager\Documents\ALUNO.FDB; port = 3054; UserID = SYSDBA; Password = masterkey";
        public Aluno GetByMatricula(int matricula)
        {
            return Get(x => x.Matricula == matricula).First();
        }

        public IEnumerable<Aluno> GetByContendoNoNome(string parteDoNome)
        {
            return Get(x => x.Nome.Contains(parteDoNome, StringComparison.InvariantCultureIgnoreCase)).ToList();
        }

        public override void Add(Aluno aluno)
        {
            using FbConnection conn = new(connectionString: strConn);
            string sqlIncluir = $@"INSERT INTO ALUNO (MATRICULA, NOME, CPF, NASCIMENTO, SEXO) VALUES 
( @matricula,@nome,@CPF,@nascimento,@sexo)";
            while (aluno.Nome.Contains("  ", StringComparison.CurrentCulture))
            {
                aluno.Nome = aluno.Nome.Replace("  ", " ");
            }
            conn.Open();
            using FbCommand cmd = new(sqlIncluir, conn);
            cmd.Parameters.Add("@matricula", aluno.Matricula);
            cmd.Parameters.Add("@nome", aluno.Nome.Trim());
            cmd.Parameters.Add("@CPF", aluno.CPF);
            cmd.Parameters.Add("@nascimento", aluno.Nascimento);
            cmd.Parameters.Add("@sexo", (int)aluno.Sexo);
            cmd.ExecuteNonQuery();
        }

        public override void Remove(Aluno aluno)
        {
            using FbConnection conn = new(connectionString: strConn);
            string sqlExcluir = $@"DELETE FROM ALUNO WHERE MATRICULA = {aluno.Matricula}";
            conn.Open();
            using FbCommand cmd = new(sqlExcluir, conn);
            cmd.ExecuteNonQuery();
        }

        public override void Update(Aluno aluno)
        {
            string sqlEditar = $@"UPDATE ALUNO SET NOME = @nome, CPF = @cpf, NASCIMENTO = @nascimento, SEXO = @sexo WHERE MATRICULA = @matricula";

            using FbConnection conn = new(connectionString: strConn);
            while (aluno.Nome.IndexOf("  ") >= 0)
            {
                aluno.Nome = aluno.Nome.Replace("  ", " ");
            }
            conn.Open();
            using FbCommand cmd = new(sqlEditar, conn);
            cmd.Parameters.Add("@matricula", aluno.Matricula);
            cmd.Parameters.Add("@nome", aluno.Nome.Trim());
            cmd.Parameters.Add("@CPF", aluno.CPF);
            cmd.Parameters.Add("@nascimento", aluno.Nascimento);
            cmd.Parameters.Add("@sexo", (int)aluno.Sexo);
            cmd.ExecuteNonQuery();
        }
            

        public override IEnumerable<Aluno> GetAll()
        {
            List<Aluno> alunos = new();
            string sqlReaderCommand = "SELECT * FROM ALUNO ORDER BY MATRICULA";
            using (FbConnection conn = new(connectionString: strConn))
            {
                conn.Open();
                using FbCommand cmd = new(sqlReaderCommand, conn);
                using FbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Aluno aluno = new()
                    {
                        Nome = reader["NOME"].ToString() ?? string.Empty,
                        CPF = reader["CPF"].ToString() ?? string.Empty,
                        Matricula = (int)reader["MATRICULA"],
                        Nascimento = (DateTime)reader["NASCIMENTO"],
                        Sexo = (EnumeradorSexo)reader["SEXO"]
                    };
                    alunos.Add(aluno);
                }
            }
            return alunos;
        }

        public override IEnumerable<Aluno> Get(Expression<Func<Aluno, bool>> predicate)
        {
            return GetAll().Where(predicate.Compile());
        }
    }
}
