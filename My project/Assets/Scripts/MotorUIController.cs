using UnityEngine;
using TMPro;

public class MotorUIController : MonoBehaviour
{
    public GameObject MotorCanvas;
    public GameObject panel;
    public TextMeshProUGUI detailsText;


    public void ShowUI(MotorData bike)
    {
        MotorCanvas.SetActive(true);
        panel.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;


        detailsText.text =
            "Motor Cycle Name: " + bike.motorcycle_Name + "\n" +
            "Price: " + bike.price + "\n" +
            "Speed: " + bike.speed + "\n" +
            "Engine: " + bike.engine + "\n" +
            "Color: " + bike.color ; 
    }

    public void HideUI()
    {
        panel.SetActive(false);
        MotorCanvas.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }
}
