namespace ApiContato.Model
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<Contato> Contatos { get; set; }
        public Pessoa()
        {
            Contatos = new List<Contato>();
        }
    }

    public class Contato
    {
        public int Id { get; set; }
        public string Type { get; set; }  // e., Phone, Email, WhatsApp
        public string Value { get; set; }
        public int PessoaId { get; set; }
    }
}
