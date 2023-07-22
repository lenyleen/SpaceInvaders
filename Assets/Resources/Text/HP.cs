using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    // Start is called before the first frame update
    public Text HPayer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HPayer.text = $"{PlayerScript.LifeCount}";
        
    }
}
