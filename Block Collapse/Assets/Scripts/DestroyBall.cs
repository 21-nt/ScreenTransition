using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBall : MonoBehaviour
{
    #region Private Methods

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }

    #endregion
}
