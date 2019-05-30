using UnityEngine;

namespace Script
{
    public class Enimg : BaseEnimig
    {
    
    
        void Update()
        { 
            transform.LookAt(Bow.transform);
            Move();
        }

        public override void Move()
        {
            float step = Speed * Time. deltaTime;
            transform. position = Vector3. MoveTowards(transform. position, TarguetTransform. position, step);
            if (Vector3.Distance(transform.position,TarguetTransform.position) < 0.1f)
            {
                Attack();
            }
        }

    
    }
}
