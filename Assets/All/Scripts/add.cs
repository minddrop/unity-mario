using UnityEngine;

public class add : MonoBehaviour
{
    public float thrust;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddForce(-thrust, 0, 0, ForceMode.Impulse);
    }

}
