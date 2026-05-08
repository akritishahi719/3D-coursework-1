using UnityEngine;
using UnityEngine.EventSystems; 

public class FurRaycast : MonoBehaviour
{
    public Camera cam;

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            if (EventSystem.current.IsPointerOverGameObject())
                return;
           
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Hit:" + hit.collider.name);

                if (!hit.collider.CompareTag("Furniture"))
                    return;
                
                FurData furniture = hit.collider.GetComponentInParent<FurData>();

                if (furniture == null)
                    return;
                    
                FurUIController ui = furniture.GetComponentInChildren<FurUIController>(true);

                if (ui != null)
                {
                    ui.ShowUI(furniture);
                }      
            }
        }   
    }
}