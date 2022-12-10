using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] private Canvas gameCanvas;
    [SerializeField] private AudioSource cyclingSound;
    private Canvas startCanvas;
    
    private void Start()
    {
        startCanvas = GetComponentInParent<Canvas>();
    }

    public void StartPlayingGame()
    {
        PlayerPrefs.SetString("Game","Continue");
        Time.timeScale = 1;
        startCanvas.enabled = false;
        gameCanvas.enabled = true;
        cyclingSound.Play();
    }
}