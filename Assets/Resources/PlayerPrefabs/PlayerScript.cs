using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed;
    private Vector3 speedofMove;
    public GameObject bullet;

    static public Transform pos;
    static public List<Transform> Bulets;
    static public int LifeCount = 3;
    private void Start() {
        speed = 0.3f;
        speedofMove = new Vector3(speed,0,0);
        Bulets = new List<Transform>(1);
        
    }
    private void Update() 
    {
            
            Shoot();
            
    }
    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.RightArrow) && this.transform.position.x < 14)
            this.transform.position += speedofMove;

        if (Input.GetKey(KeyCode.LeftArrow) && this.transform.position.x > -14 )
            this.transform.position -= speedofMove;
    }
    private void Shoot()
    {
        if(Input.GetKeyDown(KeyCode.Space) & Bulets.Count == 0)
        {
            Bulets.Add(bullet.transform);
            Instantiate(bullet, this.transform.position, Quaternion.identity);
            
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Missele")
        {
            LifeCount--;
        }
        
    }
    
    
    
}
