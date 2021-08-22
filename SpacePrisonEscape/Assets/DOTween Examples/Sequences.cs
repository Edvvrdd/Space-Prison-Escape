using UnityEngine;
using System.Collections;
using DG.Tweening;

public class Sequences : MonoBehaviour
{
	public Transform Camera;
	public float duration = 5;

	IEnumerator Start()
	{
		// Start after one second delay (to ignore Unity hiccups when activating Play mode in Editor)
		yield return new WaitForSeconds(1);

		// Create a new Sequence.
		// We will set it so that the whole duration is 6
		Sequence s = DOTween.Sequence();
		// Add an horizontal relative move tween that will last the whole Sequence's duration
		s.Append(Camera.DOMoveY(0.5f, duration).SetRelative().SetEase(Ease.InOutQuad));
		// Set the whole Sequence to loop infinitely forward and backwards
		s.SetLoops(-1, LoopType.Yoyo);
	}
}
