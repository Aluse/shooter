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
    public GameObject Enemy5;
    public GameObject Enemy6;

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
        StartCoroutine(Corutine_Spawn(17, Enemy4, 1));
        StartCoroutine(Corutine_Spawn(18, Enemy4, 1));
        StartCoroutine(Corutine_Spawn(19, Enemy4, 1));
        StartCoroutine(Corutine_Spawn(20, Enemy4, 1));
        StartCoroutine(Corutine_Spawn(20, Enemy1, 3));

        StartCoroutine(Corutine_Spawn(20, Enemy1, 0));
        StartCoroutine(Corutine_Spawn(20, Enemy5, 1));
        StartCoroutine(Corutine_Spawn(20, Enemy1, 2));
        StartCoroutine(Corutine_Spawn(20, Enemy1, 3));
        StartCoroutine(Corutine_Spawn(20, Enemy1, 4));

        StartCoroutine(Corutine_Spawn(21, Enemy2, 0));
        StartCoroutine(Corutine_Spawn(21, Enemy6, 4));
        StartCoroutine(Corutine_Spawn(22, Enemy2, 0));
        StartCoroutine(Corutine_Spawn(23, Enemy2, 3));
        StartCoroutine(Corutine_Spawn(24, Enemy3, 2));
        StartCoroutine(Corutine_Spawn(25, Enemy3, 1));
        StartCoroutine(Corutine_Spawn(26, Enemy4, 4));
        StartCoroutine(Corutine_Spawn(27, Enemy4, 0));
        StartCoroutine(Corutine_Spawn(27, Enemy1, 4));
        StartCoroutine(Corutine_Spawn(27, Enemy2, 3));
        StartCoroutine(Corutine_Spawn(28, Enemy5, 2));
        StartCoroutine(Corutine_Spawn(28, Enemy3, 4));
        StartCoroutine(Corutine_Spawn(29, Enemy2, 0));
        StartCoroutine(Corutine_Spawn(30, Enemy1, 1));

        StartCoroutine(Corutine_Spawn(31, Enemy1, 0));
        StartCoroutine(Corutine_Spawn(31, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(32, Enemy2, 2));
        StartCoroutine(Corutine_Spawn(32, Enemy1, 4));
        StartCoroutine(Corutine_Spawn(33, Enemy3, 3));
        StartCoroutine(Corutine_Spawn(34, Enemy4, 3));
        StartCoroutine(Corutine_Spawn(34, Enemy5, 4));
        StartCoroutine(Corutine_Spawn(35, Enemy1, 3));
        StartCoroutine(Corutine_Spawn(36, Enemy3, 1));
        StartCoroutine(Corutine_Spawn(37, Enemy2, 0));
        StartCoroutine(Corutine_Spawn(37, Enemy2, 4));
        StartCoroutine(Corutine_Spawn(38, Enemy2, 3));
        StartCoroutine(Corutine_Spawn(38, Enemy2, 2));
        StartCoroutine(Corutine_Spawn(39, Enemy2, 2));
        StartCoroutine(Corutine_Spawn(39, Enemy3, 4));
        StartCoroutine(Corutine_Spawn(39, Enemy4, 2));
        StartCoroutine(Corutine_Spawn(40, Enemy6, 3));

        StartCoroutine(Corutine_Spawn(41, Enemy2, 2));
        StartCoroutine(Corutine_Spawn(41, Enemy2, 3));
        StartCoroutine(Corutine_Spawn(42, Enemy2, 1));
        StartCoroutine(Corutine_Spawn(42, Enemy2, 3));
        StartCoroutine(Corutine_Spawn(43, Enemy2, 2));
        StartCoroutine(Corutine_Spawn(44, Enemy2, 4));
        StartCoroutine(Corutine_Spawn(45, Enemy3, 4));
        StartCoroutine(Corutine_Spawn(45, Enemy1, 0));
        StartCoroutine(Corutine_Spawn(45, Enemy3, 0));
        StartCoroutine(Corutine_Spawn(46, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(46, Enemy6, 2));
        StartCoroutine(Corutine_Spawn(46, Enemy1, 3));
        StartCoroutine(Corutine_Spawn(47, Enemy4, 1));
        StartCoroutine(Corutine_Spawn(47, Enemy3, 3));
        StartCoroutine(Corutine_Spawn(47, Enemy5, 1));
        StartCoroutine(Corutine_Spawn(48, Enemy1, 3));
        StartCoroutine(Corutine_Spawn(48, Enemy2, 4));
        StartCoroutine(Corutine_Spawn(48, Enemy2, 1));
        StartCoroutine(Corutine_Spawn(49, Enemy2, 1));
        StartCoroutine(Corutine_Spawn(49, Enemy1, 3));
        StartCoroutine(Corutine_Spawn(50, Enemy1, 1));

        StartCoroutine(Corutine_Spawn(51, Enemy2, 0));
        StartCoroutine(Corutine_Spawn(51, Enemy6, 4));
        StartCoroutine(Corutine_Spawn(52, Enemy2, 0));
        StartCoroutine(Corutine_Spawn(53, Enemy2, 3));
        StartCoroutine(Corutine_Spawn(54, Enemy3, 2));
        StartCoroutine(Corutine_Spawn(55, Enemy3, 1));
        StartCoroutine(Corutine_Spawn(56, Enemy4, 4));
        StartCoroutine(Corutine_Spawn(57, Enemy4, 0));
        StartCoroutine(Corutine_Spawn(57, Enemy1, 4));
        StartCoroutine(Corutine_Spawn(57, Enemy2, 3));
        StartCoroutine(Corutine_Spawn(58, Enemy5, 2));
        StartCoroutine(Corutine_Spawn(58, Enemy3, 4));
        StartCoroutine(Corutine_Spawn(59, Enemy2, 0));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));

        StartCoroutine(Corutine_Spawn(61, Enemy3, 0));
        StartCoroutine(Corutine_Spawn(61, Enemy3, 3));
        StartCoroutine(Corutine_Spawn(61, Enemy4, 2));
        StartCoroutine(Corutine_Spawn(61, Enemy4, 1));
        StartCoroutine(Corutine_Spawn(62, Enemy2, 4));
        StartCoroutine(Corutine_Spawn(62, Enemy2, 1));
        StartCoroutine(Corutine_Spawn(63, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(63, Enemy5, 2));
        StartCoroutine(Corutine_Spawn(64, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(64, Enemy1, 4));
        StartCoroutine(Corutine_Spawn(65, Enemy3, 2));
        StartCoroutine(Corutine_Spawn(66, Enemy2, 4));
        StartCoroutine(Corutine_Spawn(67, Enemy2, 0));
        StartCoroutine(Corutine_Spawn(68, Enemy2, 1));
        StartCoroutine(Corutine_Spawn(68, Enemy4, 0));
        StartCoroutine(Corutine_Spawn(68, Enemy6, 1));
        StartCoroutine(Corutine_Spawn(69, Enemy3, 2));
        StartCoroutine(Corutine_Spawn(69, Enemy4, 1));
        StartCoroutine(Corutine_Spawn(69, Enemy4, 0));
        StartCoroutine(Corutine_Spawn(69, Enemy2, 2));
        StartCoroutine(Corutine_Spawn(69, Enemy2, 4));
        StartCoroutine(Corutine_Spawn(69, Enemy2, 3));
        StartCoroutine(Corutine_Spawn(70, Enemy1, 0));
        StartCoroutine(Corutine_Spawn(70, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(70, Enemy1, 3));
        StartCoroutine(Corutine_Spawn(70, Enemy1, 2));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 2));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 3));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 4));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 2));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 2));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 3));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));

        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));
        StartCoroutine(Corutine_Spawn(60, Enemy1, 1));

    }

    IEnumerator Corutine_Spawn(float Limittime, Object Enemy, int Type )
    {
        yield return new WaitForSeconds(Limittime);

       // Instantiate(Enemy, Pos[Type],Quaternion.identity);
        Instantiate(Enemy, Pos[Type], Quaternion.Euler(0,180,0));

    }



    Vector3[] Pos = new Vector3[]
    {
        new Vector3(-19,1,25),//Pos[0]からPos[4]まではEnemy1とEnemy2用  Pos[0]はEnemy4 も使える
        new Vector3(-10,1,25),//Pos[1]はEnemy4も使える
        new Vector3(0,1,25),//Pos[2]はEnemy3,Enemy4も使える
        new Vector3(10,1,25),//Pos[3]はEnemy3も使える
        new Vector3(19,1,25),//Pos[4]はEnemy3も使える

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
