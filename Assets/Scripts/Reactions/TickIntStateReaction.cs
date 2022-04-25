namespace WillakeD.ReactionSystemDemo
{
    public class TickIntStateReaction : Reaction
    {
        public IntState state = null;

        public override void Execute()
        {
            state.SetValue(state.Value + 1);
        }
    }
}