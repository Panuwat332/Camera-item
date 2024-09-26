using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Renny1Movement : MonoBehaviour
{
    // Start is called before the first frame update
    CharacterController characterController;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
        anim.SetBool("isidle", false);
        anim.SetBool("isdancing", false);
        anim.SetBool("isstab", false);

        Time.timeScale = 1;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)){
            anim.SetBool("isdancing", true);
            anim.SetBool("isstab", false);
            anim.SetBool("isidle", false);
        }else if (Input.GetKey(KeyCode.D)){
            anim.SetBool("isstab", true);
            anim.SetBool("isdancing", false);
            anim.SetBool("isidle", false);
        }else if (Input.GetKey(KeyCode.S)){
            anim.SetBool("isidle", true);
            anim.SetBool("isdancing", false);
            anim.SetBool("isstab", false);
        }
    }
}
