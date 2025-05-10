using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidar : MonoBehaviour
{

    public GamePlayManagar Ref_GamePlayManagar;


    public void Start()
    {
        Ref_GamePlayManagar = GamePlayManagar.Instance;
    }
    public void OnTriggerEnter(Collider other)
    {

        Ref_GamePlayManagar.ReActive(transform.parent.gameObject);
      //  Ref_GamePlayManagar.DeActiveGameObject(transform.parent.gameObject);
       // Ref_GamePlayManagar.ActiveGameObject();
    }
}
