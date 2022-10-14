using System.Collections;
using Model;
using UnityEngine;

namespace Main
{
    public class ObjectDestroyer : MonoBehaviour
    {
        public void Dest(DestroyCubesData destroyCubesData)
        {
            StartCoroutine(DoDestroy(destroyCubesData));
        }

        private IEnumerator DoDestroy(DestroyCubesData destroyCubesData)
        {
            var animTime = destroyCubesData.DestroyTime;
            var currentTime = 0f;
            var sizeFrom = transform.localScale;
            var sizeTo = Vector3.zero;
            while (currentTime < animTime)
            {
                var currentSize = Vector3.Lerp(sizeFrom, sizeTo, currentTime / animTime);
                transform.localScale = currentSize;
                currentTime += Time.deltaTime;
                yield return null;
            }
            Destroy(gameObject);
        }
    }
}