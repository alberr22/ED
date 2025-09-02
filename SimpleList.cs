using System.Collections.Generic;

public class SimpleList<T> : ISimpleList<T>
{
    private List<T> lista = new List<T>();

    public T this[int index]
    {
        get => lista[index];
        set => lista[index] = value;
    }

    public int Count => lista.Count;
    public void Add(T item) => lista.Add(item);
    public void AddRange(T[] collection) => lista.AddRange(collection);
    public bool Remove(T item) => lista.Remove(item);
    public void Clear() => lista.Clear();

    // 🔹 Ordenación por Burbuja
    public void BubbleSort(IComparer<T> comparer = null)
    {
        comparer ??= Comparer<T>.Default;
        for (int i = 0; i < lista.Count - 1; i++)
        {
            for (int j = 0; j < lista.Count - i - 1; j++)
            {
                if (comparer.Compare(lista[j], lista[j + 1]) > 0)
                {
                    // swap
                    T temp = lista[j];
                    lista[j] = lista[j + 1];
                    lista[j + 1] = temp;
                }
            }
        }
    }

    // 🔹 Ordenación por Selección
    public void SelectionSort(IComparer<T> comparer = null)
    {
        comparer ??= Comparer<T>.Default;
        for (int i = 0; i < lista.Count - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < lista.Count; j++)
            {
                if (comparer.Compare(lista[j], lista[minIndex]) < 0)
                {
                    minIndex = j;
                }
            }
            if (minIndex != i)
            {
                T temp = lista[i];
                lista[i] = lista[minIndex];
                lista[minIndex] = temp;
            }
        }
    }

    // 🔹 Ordenación por Inserción
    public void InsertionSort(IComparer<T> comparer = null)
    {
        comparer ??= Comparer<T>.Default;
        for (int i = 1; i < lista.Count; i++)
        {
            T key = lista[i];
            int j = i - 1;

            while (j >= 0 && comparer.Compare(lista[j], key) > 0)
            {
                lista[j + 1] = lista[j];
                j--;
            }
            lista[j + 1] = key;
        }
    }
}
