public class Cliente
{
    public int dni{get;private set;}

    public string apellido{get;private set;}

    public string nombre{get;private set;}

    public DateTime fechaInscripcion{get;set;}

    public int tipoEntrada{get;set;}

    public int totalAbonado{get;set;}

    public Cliente()
    {

    }
    public Cliente(int dnip,string apellidop, string nombrep, int tipoEntradap, int totalAbonadop)
    {
        nombre = nombrep;
        dni = dnip;
        apellido = apellidop;
        tipoEntrada = tipoEntradap;
        totalAbonado= totalAbonadop;
    }
}

