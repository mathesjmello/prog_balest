using UnityEngine;

namespace Script
{
    public abstract class BaseEnimig : MonoBehaviour, IDamegeable, IInstansable, IMovable, IWapom
    {
        private int _last;
        public int Pool = 3;
        private IInstansable[] Tiros;
        public TiroDano Tiro;
        
        public Transform TarguetTransform;       
        public float Speed = 1;
        [SerializeField] private float _speed;
        [SerializeField] private int _life;
        [SerializeField] private int _force;
        
        public int HitForce
        {
            get { return _force; } set { _force = value; }
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

        private void Awake()
        {
            SetTarguet();
            
            Tiros = new IInstansable[Pool];
            
            for (int i = 0; i < Tiros.Length; i++)
            {
                Tiros[i] = Tiro;
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


        public IInstansable Create(Vector3 position, Quaternion rotation)
        {
            return Instantiate(this, position, rotation);
        }

        private float _lastShoot;
        public float Duration = 2;
        
        public virtual void Shot()
        {
            if(Time.timeSinceLevelLoad - _lastShoot < Duration)
                return;
            
            _lastShoot = Time.timeSinceLevelLoad;
            Tiros[_last] = Tiros[_last].Create(transform.position+ new Vector3(0.5f,0), transform.localRotation);
            _last = (_last+1)%Pool;
        }


        public virtual void Move()
        {
            throw new System.NotImplementedException();
        }

        public virtual void SetTarguet()
        {
            TarguetTransform = FindObjectOfType<Gate>().transform;
        }

        
        public virtual void Attack()
        {
            var maneger = FindObjectOfType<DamegeManeger>();
            maneger.TakeDamege(_force);
            Destroy(gameObject);
        }
    }
}
