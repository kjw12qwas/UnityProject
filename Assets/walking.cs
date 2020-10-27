using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float x = 0f;
        float z = 0f;
        if (Input.GetKey(KeyCode.W)){
            x += 0.4f;
            animator.SetBool("WalkZom", true);
        }
        if (Input.GetKey(KeyCode.S)){
            x -= 0.4f;
            animator.SetBool("WalkZom", true);
        }
        if (Input.GetKey(KeyCode.A)){
            z -= 0.4f;
            animator.SetBool("WalkZom", true);
        }
        if (Input.GetKey(KeyCode.D)){
            z += 0.4f;
            animator.SetBool("WalkZom", true);
        }
        else {
            animator.SetBool("WalkZom",false);
        }
        transform.Translate(new Vector3(z,0f,x) * 0.1f);
    }
}
