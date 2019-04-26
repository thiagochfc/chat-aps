namespace chat_aps.Model
{
    class Usuario
    {
        public string Nome { get; private set; }

        public Usuario() { }

        public Usuario(string nome)
        {
            Nome = nome;
        }
    }
}
