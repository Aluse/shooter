using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy6Move : MonoBehaviour
{
    Vector3 velocity;
    float angle = 0;
    Vector3 pos;
    float time;
    Vector3 Move;

    public GameObject Aitem2;
    public GameObject Gan;
    private float GanTime = 0f;

    private bool DeadFlag;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        Move = new Vector3(0, 0, 1);
        DeadFlag = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (this.gameObject.transform.position.x <= -20)//画面外に移動してしまったら反対側からでてくるようにしたい
        {
            Vector3 a = this.transform.position;
            this.transform.position = new Vector3(a.x + 19, a.y, a.z);
        }
        if (gameObject.transform.position.x >= 20)
        {
            Vector3 a = this.transform.position;
            this.transform.position = new Vector3(a.x - 19, a.y, a.z);
        }

        time += Time.deltaTime;
        if (time >= 0 && time < 3)
        {
            this.gameObject.transform.Translate(Move * 0.1f);
        }
        else if (time >= 3 && time < 15)
        {
            pos = this.transform.position;
            velocity = new Vector3((float)Mathf.Cos(angle), 0, (float)Mathf.Sin(angle));//回転させる公式
                                                                                        //回転調整
            velocity *= 0.2f;
            angle += 0.05f;
            transform.position = new Vector3(pos.x, pos.y, pos.z) + velocity;
        }
        else if (time >= 15)
        {
            Move = new Vector3(0, 0, -1);
            this.gameObject.transform.Translate(Move * 0.1f);
        }
        if (this.gameObject.transform.position.z >= 30)
        {
            Destroy(this.gameObject);
        }



        GanTime += Time.deltaTime;
        if (GanTime >= 2f)
        {
            Vector3 a = this.transform.position;
            Instantiate(Gan, new Vector3(a.x, a.y, a.z), Quaternion.identity);
            GanTime = 0;
        }

        if (DeadFlag == true)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PlayerBullet")
        {
            DeadFlag = true;
            Instantiate(Aitem2, transform.position, Quaternion.identity);
        }
    }
}
