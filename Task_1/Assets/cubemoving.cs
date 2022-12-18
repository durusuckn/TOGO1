using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cubemoving : MonoBehaviour
{
   
    private bool start = false;
    public float speed;
    public int point; 
    public Text puanGoster;
    public GameObject win;
    public GameObject fail;

   
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            start = true;
        }

        if (start == true)
        {
            gameObject.transform.Translate(0, 0, speed * Time.deltaTime);

        }


        if(point==-1){
            fail.SetActive(true);
            speed=0;
        }
        if(point==10){
            win.SetActive(true);
            speed=0;
        } 


    }
        void OnTriggerEnter(Collider other){

            if(other.gameObject.tag=="coin"){
                point++;
                Destroy(other.gameObject);
                puanGoster.text= "SCORE = "+point;
                


            }
            if(other.gameObject.tag=="state"){
                point--;
                Destroy(other.gameObject);
                puanGoster.text= "SCORE = "+point;
                
            }
             
        }

     


       

       
    
}

