namespace OrderRange
{
    public class OrderRange
    {

        /// <summary>
        /// Retorna una colección de números pares y uno de números impares usando los números recibidos como parámetro
        /// </summary>
        /// <param name="numeros">Los numeros a ser clasificados</param>
        public (List<int> Pares, List<int> Impares) Build(List<int> numeros)
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
