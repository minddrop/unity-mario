using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class NokonokoMoving : MonoBehaviour {

    public float thrust;
    public Rigidbody rb;
    public float speed1;
    public float speed2;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();

    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void FixedUpdate()
    {
        if (rb.velocity.x < speed1&&rb.velocity.x>speed2)
        {


            rb.AddForce(-thrust, 0, 0, ForceMode.Impulse);
        }








    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Enemy"))
        {
            //向きを変えるやつ
            thrust = -thrust;
        }
    }
}
