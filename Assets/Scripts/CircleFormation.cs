using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleFormation : MonoBehaviour
{
    // พรีแฟบที่ต้องการสร้างในรูปแบบวงกลม
    public GameObject prefab;
    // จำนวนของวัตถุ
    public int numberOfObjects = 20;
    // รัศมีของวงกลม
    public float radius = 5f;

    void Start()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            // คำนวณมุมสำหรับแต่ละวัตถุ
            float angle = i * Mathf.PI * 2 / numberOfObjects;
            // คำนวณพิกัด x และ z สำหรับตำแหน่งของวัตถุ
            float x = Mathf.Cos(angle) * radius;
            float z = Mathf.Sin(angle) * radius;
            // กำหนดตำแหน่งของวัตถุ
            Vector3 pos = transform.position + new Vector3(x, 0, z);
            // คำนวณมุมในการหมุนวัตถุ
            float angleDegrees = -angle * Mathf.Rad2Deg;
            // กำหนดการหมุนของวัตถุ
            Quaternion rot = Quaternion.Euler(0, angleDegrees, 0);
            // สร้างวัตถุในตำแหน่งและการหมุนที่กำหนด
            Instantiate(prefab, pos, rot);
        }
    }
}