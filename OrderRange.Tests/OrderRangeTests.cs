using FluentAssertions;

namespace OrderRange.Tests
{
    public class OrderRangeTests
    {

        /// <summary>
        /// 1. Entrada:[2, 1, 4, 5] salida:[1, 5] [2,4] 
        /// </summary>
        [Fact]
        public void Primer_Entrada_De_Indicaciones()
        {
            List<int> entrada = [2, 1, 4, 5];
            
            List<int> paresEsperados = [2, 4];
            List<int> imparesEsperados = [1, 5];

            var orderRange = new OrderRange();
            var result = orderRange.Build(entrada);
            
            result.Pares.Should().BeEquivalentTo(paresEsperados);
            result.Impares.Should().BeEquivalentTo(imparesEsperados);
        }

        /// <summary>
        /// 2. Entrada:[4, 2, 9, 3, 6] salida:[2, 4, 6] [3,9]
        /// </summary>
        [Fact]
        public void Segunda_Entrada_De_Indicaciones()
        {
            List<int> entrada = [4, 2, 9, 3, 6];

            List<int> paresEsperados = [2, 4, 6];
            List<int> imparesEsperados = [3, 9];

            var orderRange = new OrderRange();
            var result = orderRange.Build(entrada);

            result.Pares.Should().BeEquivalentTo(paresEsperados);
            result.Impares.Should().BeEquivalentTo(imparesEsperados);
        }

        /// <summary>
        /// 3. Entrada:[58, 60, 55, 48, 57, 73] salida:[48, 58, 60] [55, 57,73]
        /// </summary>
        [Fact]
        public void Tercer_Entrada_De_Indicaciones()
        {
            List<int> entrada = [58, 60, 55, 48, 57, 73];

            List<int> paresEsperados = [48, 58, 60];
            List<int> imparesEsperados = [55, 57, 73];

            var orderRange = new OrderRange();
            var result = orderRange.Build(entrada);

            result.Pares.Should().BeEquivalentTo(paresEsperados);
            result.Impares.Should().BeEquivalentTo(imparesEsperados);
        }
    }
}