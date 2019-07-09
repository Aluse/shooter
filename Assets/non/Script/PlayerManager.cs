using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static int Rm;
    Text text;
    // Start is called before the first frame update
    void Awake()
    {
        text = GetComponent<Text>();
        Rm = 3;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "残機:" + Rm;
    }
}
