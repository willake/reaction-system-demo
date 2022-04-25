using UnityEngine;
using System;

namespace WillakeD.ReactionSystemDemo
{
    public interface IStateWatcher<T>
    {
        void Execute(T value);
    }
}