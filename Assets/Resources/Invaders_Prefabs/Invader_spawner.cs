using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invader_spawner : MonoBehaviour
{
    
    static public GameObject[,] invaders = new GameObject[5,11];
    
    public GameObject invader_1;
    public GameObject invader_2;
    public GameObject invader_3;
    private GameObject CurrentInv ;
    public GameObject leftEdger;
    public GameObject rightEdger;

    static public  int rows;
    static public int columns;
    Vector3 spawnPosition = new Vector3(-9f,10f,0.0f);
    public AnimationCurve speed;
    static public bool isRight = false;
    static public bool isLeft = false;
   static public  Vector3 direction = Vector3.right;
   static public Transform S ;
   private int CountOfInvadors =>  rows * columns ;
   
   static public int amountKilled;
   public float Percent => (float)amountKilled / (float)CountOfInvadors;
   public GameObject SecBullet;
   
   static public List<Transform> SecBulets;
    private GameObject RandomInv;


    void Start()
    {
        
        
        SecBulets = new List<Transform>(0);
        S = this.transform;
        CurrentInv = invader_1;
        rows = invaders.GetUpperBound(0) + 1;
        columns = invaders.Length / rows;
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                if(i > 1 & i <= 3)
                {
                    CurrentInv =invader_2;
                }
                if(i > 3)
                {
                    CurrentInv = invader_3;
                }
                    invaders[i,j] = Instantiate(CurrentInv, spawnPosition, Quaternion.identity,this.transform);
                    
                    spawnPosition = new Vector3(spawnPosition.x + 2, spawnPosition.y,spawnPosition.z);
                    
               

            }
            spawnPosition = new Vector3(-9f,spawnPosition.y - 2,0.0f);
        }
        
    }


    // Update is called once per frame
    void Update()
    {
        
        this.transform.position += direction * this.speed.Evaluate(Percent) * Time.deltaTime;
       Vector3 leftEdge = Camera.main.ViewportToWorldPoint(Vector3.zero);
        Vector3 rightEdge = Camera.main.ViewportToWorldPoint(Vector3.right);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if(invaders[i,j] == null)
                    {   
                        
                        continue;
                    }
                if (direction == Vector3.right &  invaders[i,j].transform.position.x >= rightEdge.x)
                    {
                        Rotate();
                    }
                else if (direction == Vector3.left & invaders[i,j].transform.position.x <= leftEdge.x)
                    {
                        Rotate();
                    }

            }
            
        }
       
                
                 
                
       
      RandomInv = invaders[Random.Range(0,5), Random.Range(0,11)];
      if(SecBulets.Count == 0)
      {
          if(RandomInv !=null)
          {
              SecBulets.Add(SecBullet.transform);
              Instantiate(SecBullet,RandomInv.transform.position,Quaternion.identity);
          }
          
          

      }
        
               
         
        
                     
                   
                
            
           
        

    }
     public void Rotate()
    {
        direction.x *= -1.0f;
        Vector3 position = this.transform.position;
        position.y -= 1.0f;
        this.transform.position = position;
    }
    
        
    
}
