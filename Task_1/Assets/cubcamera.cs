using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubcamera : MonoBehaviour
{
    public GameObject Cube;
    public Vector3 aradakifark;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=Cube.transform.position+ aradakifark;
    }
}
