using System;
using UnityEngine;

/**
 * Foreign code from SuperGoalie(Basic)
 * Source: https://assetstore.unity.com/packages/templates/packs/super-goalie-basic-144535
 * Script was now used in the AR_Football project
 */
namespace Assets.SuperGoalie.Scripts.Triggers
{
    public class GoalTrigger : MonoBehaviour
    {
        public Action OnCollidedWithBall;

        private void OnTriggerEnter(Collider other)
        {
            //if tag is ball
            if(other.tag == "Ball")
            {
                //invoke that the wall has collided with the ball
                Action temp = OnCollidedWithBall;
                if (temp != null)
                    temp.Invoke();

                // disable
                gameObject.SetActive(false);
            }
        }
    }
}
