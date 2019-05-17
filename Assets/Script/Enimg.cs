using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enimg : MonoBehaviour
{

    public int Life;
    public float Speed = 1;
    
    public Transform TarguetTransform;

    // Start is called before the first frame update
    void Start()
    {
        TarguetTransform = FindObjectOfType<Gate>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPosition();
        if (Life<=0)
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamege()
    {
        Life--;
    }

    void MoveToPosition()
    {
        float step = Speed * Time. deltaTime;
        transform. position = Vector3. MoveTowards(transform. position, TarguetTransform. position, step);
    }
}
