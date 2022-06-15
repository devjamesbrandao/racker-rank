namespace HackerRank.DuplicateString
{
    public static class DuplicateString
    {
        // Solução 1: Ruim
        // Complexidade: O(n^2)
        public static void Solution1(List<string> letras)
        {
            int tamanho = letras.Count;

            var array = new List<string>(tamanho);

            for(var i = 0; i < letras.Count; i++)
            {
                if(array.IndexOf(letras[i]) == -1)
                {
                    array.Add(letras[i]);
                }
            }

            foreach(var p in array)
            {
                Console.WriteLine(p);
            }
        }

        // Solução 2: Razoável
        // Complexidade: O(n * logn)
        public static void Solution2(List<string> letras)
        {
            var tamanho = letras.Count;

            var b = new List<string>(tamanho);

            letras.Sort();

            string temp = "";

            for(var i = 0; i < tamanho; i++)
            {
                if(letras[i] != temp)
                {
                    b.Add(letras[i]);
                    temp = letras[i];
                }
            }

            foreach(var p in b)
            {
                Console.WriteLine(p);
            }
        }

        // Solução 3: Boa
        // Complexidade: O(n)
        public static void Solution3(List<string> letras)
        {
            var objeto = new Dictionary<string, bool>(letras.Count);

            for(var i = 0; i < letras.Count; i++)
            {
                objeto[letras[i]] = true;
            }

            foreach(var letra in objeto.Keys)
            {
                Console.WriteLine(letra);
            }
        }

        // Solução 1: Excelente (HardCore)
        // Complexidade: O(n)
        public static void Solution4(List<string> letras)
        {
            //Apenas uma linha Hardcore mlk kkkkk
            var array = new HashSet<string>(letras);

            foreach(var i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}