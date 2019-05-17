using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpamManeger : MonoBehaviour
{
    public GameObject Enimg;
    public Transform SpamTranform;
    private Vector3 _spamPosition;
    public float CriateTime=4;
    
    // Start is called before the first frame update
    void Start()
    {
        _spamPosition = SpamTranform.position;
        Invoke(nameof(CriateNew), CriateTime);
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }

    void CriateNew()
    {
        Instantiate(Enimg, new Vector3(Random.Range(-20, 20), _spamPosition.y, _spamPosition.z), SpamTranform.rotation);
        Invoke(nameof(CriateNew), CriateTime);
    }
}
