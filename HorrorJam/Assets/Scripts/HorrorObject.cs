using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class HorrorObject : MonoBehaviour, ITriggerEvent
{
    /// <summary>
    /// 剛體
    /// </summary>
    private Rigidbody rig;

    private void Awake()
    {
        rig = GetComponent<Rigidbody>();
        rig.useGravity = false;                             // 取消重力
        rig.constraints = RigidbodyConstraints.FreezeAll;   // 凍結全部
    }


    public virtual void TriggerEvent()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "玩家") TriggerEvent();
    }
}
