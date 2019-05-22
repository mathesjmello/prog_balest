﻿using UnityEngine;

namespace Script
{
    public class SpamManeger : MonoBehaviour
    {
        public BaseEnimig Enimg1,Enimg2, Enimg3, Enimg4;
        public Transform SpamTrans1;
        private Vector3 _spamPosi1;
        public float CriateTime=12;
    
   
        void Start()
        {
            _spamPosi1 = SpamTrans1.position;
            Invoke(nameof(Criate1), CriateTime);
            Invoke(nameof(Criate2), CriateTime*1.4f);
            Invoke(nameof(Criate3), CriateTime*2f);
            Invoke(nameof(Criate4), CriateTime*2.3f);
        }

    
        void Criate1()
        {
            Enimg1.Create(new Vector3(Random.Range(-20, 20), _spamPosi1.y, _spamPosi1.z), SpamTrans1.rotation);
            Invoke(nameof(Criate1), CriateTime);
        }
        void Criate2()
        {
            Enimg2.Create(new Vector3(Random.Range(-20, 20), _spamPosi1.y, _spamPosi1.z), SpamTrans1.rotation);
            Invoke(nameof(Criate2), CriateTime*1.4f);
        }
        void Criate3()
        {
            Enimg3.Create(new Vector3(Random.Range(-20, 20), _spamPosi1.y, _spamPosi1.z), SpamTrans1.rotation);
            Invoke(nameof(Criate3), CriateTime*2f);
        }
        void Criate4()
        {
            Enimg4.Create(new Vector3(Random.Range(-20, 20), _spamPosi1.y, _spamPosi1.z), SpamTrans1.rotation);
            Invoke(nameof(Criate4), CriateTime*2.3f);
        }
    }
}
