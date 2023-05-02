int ClientesInscriptos = 0;
string dniNom;
string dniApp;
int dniCliente;
int tipoEntrada;
int valorEntrada;
int totalAbandonado;
Cliente nuevoCliente = null;
 List<string> ListaEstadisticas = new List<string>();
int select = 0;
while(select < 5)
{
    Console.WriteLine("Nueva Inscripcion");
    Console.WriteLine("Obtener Estadisticas Del Evento");
    Console.WriteLine("Buscar Cliente");
    Console.WriteLine("Cambiar ENtrada Del Cliente");
    Console.WriteLine("Salir");
    select = int.Parse(Console.ReadLine());
    while(select < 5);
    switch(select)
    {
        case 1:
            nuevoCliente = CargarDatoscliente();
            tiquetera.agregarCliente(nuevoCliente);
        break;

        case 2:
            ListaEstadisticas = tiquetera.estadisticasTicketera();
            Console.WriteLine(ListaEstadisticas);
            for (int i = 0; i < ListaEstadisticas.Count(); i++)
            {
                Console.WriteLine(ListaEstadisticas[i]);
            }
        break;
    
        case 3:
            int clienteBuscar = Funciones.IngresarEntero("Ingrese el DNI el cliente");
            Cliente clienteencontrado = tiquetera.buscarCliente(clienteBuscar);
            Console.WriteLine("La informacion es la siguiente: ");
            Console.WriteLine(clienteencontrado.nombre);
            Console.WriteLine(clienteencontrado.apellido);
            Console.WriteLine(clienteencontrado.dni);
            Console.WriteLine(clienteencontrado.fechaInscripcion);
            Console.WriteLine(clienteencontrado.tipoEntrada);
            Console.WriteLine(clienteencontrado.totalAbonado);
        break;

        case 4:
            int idRemplazar = Funciones.IngresarEntero("ingrese el ID para cambiar la entrada:");
            int entrada= Funciones.IngresarEntero("ingrese el numero de opcion a la entradaa cambiar");
            int entradaAntes =Funciones.IngresarEntero("Ingrese la entrada comprada ");
            bool sepudo = tiquetera.cambiarEntrada(idRemplazar,entrada,entradaAntes);
        break;

        case 5:
        break;
    }
}
Cliente CargarDatoscliente()
{
    dniNom = Funciones.IngresarTexto("Ingrese Su Nombre:");
    dniApp = Funciones.IngresarTexto("Ingrese Su Apellido:");
    dniCliente = Funciones.IngresarEntero("Ingrese Su DNI:");
    tipoEntrada = Funciones.IngresarEntero("Ingrese El Numero De Opcion De La Entrada: ");
    valorEntrada = tiquetera.caluclarValor(tipoEntrada);
    totalAbandonado = Funciones.IngresarEntero("Ingrese el total abonado: ");
    bool puede = Funciones.caluclarabonar(totalAbandonado, valorEntrada);
    Cliente clienteNuevo = new Cliente(dniCliente,dniApp,dniNom,tipoEntrada,totalAbandonado); 
    return clienteNuevo;
}
