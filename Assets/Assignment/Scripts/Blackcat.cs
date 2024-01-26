using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blackcat : MonoBehaviour
{
    Vector2 direction;
    public Rigidbody2D rigidbody;
    public float force = 10f;
    public float force1 = 10f;
    private bool collidided = false;

    // Start is called before the first frame update
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        if (collidided == true)
        {
            transform.Translate(Vector3.left * Time.deltaTime * force1);
        }

    }
    private void FixedUpdate()
    {
        rigidbody.AddForce(direction * force * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("obsticle"))
        {
            collidided = true;
        }
        if (collision.gameObject.CompareTag("obstacle"))
        {
            collidided = false;
        }

    }

}
