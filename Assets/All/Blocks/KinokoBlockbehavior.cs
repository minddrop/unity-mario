using UnityEngine;
using System.Collections;

public class KinokoBlockbehavior : MonoBehaviour {

    public GameObject prefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Mario") )
        {
            Instantiate(prefab, transform.position +new Vector3(5, -0.8f, 0), Quaternion.identity);

        }
    }
}
