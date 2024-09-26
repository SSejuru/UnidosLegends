using UnityEngine;

public interface IState
{
    void EnterState();
    void Tick(float deltaTime = 0);
    void ExitState();
}
