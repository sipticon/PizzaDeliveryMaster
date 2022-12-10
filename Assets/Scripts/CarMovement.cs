using UnityEngine;

public class CarMovement : MonoBehaviour
{
    private float carSpeed = 200f;
    private Rigidbody carRb;
    private float carStartPosition;

    private void Start()
    {
        carRb = GetComponent<Rigidbody>();
        carStartPosition = transform.position.x;
    }

    private void FixedUpdate()
    {
        if(carStartPosition > 0)
            carRb.velocity = Vector3.left * carSpeed * Time.fixedDeltaTime;
        else
            carRb.velocity = -Vector3.left * carSpeed * Time.fixedDeltaTime;
    }
}