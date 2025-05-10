using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody Player_Rigidbody;
    float Speed = 10.0f;
    float Direction = 100.0f;
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            Player_Rigidbody.AddForce(new Vector3(Direction, 0, 0));
        }
        if(Input.GetKeyDown(KeyCode.A)) 
        {
            Player_Rigidbody.AddForce(new Vector3(-Direction, 0, 0));
        }

        Player_Rigidbody.AddForce(new Vector3(0,0,Speed));
    }
}
