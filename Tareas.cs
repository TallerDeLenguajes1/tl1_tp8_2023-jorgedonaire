namespace EspacioTareas;

public enum Estado
{
    Pendiente = 0,
    Realizado = 1
}
public class Tarea
{
    int tareaID;
    string descripcion;
    int duracion;

    public int TareaID { get => tareaID; set => tareaID = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Duracion { get => duracion; set => duracion = value; }
    
    public Tarea(int tareaID, string descripcion, int duracion)
    {
        this.TareaID = tareaID;
        this.Descripcion = descripcion;
        this.Duracion = duracion;
    }

}