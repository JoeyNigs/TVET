using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 [] - Brackets
 {} - Braces
 () - Parenthsis

Hot Keys:
 - Clear: CTRL + K + D
 - Fold: CTRL + M + O
 - Unfold: CTRL + M + P
 */
public class Player : MonoBehaviour
{
    public string message = "Sunset Shimmer";
    public Rigidbody rigid;

    float speed = 5;
   
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.K))
        {
            rigid.AddForce(Vector3.forward * speed);
        }
    }
}