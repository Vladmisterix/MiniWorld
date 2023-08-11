using UnityEngine;

public class SlowTime : MonoBehaviour
{
    private float slowMoValue = 0.01f;
    private float slowDuration = 8f;
    private bool slowTime = false;
    private Animation anim;

    private void Start()
    {
        anim = GetComponent<Animation>();
    }
    private void Update()
    {
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0.0f, 1.0f);
        Time.fixedDeltaTime = Mathf.Clamp(Time.fixedDeltaTime, 0.0f, 0.02f);
        if (slowTime)
        {
            Time.timeScale -= slowMoValue;
            Time.fixedDeltaTime = 0.02f * Time.timeScale;
            if (Time.timeScale <= 0.01f)
            {
                Time.timeScale = 0.01f;
                slowTime = false;
            }
        }
        else
        {
            if(Time.timeScale != 0)
            {
                Time.timeScale += (1f / slowDuration) * Time.unscaledDeltaTime;
                Time.fixedDeltaTime += (0.02f / slowDuration) * Time.unscaledDeltaTime;
            }
        }
    }

    public void SlowMotion()
    {
        slowTime = true;
        anim.Play();
    }
}
