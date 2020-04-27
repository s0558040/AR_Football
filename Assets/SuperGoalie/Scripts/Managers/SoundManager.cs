using System;
using Patterns.Singleton;
using UnityEngine;

/**
 * Foreign code from SuperGoalie(Basic)
 * Source: https://assetstore.unity.com/packages/templates/packs/super-goalie-basic-144535
 * Script was now used in the AR_Football project
 */
namespace Assets.SuperGoalie.Scripts.Managers
{
    public class SoundManager : Singleton<SoundManager>
    {
        public AudioSource _ballKickAS;

        public AudioSource _goalAS;

        public AudioSource _matchAmbience;

        public void PlayBallKickedSound()
        {
            _ballKickAS.Play();
        }

        public void PlayBallKickedSound(float flightTime, float velocity, Vector3 initial, Vector3 target)
        {
            _ballKickAS.Play();
        }

        public void PlayGoalScoredSound()
        {
            _goalAS.Play();
        }
    }
}
