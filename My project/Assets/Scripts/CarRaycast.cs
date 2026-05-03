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
                 if (hit.collider.CompareTag("Car"))
                {
                    CarData car = hit.collider.GetComponentInParent<CarData>();

                    if (car != null)
                    {
                        CarUIController ui = car.GetComponentInChildren<CarUIController>();

                        if (ui != null)
                        {
                            ui.ShowUI(car);
                        }
                    }
                }   
            }
        }   
    }
}