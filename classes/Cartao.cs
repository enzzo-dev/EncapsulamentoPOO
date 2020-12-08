namespace EncapsulamentoPOO.classes
{
    public class Cartao
    {
        //Atributos
        private string numCard;

        public string NumCard{
            get{return numCard;}
            set{NumCard = value;}
        }
        private string bandeira;

        public string Bandeira{
            get{ return bandeira;}
        }
        protected string token = "qwertyui";

        public string Token{
            get{return token;}
            set{token = value;}
        }
        private string cvv;

        public string Cvv{
            get{return cvv;}
            set{cvv = value;}
        }

        protected float limite = 5000;
        
        public float Limite{
            get{return limite;}
        }

        //Métodos
         public string RegistrarCompra(bool validado){

             return "";
        }

        private bool ValidarCompra(float saldo){

            return true;            
        }

        protected string ValidarToken(string token){

            return "";

        }

    }
}
