using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sphere : MonoBehaviour
{
     Rigidbody rb;
     public bool timeset = true;
     public Text winText;
    public float speed = 2.5f;
    // Rigidbody 형태의 변수 생성
    private float time;
    public Text retryText;
    public Text retryText2;

    void OnCollisionEnter(Collision col){
        if(col.transform.tag == "Car"){
            timeset = false;
            retryText.gameObject.SetActive(true);
        }
        if(col.transform.tag == "River"){
            timeset = false;
            retryText2.gameObject.SetActive(true);
        }   
    }
    // 스크립트가 활성화된 첫 프레임에 호출
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // 프레임을 렌더링 하기 전에 호출
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        float fallSpeed = rb.velocity.y;

        Vector3 velocity = new Vector3(-x, 0, -z);
        
        velocity = velocity * speed;
        velocity.y = fallSpeed;
        if(timeset){
            time += Time.deltaTime;
            winText.text = "현재 점수 : " + this.time;
        }

        rb.velocity = velocity; 
        if(retryText.gameObject.activeSelf == true){
            if(Input.GetMouseButtonDown(0)){
                timeset = true;
                time = 0;
                retryText.gameObject.SetActive(false);
                this.transform.position = new Vector3(610,3,246.5f);
            }
        }
        if(retryText2.gameObject.activeSelf == true){
            if(Input.GetMouseButtonDown(0)){
                timeset = true;
                time = 0;
                retryText2.gameObject.SetActive(false);
                this.transform.position = new Vector3(610,3,246.5f);
            }
        }
    }

}
