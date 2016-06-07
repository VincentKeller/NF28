﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class BaseAbilityMenuState : BattleState
{
    protected string menuTitle;
    protected List<string> menuOptions;

    public override void Enter()
    {
        base.Enter();
        SelectTile(turn.currentCreature.tile.pos);
        LoadMenu();
    }

    public override void Exit()
    {
        base.Exit();
        //abilityMenuPanel.Hide();
    }

    protected override void OnFire(object sender, InfoEventArgs<int> e)
    {
        if (e.info == 0)
            Confirm();
        else
            Cancel();
    }

    protected override void OnMove(object sender, InfoEventArgs<Point> e)
    {
        if (e.info.x > 0 || e.info.y < 0)
        {
            Debug.Log("On move detected " + e.info.x);
            abilityMenuPanel.Next();
        }
        else
            abilityMenuPanel.Previous();
    }

    protected abstract void LoadMenu();
    protected abstract void Confirm();
    protected abstract void Cancel();
}