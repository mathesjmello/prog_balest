using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Script
{
    public class SpamManeger : MonoBehaviour
    {
        public BaseEnimig Enimg1, Enimg2, Enimg3, Enimg4, Enimg5, Enimg6;
        public Transform SpamTrans1;
        private Vector3 _spamPosi1;
        public float CriateTime = 12;

        struct CreateData
        {
            public BaseEnimig e;
            public int inc;
            public float interval;
        }

        void Start()
        {
            var data = new CreateData[6]
            {
                new CreateData
                {
                    e = Enimg1,
                    inc = 0,
                    interval = CriateTime
                },
                new CreateData
                {
                    e = Enimg1,
                    inc = 0,
                    interval = CriateTime * 1.4f
                },
                new CreateData
                {
                    e = Enimg1,
                    inc = 0,
                    interval = CriateTime * 2f
                },
                new CreateData
                {
                    e = Enimg1,
                    inc = 0,
                    interval = CriateTime * 2.3f
                },
                new CreateData
                {
                    e = Enimg1,
                    inc = 0,
                    interval = CriateTime * 1.7f
                },
                new CreateData
                {
                    e = Enimg1,
                    inc = 0,
                    interval = CriateTime * 3f
                }
            };
            
            StopAllCoroutines();

            foreach (var createData in data)
            {
                StartCoroutine(nameof(Create),createData);
            }
        }

        IEnumerator Create(CreateData data)
        {
            while (true)
            {
                yield return new WaitForSecondsRealtime(data.interval);
                data.e.Create(new Vector3(Random.Range(-20, 20), SpamTrans1.position.y + data.inc, SpamTrans1.position.z),
                    SpamTrans1.rotation);
                if (FindObjectOfType<DamegeManeger>().Life <= 0)
                {
                    break;
                }
            }
        }
    }
}