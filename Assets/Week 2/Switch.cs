using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer.color = Color.green;
    }

    // Update is called once per frame



    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("trigger with switch");
        spriteRenderer.color = Color.red;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        spriteRenderer.color = Color.green;
        Debug.Log("Trigger switch");
    }

}
