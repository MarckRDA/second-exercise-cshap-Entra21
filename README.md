## Second C# exercises Entra21

Each resolution of this list is in this repository. The identification is a commentary above the Class' name:

    // Exercise 1)a <--- Id

If you'd like to run those codes, you need to replace de class' name to Main and after that, run the code:

``` c#
static void CArrayDiffAandB(string[] args)
        {
            int [] a= {1, 2, 50, 4, 677, 11, 34, 56, 78, 22, 1, 90, 1083, 755, 32};
            int [] b = {133, 44, 7, 23, 54, 2, 78, 44, 13, 1, 45, 67, 21, 455, 45};
            int [] c = new int [15];

            var count = 0;

            while (count < 15){
                c[count] = a[count] - b[count];
                count++;
            }
    
        }

//Replace the name (IncreasingNumbers) to (Main):

static void Main(string[] args)
        {
            int [] a= {1, 2, 50, 4, 677, 11, 34, 56, 78, 22, 1, 90, 1083, 755, 32};
            int [] b = {133, 44, 7, 23, 54, 2, 78, 44, 13, 1, 45, 67, 21, 455, 45};
            int [] c = new int [15];

            var count = 0;

            while (count < 15){
                c[count] = a[count] - b[count];
                count++;
            }
    
        }

//Then, run the code!
```
1. Leia dois arrays A e B com 15 elementos. Construir um array C, onde cada elemento de C é a subtração do elemento correspondente de A com B.

2. Ler um array com 10 inteiros e mostrar os números na ordem direta e inversa a que foram lidos.

3. Leia 10 elementos e armazene em um array A. Em seguida, solicite pelo teclado um número qualquer e pesquise no array se o número existe. Caso, seja verdade imprima a mensagem: “O número existe no array” , caso contrário “Número inexistente”.

4. Leia dois arrays A e B com 10 elementos.  Em seguida, compare os arrays e verifique se os mesmos são iguais ou diferentes.

5. Leia um array A com 15 elementos, e calcule a média aritmética dos mesmos, em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.

6. Leia um array A com 12 elementos. Após sua leitura, colocar os seus elementos em
ordem crescente. Depois ler um array B também com doze elementos, colocar os elementos de B em ordem decrescente. Construir um array C, onde cada elemento de C é a soma do elemento correspondente de A com b. Colocar em ordem crescente a matriz
C e apresentar os seus valores.
