using System.Collections;
using UnityEngine;


public class SpinButton : MonoBehaviour
{
    [SerializeField] float spinTime = 0.5f;
    [SerializeField] AnimationCurve curve = AnimationCurve.EaseInOut(0, 0, 1, 1);
    private IEnumerator StartSpinning()
    {
        if (spinTime <= 0)
        {
            yield break;
        }

        float elapsed = 0f;

        while (elapsed < spinTime)
        {
            elapsed += Time.deltaTime;
            var t = elapsed / spinTime;
            var angle = curve.Evaluate(t) * 360f;
            transform.localRotation = Quaternion.AngleAxis(angle, Vector3.right);

            yield return null;
        }

        transform.localRotation = Quaternion.identity;
    }

    public void Spin()
    {
        StartCoroutine(StartSpinning());
    }
}
