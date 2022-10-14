using Model;
using UnityEngine;

namespace Main
{
    public class CubeMovement : MonoBehaviour
    {
        [SerializeField] private DestroyCubesData _destroyCubeAnimData;
        private CubeMovementData _cubeData;
        private float _distancePassed;
        
        public void Init(CubeMovementData cubeData)
        {
            _cubeData = cubeData;
        }

        private void Update()
        {
            var movementVector = transform.forward * _cubeData.MovementSpeed * Time.deltaTime;
            _distancePassed += movementVector.magnitude;
            if (_distancePassed >= _cubeData.MovementDistance)
            {
                gameObject.AddComponent<ObjectDestroyer>().Dest(_destroyCubeAnimData);
                enabled = false;
                return;
            }
            transform.Translate(movementVector);
        }
    }
}