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
    public Arrow Arrow;
    private List<Arrow> _arrows;
    private int _currentArrow;
    private float _time;

    // Start is called before the first frame update
    void Start()
    {
        CreatePool();

        FireArrow();
    }

    private void CreatePool()
    {
        _arrows = new List<Arrow>();

        for (int i = 0; i < 1; i++)
        {
            _arrows.Add(Instantiate(Arrow,FireSpot.position, FireSpot.rotation));
        }
    }

    // Update is called once per frame
    void Update()
    {
        MouseMove();

        if (Time.realtimeSinceStartup - _time > _atakSpeed)
        {
            FireArrow();
        }
    }

    private void MouseMove()
    {
        var mouse = new Vector2(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"));
        transform.Rotate(-mouse.x * _rotSpeed * Time.deltaTime, mouse.y * _rotSpeed * Time.deltaTime, 0, Space.Self);
        transform.position= new Vector3(Input.GetAxis("Horizontal")*Time.deltaTime*Range, transform.position.y, transform.position.z);
    }

    void FireArrow()
    {
        _time = Time.realtimeSinceStartup;
        
        _arrows[_currentArrow].Shoot(transform.forward);

        _currentArrow = (_currentArrow + 1) % _arrows.Count;
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
