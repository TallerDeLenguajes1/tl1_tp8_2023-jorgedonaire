class Program
{
    private static void Main(){
        string rutaCarpeta;
        do
        {
            Console.WriteLine("Ingrese la ruta de la carpeta");
            rutaCarpeta = @Console.ReadLine();
            //@"D:\Jorge\Facultad\Programacion\TallerdeLenguaje1"
        } while (string.IsNullOrEmpty(rutaCarpeta));
              
        if (Directory.Exists(rutaCarpeta))
        {
            Console.WriteLine("**** Listado de archivos existentes en la carpeta *****");
            var archivosCarpeta = Directory.GetFiles(rutaCarpeta);

            foreach (var archivo in archivosCarpeta)
            {
                Console.WriteLine(archivo);
            }

            string rutaArchivo = "index.csv";
        }else
        {
            Console.WriteLine("Ruta incorrecta o carpeta inexistente");
        } 
        
    }
}