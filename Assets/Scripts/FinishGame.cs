using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishGame : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Finish")
            PlayerPrefs.SetString("Game", "Finish");
        SceneManager.LoadScene("WinScene");
    }
}