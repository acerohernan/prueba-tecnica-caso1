namespace OrderRange
{
    public class OrderRange
    {

        /// <summary>
        /// 
        /// </summary>
        public (List<int> Pares, List<int> Impares) build(List<int> numeros)
        {
            List<int> pares = [];
            List<int> impares = [];

            // clasificación
            foreach (int numero in numeros) {
                if (numero % 2 == 0) 
                { 
                    pares.Add(numero);
                }
                else
                {
                    impares.Add(numero);
                }
            }

            // ordenamiento
            pares.Sort();
            impares.Sort();

            return (pares, impares);
        }
    }
}
