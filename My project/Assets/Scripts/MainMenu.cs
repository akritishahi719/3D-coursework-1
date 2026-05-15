using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainMenu : MonoBehaviour
{
    public GameObject aboutPanel;
    public GameObject loadingText;

    public void StartGame()
    {
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        loadingText.SetActive(true);

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("ProjectScene");
    }

    public void OpenAbout()
    {
        aboutPanel.SetActive(true);
    }

    public void CloseAbout()
    {
        aboutPanel.SetActive(false);
    }

    public void ExitGame()
    {
        #if UNITY_EDITOR
        EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif

        Debug.Log("Game Closed");
    }
}