using System.Collections;
using System.Collections.Generic;
using Script;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField] private float _force=100;
   //private Rigidbody _rgb;
    private Vector3 _velocity;
    
    private Vector3 _iniPos;
    private Vector3 _lastPos;
    private bool _shooting;

    // Start is called before the first frame update
    void Start()
    {
        _iniPos = transform.position;
        //_rgb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(!_shooting) return;

        transform.position += _velocity * Time.deltaTime;
        _velocity += Physics.gravity;
        _lastPos = transform.position;
        RayCastCheck();
        //if (_rgb.velocity.magnitude<=0) return;

        //transform.right = -_rgb.velocity;
    }

    void RayCastCheck()
    {
        if (Physics.Raycast(_iniPos, _lastPos))
        {
            
        }
        _iniPos = _lastPos;
    }
    
    private void OnCollisionEnter(Collision other)
    {
        if(!_shooting) return;
        
        if (other.gameObject.GetComponent<BaseEnimig>() != null)
        {
            other.gameObject.GetComponent<BaseEnimig>().Damege();       
        }
        
        _shooting = false;
    }

    public void Shoot(Vector3 direction)
    {
        _shooting = true;
        _velocity = direction * _force;
        transform.position = _iniPos;
        transform.rotation = Quaternion.identity;
        
        //_rgb.AddForce(-transform.right*_force);
    }
}
