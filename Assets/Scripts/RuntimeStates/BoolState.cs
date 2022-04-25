using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WillakeD.ReactionSystemDemo
{
    [CreateAssetMenu(fileName = "BoolState", menuName = "RuntimeStates/BoolState", order = 0)]
    public class BoolState : RuntimeState<bool>
    {
        public override void Init()
        {
            if (haveCustomInitValue)
            {
                SetValue(initValue);
            }
            else
            {
                SetValue(false);
            }
        }
    }
}
