# Evaluación Técnica – Developer .NET - Parte 01

## Indicaciones

Usando C#, crear una clase llamada OrderRange que tenga un método llamado build el cual
tome un parámetro de colección de números enteros positivos (1,2,3, ...n) en cualquier orden.
El algoritmo debe retornar una colección de números pares y uno de números impares usando
los números recibidos como parámetro. Ambas listas deben mostrarse en orden ascendente.
Indicaciones

- Crear la solución en un solo archivo llamado OrderRange.cs
- El método build devuelve la salida del algoritmo

Ejemplos
- Entrada:[2, 1, 4, 5] salida:[1, 5] [2,4]
- Entrada:[4, 2, 9, 3, 6] salida:[2, 4, 6] [3,9]
- Entrada:[58, 60, 55, 48, 57, 73] salida:[48, 58, 60] [55, 57,73]

Al finalizar debe entregarse:

- Código en .zip o GIT

## Solución

### Entregable

El código fuente de la clase 'OrderRange' solicitado se encuentra [aquí](https://github.com/acerohernan/prueba-tecnica-parte1/blob/master/OrderRange/OrderRange.cs).

### Descripción
Para resolver el desafío se usó la metodología TDD, creando una librería de clase para el código fuente de la solución y un proyecto de XUnit para validar los casos propuestos en las indicaciones.  

### Dependencias 
No se usaron dependencias externas para el código fuente

### Tests
Los tests creados se encuentran [aquí](https://github.com/acerohernan/prueba-tecnica-parte1/blob/master/OrderRange.Tests/OrderRangeTests.cs).

Casos validados:
1. Entrada: [2, 1, 4, 5] salida: [1, 5] [2,4]
2. Entrada: [4, 2, 9, 3, 6] salida: [2, 4, 6] [3,9]
3. Entrada: [58, 60, 55, 48, 57, 73] salida: [48, 58, 60] [55, 57,73]