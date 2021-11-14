using UnityEngine;

[CreateAssetMenu]
public class PlayerInput : ScriptableObject
{
    [SerializeField] public KeyCode Up, Down, Left, Right;
    [SerializeField] public KeyCode Place;
}