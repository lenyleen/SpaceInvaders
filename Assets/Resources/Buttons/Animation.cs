using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animation : MonoBehaviour
{
    // Start is called before the first frame update
    public  Image chel;
    public Button play;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(chel.transform.position.y == play.transform.position.y)
        {
        play.Select();
        }
    }
}
