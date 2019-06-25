using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    private Vector3 Move;
    // Start is called before the first frame update
    void Start()
    {
        Move = Vector3.back;
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(Move * 0.5f);

        if (this.gameObject.transform.position.z <= -25)
        {
            Destroy(this.gameObject);
        }
    }
}
