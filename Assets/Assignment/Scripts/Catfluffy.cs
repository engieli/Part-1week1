using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catfluffy : MonoBehaviour
{
    public GameObject CatfluffyPrefab;
    public Transform Catspawn;
    public GameObject Catblocker;
    public GameObject Blackcat;
    private bool collided = true;
    public SpriteRenderer catRenderer;
    private float time = 10;


    public Transform spawn;


    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 2)
        {
            catRenderer.enabled = true;

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        //Instantiate(CatfluffyPrefab, Catspawn.position, Catspawn.rotation);
            catRenderer.enabled = false;
            time = 0;
            //collided = false;
            //Destroy(gameObject);
        
    }
  //private void OnTriggerEnter2D(Collider2D collision)
  //{
   //   Debug.Log("Ragdoll hit by" + collision.gameObject);


  

  //}
}
