using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.E))
            //GetKay = endless shooting
            //GetKayDown = shoot once
            //GetKeyUp = Release
        {
            Ray interactRay;
            //Creating a line from the center
            interactRay = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));

            RaycastHit hitInfo;
            if (Physics.Raycast(interactRay, out hitInfo, 10))
            {
                if (hitInfo.collider.CompareTag("Enemy"))
                {
                    Debug.Log("hit Enemy");
                }
            }
        }
	}
}
