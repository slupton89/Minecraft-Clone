﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnitySampleAssets.CrossPlatformInput;

public class CharacterControl : MonoBehaviour {

    [SerializeField]
    int moveSpeed;
    [SerializeField]
    int jumpHeight;

    private Rigidbody charRigidbody;
    private Animator anim;

	// Use this for initialization
	void Start () {
        charRigidbody = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 moveChar = new Vector3(CrossPlatformInputManager.GetAxis("Horizontal"), 0, CrossPlatformInputManager.GetAxis("Vertical"));
        transform.position += moveChar * Time.deltaTime * moveSpeed;

        if(charRigidbody.velocity.magnitude == 0) {
            anim.SetBool("IsWalking", false);
        } else {
            anim.SetBool("IsWalking", true);
        }

        if(GameManager.Instance.IsJumping) {
            anim.SetTrigger("Jump");
            transform.Translate(Vector3.up * jumpHeight * Time.deltaTime, Space.World);
            GameManager.Instance.IsJumping = false;
        }

        if (GameManager.Instance.IsPunching) {
            anim.SetTrigger("Punch");
            GameManager.Instance.IsPunching = false;      
        }

        if (GameManager.Instance.IsBuilding) {
            anim.SetTrigger("Punch");
            GameManager.Instance.IsBuilding = false;
        }
    }
}
