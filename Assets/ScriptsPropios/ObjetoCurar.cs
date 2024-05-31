using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoCurar : MonoBehaviour
{
    public int curacion;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.TryGetComponent(out VidaJugador vidajugador))
        {
            vidajugador.CurarVida(curacion);
        }
    }
}
