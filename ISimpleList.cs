public interface ISimpleList<T>
{
    T this[int index] { get; set; }
    int Count { get; }
    void Add(T item);
    void AddRange(T[] collection);
    bool Remove(T item);
    void Clear();

    // Order methods 
    void BubbleSort(IComparer<T> comparer = null);
    void SelectionSort(IComparer<T> comparer = null);

    // Insertion Sort is suposing that the first element is already sorted, then
    // it takes the next element and inserts it into the sorted sequence
    // at the correct position. It repeats this process until all elements are sorted.
    void InsertionSort(IComparer<T> comparer = null);
}
