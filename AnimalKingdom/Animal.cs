namespace AnimalKingdom
{
    public abstract class Animal
    {
        public virtual string Sound()
        {
            return "Sound will be ";
        }

        public interface IMammal
        {
            int NumberOfNipples {get;}
        }
    }
}
