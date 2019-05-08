using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float velocidad;

    private Rigidbody rig;

    private void Awake()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {

        rig.velocity = transform.up * velocidad;
        
    }

}
