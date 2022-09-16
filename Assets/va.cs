using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class va : MonoBehaviour
{
    float rx;
    float ry;
    public float rotSpeed = 50;

    public Transform body;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");
        rx += rotSpeed * my * Time.deltaTime;
        ry += rotSpeed * mx * Time.deltaTime;
        print(mx + "," +my);

        rx = Mathf.Clamp(rx, -30, 30);

        transform.eulerAngles = new Vector3(-rx, ry, 0);
        body.transform.eulerAngles = new Vector3(0, ry, 0);
    }
}
