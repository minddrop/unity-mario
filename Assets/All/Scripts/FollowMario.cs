using UnityEngine;
using System.Collections;

public class FollowMario : MonoBehaviour
{
    public Transform mario;
    private Vector3 offset;

    void Start()
    {
        offset = GetComponent<Transform>().position - mario.position;
    }

    void Update()
    {
        GetComponent<Transform>().position = mario.position + offset;
    }
}
