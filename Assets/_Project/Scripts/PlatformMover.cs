using UnityEngine;
using DG.Tweening;
using KBCore.Refs;

namespace Platformer {
    public class PlatformMover : MonoBehaviour {
        [SerializeField, Scene] Vector3 moveTo = Vector3.zero;
        [SerializeField] float moveTime = 1f;
        [SerializeField] Ease ease = Ease.InOutQuad;
        
        Vector3 startPosition;

        void Start() {
            startPosition = transform.position;
            Move();
        }

        void Move() {
            transform.DOMove(startPosition + moveTo, moveTime)
                .SetEase(ease)
                .SetLoops(-1, LoopType.Yoyo);
        }
    }
}