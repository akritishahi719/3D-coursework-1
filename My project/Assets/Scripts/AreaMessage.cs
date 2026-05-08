using UnityEngine;

public class AreaMessage : MonoBehaviour
{
    public string message;

    private bool showMessage = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            showMessage = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            showMessage = false;
        }
    }

    private void OnGUI()
    {
        if (showMessage)
        {
            GUIStyle style = new GUIStyle();

            style.fontSize = 30;
            style.normal.textColor = Color.white;
            style.alignment = TextAnchor.UpperCenter;

            GUI.Label(
                new Rect(0, 20, Screen.width, 50),
                message,
                style
            );
        }
    }
}