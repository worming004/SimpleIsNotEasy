namespace Functions
{
    // Personellement, j'accepterai ceci en code review. 
    // Mais si un autre héritage pour une autre logique devenait nécessaire,
    // Immédiatement cette classe serait détruite
    // et la classe FizzBuzzDivided serait retravaillé en composition.
    public class InheritFizzBuzz : FizzBuzzDivided, IPrintFizzBuzz
    {
        protected override void writeInConsole(string text)
        {
            /// écrire dans un fichier ? un StreamWriter ? Une composition ?
        }
    }
}