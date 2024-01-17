using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    //public GameObject launcher;
    public GameObject launcherPrefab;
    public Transform spawn;
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(launcherPrefab, spawn.position, spawn.rotation);

    }
}