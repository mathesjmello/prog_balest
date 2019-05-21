using System;
using UnityEngine;

namespace Script
{
    public interface IMovable
    {
        float speed { get; set; }
        void Move();
        void SetTarguet(Vector3 targuet);
    }

    public interface IDamegeable
    {
        int hp { get; set; }
        void Damege(int damege);
    }

    public interface IInstansable
    {
        void Criate(Vector3 position);
    }

    public interface IWapom
    {
        int Damege { get; set; }
        void Attack();
    }

    public abstract class BaseEnimig : MonoBehaviour, IDamegeable, IInstansable, IMovable
    {
        
        
        [SerializeField] private float _speed;
        [SerializeField] private int _life;

        public float speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public int hp
        {
            get { return _life; }
            set
            {
                _life = value;
                if (_life<0)
                {
                    OnDie();
                }
            }
        }

        private void OnDie()
        {
           Destroy(gameObject);
        }


        public void Damege(int damege=1)
        {
            hp=-damege;
        }


        public void Criate(Vector3 position)
        {
            throw new System.NotImplementedException();
        }


        public void Move()
        {
            throw new System.NotImplementedException();
        }

        public void SetTarguet(Vector3 targuet)
        {
            throw new System.NotImplementedException();
        }
    }
}