namespace Aula6POOPessoa
{
    public class CNPJ : Pessoa
    {
        
        public string cnpj;
        public bool ValidarCNPJ(){

            if(cnpj != null){
                return true;
            }return false;
        }
    }
}