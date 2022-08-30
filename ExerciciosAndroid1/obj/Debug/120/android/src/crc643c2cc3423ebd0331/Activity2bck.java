package crc643c2cc3423ebd0331;


public class Activity2bck
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("ExerciciosAndroid1.Activities.Activity2bck, ExerciciosAndroid1", Activity2bck.class, __md_methods);
	}


	public Activity2bck ()
	{
		super ();
		if (getClass () == Activity2bck.class)
			mono.android.TypeManager.Activate ("ExerciciosAndroid1.Activities.Activity2bck, ExerciciosAndroid1", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
