using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Glassfall : MonoBehaviour
{
    public GameObject GlassPrefab;
   
    public Transform spawn;
   

    // Start is called before the first frame update
    private void Start()
    {
        //rigidbody = GetComponent<Rigidbody2D>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Ragdoll hit by" + collision.gameObject);

        //spawn thing

       
        Instantiate(GlassPrefab, spawn.position, spawn.rotation);
        
        Destroy(gameObject);

    }
    
}
