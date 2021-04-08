using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionDictionary : MonoBehaviour
{
    public Dictionary<int, GameObject> selectedTable = new Dictionary<int, GameObject>();
    public bool selectedUnit;
    public void addSelected(GameObject go)
    {


        int id = go.GetInstanceID();

        
        if (!(selectedTable.ContainsKey(id)))
        {

            selectedTable.Add(id, go);
            go.AddComponent<selection_component>();
            Debug.Log("Added " + id + " to selected dict");
            selectedUnit = true;
            Debug.Log("SELECTED UNIT");
        }
    }

    public void deselect(int id)
    {
        Destroy(selectedTable[id].GetComponent<selection_component>());
        selectedTable.Remove(id);
        
    }

    public void deselectAll()
    {
        foreach (KeyValuePair<int, GameObject> pair in selectedTable)
        {-
            if (pair.Value != null)
            {
                Destroy(selectedTable[pair.Key].GetComponent<selection_component>());
            }
        }
        selectedTable.Clear();
    }
}

