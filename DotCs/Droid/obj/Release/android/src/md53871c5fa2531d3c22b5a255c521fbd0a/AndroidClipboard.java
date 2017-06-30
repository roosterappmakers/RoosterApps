package md53871c5fa2531d3c22b5a255c521fbd0a;


public class AndroidClipboard
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DotCs.Droid.AndroidClipboard, DotCs.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AndroidClipboard.class, __md_methods);
	}


	public AndroidClipboard () throws java.lang.Throwable
	{
		super ();
		if (getClass () == AndroidClipboard.class)
			mono.android.TypeManager.Activate ("DotCs.Droid.AndroidClipboard, DotCs.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

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
