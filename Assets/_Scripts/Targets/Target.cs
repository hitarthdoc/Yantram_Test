using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Targets
{
	public class Target : MonoBehaviour
	{
	
		void OnDrawGizmos ()
		{
			Gizmos.DrawIcon (transform.position, "Targets/Target.png");
		}

	}
}