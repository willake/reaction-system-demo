using UnityEngine;
using UnityEngine.Events;

namespace WillakeD.ReactionSystemDemo
{
    public abstract class RuntimeState<T> : ScriptableObject
    {
        [Header("Initialize")]
        public bool haveCustomInitValue;
        public T initValue;

        [Header("Runtime")]
        [SerializeField]
        private T value;
        public T Value { get => value; }
        private UnityEvent<T> _valueDidChange = new UnityEvent<T>();
        public UnityEvent<T> ValueDidChange { get => _valueDidChange; }

        public abstract void Init();

        public void SetValue(T v)
        {
            value = v;
            _valueDidChange.Invoke(v);
        }
    }
}