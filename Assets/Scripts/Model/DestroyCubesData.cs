using UnityEngine;

namespace Model
{
    [CreateAssetMenu(fileName = "DestroyCubesData", menuName = "Test/DestroyCubesData", order = 1)]
    public class DestroyCubesData : ScriptableObject
    {
        [SerializeField] private float _destroyTime = 0.5f;

        public float DestroyTime => _destroyTime;
    }
}