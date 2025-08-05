using System.Collections.Generic;

// Asegúrate de que ISimpleList<T> esté definida correctamente en tu proyecto
public class SimpleList<T> : ISimpleList<T>
{
    private List<T> lista = new List<T>();

    public SimpleList()
    {
    }

    // Implementa la propiedad de indexador
    public T this[int index]
    {
        get => lista[index];
        set => lista[index] = value;
    }

    // Implementa Count
    public int Count => lista.Count;

    // Implementa Add
    public void Add(T item)
    {
        lista.Add(item);
    }

    // Implementa AddRange
    public void AddRange(T[] collection)
    {
        lista.AddRange(collection);
    }

    // Implementa Remove
    public bool Remove(T item)
    {
        return lista.Remove(item);
    }

    // Implementa Clear
    public void Clear()
    {
        lista.Clear();
    }
}
