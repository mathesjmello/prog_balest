﻿using UnityEngine;

namespace Script
{
    public class Enimg3 : BaseEnimig
    {
    
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
            float step = Speed * Time. deltaTime;
            transform. position = Vector3. MoveTowards(transform. position, new Vector3(TarguetTransform.position.x+Random.Range(-10,10), TarguetTransform.position.y, TarguetTransform.position.z+Random.Range(-1,1)), step);
        }
    }
}
