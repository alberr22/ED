public interface ISimpleList<T>
{
    T this[int index] { get; set; }
    int Count { get; }
    void Add(T item);
    void AddRange(T[] collection);
    bool Remove(T item);
    void Clear();

    // 🔹 Métodos de ordenación
    void BubbleSort(IComparer<T> comparer = null);
    void SelectionSort(IComparer<T> comparer = null);
    void InsertionSort(IComparer<T> comparer = null);
}
