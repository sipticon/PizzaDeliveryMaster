using UnityEngine;

public class BicycleMovement : MonoBehaviour
{
    [SerializeField] private VariableJoystick speedJoystick;
    [SerializeField] private Animator pedalsAnimator;
    private float bicycleSpeed = 100f;
    private Rigidbody bicycleRb;

    private void Start()
    {
        bicycleRb = GetComponent<Rigidbody>();
        PlayerPrefs.SetString("Game", "Continue");
    }

    private void Update()
    {
        if (PlayerPrefs.GetString("Game") != "Continue")
            bicycleSpeed = 0;
    }

    private void FixedUpdate()
    {
        float newBicycleSpeed;
        if(speedJoystick.Horizontal < 0)
            newBicycleSpeed = bicycleSpeed + speedJoystick.Horizontal * 200;
        else
            newBicycleSpeed = bicycleSpeed + speedJoystick.Horizontal * 500;
        if (newBicycleSpeed < 0)
            newBicycleSpeed = 0;
        bicycleRb.velocity = Vector3.forward * newBicycleSpeed * Time.fixedDeltaTime;
        pedalsAnimator.SetFloat("Speed",newBicycleSpeed*0.01f);
    }
}