using UnityEngine;

namespace WillakeD.ReactionSystemDemo
{
    public class SetRendererColorStateReaction : Reaction<bool>
    {
        [Header("Colors")]
        public Color onColor;
        public Color offColor;

        public SpriteRenderer sr;

        protected SpriteRenderer GetSpriteRenderer()
        {
            return sr ?? (sr = GetComponent<SpriteRenderer>());
        }

        public override void Execute(bool value)
        {
            sr.color = value ? onColor : offColor;
        }
    }
}