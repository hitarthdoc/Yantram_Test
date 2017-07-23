using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Targets
{
	public class SpawnTarget : Target
	{

		public Transform GetStartPosition
		{
			get
			{
				return transform;
			}
		}

	}

}
