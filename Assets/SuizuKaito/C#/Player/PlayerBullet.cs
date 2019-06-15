using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public GameObject Bullet;
    public float power = 1000f;
    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
       // Bullet = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            GameObject newBullet = Instantiate(Bullet, spawnPoint.position,
          Quaternion.identity) as GameObject;
            newBullet.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 1) * power);
        }
    }
}
