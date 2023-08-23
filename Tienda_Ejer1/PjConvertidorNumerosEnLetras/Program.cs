String[] unidades =
{
    "Cero",
     "Uno",
      "Dos",
       "Tres",
        "Cuatro",
         "Cinco",
      "Seis",
     "Siste",
     "Ocho",
     "Nueve"
};

String[] decenas =
{
    "",
    "Diez",
    "Veinte",
    "Treinta",
    "Cuarenta",
    "Cicuenta",
    "Sesenta",

    "Setenta",
    "Ochenta",
    "Noventa"

};

String[] especiales =
{
    "",
    "Once",
    "Doce",
    "Trece",
    "Catorce",
    "Quince",
    "Dieciseis",
    "Diecisieste",
    "Dieciocho",
    "Diecinueve"
    

};
String[] centenas =
{
    "",
    "Cien",
    "Docientos",
     "Trecientos",
     "Cuatrocientos",
      "Qinientos",
       "Seiscientos",
        "Setecientos",
         "Ochocientos",
          "Novecientos",
};

int numero;
do
{
    Console.WriteLine("Ingrese un numero del 1-9999");
    if (int.TryParse(Console.ReadLine(), out numero))
    {
        if (numero >= 0 && numero <= 9999)
        {
            
           

            string numeroEnLetras = ConvertirNumerosEnLetras(numero);
            Console.WriteLine("El numero " + numero + " en letras es =" + numeroEnLetras);

        }
        else
        {
            Console.WriteLine("El numero ingresado esta fuera de rango");
        }
    }
    else
    {
        Console.WriteLine("El número ingresado es invalido. Ingrese un número válido");
    } 
} while (true);

string ConvertirNumerosEnLetras(int numero)
{
    if (numero == 0) 
    { 
    return "cero";
    }

    String numeroEnLetras = "";
   

    //Procesar las unidades de millar 

    int unidadesDeMillar = numero / 1000 ;
    if (unidadesDeMillar > 0)
    {
        if (unidadesDeMillar == 1000)
        {
            numeroEnLetras = "Mil";
        }
        else
        {
           
            numeroEnLetras += unidades[unidadesDeMillar] + "mil";
            numero %= 1000;
        }
    }
    // Unidades especiales
    int numerosEspeciales = numero / 10;
    if (numerosEspeciales >= 11 && numerosEspeciales <= 19)
    {

    }
    // Unidades de centena 
    int parteCentena = numero / 100;
    if (parteCentena > 0)
    {
        numeroEnLetras += centenas[parteCentena] + " ";
        numero %= 100;
    }
    // unidades de decena 
    int parteDecena = numero / 10;
    if (parteDecena > 0)
    {
        numeroEnLetras += decenas[parteDecena] + "";
        numero %= 10;
    }
    // unidades de 10

    int parteUnidad = numero;
    if (parteUnidad > 0)
    {
        numeroEnLetras += unidades[parteUnidad] + "";
       
    }

    return numeroEnLetras;
}