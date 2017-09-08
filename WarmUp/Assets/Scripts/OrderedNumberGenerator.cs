using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderedNumberGenerator : NumberGenerator {

//note: the class is deriving from NumberGenerator rather than MonoBehavior, making this a subclass

	public int[] order;

	int current;

	//adding override overrides the function from the parent
	public override int Next(){

	//modulo is the remainder after you divide, look it up some more

		int result = order[current % order.Length];

		current++;

		return result;
	}
}
