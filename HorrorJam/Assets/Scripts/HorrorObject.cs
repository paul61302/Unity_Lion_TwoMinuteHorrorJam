using UnityEngine;

public class HorrorObject : MonoBehaviour, ITriggerEvent
{
    public void TriggerEvent()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "玩家") TriggerEvent();
    }
}
