using Unit;
using System.Collections.Generic;

public class SimpleList<T> : ISimpleList
{
	private List <T> lista = new List <T>
	 
	public SimpleList()
	{
	}

	public void AddElement ( T newElemnt){

		lista.add(newElemnt);

	}

	public bool DeleteElement (T DeleteElement){
		return lista.Remove(DeleteElement);
	}
	
}
