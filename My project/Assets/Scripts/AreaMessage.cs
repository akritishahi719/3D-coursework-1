using UnityEngine;
using TMPro;
using System.Collections;

public class AreaMessage : MonoBehaviour
{
    public string message;

    public TextMeshProUGUI messageText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StopAllCoroutines();
            StartCoroutine(ShowMessage());
        }
    }

    IEnumerator ShowMessage()
    {
        messageText.gameObject.SetActive(true);

        messageText.text = message;

        yield return new WaitForSeconds(3f);

        messageText.gameObject.SetActive(false);
    }
}
