using UnityEngine;
using UnityEngine.UI;

public class SoundOnOff : MonoBehaviour
{
    [SerializeField] private AudioListener cameraAudioListener;
    [SerializeField] private AudioSource musicAudioSource;
    private Image buttonImage;
    private static bool startMusic=true;

    private void Awake()
    {
        if (startMusic)
        {
            PlayerPrefs.SetString("Sound", "True");
            startMusic = false;
        }
    }

    private void Start()
    {
        buttonImage = GetComponent<Image>();
        Change(PlayerPrefs.GetString("Sound") == "True");
    }

    public void ControlSound()
    {
        Change(!cameraAudioListener.enabled);
        PlayerPrefs.SetString("Sound", cameraAudioListener.enabled.ToString());
    }

    private void Change(bool state)
    {
        cameraAudioListener.enabled = state;
        musicAudioSource.enabled = state;
        buttonImage.color = state ? Color.white : Color.red;
    }
}