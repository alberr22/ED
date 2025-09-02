using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ListController : MonoBehaviour
{
    public Button sortButton;
    public TextMeshProUGUI listText;
    public Button addButton;
    public Button removeButton;
    public Button clearButton;
    public Button showButton;

    private List<string> itemList = new List<string>();

    void Start()
    {

        Debug.Log("Esta entrando en start");
        if (addButton != null) addButton.onClick.AddListener(AddItem);
        if (removeButton != null) removeButton.onClick.AddListener(RemoveItem);
        if (clearButton != null) clearButton.onClick.AddListener(ClearList);
        if (showButton != null) showButton.onClick.AddListener(ShowList);
    }

    void AddItem()
    {
        itemList.Add("Elemento " + (itemList.Count + 1));
        Debug.Log("Elemento añadido");
        ShowList();
        Debug.Log("te ha enseñadp la lista");
    }

    void RemoveItem()
    {
        if (itemList.Count > 0)
        {
            itemList.RemoveAt(itemList.Count - 1);
            Debug.Log("Elemento eliminado");
            ShowList();
            Debug.Log("Te ha enseñado la lista");

        }
    }

    void ClearList()
    {
        itemList.Clear();
        Debug.Log("Lista vaciada");
        ShowList();
        Debug.Log("Te ha enseñado la lista");
    }

    public void ShowList()
    {
        if (listText == null)
        {
            Debug.LogError("listText está vacío (null). ¡Así no se puede mostrar la lista!");
            return;
        }

        if (itemList.Count == 0)
        {
            listText.text = "La lista está vacía.";
            return;
        }

        listText.text = "Elementos:\n";
        foreach (var item in itemList)
        {
            listText.text += "- " + item + "\n";
        }

    }

    void Start()
    {
        if (sortButton != null) sortButton.onClick.AddListener(SortList);
    }

    void SortList()
    {
        itemList.BubbleSort(); // o SelectionSort(), o InsertionSort()
        Debug.Log("Lista ordenada con BubbleSort");
        ShowList();
    }

}
