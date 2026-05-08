using UnityEngine;
using UnityEngine.EventSystems; 

public class MotorRaycast : MonoBehaviour
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

                if (!hit.collider.CompareTag("Motor"))
                    return;
                
                MotorData bike = hit.collider.GetComponentInParent<MotorData>();

                if (bike == null)
                    return;
                    
                MotorUIController ui = bike.GetComponentInChildren<MotorUIController>(true);

                if (ui != null)
                {
                    ui.ShowUI(bike);
                }      
            }
        }   
    }
}