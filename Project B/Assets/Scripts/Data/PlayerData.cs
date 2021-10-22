using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

[System.Serializable]
public class PlayerData 
{
    #region Public Properties

    public int Health
    {
        get { return health; }
    }

    public PlayerInput Input => input;

    #endregion

    #region Private Variables

    private int maxHealth;
    [ProgressBar(0, "maxHealth", ColorGetter = "GetHealthBarColor")]
    [SerializeField] private int health;
    [SerializeField] private PlayerInput input;

    #endregion

    #region Functions

    // Constructor
    public PlayerData(int _maxHealth)
    {
        maxHealth = _maxHealth;
        health = maxHealth;
    }

    public void SetHealth(int val) => health = val;
    public void ReduceHealth(int val = 1)
    {
        health -= val;
        if (health < 0)
            health = 0;
    }

    #endregion

    #region Odin Inspector Functions

    public Color GetHealthbarColor(float val)
    {
        return Color.Lerp(Color.green, Color.red, val);
    }

    #endregion
}

[System.Serializable]
public struct PlayerInput
{
    [SerializeField] public KeyCode Up, Down, Left, Right;
    [SerializeField] public KeyCode Place;
}