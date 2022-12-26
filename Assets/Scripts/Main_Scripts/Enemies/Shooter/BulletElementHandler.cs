using System;
using ElementSystem;
using UnityEngine;

namespace Enemies.Shooter {
    public class BulletElementHandler : MonoBehaviour {
        private ElementSO _bulletElement;

        public void InitializeBullet(ElementSO elementSo) {
            _bulletElement = elementSo;
            GetComponent<SpriteRenderer>().sprite = _bulletElement.bulletSprite;
        }
    }
}