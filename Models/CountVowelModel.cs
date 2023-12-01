namespace TestBackEnd.Models
{
    public class VowelCountModel
    {
        public int CountVowels(string word)
        {
            char[] vocals = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int conteoVocales = word.Count(w => vocals.Contains(w));
            return conteoVocales;
        }
    }
}
