using EspacioTareas;
namespace Funciones;

class Funciones
{
    public static int numeroAleatorio(int minimo, int maximo){
        Random aleatorio = new Random();
        return aleatorio.Next(minimo,maximo);
    }

    public static void cargarLista(List<Tarea> TareasPendientes, int cantidadTareas){
        string descripcion, tiempoIngresado;
        int tiempo;

        for (int i = 0; i < cantidadTareas; i++)
        {
            Console.WriteLine("Tarea nro: "+ (i+1));

            do
            {
                Console.WriteLine("Ingrese descripcion:");
                descripcion = Console.ReadLine();
            } while (string.IsNullOrEmpty(descripcion));

            do
            {
                Console.WriteLine("Ingrese tiempo de duracion: ");
                tiempoIngresado = Console.ReadLine();
            } while (String.IsNullOrEmpty(tiempoIngresado));

            bool control = int.TryParse(tiempoIngresado, out tiempo);

            if (control)
            {
                Tarea nuevaTarea = new Tarea(i,descripcion,tiempo);
                TareasPendientes.Add(nuevaTarea);
                Console.WriteLine();
            }else
            {
                Console.WriteLine("Error al ingresar duracion");
                i--;
            }
        }
    }

    public static void moverTarea(List<Tarea>listaOrigen, List<Tarea>listaDestino, int cantidadTareas){
        string idTareaMoverIngresado;
        int idTareaMover;
        Console.WriteLine("******** Lista de Tareas Pendientes **********");
        mostrarLista(listaOrigen);
        Console.WriteLine("Ingrese el Nro de la tarea a mover: ");
        idTareaMoverIngresado = Console.ReadLine();
        bool control = int.TryParse(idTareaMoverIngresado, out idTareaMover);
        if (control)
        {   
            var tareaMarcada = listaOrigen[idTareaMover];
            listaDestino.Add(tareaMarcada);
            listaOrigen.Remove(tareaMarcada);
        }
    }

    public static void mostrarTarea(Tarea tareaSolicitada){
        Console.WriteLine("Nro de Tarea: "+tareaSolicitada.TareaID);
        Console.WriteLine("Descripcion de la Tarea: "+tareaSolicitada.Descripcion);
        Console.WriteLine("Duracion de la Tarea: "+tareaSolicitada.Duracion);
        Console.WriteLine("**********");
    }

    public static void mostrarLista(List<Tarea> listaSolicitada){
        foreach (var tarea in listaSolicitada)
        {
            mostrarTarea(tarea);
        }
    }

    public static void buscarTarea(List<Tarea>tareasPendientes, string palabraBuscada, int cantidadTareas){
        for (int i = 0; i < cantidadTareas; i++)
        {
            string descripcionDeTarea = tareasPendientes[i].Descripcion;
            bool resultadoBusqueda = descripcionDeTarea.Contains(palabraBuscada);
            if (resultadoBusqueda)
            {
                mostrarTarea(tareasPendientes[i]);
            }
        }
    }
}