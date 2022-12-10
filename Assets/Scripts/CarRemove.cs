using UnityEngine;

public class CarRemove : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "RemovePoint")
            Destroy(gameObject);
    }
}