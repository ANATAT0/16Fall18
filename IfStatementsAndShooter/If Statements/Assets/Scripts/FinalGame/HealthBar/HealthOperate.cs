using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthOperate : MonoBehaviour
{
    public Sprite[] PeppermintHealthBar;

    public Image MintUI;

    private GingerbreadCharacterMover player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<GingerbreadCharacterMover>();
    }

    private void Update()
    {
        MintUI.sprite = PeppermintHealthBar[player.CurrentHealth];
    }
}
