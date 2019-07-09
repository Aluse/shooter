using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouseController : MonoBehaviour
{
    [SerializeField]
    private GameObject moveobject = null;
    void Update()
    {
        Vector3 touchScreenPosition = Input.mousePosition;
        touchScreenPosition.z = 20;//カメラとの距離

        Camera gamecamera = Camera.main;
        Vector3 touchWorldPosition = gamecamera.ScreenToWorldPoint(touchScreenPosition);
        moveobject.transform.position = touchWorldPosition;
    }
    //void OnMouseDrag()
    //{
    //    Vector3 objectPointInScreen =
    //        Camera.main.WorldToScreenPoint(this.transform.position);

    //    Vector3 mousePointINScreen = new Vector3(Input.mousePosition.x, objectPointInScreen.y, Input.mousePosition.z);

    //    Vector3 mousePointInWorld = Camera.main.ScreenToWorldPoint(mousePointINScreen);
    //    mousePointInWorld.z = this.transform.position.z;
    //    this.transform.position = mousePointInWorld;
    //}
}
