namespace WillakeD.ReactionSystemDemo
{
    public class SwitchBoolStateReaction : Reaction
    {
        public BoolState state = null;

        public override void Execute()
        {
            state.SetValue(!state.Value);
        }
    }
}