using UnityEngine;
using System.Collections;


public class MarioController : MonoBehaviour
{
    public float speed;
    public float jump;
    public bool jumpable = true;

    void Start()
    {
    }

    void FixedUpdate()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        float x = Input.GetAxis("Horizontal");
        if (GetComponent<Rigidbody>().velocity.x < 8)
        {
            rigidbody.AddForce(x*speed, 0, 0);
        }
    
        if (Input.GetKey(KeyCode.Space) && jumpable)
        {
            GetComponent<Rigidbody>().AddForce(0,jump,0);
            jumpable = false;
        }       
    }

    public void OnCollisionEnter(Collision other)
    {
        Debug.Log("a");
        if (other.gameObject.CompareTag("Ground"))
        {
            jumpable = true;
            Debug.Log("b");
        }

    }
}