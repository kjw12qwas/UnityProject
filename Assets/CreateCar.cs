using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCar : MonoBehaviour
{
    public GameObject car;
    public float time = 3.0f;
    public float curtime = 0.0f;
    // Start is called before the first frame update
    public float DestroyTime = 5.0f;
    void Start ()
    {

    }

    // Update is called once per frame
    void Update()
    {
        curtime += Time.deltaTime;
            if (curtime >= time){
                Instantiate(car ,transform.position,transform.rotation);
                curtime = 0;
            }
             
    }

    
}
