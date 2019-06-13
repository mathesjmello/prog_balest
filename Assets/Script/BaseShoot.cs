using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseShoot : MonoBehaviour
{
    public BowControl Bow;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Bow.CanShoot = true;
    }

    private void OnTriggerStay(Collider other)
    {
        Bow.CanShoot = true;
    }

    private void OnTriggerExit(Collider other)
    {
        Bow.CanShoot = false;
    }
}
