using UnityEngine;
using System;

namespace WillakeD.ReactionSystemDemo
{
    public class BoolStateWatcher : MonoBehaviour, IStateWatcher<bool>
    {
        public BoolState state;

        public Reaction<bool>[] reactions = new Reaction<bool>[0];

        private void Start()
        {
            state
                .ValueDidChange
                .AddListener(Execute);

            Execute(state.Value);
        }

        public void Execute(bool value)
        {
            foreach (Reaction<bool> reaction in reactions)
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