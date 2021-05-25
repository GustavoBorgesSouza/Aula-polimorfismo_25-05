namespace Override.classes
{
    public class Player
    {
        private float velocidade;
        private float forcaPulo;

        public virtual string Correr(){
            return "O player correu";
        }
        public virtual string Pular(){
            return "O player pulou";
        }
    }
}