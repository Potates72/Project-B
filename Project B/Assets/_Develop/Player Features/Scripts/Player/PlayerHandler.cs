using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class PlayerHandler : MonoBehaviour
{
    [SerializeField, HideInPlayMode] private int startHealth;
    [SerializeField, HideInEditorMode] private PlayerData firstPlayer, secondPlayer;
    [SerializeField, HideInPlayMode] private PlayerInput[] inputTypes;

    // Start is called before the first frame update
    void Start()
    {
        firstPlayer = new PlayerData(startHealth, inputTypes[0]);
        secondPlayer = new PlayerData(startHealth, inputTypes[1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
