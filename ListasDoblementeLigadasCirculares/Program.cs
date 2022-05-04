using ListasDoblementeLigadasCirculares;

Lista listas = new Lista();

Console.WriteLine("Mostrando elementos de la lista");
listas.AgregarNodo("Cero");
listas.AgregarNodo("Uno");
listas.AgregarNodo("Dos");
listas.AgregarNodo("Tres");
listas.AgregarNodo("Cuatro");
Console.WriteLine(listas.RecorrerLista());
Console.WriteLine("---------------------------------------------------------");

Console.WriteLine("Buscando siguiente a Cuatro");
Nodo nodoPosteriorAtres = listas.Buscar("Cuatro");
Console.WriteLine(nodoPosteriorAtres.Enlace.Enlace.Valor);
Console.WriteLine("--------------------------------------------------------");

Console.WriteLine("Borrar Uno");
listas.BorrarNodo("Uno");
Console.WriteLine(listas.RecorrerLista());