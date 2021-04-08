using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class UnitController : MonoBehaviour
{
    Camera cam;

    public LayerMask groundLayer;

    public NavMeshAgent playerAgent;

    private RaycastHit hit;

    #region Monobehaviour API
    // Start is called before the first frame update
    void Awake()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject EventSystem = GameObject.Find("EventSystem");
        SelectionDictionary selectionDictionary = EventSystem.GetComponent<SelectionDictionary>();


        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        int layer_mask = LayerMask.GetMask("Terrain");

        if (Physics.Raycast(ray, out hit, (1 << 8), layer_mask))
        {
            if (selectionDictionary.selectedUnit == true)
            {
                if (Input.GetMouseButtonDown(1))
                {
                    playerAgent.transform.position = hit.point;
                }
            }
        }

        

        
    }
    #endregion
   
   





//    private Vector3 GetPointUnderCursor()
//    {
//        Vector2 screenPosition = Input.mousePosition;
//        Vector3 mouseWorldPosition = cam.ScreenToWorldPoint(screenPosition);

//        RaycastHit hitPosition;

//        Physics.Raycast(mouseWorldPosition, cam.transform.forward, out hitPosition, 100, groundLayer);
//        return hitPosition.point;
//    }
}
