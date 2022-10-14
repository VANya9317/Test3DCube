using System;
using System.Collections;
using Model;
using UnityEngine;

namespace Main
{
    public class CubesSpawnController : MonoBehaviour
    {
        [SerializeField] private CubesSpawnData _cubesSpawnData;
        private Coroutine _currentSpawnTimer;

        public float CubeSpawnValue
        {
            get => _cubesSpawnData.SpawnCube; 
            set
            {
                if (value > 0)
                {
                    _cubesSpawnData.SpawnCube = value;
                    StopSpawnCube();
                    StartSpawnCube();
                }
                OnSpawnDataValueChanged?.Invoke();
            }
        }
        public float CubeValueSpeed
        {
            get => _cubesSpawnData.SpeedCube; 
            set
            {
                if (value > 0)
                {
                    _cubesSpawnData.SpeedCube = value;
                }
                OnSpawnDataValueChanged?.Invoke();
            }
        }
        public float CubeDistanceValue
        {
            get => _cubesSpawnData.DistanceCube; 
            set
            {
                if (value > 0)
                {
                    _cubesSpawnData.DistanceCube = value;
                }
                OnSpawnDataValueChanged?.Invoke();
            }
        }

        public event Action OnSpawnDataValueChanged;

        private void Awake()
        {
            _cubesSpawnData = Instantiate(_cubesSpawnData);
        }

        private void Start()
        {
            StartSpawnCube();
            OnSpawnDataValueChanged?.Invoke();
        }

        private void StartSpawnCube()
        {
            _currentSpawnTimer = StartCoroutine(SpawnCubesTimer());                        
        }

        private void StopSpawnCube()
        {
            StopCoroutine(_currentSpawnTimer);
        }

        private IEnumerator SpawnCubesTimer()
        {
            while (true)
            {
                SpawnCube();
                yield return new WaitForSeconds(_cubesSpawnData.SpawnCube);
            }
        }

        private void SpawnCube()
        {
            var cube = Instantiate(_cubesSpawnData.CubePrefab, transform.position, Quaternion.identity);
            cube.GetComponent<CubeMovement>().Init(new CubeMovementData(_cubesSpawnData.SpeedCube, _cubesSpawnData.DistanceCube));
        }
    }
}