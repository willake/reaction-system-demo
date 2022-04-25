using UnityEngine;

namespace WillakeD.ReactionSystemDemo
{
    public class SetActiveBoolReaction : Reaction<bool>
    {
        public bool reverse;
        public GameObject target;

        public override void Execute(bool value)
        {
            if (target != null)
            {
                target.SetActive(reverse ? !value : value);
            }
        }
    }
}