public static class Funciones
{
    public static string IngresarTexto(string msj)
    {
        string texto = "";
        while (texto == "")
        {
            Console.Write(msj);
            texto = Console.ReadLine();
        }
        return texto;
    }
    public static int IngresarEntero(string msj)
    {
        int entero=-1;
        while (entero == -1)
        {   
            Console.Write(msj);
            int.TryParse(Console.ReadLine(), out entero);
        }
        return entero;
    }
    

    public static bool caluclarabonar(int abonado,int entrada)
    {
        bool puede = false;
        if(abonado > entrada)
        {
            puede = true;
        }
        else if(abonado == entrada)
        {
            puede = true;
        }
        return puede;
    }
}