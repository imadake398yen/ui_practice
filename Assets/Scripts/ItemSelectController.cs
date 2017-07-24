using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSelectController : MonoBehaviour {

	[SerializeField] private Image iconImage;
	[SerializeField] private List<Sprite> itemIcons;

	[SerializeField]
	private int currentSelect = 0;

	private void Update () {
		if ( Input.GetKeyDown(KeyCode.RightArrow) ) {
			currentSelect = (currentSelect + 1) % itemIcons.Count;
			iconImage.sprite = itemIcons[currentSelect];
		}
		if ( Input.GetKeyDown(KeyCode.LeftArrow) ) {
			if (currentSelect > 0) currentSelect -= 1;
			else currentSelect = itemIcons.Count - 1;
			iconImage.sprite = itemIcons[currentSelect];
		}
	}

}
