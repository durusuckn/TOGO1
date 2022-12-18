using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMathf : MonoBehaviour
{
   
   
    void Start()
    {
        
    }

    
    void Update()
    {
        var pos = transform.position;
        pos.x= Mathf.Clamp(transform.position.x,-4.51f,4.51f);
        transform.position=pos;

        //Burada değerler arasına pos değeri atandı ve değerleri transfor dğerine eşitledik
}
}