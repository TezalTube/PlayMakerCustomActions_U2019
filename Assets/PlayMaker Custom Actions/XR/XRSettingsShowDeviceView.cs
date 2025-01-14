// (c) Copyright HutongGames, LLC 2010-2020. All rights reserved.  
// License: Attribution 4.0 International(CC BY 4.0) 
/*--- __ECO__ __PLAYMAKER__ __ACTION__ ---*/

using UnityEngine.VR;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("VR")]
	[Tooltip("Mirror what is shown on the device to the main display, if possible.")]
	public class VRSettingsShowDeviceView : FsmStateAction
	{
		[RequiredField]
		[Tooltip("If True, will show on the device to the main display, if possible.")]
		public FsmBool showDeviceView;

		public override void Reset()
		{
			showDeviceView = null;
		}

		public override void OnEnter()
		{
			UnityEngine.XR.XRSettings.showDeviceView = showDeviceView.Value;
			Finish();		
		}

	}
}