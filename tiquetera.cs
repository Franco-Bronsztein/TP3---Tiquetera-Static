
public static class tiquetera
{ 
    private static Dictionary <int,Cliente> tiqueteraDic = new Dictionary<int,Cliente>();
    public static int ultimoIDEntrada = 0;
    private static Cliente clienteBuscar = null;
    private static int opcion1 = 15000;
    private static int opcion2 = 30000;
    private static int opcion3 = 10000;
    private static int opcion4 = 40000;
    public static int[] opcion = new int[5];
    public static int recaudacionTotal = 0;
    static int devolverUltimoID()
    {   
        return ultimoIDEntrada;
    }
    public static int agregarCliente(Cliente objCliente)
    {
        ultimoIDEntrada++;
        tiqueteraDic.Add(ultimoIDEntrada,objCliente);
        return ultimoIDEntrada;

    }
    public static Cliente buscarCliente(int idEntrada)
    {   
        bool existe = tiqueteraDic.ContainsKey(idEntrada);
        if(existe)
        {
            clienteBuscar = tiqueteraDic[idEntrada];
        }
        else
        {
            clienteBuscar = new Cliente();
        }
        return clienteBuscar;
    }

    public static int caluclarValor(int tipo)
    {
        int valor = 0;
        if(tipo == 1)
        {
            valor = 15000;
            opcion[1] = opcion[1] + valor;
        }
        else if(tipo == 2)
        {
            valor = 30000;
            opcion[2] = opcion[2] + valor;
        }
        else if(tipo == 3)
        {
            valor = 10000;
            opcion[3] = opcion[3] + valor;
        }
        else if(tipo == 4)
        {
            valor = 40000;
            opcion[4] = opcion[4] + valor;
        }
        else
        {
            valor = 0;

        }
        return valor;
    }
    public static double promedio()
    {
        double promedios = 0;
        promedios = recaudacionTotal / ultimoIDEntrada;
        return promedios;
    }
    public static List<string> estadisticasTicketera()
    {
        List<string> ListaEstadisticas = new List<string>();
        ListaEstadisticas.Add("La cantidad de clientes que compraron entradas es " + ultimoIDEntrada);
        double promedioss = promedio(); 
        ListaEstadisticas.Add("El promedio es de " + promedioss);
        recaudacionTotal = 0;
        for (int i = 0; i < opcion.Length; i++)
        {
            ListaEstadisticas.Add("Del dia " + (i + 1) + " se recaudó " + opcion[i]);
            recaudacionTotal = recaudacionTotal + opcion[i];
        }
        ListaEstadisticas.Add("recaudacion total: " + (recaudacionTotal));
        return ListaEstadisticas;
    }

    public static bool cambiarEntrada(int id, int tipo, int eligio)
    {
        bool cambiar = false;
        if(buscarCliente(id))
        {
            if(caluclarValor(tipo) > eligio)
        {
            cambiar = false;
            Console.WriteLine("Debe tener un importe mayor al ya comprado");
        }
        else
        {
            cambiar = true;
            
            Console.WriteLine("Se a cambiado la entrada");
        }
        }
        else
        {
            Console.WriteLine("No existe el cliente");
        }
        return cambiar;
    }
}

