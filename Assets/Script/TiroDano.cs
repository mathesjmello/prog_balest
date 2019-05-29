using UnityEngine;

namespace Script
{
    public class TiroDano: MonoBehaviour, IMovable, IWapom, IInstansable
    {
        public Transform TarguetTransform;
        public int Speed=1;
        public int HitForce { get; set; } = 1;
        
        TiroDano _self;

        private bool _update;

        private void Start()
        {
            SetTarguet();
        }

        private void Update()
        {
            if(!_update) return;
            
            Move();
        }

        public void SetTarguet()
        {
            TarguetTransform = FindObjectOfType<Gate>().transform;
        }
        
        public void Move()
        {
            float step = Speed * Time. deltaTime;
            transform. position = Vector3. MoveTowards(transform. position, TarguetTransform.position, step);
            if (transform.position.Equals(TarguetTransform.position))
            {
                Attack();
            }
            
        }
        public void Attack()
        {
            var maneger = FindObjectOfType<DamegeManeger>();
            maneger.TakeDamege(HitForce);
            _update = false;
        }

        public IInstansable Create(Vector3 position, Quaternion rotation)
        {
            if (_self == null)
            {
                _self = Instantiate(this, position, rotation);
                _self._update = true;
                _self._self = _self;
                var self = _self;

                _self = null;

                return self;
            }
            else
                _self.Reset(position, rotation);
            
            return _self;
        }

        private void Reset(Vector3 position, Quaternion rotation)
        {
            transform.position = position;
            transform.rotation = rotation;

            _update = true;
        }
    }
}