using UnityEngine;

namespace WillakeD.ReactionSystemDemo
{
    public class RuntimeStateInitializer : MonoBehaviour
    {
        public BoolState[] boolStates;
        public IntState[] intStates;

        private void Awake()
        {
            foreach (BoolState state in boolStates)
            {
                state.Init();
            }

            foreach (IntState state in intStates)
            {
                state.Init();
            }
        }
    }
}