using UnityEngine;

namespace Model
{
    [CreateAssetMenu(fileName = "CubesSpawnData", menuName = "Test/CubesSpawnData", order = 0)]
    public class CubesSpawnData : ScriptableObject
    {
        [SerializeField] private GameObject _cubePrefab = default;
        [SerializeField] private float _spawnCube = 1f;
        [SerializeField] private float _speedCube = 10f;
        [SerializeField] private float _distanceCube = 40f;

        public GameObject CubePrefab => _cubePrefab;

        public float SpawnCube { get => _spawnCube; set => _spawnCube = value; }
        public float SpeedCube { get => _speedCube; set => _speedCube = value; }
        public float DistanceCube { get => _distanceCube; set => _distanceCube = value; }
    }
}