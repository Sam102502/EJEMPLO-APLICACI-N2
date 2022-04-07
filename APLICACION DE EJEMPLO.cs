utilizando el sistema;
uso de System.IO;
{
 Programa de clase
    {

        static void Main(string[] args)
        {
 Pedimos nombre del Archivo
            Console.WriteLine("Ingrese Nombre del Archivo");
 Arco de cadena = Console.ReadLine();

 Abrimos o Creamos un Archivo si no existe.
            Stream Archivo = new FileStream("./" + Arc + ".txt", FileMode.OpenOrCreate);

 Escribimos en nuestro Archivo mediante StramWrite
 StreamWriter Escribir = nuevo StreamWriter(Archivo);

            Console.WriteLine("Ingres texto para escribir en: " + Arc + ".txt");
 Texto de cadena = Console.ReadLine();

            Escribir.WriteLine(Texto);

 Cerramos
            Escribir.Close();
            Archivo.Close();

 Abrimos o Creamos un Archivo si no existe.
            Stream Archivo2 = new FileStream("./" + Arc + ".txt", FileMode.OpenOrCreate);
            Console.WriteLine("\nLectura:\n");

 Leemos nuestro archivo mediante StreamReader
 StreamReader Leer = nuevo StreamReader(Archivo2);
            Console.WriteLine(Leer.ReadToEnd());

 Cerramos
            Leer.Close();
            Archivo2.Close();

        }
    }
}