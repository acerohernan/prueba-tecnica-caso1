# Evaluaci�n T�cnica � Developer .NET - Parte 01

## Indicaciones

Usando C#, crear una clase llamada OrderRange que tenga un m�todo llamado build el cual
tome un par�metro de colecci�n de n�meros enteros positivos (1,2,3, ...n) en cualquier orden.
El algoritmo debe retornar una colecci�n de n�meros pares y uno de n�meros impares usando
los n�meros recibidos como par�metro. Ambas listas deben mostrarse en orden ascendente.
Indicaciones

- Crear la soluci�n en un solo archivo llamado OrderRange.cs
- El m�todo build devuelve la salida del algoritmo

Ejemplos
- Entrada:[2, 1, 4, 5] salida:[1, 5] [2,4]
- Entrada:[4, 2, 9, 3, 6] salida:[2, 4, 6] [3,9]
- Entrada:[58, 60, 55, 48, 57, 73] salida:[48, 58, 60] [55, 57,73]

Al finalizar debe entregarse:

- C�digo en .zip o GIT

## Soluci�n

### Entregable

El c�digo fuente de la clase 'OrderRange' solicitado se encuentra [aqu�](https://github.com/acerohernan/prueba-tecnica-parte1/blob/master/OrderRange/OrderRange.cs).

### Descripci�n
Para resolver el desaf�o se us� la metodolog�a TDD, creando una librer�a de clase para el c�digo fuente de la soluci�n y un proyecto de XUnit para validar los casos propuestos en las indicaciones.  

### Dependencias 
No se usaron dependencias externas para el c�digo fuente

### Tests
Los tests creados se encuentran [aqu�](https://github.com/acerohernan/prueba-tecnica-parte1/blob/master/OrderRange.Tests/OrderRangeTests.cs).

Casos validados:
1. Entrada: [2, 1, 4, 5] salida: [1, 5] [2,4]
2. Entrada: [4, 2, 9, 3, 6] salida: [2, 4, 6] [3,9]
3. Entrada: [58, 60, 55, 48, 57, 73] salida: [48, 58, 60] [55, 57,73]