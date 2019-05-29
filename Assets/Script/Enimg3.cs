using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

namespace Script
{
    public class Enimg3 : BaseEnimig
    {
        private Vector3 _trig;
        private void Start()
        {

            _trig = new Vector3(TarguetTransform.position.x + Random.Range(-5, 5), TarguetTransform.position.y,
                TarguetTransform.position.z + 0.5f);
        }

        public override void SetTarguet()
        {           
            TarguetTransform = FindObjectOfType<ShotLocal>().transform;
        }
        void Update()
        {
            Move();
        }

        public override void Move()
        {
            float step = Speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, _trig, step);
            if (transform.position.Equals(_trig))
            {
                Shot();
            }
        }
    }
}
