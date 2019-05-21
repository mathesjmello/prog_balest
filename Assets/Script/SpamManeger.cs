using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpamManeger : MonoBehaviour
{
    public GameObject Enimg1,Enimg2, Enimg3;
    public Transform SpamTrans1;
    private Vector3 _spamPosi1;
    public float CriateTime=12;
    
    // Start is called before the first frame update
    void Start()
    {
        _spamPosi1 = SpamTrans1.position;
        Invoke(nameof(Criate1), CriateTime);
        Invoke(nameof(Criate2), CriateTime*1.4f);
        Invoke(nameof(Criate3), CriateTime*2f);
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }

    void Criate1()
    {
        Instantiate(Enimg1, new Vector3(Random.Range(-20, 20), _spamPosi1.y, _spamPosi1.z), SpamTrans1.rotation);
        Invoke(nameof(Criate1), CriateTime);
    }
    void Criate2()
    {
        Instantiate(Enimg2, new Vector3(Random.Range(-20, 20), _spamPosi1.y, _spamPosi1.z), SpamTrans1.rotation);
        Invoke(nameof(Criate2), CriateTime*1.4f);
    }
    void Criate3()
    {
        Instantiate(Enimg3, new Vector3(Random.Range(-20, 20), _spamPosi1.y, _spamPosi1.z+Random.Range(-0.5f,0.5f)), SpamTrans1.rotation);
        Invoke(nameof(Criate3), CriateTime*2f);
    }
}
