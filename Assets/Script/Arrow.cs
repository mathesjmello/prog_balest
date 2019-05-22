using System.Collections;
using System.Collections.Generic;
using Script;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField] private float _force=100;
    private Rigidbody _rgb;
    // Start is called before the first frame update
    void Start()
    {
        _rgb = GetComponent<Rigidbody>();
        _rgb.AddForce(-transform.right*_force);
        
        Destroy(gameObject, 3);
    }

    private void LateUpdate()
    {
      
        if (_rgb.velocity.magnitude<=0) return;
        
        transform.right = -_rgb.velocity;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<BaseEnimig>() != null)
        {
            other.gameObject.GetComponent<BaseEnimig>().Damege();       
        }
        Destroy(gameObject);
    }
}
