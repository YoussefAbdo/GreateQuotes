﻿using Android.App;
using System;
using Android.Runtime;
using System.Collections.Generic;
using System.Linq;
using GreatQuotes.Data;

namespace GreatQuotes
{
	[Application(Icon="@drawable/icon", Label="@string/app_name")]
	public class App : Application
	{
		static QuoteLoader quoteLoader;

		public App(IntPtr h, JniHandleOwnership jho) : base(h, jho)
		{
		}

		public override void OnCreate()
		{
            QuoteLoaderFactory.Create = () => new QuoteLoader();
            base.OnCreate();
        }

        public static void Save()
		{
			QuoteManager.Instance.Save();
		}
	}
}

