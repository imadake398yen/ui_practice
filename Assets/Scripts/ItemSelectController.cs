using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSelectController : MonoBehaviour {

	[SerializeField] private List<Sprite> itemIcons;

	private int currentSelect = 0;

	private void Update () {
		if ( Input.GetKeyDown(KeyCode.RightArrow) ) {
			if (itemIcons.Count-1 < currentSelect) currentSelect += 1;
			else currentSelect = 0;
		}
		if ( Input.GetKeyDown(KeyCode.LeftArrow) ) {
			if (currentSelect > 0) currentSelect -= 1;
			else currentSelect = itemIcons.Count - 1;
		}
	}

}
