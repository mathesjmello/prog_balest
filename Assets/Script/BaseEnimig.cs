using UnityEngine;

namespace Script
{
    public abstract class BaseEnimig : MonoBehaviour, IDamegeable, IInstansable, IMovable
    {
        
        public Transform TarguetTransform;       
        public float Speed = 1;
        [SerializeField] private float _speed;
        [SerializeField] private int _life;


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

        private void Awake()
        {
            SetTarguet();
        }
        
        private void OnDie()
        {
            Destroy(gameObject);
        }


        public void Damege(int damege=1)
        {
            hp=-damege;
        }


        public void Create(Vector3 position, Quaternion rotation)
        {
            Instantiate(gameObject, position, rotation);
        }


        public virtual void Move()
        {
            throw new System.NotImplementedException();
        }

        public virtual void SetTarguet()
        {
            TarguetTransform = FindObjectOfType<Gate>().transform;
        }
    }
}
