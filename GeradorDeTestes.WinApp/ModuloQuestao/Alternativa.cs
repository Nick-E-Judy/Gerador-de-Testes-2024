namespace GeradorDeTestes.WinApp.ModuloQuestao
{
    public class Alternativa
    {
        public char Letra { get; set; }
        public string Resposta { get; set; }
        public bool Correto { get; set; }
        
        public Alternativa() { }
        public Alternativa(char letra, string resposta, bool correto)
        {
            Letra = letra;
            Resposta = resposta;
            Correto = correto;
        }


        public override string ToString()
        {
            return $"({Letra}) -> {Resposta}";
        }
    }
}