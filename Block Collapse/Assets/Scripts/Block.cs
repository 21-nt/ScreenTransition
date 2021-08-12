using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    #region Private Methods

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

    #endregion
    
}
