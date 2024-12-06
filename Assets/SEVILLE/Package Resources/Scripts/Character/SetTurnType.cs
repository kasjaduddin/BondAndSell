using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning;

namespace Seville
{
    public class SetTurnType : MonoBehaviour
    {
        public SnapTurnProvider snapTurnProvider;
        public ContinuousTurnProvider continuousTurnProvider;

        public void SetTypeFormIndex(int index)
        {
            if (index == 0)
            {
                snapTurnProvider.enabled = false;
                continuousTurnProvider.enabled = true;
            }
            else if (index == 1)
            {
                snapTurnProvider.enabled = true;
                continuousTurnProvider.enabled = false;
            }
        }
    }
}