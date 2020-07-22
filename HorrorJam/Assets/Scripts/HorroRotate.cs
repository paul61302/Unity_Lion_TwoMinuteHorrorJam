using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorroRotate : HorrorObject
{
    [Header("旋轉物件")]
    public Transform rota;
    [Header("旋轉角度"), Range(90, 270)]
    public float angle = 120;
    [Header("旋轉速度"), Range(1, 1000)]
    public float speed = 10;

    /// <summary>
    /// 旋轉
    /// </summary>
    public override void TriggerEvent()
    {
        StartCoroutine(rotate());
    }

    private IEnumerator rotate()
    {
        GetComponentInChildren<BoxCollider>().enabled = false;

        float y = rota.localEulerAngles.y;
        float targetY = y + angle;

        // 當 原始 Y < 目標 Y
        while (y < targetY)
        {
            // 角度遞增
            rota.localEulerAngles += Vector3.up * Time.deltaTime * speed;
            y -= Time.deltaTime * speed;
            yield return null;
        }
    }
}
