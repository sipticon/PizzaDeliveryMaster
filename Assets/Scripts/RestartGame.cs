using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    [SerializeField] private Canvas startCanvas;
    private Canvas pausetCanvas;
    
    private void Start()
    {
        pausetCanvas = GetComponentInParent<Canvas>();
    }

    public void RestartPlayingGame()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene("GameScene");
    }
}
