namespace TESTE_3_GFT.Models
{
    public class Morador
    {
        private string Telefone;

        private int NumeroResidencia;

        public Morador(string tel,int n)
        {
        this.Telefone = tel;

        this.NumeroResidencia = n;
        }
        public string getTelefone()
        {
            return Telefone;
        }

        public int getNumeroResidencia()
        {
            return NumeroResidencia;
        }
    }
}