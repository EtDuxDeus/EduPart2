using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;

namespace Tools
{
    public class LayerMaskGetter : MonoBehaviour
    {
        private RaycastHit _hit;
        private GameObject _entityFromRaycast;
        private LayerMask _rayMask;


        private void Start()
        {
            _hit = new RaycastHit();
            _rayMask = 1 << 9;
        }


        private void Update()
        {
            GetTheLayerOfTheObject();
        }


        private void GetTheLayerOfTheObject()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ShootTheRay();
            }
        }


        private void ShootTheRay()
        {
            if (Physics.Raycast(gameObject.transform.position, transform.forward, out _hit, 100f, _rayMask))
            {
                _entityFromRaycast = _hit.collider.gameObject;

                LayerMask entityMask = _entityFromRaycast.layer;

                Debug.Log("Got it, layerNumber is: " + LayerMask.LayerToName(entityMask));

                _rayMask = _rayMask << 1;
            }
            else
            {
                Debug.Log("Missed, layerNumber is: " + LayerMask.LayerToName(_rayMask));

                _rayMask = _rayMask << 1;
            }
        }

    }
}
