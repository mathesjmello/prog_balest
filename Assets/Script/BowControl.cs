using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowControl : MonoBehaviour
{
    private float _lastShoot;
    public float _atakSpeed = 0.5f;
    public float _rotSpeed = 100;
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
        var mouse = new Vector2(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"));
        transform.Rotate(-mouse.x * _rotSpeed * Time.deltaTime, mouse.y * _rotSpeed * Time.deltaTime, 0, Space.Self);
        transform.position= new Vector3(Input.GetAxis("Horizontal")*Time.deltaTime*Range, transform.position.y, transform.position.z);
    }

    void FireArrow()
    {
       var tmp = Instantiate(Arrow,FireSpot.position, FireSpot.rotation);
        Invoke(nameof(FireArrow),_atakSpeed);
    }

    public void NormalizeAttak()
    {
        StartCoroutine(NormAtt());
    }

    public void NormalizeRot()
    {
        StartCoroutine(NormRot());
    }

    IEnumerator NormAtt()
    {
            yield return new WaitForSeconds(5);
            _atakSpeed = 0.5f;     
    }
    IEnumerator NormRot()
    {
        yield return new WaitForSeconds(5);
        _rotSpeed = 100;
    }
}
