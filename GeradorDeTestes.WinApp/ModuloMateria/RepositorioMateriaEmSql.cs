
using GeradorDeTestes.WinApp.ModuloDisciplina;
using Microsoft.Data.SqlClient;

namespace GeradorDeTestes.WinApp.ModuloMateria
{
    public class RepositorioMateriaEmSql : IRepositorioMateria
    {
        private string enderecoBanco;

        public RepositorioMateriaEmSql()
        {
            enderecoBanco = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=GeradorDeTestesDb;Integrated Security=True;Pooling=False";
        }

        private const string sqlInserir =
            @"INSERT INTO [TBMATERIA]
                (
                    [NOME],
                    [SERIE],       
                    [DISCIPLINA_ID]
                )
                VALUES
                (
                    @NOME,
                    @SERIE,
                    @DISCIPLINA_ID

                ); SELECT SCOPE_IDENTITY();";

        private const string sqlEditar =
          @"UPDATE [TBMATERIA]
                SET 
                    [NOME] = @NOME,
                    [SERIE] = @SERIE, 
                    [DISCIPLINA_ID] = @DISCIPLINA_ID
                WHERE 
                    [ID] = @ID";

        private const string sqlExcluir =
            @"DELETE FROM [TBMATERIA]
		        WHERE
			        [ID] = @ID";

        private const string sqlSelecionarPorId =
          @"SELECT
                MA.[ID],
                MA.[NOME],
                MA.[SERIE],
                MA.[DISCIPLINA_ID],
                DP.[NOME] AS [DISCIPLINA_NOME]
            FROM
                [TBMATERIA] AS MA LEFT JOIN
                [TBDISCIPLINA] AS DP
            ON
                DP.ID = MA.DISCIPLINA_ID
            WHERE
                MA.[ID] = @ID;";

        private const string sqlSelecionarTodos =
            @"SELECT
                MA.[ID],
                MA.[NOME],
                MA.[SERIE],
                MA.[DISCIPLINA_ID],
                DP.[NOME] AS [DISCIPLINA_NOME]
            FROM
                [TBMATERIA] AS MA LEFT JOIN
                [TBDISCIPLINA] AS DP
            ON
                DP.ID = MA.DISCIPLINA_ID;";


        public void Cadastrar(Materia novaMateria)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoInsercao = new SqlCommand(sqlInserir, conexaoComBanco);

            ConfigurarParametrosMateria(novaMateria, comandoInsercao);

            conexaoComBanco.Open();

            object id = comandoInsercao.ExecuteScalar();

            novaMateria.Id = Convert.ToInt32(id);

            conexaoComBanco.Close();
        }

        public bool Editar(int id, Materia materiaEditada)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoEdicao = new SqlCommand(sqlEditar, conexaoComBanco);

            materiaEditada.Id = id;

            ConfigurarParametrosMateria(materiaEditada, comandoEdicao);

            conexaoComBanco.Open();

            int numeroRegistrosAfetados = comandoEdicao.ExecuteNonQuery();

            conexaoComBanco.Close();

            if (numeroRegistrosAfetados < 1)
                return false;

            return true;
        }

        public bool Excluir(int id)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoExclusao = new SqlCommand(sqlExcluir, conexaoComBanco);

            comandoExclusao.Parameters.AddWithValue("ID", id);

            conexaoComBanco.Open();

            int numeroRegistrosExcluidos = comandoExclusao.ExecuteNonQuery();

            conexaoComBanco.Close();

            if (numeroRegistrosExcluidos < 1)
                return false;

            return true;
        }

        public List<Materia> SelecionarPorDisciplina(int disciplinaId)
        {
            throw new NotImplementedException();
        }

        public Materia SelecionarPorId(int idSelecionado)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao =
                new SqlCommand(sqlSelecionarPorId, conexaoComBanco);

            comandoSelecao.Parameters.AddWithValue("ID", idSelecionado);

            conexaoComBanco.Open();

            SqlDataReader leitor = comandoSelecao.ExecuteReader();

            Materia materia = null;

            if (leitor.Read())
                materia = ConverterParaMateria(leitor);

            conexaoComBanco.Close();

            return materia;
        }

        public List<Materia> SelecionarTodos()
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao =
                new SqlCommand(sqlSelecionarTodos, conexaoComBanco);

            conexaoComBanco.Open();

            SqlDataReader leitorMateria = comandoSelecao.ExecuteReader();

            List<Materia> materias = new List<Materia>();

            while (leitorMateria.Read())
            {
                Materia materia = ConverterParaMateria(leitorMateria);

                materias.Add(materia);
            }

            conexaoComBanco.Close();

            return materias;
        }

        private Materia ConverterParaMateria(SqlDataReader leitorMateria)
        {

            Materia materia = new Materia()
            {
                Id = Convert.ToInt32(leitorMateria["ID"]),
                Nome = Convert.ToString(leitorMateria["NOME"]),
                Serie = Convert.ToInt32(leitorMateria["SERIE"])
            };

            if (leitorMateria["DISCIPLINA_ID"] != DBNull.Value)
                materia.Disciplina = ConverterParaDisciplina(leitorMateria);

            return materia;
        }

        private Disciplina ConverterParaDisciplina(SqlDataReader leitor)
        {
            Disciplina disciplina = new Disciplina()
            {
                Id = Convert.ToInt32(leitor["DISCIPLINA_ID"]),
                Nome = Convert.ToString(leitor["DISCIPLINA_NOME"])
            };

            return disciplina;
        }

        private static void ConfigurarParametrosMateria(Materia novaMateria, SqlCommand comandoInsercao)
        {
            comandoInsercao.Parameters.AddWithValue("ID", novaMateria.Id);
            comandoInsercao.Parameters.AddWithValue("NOME", novaMateria.Nome);
            comandoInsercao.Parameters.AddWithValue("SERIE", novaMateria.Serie);

            object valorDaDisciplina =
                novaMateria.Disciplina == null ? DBNull.Value : novaMateria.Disciplina.Id;

            comandoInsercao.Parameters.AddWithValue("DISCIPLINA_ID", valorDaDisciplina);
        }
    }
}
