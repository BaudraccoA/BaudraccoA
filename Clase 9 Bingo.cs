
Console.Clear();
// Creamos un carton de Bingo:
Console.WriteLine();
Console.WriteLine("===============BINGO===============");
Console.WriteLine();

// Declaramos Filas y Columnas y variables:

int[,] carton = new int[3,9];
Random columna = new Random();
int numeroAleatorios;
bool numeros = true; 

//Se crean los numeros de manera aleatoria
for (int f = 0; f < 3; f++)
{
int primerNumero = 0;
int segundoNumero = 9;

    for (int c = 0; c < 9; c++)
    {
        numeroAleatorios = columna.Next(primerNumero, segundoNumero);

        if (f == 1)
        {
            if (numeroAleatorios == carton[0, c]) 
            {
                numeros = false;
            }
        }
        else if (f == 2)
        {
            if (numeroAleatorios == carton[0, c] || numeroAleatorios == carton[1, c])
            {
                numeros = false;
            }
        }
        


        if (numeros == false)
        {
                c--;
        }

        else
        {
            carton[f, c] = numeroAleatorios;
            primerNumero = primerNumero + 10;
            segundoNumero = segundoNumero + 10;
        }

        numeros = true;

    }
}

// Cambio posiciones aleatoria de numeros por espacios en 0:

int posicionAleatoria;

for (int f = 0; f < 3; f++)
{

    for (int i = 0; i < 4; i++)
    {
        int espacio = 00;
        if (f == 2)
        {
            for (int j = 0; j < 9; j++)
            {
                if (carton[0, j] != 0 && carton[1, j] != 0)
                {
                    carton[2, j] = espacio;
                    i++;
                }
            }
        }
        posicionAleatoria = columna.Next(0, 9);

        if (carton[f, posicionAleatoria] == 00)
        {
            numeros = false;
        }
        if (f == 2)
        {
            if (carton[0, posicionAleatoria] == 0 && carton[1, posicionAleatoria] == 0)
            {
                numeros = false;
            }

        }
        if (numeros == false)
        {
            i--;
        }
        else
        {
            carton[f, posicionAleatoria] = espacio;
        }
        numeros = true;
    }
}



//// Se escriben los numeros
for (int f = 0; f < 3; f++)
{
    for (int c = 0; c < 9; c++)
    {
        if (carton[f, c] == 0)
        {
            Console.Write(" = | ");
        }
        else
        {
            Console.Write(carton[f, c]);
            
            Console.Write("  | ");

        }
       
    }
    Console.WriteLine();
}
Console.ReadKey();







