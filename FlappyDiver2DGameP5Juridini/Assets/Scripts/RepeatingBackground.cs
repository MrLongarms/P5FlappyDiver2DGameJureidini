using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    private BoxCollider2D groundCollider;
    private float groundHorizontallength;
    
    // Start is called before the first frame update
    void Start()
    {
        groundCollider = GetComponent<BoxCollider2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
