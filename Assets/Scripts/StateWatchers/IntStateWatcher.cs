using UnityEngine;
using System;

namespace WillakeD.ReactionSystemDemo
{
    public class IntStateWatcher : MonoBehaviour, IStateWatcher<int>
    {
        public IntState state;

        public Reaction<int>[] reactions = new Reaction<int>[0];

        private void Start()
        {
            state
                .ValueDidChange
                .AddListener(Execute);

            Execute(state.Value);
        }

        public void Execute(int value)
        {
            foreach (Reaction<int> reaction in reactions)
            {
                reaction.Execute(value);
            }
        }

        private void OnDestroy()
        {
            state
                .ValueDidChange
                .RemoveListener(Execute);
        }
    }
}