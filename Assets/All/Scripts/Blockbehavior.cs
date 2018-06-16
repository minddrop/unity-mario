using UnityEngine;
using System.Collections;

public class Blockbehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.CompareTag("Mario") )
        {
            //向きを変えるやつ
            Destroy(this.gameObject);
        }
    }
}
