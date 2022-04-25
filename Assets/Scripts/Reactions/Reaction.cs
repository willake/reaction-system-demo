using UnityEngine;

namespace WillakeD.ReactionSystemDemo
{
    public abstract class Reaction : MonoBehaviour
    {
        public abstract void Execute();
    }

    public abstract class Reaction<T> : MonoBehaviour
    {
        public abstract void Execute(T value);
    }
}