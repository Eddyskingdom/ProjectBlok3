using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildPlacementScript : MonoBehaviour
{
    public Vector3 place;
    public GameObject Build;

    private RaycastHit hit;

    public bool placeNow;

    void Start()
    {

    }


    void Update()
    {


        //  if (Input.GetMouseButtonDown(0) && placeNow == true)
        {
            //   if(Physics.Raycast (Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                //    place = new Vector3(hit.point.x, hit.point.y, hit.point.z);
                //   Instantiate(Build, place, Quaternion.identity);
                //   if (Input.GetKey(KeyCode.LeftShift))
                {
                    //      placeNow = true;
                }
                //    else
                {
                    //      placeNow = false;
                    //     Debug.Log("placenow false");

                }
            }
        }
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        int layer_mask = LayerMask.GetMask("Terrain");

        if (placeNow == true)
        {
            if (Physics.Raycast(ray, out hit, (1 << 8), layer_mask))
            {
                Build.transform.position = hit.point;
                if (Input.GetMouseButtonDown(0) && placeNow == true)
                {
                    place = new Vector3(hit.point.x, hit.point.y, hit.point.z);
                    Instantiate(Build, place, Quaternion.identity);
                    if (Input.GetKey(KeyCode.LeftShift))
                    {
                        placeNow = true;
                    }
                    else
                    {
                        placeNow = false;
                        Debug.Log("placenow false");

                    }
                }
            }

        }
    }

    public void placeBuild()
    {
        placeNow = true;
    }
}
