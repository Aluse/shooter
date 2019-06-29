using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnemyMove : MonoBehaviour
{
    private Vector3 Move;
    private bool DeadFlag;
    private bool StandardPosFlag;
    public int a;
    public  float speed;
    private float step;
    private float time;
    private bool SideFlag;

    Vector3 velocity;
    float angle = 0;
    Vector3 pos;

    public GameObject Player;
    private int Hp;

    // Start is called before the first frame update
    void Start()
    {
        Move = new Vector3(0, 0, 1);
        DeadFlag = false;
        StandardPosFlag = false;
        a = 0;
        speed = 2;
        step = 2 * Time.deltaTime;
        time = 0;
        SideFlag = false;
        Hp = 50;
    }

    // Update is called once per frame
    void Update()
    {
       

        if(gameObject.transform.position.z>=9&&gameObject.transform.position.z<=8&&gameObject.transform.position.x<=-1&& gameObject.transform.position.x >= 1)
        {
            StandardPosFlag = true;
            a = Random.Range(1, 3);
        }

        if(StandardPosFlag== true)
        {
            switch(a)
            {
                case 1:
                    StandardPosFlag = false;
                    time = 0;
                    time+= Time.deltaTime;
                    if (gameObject.transform.position.x <= 13 || gameObject.transform.position.x >= -13)
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
                    break;
            }
        }

        
    }
}
