using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public bool IsActive= false;


    public void SetActive()
    {
        IsActive = true;
       // transform.gameObject.SetActive(true);
    }

    public void SetDeactive()
    {
        IsActive = false;
        this.gameObject.SetActive(false);
    }
}
