using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rigidPlayer;
    public float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        rigidPlayer = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        transform.Translate(x * speed, 0, 0);
        transform.Translate(0 , 0, y * speed);
    }
}
