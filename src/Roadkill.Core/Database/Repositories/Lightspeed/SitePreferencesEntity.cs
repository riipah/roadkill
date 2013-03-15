﻿using System;
using Mindscape.LightSpeed;

namespace Roadkill.Core.Database.LightSpeed
{
	[Table("roadkill_siteconfiguration")]
	[Cached(ExpiryMinutes = 15)]
	internal class SitePreferencesEntity : Entity<Guid>
	{
		private string _content;
		private string _version;

		public Guid Id
		{
			get
			{
				return SitePreferences.SitePreferencesId;
			}
		}


		public string Content
		{
			get
			{
				return _content;
			}
			set
			{
				Set<string>(ref _content, value);
			}
		}


		public string Version
		{
			get
			{
				return _version;
			}
			set
			{
				Set<string>(ref _version, value);
			}
		}
	}
}