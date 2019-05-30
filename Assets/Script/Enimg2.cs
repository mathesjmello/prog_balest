using UnityEngine;

namespace Script
{
    public class Enimg2 : BaseEnimig
    {
        private Vector3 _trig;
        
        
        void Start()
        {

            _trig = new Vector3(TarguetTransform.position.x + Random.Range(-5, 5), TarguetTransform.position.y,
                TarguetTransform.position.z + 0.5f);
        }
        void Update()
        {
            transform.LookAt(Bow.transform);
            Move();
        }

        public override void SetTarguet()
        {
            
            TarguetTransform = FindObjectOfType<ShotLocal>().transform;
        }
    
        public override void Move()
        {
            float step = Speed * Time. deltaTime;
            transform. position = Vector3. MoveTowards(transform.position, _trig, step);
            if (Vector3.Distance(transform.position,_trig) < 0.1f)
            {
                Shot();
            }
        }
    }
}
