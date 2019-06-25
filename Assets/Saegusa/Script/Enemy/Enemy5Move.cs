using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy5Move : MonoBehaviour
{
    private Vector3 Move;
    private bool DeadFlag;
    public GameObject Aitem;
    // Start is called before the first frame update
    void Start()
    {
        Move = Vector3.back;
        DeadFlag = false;
    }

    // Update is called once per frame
    void Update()
    {

        this.gameObject.transform.Translate(Move * 0.1f);

        if (this.gameObject.transform.position.z <= -25)
        {
            Destroy(this.gameObject);
        }

        if(DeadFlag == true)
        {
            Destroy(this.gameObject);
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PlayerBullet")
        {
            DeadFlag = true;
            Instantiate(Aitem, transform.position, Quaternion.identity);
        }
    }
}
