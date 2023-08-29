using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellDisappear : MonoBehaviour
{
    private void OnBecameInvisible() {
        Destroy(this.gameObject);
    }
}
