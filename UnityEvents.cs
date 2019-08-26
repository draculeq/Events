using System;
using UnityEngine;
using UnityEngine.Events;

namespace Deadbit.Events
{
    [Serializable] public class IntEvent : UnityEvent<int> { }
    [Serializable] public class FloatEvent : UnityEvent<float> { }
    [Serializable] public class BoolEvent : UnityEvent<bool> { }
    [Serializable] public class StringEvent : UnityEvent<string> { }
    [Serializable] public class Vector2Event : UnityEvent<Vector2> { }
    [Serializable] public class Vector3Event : UnityEvent<Vector3> { }
    [Serializable] public class QuaternionEvent : UnityEvent<UnityEngine.Quaternion> { }
    [Serializable] public class TransformEvent : UnityEvent<Transform> { }
    [Serializable] public class ColorEvent : UnityEvent<UnityEngine.Color> { }
    [Serializable] public class SpriteEvent : UnityEvent<UnityEngine.Sprite> { }
    [Serializable] public class ImageEvent : UnityEvent<UnityEngine.UI.Image> { }
    [Serializable] public class GameObjectEvent : UnityEvent<GameObject> { }
    [Serializable] public class ColliderEvent : UnityEvent<Collider> { }
}
