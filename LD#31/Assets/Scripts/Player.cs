using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
		public GameManeger thisM;
		public int cash = 200;
		public Text cashUI;

		void Start ()
		{
	
		}
	
		void Update ()
		{
				cashUI.text = "Money : $" + cash.ToString ();
		}
}
