using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityStandardAssets.Characters.ThirdPerson;
using UnityStandardAssets.Cameras;

using Targets;

namespace Managers
{
	public class GameManager : MonoBehaviour
	{

		[SerializeField]
		List <Target> Targets;

		[SerializeField]
		SpawnTarget PlayeSpawnTarget;

		public GameObject PlayerPrefab;
		public GameObject ThirdPersonCameraPrefab;

		// Use this for initialization
		void Awake ()
		{
			Targets = new List<Target> ( FindObjectsOfType <Target> () );
			PlayeSpawnTarget = FindObjectOfType <SpawnTarget> ();
			
			ThirdPersonCharacter TPCTempRef = FindObjectOfType<ThirdPersonCharacter> ();
			FreeLookCam FreeLookCamTempRef = FindObjectOfType<FreeLookCam> ();
			if ( TPCTempRef == null )
			{
				if ( FreeLookCamTempRef == null )
				{
					Spawnplayer (false);
				}
				else
				{
					Spawnplayer (true, FreeLookCamTempRef);
				}
			}
			else
			{
				if ( FreeLookCamTempRef == null )
				{
					PositionPlayer (TPCTempRef, false);
				}
				else
				{
					PositionPlayer (TPCTempRef, true, FreeLookCamTempRef);
				}
			}
		}

		void Spawnplayer ( bool spawnCamFlag = false, FreeLookCam freeLookCamTempRef = null )
		{
			throw new System.NotImplementedException ();
//			PositionPlayer ( Instantiate ( PlayerPrefab ).GetComponent <ThirdPersonCharacter> () );
		}

		void PositionPlayer ( ThirdPersonCharacter tPCTempRef, bool spawnCamFlag = false, FreeLookCam freeLookCamTempRef = null )
		{
			throw new System.NotImplementedException ();
		}
	}
}