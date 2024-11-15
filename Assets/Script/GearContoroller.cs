using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearContoroller : MonoBehaviour
{
    public GameObject gear1; // 1つ目の歯車
    public GameObject gear2; // 2つ目の歯車
    private float gear1RotationCount = 0; // 1つ目の歯車の回転数

    void Start()
    {

    }

    public float rotationSpeed = 6.0f; // 1秒で6度回転（1分で360度）

    void Update()
    {
        // 歯車を回転させる
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }

}