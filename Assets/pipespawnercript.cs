using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespawnercript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if  (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
       } 
       else
       {
             Instantiate(pipe, transform.position, transform.rotation); 
             timer = 0;
        }
      
    }
}
