using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InmortalityBuff : MonoBehaviour
{
    private float duration; // Duración del buff en segundos
    private bool active; // Indica si el buff está activo

    public InmortalityBuff(float duration)
    {
        this.duration = duration;
        this.active = false;
    }

    public void ActivateBuff()
    {
        active = true;
        // Aplicar efectos visuales o sonoros para indicar que el jugador es inmortal
        // Por ejemplo, cambiar el color del jugador a uno brillante
    }

    public void DeactivateBuff()
    {
        active = false;
        // Revertir los efectos visuales o sonoros aplicados al activar el buff
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
