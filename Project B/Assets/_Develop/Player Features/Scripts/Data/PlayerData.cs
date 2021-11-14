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
    [ProgressBar(0, "maxHealth", ColorGetter = "GetHealthbarColor")]
    [SerializeField, HideInEditorMode] private int health;
    [SerializeField, InlineEditor] private PlayerInput input;

    #endregion

    #region Functions

    // Constructor
    public PlayerData(int _maxHealth, PlayerInput _input)
    {
        maxHealth = _maxHealth;
        health = maxHealth;

        input = _input;
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
        return Color.Lerp(Color.green, Color.red, 1 - val/maxHealth);
    }

    #endregion
}
