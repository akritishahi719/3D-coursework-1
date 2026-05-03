using UnityEngine;
using TMPro;

public class CarUIController : MonoBehaviour
{
    public GameObject CarCanvas;
    public GameObject panel;
    public TextMeshProUGUI detailsText;
    //public GameObject player;


    public void ShowUI(CarData car)
    {
        CarCanvas.SetActive(true);
        panel.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        //player.GetComponent<CarUIController>().enabled = false;

        detailsText.text =
            "Car Name: " + car.carName + "\n" +
            "Price: " + car.price + "\n" +
            "Speed: " + car.speed + "\n" +
            "Engine: " + car.engine + "\n" +
            "Color: " + car.color + "\n" +
            "Type: " + car.type;
    }

    public void HideUI()
    {
        panel.SetActive(false);
        CarCanvas.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        //player.GetComponent<CarUIController>().enabled = false;
    }
}