using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public GameObject Bullet;
    public float power = 1000f;
    public Transform spawnPoint;
    public float timer=0;
    bool diffusion;
    // Start is called before the first frame update
    void Start()
    {

        diffusion = false;
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
            if (diffusion)
            {
                GameObject newRightBullet = Instantiate(Bullet, spawnPoint.position - new Vector3(1, 0, 0),
          Quaternion.identity) as GameObject;
                newRightBullet.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 1) * power);
                GameObject newLeftBullet = Instantiate(Bullet, spawnPoint.position - new Vector3(-1, 0, 0),
          Quaternion.identity) as GameObject;
                newLeftBullet.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 1) * power);

            }
            timer = 0.0f;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.tag = "AItem1";
        {
            diffusion = true;
        }
    }



}
