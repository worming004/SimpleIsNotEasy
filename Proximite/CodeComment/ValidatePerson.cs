namespace CodeComment
{
    public class ValidatePerson
    {
        // Validate Name
        public bool ValidateName(string name)
        {
            return !string.IsNullOrEmpty(name);
        }


        // Valide que l'age est supérieur à 18. Ne marche pas pour tous les pays, mais notre produit est actuellement vendu en Belgique. Please, changez cette méthode ou refactorer si nous proposons notre produit à d'autres pays.
        public bool IsMajor(int age)
        {
            return age > 18;
        }
    }
}
