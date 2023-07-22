using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position -= new Vector3(0,0.5f,0);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "SideWall" | other.tag == "Bunker")
        {
            Invader_spawner.SecBulets.Remove(Invader_spawner.SecBulets[0]); 
            Destroy(this.gameObject);
        }
       
    }
    
}
