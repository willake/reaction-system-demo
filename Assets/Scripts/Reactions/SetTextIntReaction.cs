using UnityEngine;
using UnityEngine.UI;

namespace WillakeD.ReactionSystemDemo
{
    public class SetTextIntReaction : Reaction<int>
    {
        public Text text;

        protected Text GetTextComponent()
        {
            return text ?? (text = GetComponent<Text>());
        }

        public override void Execute(int value)
        {
            text.text = value.ToString();
        }
    }
}