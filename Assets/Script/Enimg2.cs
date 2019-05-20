using System.Collections;
using System.Collections.Generic;
using Script;
using UnityEngine;

public class Enimg2 : MonoBehaviour
{
    public int Life;
    public float Speed = 1;
    
    public Transform TarguetTransform;

    // Start is called before the first frame update
    void Start()
    {
        TarguetTransform = FindObjectOfType<ShotLocal>().transform;
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
        transform. position = Vector3. MoveTowards(transform. position, new Vector3(TarguetTransform.position.x+Random.Range(-10,10), TarguetTransform.position.y), step);
    }
}
