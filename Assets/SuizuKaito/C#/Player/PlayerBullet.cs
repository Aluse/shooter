using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public GameObject Bullet;
    public float power = 1000f;
    public Transform spawnPoint;
    public float timer=0;
    // Start is called before the first frame update
    void Start()
    {
       // Bullet = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += 0.1f;
        if (Input.GetMouseButton(0)&&timer>1.0f)
        {
            GameObject newBullet = Instantiate(Bullet, spawnPoint.position,
          Quaternion.identity) as GameObject;
            newBullet.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 1) * power);
            timer = 0.0f;
        }
    }
   
}
