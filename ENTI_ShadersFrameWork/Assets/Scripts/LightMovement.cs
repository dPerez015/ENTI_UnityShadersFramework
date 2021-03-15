using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMovement : MonoBehaviour
{
    public GameObject center;
    public float radius = 2;

    // Update is called once per frame
    void Update()
    {
        Vector3 centerPos = center.transform.position;
        transform.position = new Vector3(Mathf.Sin(Time.time)*radius+centerPos.x,transform.position.y, Mathf.Cos(Time.time)*radius+centerPos.z);
    }
}
