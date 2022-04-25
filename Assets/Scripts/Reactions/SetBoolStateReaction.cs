namespace WillakeD.ReactionSystemDemo
{
    public class SetBoolStateReaction : Reaction
    {
        public BoolState state = null;
        public bool value;

        public override void Execute()
        {
            state.SetValue(value);
        }
    }
}