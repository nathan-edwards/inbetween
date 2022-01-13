using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// jieying was here: class for sword items
[CreateAssetMenu(fileName = "new sword item", menuName = "jay-is-items/sworditem")]
public class SwordItem : Item
{
	Fox_Move player;

	//override use method to equip sword to player
	public override void Use()
	{
		player = FindObjectOfType<Fox_Move>();
		player.swordOn = true;
	}
}
