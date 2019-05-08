using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MouseFollower : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButton("Fire1"))
        {
            //if tocando pantalla
            Vector3 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition/*posicion del dedo*/);
            pz.z = 0;
            gameObject.transform.position = pz;
            if (!(Input.GetButton("Fire1")))
            {
                
            }
        }
	}
}
