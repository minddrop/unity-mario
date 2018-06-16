using UnityEngine;

public class ENEMYScript : MonoBehaviour
{


    void Start()
    {

    }
    void Update()

    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.GetComponent<Rigidbody>().AddForce(0, 0, 2);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.GetComponent<Rigidbody>().AddForce(0, 0, -2);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.GetComponent<Rigidbody>().AddForce(2, 0, 0);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.GetComponent<Rigidbody>().AddForce(-2, 0, 0);

    }
}
