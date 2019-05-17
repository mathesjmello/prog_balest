using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowControl : MonoBehaviour
{
    
    [SerializeField] private float _atakSpeed = 0.5f;
    [SerializeField] private float _rotSpeed = 20;
    public float Range=10;
    public Transform FireSpot;
    public GameObject Arrow;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(FireArrow),_atakSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        MouseMove();
        
    }

    private void MouseMove()
    {
        transform.Rotate((Input.GetAxis("Mouse Y") * _rotSpeed * Time.deltaTime), (Input.GetAxis("Mouse X") * _rotSpeed * Time.deltaTime), 0, Space.World);
        transform.position= new Vector3(Input.GetAxis("Horizontal")*Time.deltaTime*Range, transform.position.y, transform.position.z);
    }

    void FireArrow()
    {
       var tmp = Instantiate(Arrow,FireSpot.position, FireSpot.rotation);
        Invoke(nameof(FireArrow),_atakSpeed);
    }
}
