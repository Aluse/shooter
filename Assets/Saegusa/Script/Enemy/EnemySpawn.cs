using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    float time;
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Enemy4;
    List<int> enemyTyp;//敵の種類を指定するための数字
   // private bool SpawnFlug;//スポーンしたらtrueになる
    List<Object> EnemyList;                       
   // public float SpawnNextTime;//　次に敵が出現するまでの時間
    List<int> PosTyp;//敵がスポーンする座標を指定する数字
    //int a, b,c;//aはenemyTypの入れ物　　bはPosTypの入れ物   cはSpawnNextTimeの入れ物
    List<int> SpawnNextTime;



    // Start is called before the first frame update
    void Start()
    {
        EnemyList = new List<Object>();
        PosTyp = new List<int>();
        SpawnNextTime = new List<int>();

        EnemyList.Add(Enemy1);
        EnemyList.Add(Enemy2);
        EnemyList.Add(Enemy1); 
        ////a = 0;
        ////b = 0;
        ////c = 0;
       // SpawnFlug = false;
        time = 0;
       
        PosTyp.Add(0);
        PosTyp.Add(0);
        PosTyp.Add(0);
        SpawnNextTime.Add(1);
        SpawnNextTime.Add(2);
        SpawnNextTime.Add(3);

        //Spawn(10, Enemy2, 0,SpawnFlug);
        //Debug.Log("敵だー");
        //Spawn(1, Enemy2, 0,SpawnFlug);
        //Debug.Log("追加の敵だ");
        //Spawn(1, Enemy2, 1,SpawnFlug);
        //Spawn(1, Enemy2, 2,SpawnFlug);
        //Spawn(1, Enemy2, 0,SpawnFlug);
        //Invoke("Spawn", 10);
        StartCoroutine(Corutine_Spawn(1, Enemy1, 0));
        StartCoroutine(Corutine_Spawn(2, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(3, Enemy1, 2));
        StartCoroutine(Corutine_Spawn(4, Enemy1, 3));
        StartCoroutine(Corutine_Spawn(5, Enemy1, 4));
        StartCoroutine(Corutine_Spawn(6, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(7, Enemy1, 4));
        StartCoroutine(Corutine_Spawn(7, Enemy1, 3));
        StartCoroutine(Corutine_Spawn(8, Enemy1, 2));
        StartCoroutine(Corutine_Spawn(9, Enemy1, 1));

        StartCoroutine(Corutine_Spawn(10, Enemy2, 3));
        StartCoroutine(Corutine_Spawn(10, Enemy2, 0));
        StartCoroutine(Corutine_Spawn(10, Enemy2, 4));
        StartCoroutine(Corutine_Spawn(11, Enemy3, 3));
        StartCoroutine(Corutine_Spawn(12, Enemy3, 3));
        StartCoroutine(Corutine_Spawn(13, Enemy3, 3));
        StartCoroutine(Corutine_Spawn(14, Enemy3, 3));
        StartCoroutine(Corutine_Spawn(15, Enemy3, 3));
        StartCoroutine(Corutine_Spawn(16, Enemy2, 2));

    }

    IEnumerator Corutine_Spawn(float Limittime, Object Enemy, int Type )
    {
        yield return new WaitForSeconds(Limittime);

        Instantiate(Enemy, Pos[Type], Quaternion.identity);

       
    }



    Vector3[] Pos = new Vector3[]
    {
        new Vector3(-15,1,25),//Pos[0]からPos[4]まではEnemy1とEnemy2用  Pos[0]はEnemy4 も使える
        new Vector3(-13,1,25),//Pos[1]はEnemy4も使える
        new Vector3(0,1,25),//Pos[2]はEnemy3,Enemy4も使える
        new Vector3(13,1,25),//Pos[3]はEnemy3も使える
        new Vector3(15,1,25),//Pos[4]はEnemy3も使える

    };
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        //if (time >= 15)
        //{
        //    switch (EnemyType)
        //    {
        //        case 1:
        //    Instantiate(Enemy1, new Vector3(Random.Range(-5,5), 1, 10), Quaternion.identity);
        //            time = 0;
        //            EnemyType = 2;
        //        break;

        //        case 2:
        //    Instantiate(Enemy2, new Vector3(0, 1, 10), Quaternion.identity);
        //            time = 0;
        //            EnemyType = 1;
        //            break;
        //    }
        // }



        //開始10秒で5体出てくる
        //Spawn(10, Enemy2, 0,SpawnFlug);
        //Debug.Log("敵だー");
        //Spawn(1, Enemy2, 0,SpawnFlug);
        //Debug.Log("追加の敵だ");
        //Spawn(1, Enemy2, 1,SpawnFlug);
        //Spawn(1, Enemy2, 2,SpawnFlug);
        //Spawn(1, Enemy2, 0,SpawnFlug);





        //↓試してるやつ

        //　経過時間が経ったら
        //if (c < SpawnNextTime.Count)
        //{
        //    if (time > SpawnNextTime[c])
        //    {
        //        time = 0f;

        //        Spawn2();
        //        c++;
        //    }
        //}
    }
    //void Spawn(float Limittime, Object Enemy, int Typ,bool a)
    //{
    //    if (time >= Limittime&&SpawnFlug== false)
    //    {
    //        Debug.Log("敵出現");
    //        Instantiate(Enemy, Pos[Typ], Quaternion.identity);
    //        SpawnFlug = true;
    //        time = 0;
    //    }
    //}

    //void Spawn2()
    //{
    //    Instantiate(EnemyList[a], Pos[b], Quaternion.identity);
    //    a++;
    //    b++;
    //}
}
