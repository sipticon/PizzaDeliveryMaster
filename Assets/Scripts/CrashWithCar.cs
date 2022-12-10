using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashWithCar : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<CarMovement>())
        {
            GetComponent<AudioSource>().Stop();
            collision.gameObject.GetComponent<AudioSource>().Play();
            StartCoroutine(LoadLoseScene());
            PlayerPrefs.SetString("Game", "Lose");
        }
    }
    IEnumerator LoadLoseScene()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("LoseScene");
    }
}