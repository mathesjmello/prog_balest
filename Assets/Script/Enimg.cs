using UnityEngine;

namespace Script
{
    public class Enimg : BaseEnimig
    {
    
    
        void Update()
        { 
            Move();
        }

        public override void Move()
        {
            float step = Speed * Time. deltaTime;
            transform. position = Vector3. MoveTowards(transform. position, TarguetTransform. position, step);
            if (transform.position.Equals(TarguetTransform.position))
            {
                Attack();
            }
        }

    
    }
}
