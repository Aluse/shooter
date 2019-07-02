using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    
    private bool StandardPosFlag;//最初に出てきたとき初期位置に移動できたかの確認
    private int Hp;
    private float step;//移動するまでの時間
    private bool SideFlag;//左に移動しているか右に移動しているか判定する

    Vector3 pos;//回転移動するときに使う座標の入れ物
    Vector3 velocity;
    float angle = 0;//回転
    private bool AttckFlag;//アタックできる状態か？
    public GameObject Player;

    private float time;//ボスの動きを区切るのに使う
    private int typ;//ボスの動きを決めるもの
    private float backtime;//行動が終わった時に初期値に戻る速度
    private float Gantime;//弾が出る間隔

    public GameObject Gan;

    // Start is called before the first frame update
    void Start()
    {
        step = 10 * Time.deltaTime;
        
        StandardPosFlag = false;
        Hp = 20;
        SideFlag = false;
        AttckFlag = false;
        // typ = Random.Range(1, 2);//3は今は使えないからあとあと実装
        typ = 1;//1以外いまはつかえない
        backtime = 20 * Time.deltaTime;
  
    }

    // Update is called once per frame
    void Update()
    {
        if (StandardPosFlag == false)
        {
            transform.position = Vector3.MoveTowards(this.gameObject.transform.position, new Vector3(0, 1, 5), step);
        }
        else if(StandardPosFlag == true)
        {
            switch (typ)
            {
                case 1:
                  
                    
                    time += Time.deltaTime;
                   

                    if (time >= 5)
                    {
                        time = 0;
                        transform.position = Vector3.MoveTowards(this.gameObject.transform.position, new Vector3(0, 1, 5), backtime);
                        typ = Random.Range(1, 3);
                    }
                    else
                    {
                        SideMove();
                    }

                    break;

                case 2:
                    
                   
                    time += Time.deltaTime;

                   

                    if (time >= 5)
                    {
                        time = 0;
                        transform.position = Vector3.MoveTowards(this.gameObject.transform.position, new Vector3(0, 1, 5), backtime);
                        typ = Random.Range(1, 3);
                    }
                    else
                    {
                        if (transform.position.z >= 12)//回転でどんどん上に行ってしまうから
                        {
                            transform.position = Vector3.MoveTowards(this.gameObject.transform.position, new Vector3(0, 1, 5), backtime);
                        }
                        else
                        {
                            RotationMove();
                        }
                    }

                    break;
                case 3:
                   
                    
                    time += Time.deltaTime;
                    AttckFlag = false;

                    if (AttckFlag==true)
                    {
                        time = 0;
                        transform.position = Vector3.MoveTowards(this.gameObject.transform.position, new Vector3(0, 1, 5), step);
                        typ = Random.Range(1, 3);
                    }
                    else
                    {
                        AttckMove();
                    }
                    break;
            }
        }

        Gantime += Time.deltaTime;
        if(Gantime>=0.5f)
        {
            Instantiate(Gan, transform.position, Quaternion.identity);
            Gantime = 0;
        }

        if(Hp<=0)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        

        if (collision.gameObject.tag == "BossBasePos")
        {
            StandardPosFlag = true;
        }
        if (collision.gameObject.tag == "Player")
        {
            Hp--;
            AttckFlag = true;
            transform.position = Vector3.MoveTowards(this.gameObject.transform.position, new Vector3(0, 1, 5), step);
        }
        if (collision.gameObject.tag == "PlayerBullet")
        {
            Hp--;
        }


    }
    void SideMove()
    {
        if (gameObject.transform.position.x >= 13 || gameObject.transform.position.x <= -13)
        {
            SideFlag = !SideFlag;
        }
        if (SideFlag == false)
        {
            transform.Translate(-transform.right * 10 * Time.deltaTime);
        }
        if (SideFlag == true)
        {
            transform.Translate(transform.right * 10 * Time.deltaTime);
        }
    }

    void RotationMove()
    {
        pos = this.transform.position;
        velocity = new Vector3((float)Mathf.Cos(angle), 0, (float)Mathf.Sin(angle));//回転させる公式
                                                                                    //回転調整
        velocity *= 0.2f;
        angle += 0.05f;
        transform.position = new Vector3(pos.x, pos.y, pos.z) + velocity;
    }
    void AttckMove()
    {
        if (AttckFlag == false)
        {
            transform.position = Vector3.MoveTowards(this.gameObject.transform.position, Player.transform.position, step);
        }
    }
}
