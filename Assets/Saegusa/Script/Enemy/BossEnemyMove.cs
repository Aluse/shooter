using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnemyMove : MonoBehaviour
{
    private Vector3 Move;
    
    private bool StandardPosFlag;
    public int typ;
    private   float speed;
    private float step;
    private float time;
    private bool SideFlag;

    Vector3 velocity;
    float angle = 0;
    Vector3 pos;

    public GameObject Player;
    private int Hp;
    private bool AttckFlag;
    private float RandomTime;

    private bool StartFlag;
    // Start is called before the first frame update
    void Start()
    {
        Move = new Vector3(0, 0, 1);
       
        StandardPosFlag = false;
        typ = 1;
        speed = 50;
        step = 10 * Time.deltaTime;
        time = 0;
        SideFlag = false;
        Hp = 50;
        AttckFlag = false;
        RandomTime = 0;
        StartFlag = false;
    }

    

    // Update is called once per frame
    void Update()
    {
       if(StartFlag==false)
        {
            transform.position = Vector3.MoveTowards(this.gameObject.transform.position, new Vector3(0, 1, 8), step);
        }


        if(StandardPosFlag== true)
        {
            switch(typ)
            {
                case 1:
                    StandardPosFlag = false;
                    time = 0;
                    time+= Time.deltaTime;
                    if (gameObject.transform.position.x >= 13 || gameObject.transform.position.x <= -13)
                    {
                        SideFlag = !SideFlag;
                    }
                    if (SideFlag == false)
                    {
                        transform.Translate(-transform.right * speed * Time.deltaTime);
                    }
                    if(SideFlag==true)
                    {
                        transform.Translate(transform.right * speed * Time.deltaTime);
                    }
                    
                    if(time==5)
                    {
                        transform.position = Vector3.MoveTowards(this.gameObject.transform.position, new Vector3(0, 1, 8), step);
                    }

                    break;

                case 2:
                    StandardPosFlag = false;
                    time = 0;
                    time += Time.deltaTime;

                    pos = this.transform.position;
                    velocity = new Vector3((float)Mathf.Cos(angle), 0, (float)Mathf.Sin(angle));//回転させる公式
                                                                                                //回転調整
                    velocity *= 0.2f;
                    angle += 0.05f;
                    transform.position = new Vector3(pos.x, pos.y, pos.z) + velocity;

                    if(time==5)
                    {
                        transform.position = Vector3.MoveTowards(this.gameObject.transform.position, new Vector3(0, 1, 8), step);
                    }

                    break;
                case 3:
                    StandardPosFlag = false;
                    time = 0;
                    time += Time.deltaTime;
                    if (AttckFlag==false)
                    {
                        transform.position = Vector3.MoveTowards(this.gameObject.transform.position, Player.transform.position, step);
                    }
                    
                    if(time==5)
                    {
                        transform.position = Vector3.MoveTowards(this.gameObject.transform.position, new Vector3(0, 1, 8), step);
                    }
                    break;
            }
        }

        
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PlayerBullet")
        {
            Hp--;
        }
        if(collision.gameObject.tag=="Player")
        {
            Hp--;
            AttckFlag = true;
            transform.position = Vector3.MoveTowards(this.gameObject.transform.position, new Vector3(0, 1, 8), step);
        }

        if (collision.gameObject.tag == "BossBasePos")
        {
            RandomTime += Time.deltaTime;
            StartFlag = true;
            StandardPosFlag = true;
            if (RandomTime == 3)
            {
                typ = Random.Range(1, 3);
                RandomTime = 0;
            }

            AttckFlag = false;
        }
    }
}
