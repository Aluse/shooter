using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBullet : MonoBehaviour
{
    public float timer;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 5.0f)
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    //何かに当たったら死ぬ
    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
