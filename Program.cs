using Cartas_Españolas;

Baraja b = new Baraja();

/* Mostramos la baraja*/
b.MostrarBaraja();                            
/* Avisamos al usuario que no ha salido ninguna carta*/
b.CartasDelMonton();                      
/* Mostramos las cartas que ya salieron en la parte inferior*/
b.SiguinteCarta();                           
b.SiguinteCarta();
Console.WriteLine();
b.CartasDelMonton();

/* Mostramos las cartas disponibles*/
b.CartasDisponibles();                      
Console.WriteLine(b.CartasDisponibles());

/* Indicamos al usuario que ya no hay mas cartas.*/
b.SiguinteCarta();                                       
b.SiguinteCarta(); b.SiguinteCarta(); b.SiguinteCarta();
b.SiguinteCarta(); b.SiguinteCarta(); b.SiguinteCarta();
b.SiguinteCarta(); b.SiguinteCarta(); b.SiguinteCarta();
b.SiguinteCarta(); b.SiguinteCarta(); b.SiguinteCarta();
b.SiguinteCarta(); b.SiguinteCarta(); b.SiguinteCarta();
b.SiguinteCarta(); b.SiguinteCarta(); b.SiguinteCarta();
b.SiguinteCarta(); b.SiguinteCarta(); b.SiguinteCarta();
b.SiguinteCarta(); b.SiguinteCarta(); b.SiguinteCarta();
b.SiguinteCarta(); b.SiguinteCarta(); b.SiguinteCarta();
b.SiguinteCarta(); b.SiguinteCarta(); b.SiguinteCarta();
b.SiguinteCarta(); b.SiguinteCarta(); b.SiguinteCarta();
b.SiguinteCarta(); b.SiguinteCarta(); b.SiguinteCarta();
b.SiguinteCarta(); b.SiguinteCarta();

/* Mostramos las cartas disponibles*/
b.CartasDisponibles();                      
Console.WriteLine(b.CartasDisponibles());


//b.CartasDelMonton();

/*Damos cartas*/
//Cartas[] c = b.DarCartas(5);                   
//for (int i = 0; i < c.Length; i++)

//{
//    Console.WriteLine(c[i]);
//}

/* Cuando pedimos de mas nos dice un mensaje.*/
//c = b.DarCartas(36);                         

/* cuando ya no tenemos mas cartas, la posicion vuelve en cero y volvemos a barajar.*/
b.Barajar();
b.MostrarBaraja();                             



