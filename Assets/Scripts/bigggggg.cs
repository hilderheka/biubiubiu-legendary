using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigggggg : MonoBehaviour
{
    public GameObject a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(transform.position,a.transform.position);
        Vector3 targetpos;
        if (dist < 11)
        {
            targetpos = new Vector3(transform.position.x, 1, transform.position.z);
        }
        else
        {
            targetpos = new Vector3(transform.position.x, -2, transform.position.z);
        }
        transform.position = Vector3.Lerp(transform.position, targetpos, 0.01f);
    }
}
