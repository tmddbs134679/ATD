using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerSelector : GenericSingleton<PlayerSelector>
{
    [SerializeField] private InputReader inputReader;
    [SerializeField] private List<PlayerStateMachine> allPlayers;

    private PlayerStateMachine selectedPlayer;

    private void Start()
    {
        SelectPlayer(0);
    }

    public void SelectPlayer(int idx)
    {
        if (selectedPlayer != null)
            selectedPlayer.DisconnectInput(); // �Է� ���� ����

        selectedPlayer = allPlayers[idx];
        selectedPlayer.ConnectInput(inputReader); // �Է� ����
    }
}
