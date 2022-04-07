using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerTorque : MonoBehaviour
{
	private Rigidbody Rb;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
		Rb.AddTorque(0,0.1f,0, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
