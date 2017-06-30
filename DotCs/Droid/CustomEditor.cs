using System;
using Android.OS;
using Android;
using Android.App;
using Android.Content;
using DotCs.Droid;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using DotCs;
using Android.Text.Method;
using Android.Views;
using Android.Widget;

[assembly: ExportRenderer(typeof(MyEditor), typeof(CustomEditor))]
namespace DotCs.Droid
{
	public class CustomEditor : EditorRenderer
	{
		public CustomEditor()
		{
		}

		protected override void OnDraw(Android.Graphics.Canvas canvas)
		{
			base.OnDraw(canvas);
			if (Control != null)
			{
				Control.VerticalScrollBarEnabled = true;
				Control.SetScroller(new Android.Widget.Scroller(Context));
			}
		}

		protected override void InitializeScrollbars(Android.Content.Res.TypedArray a)
		{
			base.InitializeScrollbars(a);
		}

		protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
		{
			base.OnElementChanged(e);
			EditText editText = new EditText(this.Context);
			editText.SetForegroundGravity(GravityFlags.Top);
			editText.SetSingleLine(false);
			editText.Id = 1;
			editText.LayoutParameters = new TableLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent, 0f);
			//editText.setId(1);
			//editText.setLayoutParams(new TableLayout.LayoutParams(LayoutParams.MATCH_PARENT, LayoutParams.MATCH_PARENT, 0f));
			editText.SetRawInputType(Android.Text.InputTypes.TextFlagMultiLine);
			editText.SetForegroundGravity(GravityFlags.Top | GravityFlags.Left);
			editText.Hint = "Comment";
			//editText.SetHint(editText.Id);
			editText.SetSingleLine(false);
			editText.SetLines(5);
			editText.SetMaxLines(5);
			editText.Text = "Nothing";
			editText.VerticalScrollBarEnabled = true;
			editText.Focusable = false;
			editText.SetOnTouchListener(new DroidTouchListener());

			//editTextRemark.setFocusable(false);
			//editTextRemark.setOnTouchListener(touchListener);
		}



		public class DroidTouchListener : Java.Lang.Object, Android.Views.View.IOnTouchListener
		{
			public bool OnTouch(Android.Views.View v, MotionEvent e)
			{
				v.Parent?.RequestDisallowInterceptTouchEvent(true);
				if ((e.Action & MotionEventActions.Up) != 0 && (e.ActionMasked & MotionEventActions.Up) != 0)
				{
					v.Parent?.RequestDisallowInterceptTouchEvent(false);
				}
				return false;
			}
		}
	}
}
