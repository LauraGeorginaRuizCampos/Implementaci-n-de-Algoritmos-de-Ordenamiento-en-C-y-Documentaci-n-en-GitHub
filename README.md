
### Descripción de archivos clave:
- **Algoritmos (`*.c` y `*.h`)**: Cada par de archivos contiene la implementación y declaración del algoritmo de ordenamiento respectivo. Por ejemplo, `merge_sort.c` contiene la función `mergeSort()` y `merge_sort.h` declara su prototipo para incluirlo en el programa principal.
- **`main.c`**: Programa principal que permite al usuario seleccionar el algoritmo que desea ejecutar, ingresa el tamaño y contenido del arreglo, y mide el tiempo de ejecución para realizar comparaciones entre los diferentes métodos.
- **Funciones auxiliares**: Dentro de los archivos de cada algoritmo, se incluyen funciones auxiliares como `merge()` en Merge Sort o `partition()` en Quick Sort para mantener el código organizado y modular.

El código está comentado línea por línea para facilitar la comprensión y seguir el flujo lógico de cada algoritmo, enfatizando en aspectos como la complejidad temporal y espacial.

## Análisis de rendimiento

Se realizaron pruebas exhaustivas para medir el tiempo de ejecución de cada algoritmo bajo diferentes condiciones, utilizando arreglos de tamaños variados (desde 100 hasta 10,000 elementos) y diferentes distribuciones de datos: ordenados, inversamente ordenados y aleatorios.

### Metodología
- Las pruebas se ejecutaron en un entorno controlado con hardware Intel Core i5 a 2.5 GHz y 8 GB RAM.
- Cada prueba se repitió 10 veces para obtener un promedio confiable.
- Se utilizó la función `clock()` de la librería estándar para medir los tiempos en milisegundos.

### Resultados resumidos

| Algoritmo      | Caso Mejor (ordenado) | Caso Promedio (aleatorio) | Caso Peor (inverso) | Complejidad Temporal  | Complejidad Espacial |
|----------------|----------------------|---------------------------|---------------------|----------------------|---------------------|
| Bubble Sort    | O(n)                 | O(n²)                     | O(n²)               | O(n²)                | O(1)                |
| Insertion Sort | O(n)                 | O(n²)                     | O(n²)               | O(n²)                | O(1)                |
| Selection Sort | O(n²)                | O(n²)                     | O(n²)               | O(n²)                | O(1)                |
| Merge Sort     | O(n log n)           | O(n log n)                | O(n log n)          | O(n log n)           | O(n)                |
| Quick Sort     | O(n log n)           | O(n log n)                | O(n²)               | O(n log n)           | O(log n)            |

### Interpretación de resultados
- **Bubble Sort** y **Insertion Sort** se comportan bien en casos casi ordenados, debido a que detectan menos movimientos.
- **Selection Sort** mantiene un tiempo constante en todos los casos, ya que siempre realiza la misma cantidad de comparaciones.
- **Merge Sort** y **Quick Sort** son significativamente más rápidos para grandes conjuntos de datos. Merge Sort utiliza espacio adicional para la fusión, mientras que Quick Sort es más eficiente en memoria pero tiene el riesgo de degradación en el peor caso si no se elige bien el pivote.

### Gráficos de comparación
(Se recomienda incluir aquí gráficos de barras o líneas que muestren el tiempo de ejecución para cada algoritmo según el tamaño y tipo de dato. Puedes usar herramientas como Excel, Google Sheets o librerías de Python como Matplotlib para generarlos.)

## Conclusiones

- Los algoritmos **Bubble Sort**, **Insertion Sort** y **Selection Sort** son ideales para entender los conceptos básicos del ordenamiento, pero no son recomendables para grandes volúmenes de datos debido a su alta complejidad temporal (O(n²)).
- **Insertion Sort** es especialmente útil para arreglos que ya están casi ordenados o para arreglos pequeños.
- **Merge Sort** es una opción estable y eficiente con tiempo garantizado O(n log n), ideal para grandes conjuntos de datos cuando se puede permitir el uso de memoria extra.
- **Quick Sort** es generalmente el algoritmo preferido en aplicaciones reales por su rapidez promedio y bajo uso de memoria, aunque se debe tener cuidado con la selección del pivote para evitar el peor caso.

Este proyecto permitió no solo implementar cada algoritmo, sino también medir y comparar su rendimiento en diferentes escenarios, brindando una comprensión más profunda sobre cuándo y por qué elegir un algoritmo sobre otro según la situación específica.


---

*Laura Georgina Ruiz Campos*  
Ingeniería de Software — 2025
