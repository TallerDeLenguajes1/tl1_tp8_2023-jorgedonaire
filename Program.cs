using System;
internal class Program
{
    private static void Main(string[] args){
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

            using (StreamWriter archivocsv = new StreamWriter(rutaArchivo))
            {
                archivocsv.WriteLine("Indice , Nombre, Extension");
                for (int i = 0; i < archivosCarpeta.Length; i++)
                {
                    string nombreArchivo = Path.GetFileNameWithoutExtension(archivosCarpeta[i]);
                    string extensionArchivo = Path.GetExtension(archivosCarpeta[i]);
                    archivocsv.WriteLine((i+1)+ "," + nombreArchivo + "," + extensionArchivo);
                }
            }
            
        }else
        {
            Console.WriteLine("Ruta incorrecta o carpeta inexistente");
        } 
        
    }
}