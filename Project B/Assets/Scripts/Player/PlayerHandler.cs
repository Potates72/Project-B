using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    [SerializeField] private int startHealth;
    [SerializeField] private PlayerData firstPlayer, secondPlayer;

    // Start is called before the first frame update
    void Start()
    {
        firstPlayer = new PlayerData(startHealth);
        secondPlayer = new PlayerData(startHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
