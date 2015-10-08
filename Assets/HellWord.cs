using UnityEngine;
using System.Collections;

[RequireComponent(typeof(TextMesh))]
public class HellWord : MonoBehaviour
{
	[SerializeField]
	private int delta = 1;

	void LateUpdate()
	{
		TextMesh textMesh = GetComponent<TextMesh>() as TextMesh;
		if (!textMesh)
		{
			return;
		}

		textMesh.fontSize += delta;

		const int max = 125;
		const int min = 1;

		if (textMesh.fontSize >= max || min >= textMesh.fontSize)
		{
			delta *= -1;
		}
	}
}
