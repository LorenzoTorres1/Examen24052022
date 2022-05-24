
using System;
class EjemploDeMiCafetera
{

    ///<summary>
    /// Crea una nueva instancia de la clase Cafetera
    ///</summary>
    ///<example> Este ejemplo demuestra como realizar la instancia 
    ///del objeto
    /// <code>
    /// Cafetera mi_cafetera_ejemplo = new Cafetera();
    /// </code>
    ///</example>
    static void main()
    {
        Cafetera mi_cafetera_ejemplo = new Cafetera("EspressoBarista", "Procoffee", 0.6, 7);

        Console.WriteLine(mi_cafetera_ejemplo.CantidadAguaRecipiente);
        Console.WriteLine(mi_cafetera_ejemplo.ConsumoCapsulas(5));
        Console.WriteLine(mi_cafetera_ejemplo.TotalCapsulas);
        Console.WriteLine(mi_cafetera_ejemplo.ConsumoAgua(5));
        Console.WriteLine(mi_cafetera_ejemplo.CantidadAguaRecipiente);
        mi_cafetera_ejemplo.LlenarDeposito(0.5);
        Console.WriteLine(mi_cafetera_ejemplo.CantidadAguaRecipiente);
        mi_cafetera_ejemplo.ReponerCapsulas(3);
        Console.WriteLine(mi_cafetera_ejemplo.TotalCapsulas);
    }

}
///<summary>
/// Esta clase es la clase Cafetera
///</summary>
class Cafetera
{
    ///<summary>
    /// <para> Proporciona las propiedades Marca, Modelo, 
    /// Cantidad de Agua en el Recipiente y Total de Capsulas</para> 
    ///<para> Cuando utilice esta clase asegúrese de que utilizara todas 
    ///las propiedades expuestas por la misma </para> 
    ///</summary>

    private string Marca; //Marca de la máquina cafetera
    public global::System.String Marca { get => Marca; set => Marca = value; }

    private string Modelo; //Referencia del modelo
    public global::System.String Modelo { get => Modelo; set => Modelo = value; }

    private double CantidadAguaRecipiente;  //Cantidad de agua en el recipiente. 
    public global::System.Double CantidadAguaRecipiente { get => CantidadAguaRecipiente; set => CantidadAguaRecipiente = value; }

    private double TotalCapsulas; //Total de cápsulas en la máquina
    public global::System.Double TotalCapsulas { get => TotalCapsulas; set => TotalCapsulas = value; }

    public Cafetera(string marca, string modelo, double cantidadAguaRecipiente, double totalCapsulas)
    {
        Marca = marca; 
        Modelo = modelo; 
        TotalCapsulas = totalCapsulas; 
        CantidadAguaRecipiente = cantidadAguaRecipiente; 
    }

    ///<summary>
    /// Método para obtener el consumo de agua
    ///</summary>
    ///<param name="numeroCafes">Valor de tipo double el cual 
    ///específica el número de cafés que se pueden hacer.</param>
    ///<returns>Un string con los centilitros que quedan por llenar o un mensaje de alterta
    ///de revisión de los niveles</returns>
    ///<remarks>El valor predeterminado para el parámetro 
    ///<paramref name="numeroCafes"></paramref> es de 1 cafes</remarks>
   
    public string ConsumoAgua(double numeroCafes) //numero de cafés a hacer
    {
        const double CONSUMO = 0.1; // Constante de consumo de agua 0.1l por cada unidad de café. 

        CantidadAguaRecipiente = CantidadAguaRecipiente - numeroCafes * CONSUMO; 

        if (CantidadAguaRecipiente < 0.1) 
        {
            CantidadAguaRecipiente = 0; 
            return "Falta agua en el depósito, por favor, revisar los niveles.";
        }
        else 
        {
            return "Quedan" + CantidadAguaRecipiente + " centilitros";
        }
    }

    ///<summary>
    /// Método para obtener el consumo de capsulas de café
    ///</summary>
    ///<param name="numeroCafes">Valor de tipo double el cual 
    ///específica el número de cafés que se pueden hacer.</param>
    ///<returns> Un string con el total de cápsulas que quedan en la cafetera o un mensaje de alerta</returns>
    ///<remarks>El valor predeterminado para el parámetro 
    ///<paramref name="numeroCafes"></paramref> es de 1 cafes</remarks>
    public string ConsumoCapsulas(double numeroCafes) 
    {
        TotalCapsulas = TotalCapsulas - numeroCafes;
        if (TotalCapsulas < 0) 
        {
            TotalCapsulas = 0; 
            return "Faltan cápsulas en el depósito, por favor, compre cápsulas.";
        }
        else
        {
            return "Quedan" + TotalCapsulas + "unidades";
        }
    }
    ///<summary>
    /// Método para actualizar el total de capsulas de café
    ///</summary>
    ///<param name="cantidadCapsulas">Valor de tipo double el cual 
    ///se suman un determinado número de cápsulas al total que ya teníamos.</param>
    ///<returns> Un double con el total de capsulas que hay</returns>
    public double ReponerCapsulas(double cantidadCapsulas) 
    {
        TotalCapsulas = TotalCapsulas + cantidadCapsulas; 
        return TotalCapsulas;
    }


    ///<summary>
    /// Método para obtener el llenado de agua del recipiente
    ///</summary>
    ///<param name="litros">Valor de tipo double el cual 
    ///se suman un determinado número de litros al total que ya teníamos.</param>
    ///<returns>Un double con los centilitros que quedan por llenar o un mensaje de alterta
    ///de revisión de los niveles</returns>
    ///<returns> Un double con el total de cantidad de agua en litros que hay en el recipiente</returns>
    public double LlenarDeposito(double litros) 
    {
        CantidadAguaRecipiente = CantidadAguaRecipiente + litros;
        return CantidadAguaRecipiente;
    }


}


