using UnityEngine;
using TMPro;

public class FurUIController : MonoBehaviour
{
    public GameObject FurCanvas;
    public GameObject panel;
    public TextMeshProUGUI detailsText;

    public void ShowUI(FurData furniture)
    {
        FurCanvas.SetActive(true);
        panel.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;


        detailsText.text =
            "Furniture Name: " + furniture.furnitureName + "\n" +
            "Price: " + furniture.price + "\n" +
            "Color: " + furniture.color + "\n" +
            "Size: " + furniture.size + "\n" +
            "Type: " + furniture.type;
    }

    public void HideUI()
    {
        panel.SetActive(false);
        FurCanvas.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }
}