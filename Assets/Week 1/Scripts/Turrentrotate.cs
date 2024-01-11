using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turrentrotate : MonoBehaviour
{

    // Start is called before the first frame update
    public float speed = 10;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Vertical");
        transform.Rotate(0, 0, direction * speed * Time.deltaTime);
    }
}