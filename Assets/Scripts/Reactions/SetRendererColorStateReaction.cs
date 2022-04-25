using UnityEngine;

namespace WillakeD.ReactionSystemDemo
{
    public class SetRendererColorStateReaction : Reaction<bool>
    {
        [Header("Colors")]
        public Color onColor;
        public Color offColor;

        public SpriteRenderer

        public override void Execute(bool value)
        {
            state.SetValue(value ? onColor : offColor);
        }
    }
}