using UnityEngine;

namespace Script
{
    public class Enimg4: BaseEnimig
    {
        
        void Update()
        {
            transform.LookAt(Bow.transform);
            Move();
        }

        public override void Move()
        {
            float step = Speed * Time. deltaTime;
            transform. position = Vector3. MoveTowards(transform. position, new Vector3(TarguetTransform.position.x, TarguetTransform.position.y, TarguetTransform.position.z), step);
            if (Vector3.Distance(transform.position,TarguetTransform.position) < 0.1f)
            {
                Attack();
            }
        }
    }
}