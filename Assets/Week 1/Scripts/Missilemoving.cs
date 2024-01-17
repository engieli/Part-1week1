using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Missilemoving : MonoBehaviour
{
  
    public float missileSpeed = 3f;
    Rigidbody2D rigidbody;

    // Start is called before the first frame update
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }



// Update is called once per frame
void Update()
    {
        transform.Translate(missileSpeed * Time. deltaTime, 0, 0);
    }
    private void FixedUpdate()
    {
        Vector2 direction = new Vector2(missileSpeed * Time.deltaTime, 0);
        rigidbody.MovePosition(rigidbody.position + direction);

    }
    private void OnCollisionEnter2D (Collision2D collision)
    {
        Debug.Log("Player hit by" + collision. gameObject);
        Destroy(gameObject);
    }

}
