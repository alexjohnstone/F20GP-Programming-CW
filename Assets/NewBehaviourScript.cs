using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   float Speed = 5f;                                        //setting player speed 
    // Update is called once per frame
    //setting the speed and the arrow keys to match the respective directions 
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.RightArrow))
       transform.position +=  Speed * Vector3.right;
       if (Input.GetKeyDown(KeyCode.LeftArrow))
       transform.position += Speed * Vector3.left;
       if (Input.GetKeyDown(KeyCode.UpArrow))
       transform.position += Speed * Vector3.forward;
       if (Input.GetKeyDown(KeyCode.DownArrow))
       transform.position += Speed * Vector3.back;
    }
}
