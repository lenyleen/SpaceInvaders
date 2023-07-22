using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asd : MonoBehaviour
{
    // Start is called before the first frame update
     static   public Sprite invader_1;
    static public Sprite invader_2;
   static public Sprite invader_3;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerExit2D(Collider2D other) {
        if(other.tag == "Enemy")
        this.transform.position -=new Vector3(2,0,0);

    }
}
