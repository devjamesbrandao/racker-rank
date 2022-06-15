namespace HackerRank.Anagram
{
    public static class CheckIsAnagram
    {
        // Solução : Boa
        // Complexidade: O(n)
        public static void CheckAnagrama(string p1, string p2)
        {
            var objeto = new Dictionary<char, int>();

            for(var i = 0; i < p1.Length; i++)
            {
                var letra = p1[i];

                if(objeto.ContainsKey(letra))
                {
                    objeto[letra]++;
                } else 
                {
                    objeto[letra] = 1;
                } 
            }

            for(var i = 0; i < p2.Length; i++)
            {
                var letra = p2[i];

                if(objeto.ContainsKey(letra))
                {
                    objeto[letra]--;
                } else 
                {
                    Console.WriteLine("Não é anagrama");
                }
            }

            foreach(var valor in objeto.Keys)
            {
                if(objeto[valor] != 0)
                {
                    Console.WriteLine("Não é anagrama");;
                }
            }

            Console.WriteLine("É anagrama");;
        }
    }
}