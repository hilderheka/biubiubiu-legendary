using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mid : MonoBehaviour
{
    public GameObject a;
    public GameObject b;

    void Start()
    {




    
}

    void LateUpdate()
    {

        transform.position = (a.transform.position + b.transform.position) / 2;

    }
}

