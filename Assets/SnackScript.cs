using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnackScript : MonoBehaviour
{
    public GameObject Snack;

    public void Add() {
        Instantiate(Snack, transform.position, transform.rotation);
    }
       
}
