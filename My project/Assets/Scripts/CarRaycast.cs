using UnityEngine;
using UnityEngine.EventSystems; 

public class CarRaycast : MonoBehaviour
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

                if (!hit.collider.CompareTag("Car"))
                    return;
                
                CarData car = hit.collider.GetComponentInParent<CarData>();

                if (car == null)
                    return;
                    
                CarUIController ui = car.GetComponentInChildren<CarUIController>(true);

                if (ui != null)
                {
                    ui.ShowUI(car);
                }      
            }
        }   
    }
}