using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InmortalityBuff : MonoBehaviour
{
    private float duration;
    private bool active;

    public InmortalityBuff(float duration)
    {
        this.duration = duration;
        this.active = false;
    }

    public void ActivateBuff()
    {
        active = true;
        // Aplicar efectos visuales o sonoros para indicar que el jugador es inmortal
    }

    public void DeactivateBuff()
    {
        active = false;
        // Revertir los efectos visuales aplicados al activar el buff
    }

    public bool IsActive()
    {
        return active;
    }

    public IEnumerator StartBuffDurationCoroutine()
    {
        yield return new WaitForSeconds(duration);
        DeactivateBuff();
    }

}
