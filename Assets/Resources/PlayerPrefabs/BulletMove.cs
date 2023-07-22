using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Move();

    }   

    private void Move()
    {
        
            
            this.transform.position += Vector3.up;
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "UpperBorder")
            {PlayerScript.Bulets.Remove(PlayerScript.Bulets[0]);
            Destroy(this.gameObject);}
        if(other.tag == "Enemy")
            {PlayerScript.Bulets.Remove(PlayerScript.Bulets[0]);
            Destroy(this.gameObject);}
        if(other.tag == "Bunker")
            {
            PlayerScript.Bulets.Remove(PlayerScript.Bulets[0]);
            Destroy(this.gameObject);
            }
            
    }
}
