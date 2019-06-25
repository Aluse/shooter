using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Move : MonoBehaviour
{
    private  float Speedf = 10f;
    private  float Speed = 15f;
    private float moveTime = 0f;
    private float moveTimeMax = 1;
    private int MoveType;

    public GameObject Gan;
    private float GanTime = 0f;

    private bool DeadFlag;
    // Start is called before the first frame update
    void Start()
    {
        MoveType = 0;
        DeadFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        switch (MoveType)
        {
            case 0://下に直進
                transform.Translate(-transform.forward * Speedf * Time.deltaTime);
                break;
            case 1://左に移動
                transform.Translate(-transform.right * Speed * Time.deltaTime);
                break;
            case 2://右に移動
                transform.Translate(transform.right * Speed * Time.deltaTime);
                break;
        }

        // 時間をカウントし、移動種類を切り替える
        moveTime += Time.deltaTime;

        if (moveTime > moveTimeMax)
        {
            if (MoveType == 0)
            {
                MoveType = Random.Range(1, 3);
            }
            else
            {
                MoveType = 0;
            }
            moveTime = 0f;
        }

        //if(this.gameObject.transform.position.x <=-5|| this.gameObject.transform.position.x >= 5)//画面外に行こうとしたら移動方向を反対にする
        //{
        //    if(MoveType==1)//左に向かっていたら
        //    {
        //        MoveType = 2;//右に向かわせる
        //    }
        //    if(MoveType==2)//右に向かっていたら
        //    {
        //        MoveType = 1;//左に向かわせる
        //    }
        //}

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
        if (this.gameObject.transform.position.z <= -25)
        {
            Destroy(this.gameObject);
        }

        GanTime += Time.deltaTime;
        if (GanTime >= 3f)
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
        }
    }
}
