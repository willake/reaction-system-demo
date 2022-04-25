namespace WillakeD.ReactionSystemDemo
{
    public class SetIntStateReaction : Reaction
    {
        public IntState state = null;
        public int value;

        public override void Execute()
        {
            state.SetValue(state.Value + 1);
        }
    }
}