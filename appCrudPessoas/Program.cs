namespace appCrudPessoas
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Nome: {Nome}, Idade: {Idade}, Email: {Email}";
        }

    }
}
