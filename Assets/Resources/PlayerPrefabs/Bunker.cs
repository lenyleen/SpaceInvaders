using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bunker : MonoBehaviour
{
    // Start is called before the first frame update
    private int HP = 7;
    public SpriteRenderer spriteRenderer { get; private set; }
    public Sprite[] animationSprites = new Sprite[8];
    public int animationFrame { get; private set; } 
    
    private void Awake()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        this.spriteRenderer.sprite = this.animationSprites[7];
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        if(HP < 0)
            this.gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Missele")
        {
            HP--;
            this.spriteRenderer.sprite = this.animationSprites[HP];
        }
        
    }
}
