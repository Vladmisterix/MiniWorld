using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class HealthUp : MonoBehaviour
{
    private Animation anim;
    public static bool GOD = false;
    private void Start()
    {
        anim = GetComponent<Animation>();
    }
    public void Untouchable()
    {
        GOD = true;
        StartCoroutine(GODNESS());
        anim.Play();
    }
    IEnumerator GODNESS()
    {
        yield return new WaitForSeconds(5f);
        GOD = false;
    }
}
