using System;
using UnityEngine;

namespace Script
{
    public interface IMovable
    {
        void Move();
        void SetTarguet();
    }

    public interface IDamegeable
    {
        int hp { get; set; }
        void Damege(int damege);
    }

    public interface IInstansable
    {
        void Create(Vector3 position, Quaternion rotation);
    }

    public interface IWapom
    {
        int Damege { get; set; }
        void Attack();
    }
    
    
}