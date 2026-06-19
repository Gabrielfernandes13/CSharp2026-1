namespace ProjetoAPI01.Classes.DTO
{
    public class AdminRequestDTO
    {
        public int Id { get; internal set; }
        public string Nome { get; internal set; }
        public int Regra { get; internal set; }
    }
    namespace ProjetoAPI01.Classes.DTO
    {
        public class AdminRequestDTO
        {
            public int Id { get; set; }
            public string Nome { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
            public int Regra { get; set; }
        }
    }
}
