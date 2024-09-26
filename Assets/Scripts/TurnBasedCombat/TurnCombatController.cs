using System;
using UnityEngine;
using UnityEngine.Events;


public class TurnCombatController : MonoBehaviour
{
    private CombatStateMachine _combatStateMachine;

    private void Awake()
    {
        _combatStateMachine = new CombatStateMachine();
        _combatStateMachine.OnEnterState.AddListener(OnEnterState);
        _combatStateMachine.OnExitState.AddListener(OnExitState);
    }

    private void Start()
    {
        
    }

    private void OnEnterState(CombatState state)
    {

    }

    private void OnExitState(CombatState state)
    {
        
    }

    private void Update()
    {
        _combatStateMachine.Tick(Time.deltaTime);
    }


}
