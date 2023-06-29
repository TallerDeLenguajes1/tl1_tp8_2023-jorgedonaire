// See https://aka.ms/new-console-template for more information
using EspacioTareas;
using Funciones;

class Program
{
    private static void Main(){
        bool programaOn = true;
        string menu;
        int menuSeleccionado, cantidadTareas;

        var TareasPendientes = new List<Tarea>();
        var TareasRealizadas = new List<Tarea>();
        cantidadTareas = Funciones.Funciones.numeroAleatorio(1,5);


        while (programaOn)
        {
            do
            {
                Console.WriteLine("Elija una opcion:");
                Console.WriteLine("1-Cargar Tareas Pendientes\n2-Modificar estado de las Tareas\n3-Buscar Tareas\n4-Guardar horas trabajadas\n5-Salir");
                menu = Console.ReadLine();
            } while (String.IsNullOrEmpty(menu));
        
            bool control = int.TryParse(menu, out menuSeleccionado);
            if (control)
            {
                switch (menuSeleccionado)
                {
                    case 1:
                        Console.WriteLine("Cantidad de tareas a cargar:" + cantidadTareas);
                        Funciones.Funciones.cargarLista(TareasPendientes, cantidadTareas);
                        break;
                    case 2:
                        if (TareasPendientes.Count == 0)
                        {
                            Console.WriteLine("Lista de tareas pendientes vacia");
                        }else
                        {
                            Funciones.Funciones.moverTarea(TareasPendientes,TareasRealizadas,cantidadTareas);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el texto buscado");
                        string textoIngresado = Console.ReadLine();
                        Console.WriteLine("La tarea encontrada es:");
                        Funciones.Funciones.buscarTarea(TareasPendientes,textoIngresado,cantidadTareas);
                        break;
                    case 4:

                    case 5:
                        programaOn = false;
                        Console.WriteLine("****** Programa Finalizado ******");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}