using UnityEngine;

namespace Script
{
    public class Enimg4: BaseEnimig
    {
        
        void Update()
        {
            Move();
        }

        public override void Move()
        {
            float step = Speed * Time. deltaTime;
            transform. position = Vector3. MoveTowards(transform. position, new Vector3(TarguetTransform.position.x, TarguetTransform.position.y, TarguetTransform.position.z), step);
            if (transform.position.Equals(TarguetTransform.position))
            {
                Attack();
            }
        }
    }
}