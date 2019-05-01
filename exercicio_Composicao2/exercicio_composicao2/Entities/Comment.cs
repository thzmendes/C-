namespace exercicio_composicao2.Entities
{
    public class Comentario
    {
        public string Text { get; set; }

        public Comentario() { }

        public Comentario(string comment)
        {
            Text = comment;
        }
    }
}
