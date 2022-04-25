using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WillakeD.ReactionSystemDemo
{
    [CreateAssetMenu(fileName = "IntState", menuName = "RuntimeStates/IntState", order = 0)]
    public class IntState : RuntimeState<int>
    {
        public override void Init()
        {
            if (haveCustomInitValue)
            {
                SetValue(initValue);
            }
            else
            {
                SetValue(0);
            }
        }
    }
}
