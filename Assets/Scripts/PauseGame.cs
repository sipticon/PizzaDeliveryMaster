using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    [SerializeField] private Canvas startCanvas;
    [SerializeField] private AudioSource cyclingSound;
    private Canvas gameCanvas;

    private void Start()
    {
        gameCanvas = GetComponentInParent<Canvas>();
    }

    public void MakePause()
    {
        Time.timeScale = 0;
        gameCanvas.enabled = false;
        startCanvas.enabled = true;
        cyclingSound.Pause();
    }
}