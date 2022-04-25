using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace WillakeD.ReactionSystemDemo
{
    public class SetTextIntReaction : Reaction<int>
    {
        public TextMeshProUGUI text;

        protected TextMeshProUGUI GetTextComponent()
        {
            return text ?? (text = GetComponent<TextMeshProUGUI>());
        }

        public override void Execute(int value)
        {
            text.text = value.ToString();
        }
    }
}