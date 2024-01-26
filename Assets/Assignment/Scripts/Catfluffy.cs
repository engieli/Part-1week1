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


    public Transform spawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(CatfluffyPrefab, Catspawn.position, Catspawn.rotation);
        if (collision.gameObject.CompareTag("obsticle"))
        {
            collided = false;
            Destroy(gameObject);
        }
        
    }
  //private void OnTriggerEnter2D(Collider2D collision)
  //{
   //   Debug.Log("Ragdoll hit by" + collision.gameObject);


  

  //}
}
