using System.Collections;
using System.Collections.Generic;
using Unity.Entities.UniversalDelegates;
using UnityEditor.Build.Pipeline.Interfaces;
using UnityEngine;

public class GamePlayManagar : MonoBehaviour
{
   public List<GameObject> Ground = new List<GameObject>();
    public Vector3 LastGroundPostion;


    public static GamePlayManagar Instance;

    public void Awake()
    {
        Instance = this;
    }

    public void Start()
    {
      
    }
 
    public void ReActive(GameObject gameObject)
    {
        for (int i = 0; i < Ground.Count; i++)
        {
            if (Ground[i] == gameObject)
            {
                Ground[i].transform.localPosition = LastGroundPostion + new Vector3(0, 0, 100);
                LastGroundPostion = Ground[i].transform.localPosition;
                return;

            }
        }
    }
}
