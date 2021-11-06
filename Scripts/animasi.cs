using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animasi : MonoBehaviour
{
    //var
    private float nilai_x;
    private float nilai_z;
    private bool status_ground;

    //ref
    public  Animator anim;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //anim = GetComponentInChildren<Animator>();
        //player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        nilai_x = player.GetComponent<pergerakan_player>().x;
        nilai_z = player.GetComponent<pergerakan_player>().z;
        status_ground = player.GetComponent<pergerakan_player>().isGrounded;
        anim.SetFloat("x", nilai_x);
        anim.SetFloat("z", nilai_z);
        anim.SetBool("isGrounded", status_ground);
    }
}