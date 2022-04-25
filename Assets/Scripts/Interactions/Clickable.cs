using UnityEngine;

namespace WillakeD.ReactionSystemDemo
{
    public class Clickable : MonoBehaviour
    {
        [SerializeField]
        private bool _isInteractable = true;
        public bool IsInteractable { get => _isInteractable; }
        public Reaction[] reactions = new Reaction[0];

        public void SetIsInteractable(bool isInteractable)
        {
            _isInteractable = isInteractable;
        }

        public void OnClick()
        {
            if (IsInteractable == false) return;
            foreach (Reaction reaction in reactions)
            {
                reaction.Execute();
            }
        }
    }
}