using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

/**
 * Foreign code from SuperGoalie(Basic)
 * Source: https://assetstore.unity.com/packages/templates/packs/super-goalie-basic-144535
 * Script was now used in the AR_Football project
 */
namespace Assets.SoccerGameEngine_Basic_.Scripts.Controllers
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField]
        float _distanceMaxDisplacement = 30f;

        [SerializeField]
        float _speedFollow = 3f;

        [SerializeField]
        Transform target;

        [SerializeField]
        float distanceMaxZ;
        [SerializeField]
        float distanceMinZ;

        private void Awake()
        {
            distanceMaxZ = transform.position.z + _distanceMaxDisplacement;
            distanceMinZ = transform.position.z - _distanceMaxDisplacement;
        }

        private void LateUpdate()
        {
            // find the next position to move
            Vector3 nextPosition = Vector3.MoveTowards(transform.position,
                target.position,
                _speedFollow);

            // clean the psotion
            nextPosition.x = transform.position.x;
            nextPosition.y = transform.position.y;
            nextPosition.z = Mathf.Clamp(nextPosition.z, distanceMinZ, distanceMaxZ);

            // set the next position
            transform.position = nextPosition;
        }
    }
}
