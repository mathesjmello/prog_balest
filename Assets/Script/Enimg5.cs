using TMPro;
using UnityEngine;

namespace Script
{
    public class Enimg5: BaseEnimig
    {
        private Vector3 _trig;

        private void Start()
        {

            _trig = new Vector3(TarguetTransform.position.x + Random.Range(-10, 10), TarguetTransform.position.y+3,
                TarguetTransform.position.z);
        }
        
        void Update()
        {
            Move();
        }

        public override void SetTarguet()
        {
            
            TarguetTransform = FindObjectOfType<ShotLocal>().transform;
        }
        
        public override void Move()
        {
            float step = Speed * Time. deltaTime;
            transform. position = Vector3. MoveTowards(transform. position, _trig, step);
            if (transform.position.Equals(_trig))
            {
                Shot();
            }
        }
    }
}